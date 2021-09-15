using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ReadAPI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dataGridView1.Columns.Add("address", "주소");
            dataGridView1.Columns.Add("attractname", "장소");
            dataGridView1.Columns.Add("tel", "전화번호");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string key = "xUkdAw8rwMaVaPqRNjec8VDNIx78M3QrM5rWwcMvaqgMnHJlHpui84hNt3j7uuJeO27NqXt9HLP4084KoWyPew%3D%3D";
            string pageNo = "1";
            string numOfRows = "10";
            string url = $"https://tour.daegu.go.kr/openapi-data/service/rest/getTourKorAttract/svTourKorAttract.do?serviceKey={key}&pageNo={pageNo}&numOfRows={numOfRows}&SG_APIM=2ug8Dm9qNBfD32JLZGPN64f3EoTlkpD8kSOHWfXpyrY";

            XElement api = XElement.Load(url);

            dataGridView1.DataSource = null;

            foreach (var item in api.Descendants("item"))
            {
                string address = item.Element("address").Value;
                string attractname = item.Element("attractname").Value;
                string tel = item.Element("tel").Value;

                dataGridView1.Rows.Add(address, attractname, tel);
            }
        }
    }
}
