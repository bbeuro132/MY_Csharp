using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate_and_lamda
{
    public partial class Form1 : Form
    {
        //일종의 자료형을 하나 선언한 것
        //이 자료형은 함수를 저장하는 자료형
        //매개변수와 반환형이 없는 함수를 저장하는 자료형
        public delegate void TempFunc();

        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("안녕");
            

            //button1.Click -= button1_Click;

            button1.Click += button1_Click; //델리게이트

            button1.Click += (object s, EventArgs e) =>
            {
                MessageBox.Show("메시지 박스 지겹다");
            }; //람다를 이용한 추가

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("버튼 클릭시 이벤트 여럿 추가 가능");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(() => 
            { 
                for (int i = 0; i < 50; i++)
                    Console.Write("A");      
            });

            Thread t2 = new Thread(() =>
            {
                for (int i = 0; i < 50; i++)
                    Console.Write("B");
            });

            t1.Start();
            t2.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //new Form2().Show(); //뒤의 것을 선택가능, 모달리스(modeless)

            //model
            new Form2().ShowDialog(); //message box처럼 뒤에 것을 선택할 수 없음
        }

        /* public void myFunc()
         {
             MessageBox.Show("Test");
         }

         public void iteratorFunction(TempFunc t, int count)
         {
             for (int i = 0; i < count; i++)
                 t();

         }*/


    }
}
