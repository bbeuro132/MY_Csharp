using class0610_2.model;
using class0610_2.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0610_2.main
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] st = new Student[10];
            RandData r = new RandData();

            for (int i = 0; i < st.Length; i++)
            {
                st[i] = new Student(r.getName(), r.getAge(), r.getGender(), r.getAddress());
                Console.WriteLine((i + 1) + "번째 학생 출력");
                st[i].showStudentInfo();
                Console.WriteLine();
            }
        }
    }
}
