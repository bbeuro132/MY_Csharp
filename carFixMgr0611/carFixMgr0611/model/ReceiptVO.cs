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
        private int receiptId;
        private string carNum;

        public ReceiptVO(string indate, int totalPrice, string custName, string staffName)
        {
            this.indate = indate;
            this.totalPrice = totalPrice;
            this.custName = custName;
            this.staffName = staffName;
        }

        public ReceiptVO(string indate, int totalPrice,
                        string custName, string staffName,
                        int receiptId, string carNum) 
                        : this(indate, totalPrice, custName, staffName)
        {
            this.receiptId = receiptId;
            this.carNum = carNum;
        }

        public string Indate { get => indate; set => indate = value; }
        public int TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string CustName { get => custName; set => custName = value; }
        public string StaffName { get => staffName; set => staffName = value; }
        public int ReceiptId { get => receiptId; set => receiptId = value; }
        public string CarNum { get => carNum; set => carNum = value; }
    }
}
