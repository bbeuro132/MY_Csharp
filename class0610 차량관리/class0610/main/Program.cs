using class0610.carApp;
using class0610.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class0610.main
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] cust = new Customer[10];
            RandData r = new RandData();

            for (int i = 0; i < cust.Length; i++)
            {
                Console.WriteLine((i + 1) + "번째 생성");
                cust[i] = new Customer(r.getName(),
                                    r.getTel(),
                                    r.getAddress(),
                                    new Car(r.getModel(),
                                            r.getColor(),
                                            r.getYear(), 
                                            r.getCompany()));
                cust[i].printCustomerInfo();
            }
        }
    }
}
