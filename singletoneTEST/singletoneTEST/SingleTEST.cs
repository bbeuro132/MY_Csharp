using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singletoneTEST
{
    class SingleTEST
    {
        Random r = new Random();
        private static SingleTEST inst;
        private int data;
        SingleTEST()
        {
            data = r.Next(100) * 100;
        }

        public static SingleTEST getInstance()
        {
            if (inst == null)
            {
                inst = new SingleTEST();
            }
            return inst;
        }
        public int getData()
        {
            return data;
        }
    }
}
