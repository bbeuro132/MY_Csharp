using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_and_lamda
{
    class Person
    {
        /*
         자바, c++ 버전
        private string name_;

        public string getName() {return name_;}
        public void setName(string name){name_ = name;}
         */

        //최종적으로 축약한 getter, setter
        public string name { get; set; }
        public int age { get; set; }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Person()
        {
        }

        public void Sleep()
        {
            System.Windows.Forms.MessageBox.Show("쿨쿨");
        }
    }
}
