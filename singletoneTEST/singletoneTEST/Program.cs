using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singletoneTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("싱글톤: " + SingleTEST.getInstance(r).getData());
                Console.WriteLine("인스턴스: " + new SingleTEST(r).getData());
            }

        }
    }
}
