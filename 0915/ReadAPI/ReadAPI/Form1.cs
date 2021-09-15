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
using System.Xml.Linq;

namespace ReadAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); //Form1을 실행할때 자동으로 생성되는 것, 화면에 보이게 해주는 것
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string key = "xUkdAw8rwMaVaPqRNjec8VDNIx78M3QrM5rWwcMvaqgMnHJlHpui84hNt3j7uuJeO27NqXt9HLP4084KoWyPew%3D%3D";
            string pageNo = "1";
            string numOfRows = "10";
            string url = $"https://tour.daegu.go.kr/openapi-data/service/rest/getTourKorAttract/svTourKorAttract.do?serviceKey={key}&pageNo={pageNo}&numOfRows={numOfRows}&SG_APIM=2ug8Dm9qNBfD32JLZGPN64f3EoTlkpD8kSOHWfXpyrY";

            XElement api = XElement.Load(url);

            List<daegu> daegus = new List<daegu>();

            foreach (var item in api.Descendants("item"))
            {
                string address = item.Element("address").Value;
                string attractname = item.Element("attractname").Value;
                string tel = item.Element("tel").Value;
                daegu temp = (new daegu(address, attractname, tel));

                daegus.Add(temp);

                //인스턴스란 사용자 정의 자료형으로 만든 변수
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = daegus;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form2().Show(); //모달리스
        }
    }
}
