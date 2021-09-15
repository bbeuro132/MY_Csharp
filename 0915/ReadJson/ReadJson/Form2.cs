using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadJson
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            chart1.Series[0].Points.AddXY(100, 20);
            chart1.Series[0].Points.AddXY(200, 40);
            chart1.Series[0].Points.AddXY(300, 80);

            //Add 함수를 쓸 때에는 한칸짜리 배열을 넣어줄 것
            //AddXY는 X축과 Y축의 값을 일일이 지정
            //Add는 Y축에 들어갈 값만 지정하고, X값은 자동으로 증가
            chart2.Series[0].Points.Add(new double[] { 2.0 }); //x = 1, y = 2.0
            chart2.Series[0].Points.Add(new double[] { 5.0 }); //x = 1, y = 2.5

            chart2.Series.Add("aaaa");
            chart2.Series[1].Points.Add(new double[] { 1.0 });
            chart2.Series[1].Points.Add(new double[] { 6.0 });


            //눈금 숫자 간격을 조절할 수 있다
            //chart3.ChartAreas[0].AxisX.LabelStyle.Interval = 1;

            for (int i = 0; i < 20; i++)
            {
                chart3.Series["Series1"].Points.AddXY(i, i + 10);
            }
        }
    }
}
