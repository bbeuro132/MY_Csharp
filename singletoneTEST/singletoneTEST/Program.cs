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
            var object1 = SingleTEST.getInstance().getData();
            var object2 = SingleTEST.getInstance().getData();

            Console.WriteLine("object1 : " + object1);
            Console.WriteLine("object2 : " + object2);

        }
    }
}
