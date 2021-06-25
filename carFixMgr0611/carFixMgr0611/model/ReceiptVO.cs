using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carFixMgr0611.model
{
    class ReceiptVO
    {
        private string indate;
        private int totalPrice;
        private string custName;
        private string staffName;

        public ReceiptVO(string indate, int totalPrice, string custName, string staffName)
        {
            this.indate = indate;
            this.totalPrice = totalPrice;
            this.custName = custName;
            this.staffName = staffName;
        }

        public string Indate { get => indate; set => indate = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string CustName { get => custName; set => custName = value; }
        public string StaffName { get => staffName; set => staffName = value; }

    }
}
