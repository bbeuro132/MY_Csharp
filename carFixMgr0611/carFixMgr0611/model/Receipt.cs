using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carFixMgr0611.model
{
    class Receipt
    {
        private Customer cust;
        private Car car;
        private string inDate;
        private string staffName;
        private List<RepairItem> itemList;

        public Receipt(Customer cust, 
                        Car car, 
                        string inDate,
                        string staffName,
                        List<RepairItem> itemList)
        {
            this.cust = cust;
            this.car = car;
            this.inDate = inDate;
            this.staffName = staffName;
            this.itemList = itemList;
        }

        /*public void showInfo()
        {
            Console.WriteLine(cust.Name + " " + cust.Tel + " " + cust.Birth);
            Console.WriteLine(car.Model + " " + car.Number + " " + car.Cc + " " + car.Year);
            Console.WriteLine(InDate);
            Console.WriteLine(staffName);
            for (int i = 0; i < itemList.Count; i++)
            {
                Console.WriteLine(itemList[i].Idx);
                Console.WriteLine(itemList[i].Price);
                Console.WriteLine(itemList[i].Repair);
            }

        }*/

        public string InDate { get => inDate; set => inDate = value; }
        public string StaffName { get => staffName; set => staffName = value; }
        internal Customer Cust { get => cust; set => cust = value; }
        internal Car Car { get => car; set => car = value; }
        internal List<RepairItem> ItemList { get => itemList; set => itemList = value; }
    }
}
