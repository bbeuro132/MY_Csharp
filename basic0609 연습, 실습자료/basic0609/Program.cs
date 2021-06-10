using System;

namespace basic0609
{
    class Program
    {
        static void Main(string[] args) //static이 붙으면 클래스 메소드
        {
            Console.WriteLine("Hello Csharp!");

            Console.Write("이름 입력 : ");
            string name = Console.ReadLine();

            Console.Write("나이 입력 : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("나이 : {0}", age);
            Console.WriteLine("나이 : {0}, 이름 : {1}", age, name);

            string str = string.Format("이름:{0}, 나이:{1}", name, age);

            Console.WriteLine(str);
        }
    }
}
