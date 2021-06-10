using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic0609
{
    class Class2
    {
        static void Main(string[] args)
        {
            int[,,] arrInt9 = new int[5, 3, 2];
            int n = arrInt9.Rank;
            Console.WriteLine("차원 : " + n);
            for (int x = 0; x < n; x++)
            {
                // 5, 3, 2
                Console.WriteLine(arrInt9.GetLength(x));
            }
        }
    }
}
