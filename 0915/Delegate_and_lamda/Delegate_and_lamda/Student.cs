using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_and_lamda
{
    //name 값을 기본으로 갖고 hakbeon을 추가로 갖는 클래스
    class Student : Person //상속 받을 때는 : 클래스 이름  을 적으면 된다
    {
        public string hakbeon { get; set; }

        //sleep 기능에 이어 study 기능도 추가된 클래스
        public void study()
        {
            System.Windows.Forms.MessageBox.Show("공부하는중");
        }
    }
}
