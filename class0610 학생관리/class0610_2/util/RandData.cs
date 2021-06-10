using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0610_2.util
{
    class RandData
    {
        Random rand = new Random();

        static string[] name = { "홍길동", "김길동", "박길동", "최길동", "이길동" };
        static int[] age = { 20, 25, 30, 35, 40 };
        static char[] gender = { '남', '여' };
        static string[] address = { "대구시 동구 신천3동", "대구시 동구 신천4동",
                            "대구시 동구 신천5동", "대구시 동구 신천6동", 
                            "대구시 동구 신천7동"};

        public string getName()
        {
            return name[rand.Next(name.Length)];
        }
        public int getAge()
        {
            return age[rand.Next(age.Length)];
        }
        public char getGender()
        {
            return gender[rand.Next(gender.Length)];
        }
        public string getAddress()
        {
            return address[rand.Next(address.Length)];
        }
    }
}
