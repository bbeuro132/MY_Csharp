using carFixMgr0611.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carFixMgr0611.handler
{
    class ReceiptAdapter
    {
        private List<Receipt> receiptList = new List<Receipt>();
        private OraHandler ora;

        public ReceiptAdapter(OraHandler ora)
        {
            this.ora = ora;
        }

        public void addReceipt(Receipt receipt)
        {
            receiptList.Add(receipt);

        }

        public void addReceiptDb()
        {
            for (int i = 0; i < receiptList.Count; i++)
            {
                ora.insertDb(receiptList[i]);
            }
            receiptList.Clear();
        }

        public void viewReceipt()
        {
            for (int i = 0; i < receiptList.Count; i++)
            {
                Customer cust = receiptList[i].Cust;
                Car car = receiptList[i].Car;

                Console.WriteLine("고객명 : " + cust.Name);
                Console.WriteLine("전화번호 : " + cust.Tel);
                Console.WriteLine("생년월일 : " + cust.Birth);
                Console.WriteLine("차량모델 : " + car.Model);
                Console.WriteLine("차량번호 : " + car.Number);
                Console.WriteLine("배기량 : " + car.Cc);
                Console.WriteLine("연식 : " + car.Year);
                Console.WriteLine("담당자 : " + receiptList[i].StaffName);
                Console.WriteLine("접수날짜 : " + receiptList[i].InDate);

                List<RepairItem> itemList = receiptList[i].ItemList;

                for (int j = 0; j < itemList.Count; j++)
                {
                    Console.WriteLine("수리 번호 : " + itemList[j].Idx);
                    Console.WriteLine("수리 내역 : " + itemList[j].Repair);
                    Console.WriteLine("비용 : " + itemList[j].Price);
                }

            }
        }

        public void viewReceiptDb()
        {
            ora.showDb();
        }

        public List<ReceiptVO> getReceiptDb()
        {
            List<ReceiptVO> list = ora.getReceipt();
            return list;
        }

        public List<ReceiptVO> getReceiptVoDb()
        {
            List<ReceiptVO> list = ora.getReceiptVO();
            return list;
        }

        public List<RepairItem> GetRepairItemsDb(string name)
        {
            return ora.getRepairItem(name);
        }

        public List<ReceiptVO> getReceiptDbBySearch(
            string searchItem, string searchValue)
        {
            List<ReceiptVO> list =
                ora.getReceiptVoBySearch(searchItem, searchValue);

            return list;
        }
    }
}
