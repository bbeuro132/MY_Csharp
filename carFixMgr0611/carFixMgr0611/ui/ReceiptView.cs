using carFixMgr0611.common;
using carFixMgr0611.handler;
using carFixMgr0611.model;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carFixMgr0611.ui
{
    partial class ReceiptView : MaterialForm
    {
        ReceiptAdapter adapter;
        List<ReceiptVO> receiptList;
        public ReceiptView()
        {
            InitializeComponent();

        }

        public ReceiptView(ReceiptAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReceiptView_Load(object sender, EventArgs e)
        {
            CommUtil.colorListViewHeader(ref viewList, Color.LightSlateGray,
                                        Color.BlanchedAlmond);

            List<ReceiptVO> list = adapter.getReceiptVoDb();
            initList(list);
            initGrid();
        }

        public void initList() //ViewList에 표시되기 위한 내용이 담김, 디폴트 값
        {

            string strPrice = string.Format("{0:#,0}원", 120000);
            string[] data = { "1", "2021년6월24일", strPrice,
                            "김담당", "박고객"};
            viewList.Items.Add(new ListViewItem(data));

            for (int i = 0; i < 50; i++)
            {
                viewList.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+2).ToString(), "2021년6월24일",
                        strPrice ,"김담당", "박고객"
                    }));
            }
        }

        public void initList(List<ReceiptVO> list)
            //오버로딩한 메소드, SQL 내의 정보가 들어감
        {
            for (int i = 0; i < list.Count; i++)
            {
                string strPrice = string.Format("{0:#,0}원", list[i].TotalPrice);
                viewList.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+1).ToString(),
                        list[i].Indate,
                        strPrice,
                        list[i].StaffName,
                        list[i].CarNum,
                        list[i].CustName
                    }));
            }
            CommUtil.setRowColor(viewList, Color.LightSalmon, Color.LightBlue);
            int index = viewList.Items.Count - 1;
            viewList.Items[index].Selected = true;
            viewList.Items[index].Focused = true;
            viewList.EnsureVisible(index);
        }

        public void initGrid()
        {
            string strPrice = string.Format("{0:#,0}원", 80000);
            string[] data = { "1", "엔진오일 교환", strPrice };

            viewGrid.Rows.Add(data);

            for (int i = 0; i < 30; i++)
            {
                viewGrid.Rows.Add(new string[]
                {
                    (i+2).ToString(), "부동액 교환", strPrice
                });
            }
            int count = viewGrid.Rows.Count - 1;
            viewGrid.FirstDisplayedScrollingRowIndex = count;
            viewGrid.CurrentCell =
                viewGrid.Rows[count - 1].Cells[0];
        }
        
        public void initGrid(List<RepairItem> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                string strPrice =
                string.Format("{0:#,0}원", list[i].Price);
                viewGrid.Rows.Add(new ListViewItem(
                    new string[]
                    {
                        (i+1).ToString(), 
                        list[i].Repair,
                        strPrice
                    }
                    ));
            }
            int count = viewGrid.Rows.Count - 1;
            viewGrid.FirstDisplayedScrollingRowIndex = count;
            viewGrid.CurrentCell =
                viewGrid.Rows[count - 1].Cells[0];
        }




        private void viewList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewList.SelectedItems.Count != 0)
            {
                int n = viewList.SelectedItems[0].Index;
                string num = viewList.Items[n].SubItems[0].Text;
                string date = viewList.Items[n].SubItems[1].Text;
                string price = viewList.Items[n].SubItems[2].Text;
                string staff = viewList.Items[n].SubItems[3].Text;
                string carNum = viewList.Items[n].SubItems[4].Text;
                string cust = viewList.Items[n].SubItems[5].Text;


                Console.WriteLine("번호 : " + num);
                Console.WriteLine("접수날짜 : " + date);
                Console.WriteLine("총결제금액 : " + price);
                Console.WriteLine("담당자 : " + staff);
                Console.WriteLine("차량번호 : " + carNum);
                Console.WriteLine("고객명 : " + cust);

                List<RepairItem> list = adapter.GetRepairItemsDb(cust);

                viewGrid.ClearRows();
                initGrid(list);

                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine("수리항목 : " + list[i].Repair);
                    Console.WriteLine("수리비 : " + list[i].Price);
                }

            }
        }

        private void vSearchItem_Click(object sender, EventArgs e)
        {
            string item = viewSelect.Text;
            string value = viewSearch.Text;
            if (item.Equals("") || item.Equals("검색항목 선택") ||
                value.Equals(""))
            {
                MessageBox.Show("정확한 검색어을 입력하세요");
                return;
            }
            else
            {
                switch (item)
                {
                    case "고객명":
                        item = "cust_name";
                        break;
                    case "차량번호":
                        item = "car_num";
                        break;
                }
            }
            List<ReceiptVO> list =
                adapter.getReceiptDbBySearch(item, value);
            viewList.Items.Clear();
            initList(list);
        }

        private void vSearchAll_Click(object sender, EventArgs e)
        {

        }
    }
}
