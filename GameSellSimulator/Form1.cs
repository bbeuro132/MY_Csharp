using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ClassGrade
{
    public partial class Form1 : Form
    {
        private List<Game> listGames = new List<Game>();
        public Form1()
        {
            InitializeComponent();
            Read_Product();
        }

        private void button1_Click(object sender, EventArgs e) //기입
        {
            if (textBox1.Text != "" || textBox2.Text != "" ||
               textBox3.Text != "" || textBox4.Text != "" ||
               textBox5.Text != "")
            {
                int output;
                int output2;

                if (int.TryParse(textBox4.Text, out output)&&int.TryParse(textBox5.Text, out output2))
                {
                    listGames.Add(new Game()
                    {

                        title = textBox1.Text,
                        model = textBox2.Text,
                        genre = textBox3.Text,
                        price = output,
                        stock = output2
                    });
                }
            }

            dataGridView1.DataSource = null;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            dataGridView1.DataSource = listGames;
        }



        private void button3_Click(object sender, EventArgs e) //XML 생성
        {
            Make_Products();
        }

        private void button4_Click(object sender, EventArgs e) //XML 읽기
        {
            Read_Product();
        }

        private void Make_Products()
        {
            // 사용자 XML 생성
            string gamesOutput = "";
            gamesOutput += "<products>\n";
            foreach (var item in listGames)
            {
                gamesOutput += "<product>\n";
                gamesOutput += "  <title>" + item.title + "</title>\n";
                gamesOutput += "  <model>" + item.model + "</model>\n";
                gamesOutput += "  <genre>" + item.genre + "</genre>\n";
                gamesOutput += "  <price>" + item.price + "</price>\n";
                gamesOutput += "  <stock>" + item.stock + "</stock>\n";
                gamesOutput += "</product>\n";
            }
            gamesOutput += "</products>";

            // 저장

            File.WriteAllText(@"./products.xml", gamesOutput);
        }

        private void Read_Product()
        {
            try
            {
                FileInfo fiu = new FileInfo(@"./products.xml");

                if (!fiu.Exists)
                {
                    MessageBox.Show("products.xml 파일이 존재하지 않습니다.");
                    return;
                }

                listGames.Clear();

                XmlDocument xdocUser = new XmlDocument();
                xdocUser.Load(@"./products.xml");
                XmlNodeList nodeUsers = xdocUser.SelectNodes("/products/product");
                foreach (XmlNode user in nodeUsers)
                {
                    listGames.Add(new Game()
                    {
                        
                        title = user.SelectSingleNode("title").InnerText,
                        model = user.SelectSingleNode("model").InnerText,
                        genre = user.SelectSingleNode("genre").InnerText,
                        price = int.Parse(user.SelectSingleNode("price").InnerText),
                        stock = int.Parse(user.SelectSingleNode("stock").InnerText),
                    });
                }

            }
            catch (FileLoadException exception)
            {
                // 파일이 없으면 예외 발생: 새로운 파일 생성
                Make_Products();
            }

        }
        private void button2_Click(object sender, EventArgs e) //XML표시
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listGames;
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {

            foreach (var item in dataGridView1.Rows)
            {
                DataGridViewRow dgvRow = item as DataGridViewRow;
                DataGridViewCell dataGridViewCell = dgvRow.Cells[0];
                if (dataGridViewCell is DataGridViewCheckBoxCell)
                {

                    //string st = dataGridViewCell.Value.ToString();
                    if (dataGridViewCell.Value != null && 
                        dataGridViewCell.Value.ToString() != "False")
                    {
                        

                        if ((dgvRow.DataBoundItem as Game).stock >= 0 &&
                            (dgvRow.DataBoundItem as Game).stock != 0)
                        {
                            int pp;
                            if (int.TryParse(ProfitTextBox.Text, out pp))
                            {
                                ProfitTextBox.Text =
                                   ((dgvRow.DataBoundItem as Game).price
                                   + int.Parse(ProfitTextBox.Text)).ToString();
                            }
                            else
                            {
                                ProfitTextBox.Text =
                                   ((dgvRow.DataBoundItem as Game).price).ToString();
                            }
                            (dgvRow.DataBoundItem as Game).stock -= 1;
                        }
                        else
                        {
                            MessageBox.Show((dgvRow.DataBoundItem as Game).title + "의 남은 재고가 없습니다.");
                            
                        }
                        
                        
                    }

                }
            }

            

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listGames;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            foreach (var item in dataGridView1.Rows)
            {
                DataGridViewRow dgvRow = item as DataGridViewRow;
                DataGridViewCell dataGridViewCell = dgvRow.Cells[0];
                if (dataGridViewCell is DataGridViewCheckBoxCell)
                {
                    if (dataGridViewCell.Value != null &&
                        dataGridViewCell.Value.ToString() != "False")
                    {
                        listGames.Remove(dgvRow.DataBoundItem as Game);
                    }

                }
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listGames;
        }

        private void ShowInfoBTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.내용 기입방법\n\n게임의 제목과 전용기종, 장르, 가격, 현재 재고를 입력한 후 '기입하기'를" +
                " 클릭해주세요.");
            MessageBox.Show("2.자료 불러오기\n\n저장된 데이터를 화면에 표시하려면 '내용 표시하기'를" +
                " 클릭해주세요. 프로그램 실행 후 변동사항이 있을 시 'XML 읽기'를 클릭한 후 " +
                "'내용 표시하기'를 클릭해주세요.");
            MessageBox.Show("3.자료 저장하기\n\n기입한 자료를 저장하려면 'XML 저장 및 새로만들기'를 " +
                "클릭해주세요. XML자료가 없을 시 비어있는 파일이 자동으로 생성됩니다.");
            MessageBox.Show("4.구입하기\n\n그리드뷰에 나타난 상품의 체크박스에 체크를 한 후 " +
                "'구입하기' 버튼을 클릭해주세요.");
            MessageBox.Show("5.자료 삭제하기\n\n그리드뷰에 나타난 상품의 체크박스에 체크를 한 후 " +
                "'선택 항목 삭제'를 클릭해주세요.");
        }
    }
}
