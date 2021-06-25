using carFixMgr0611.handler;
using carFixMgr0611.model;
using carFixMgr0611.util;
using MaterialSkin.Controls;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carFixMgr0611.ui
{
    partial class ReceiptForm : MaterialForm
    {
        ReceiptAdapter adapter;

        public ReceiptForm()
        {
            InitializeComponent();
        }
        public ReceiptForm(ReceiptAdapter adapter)
        {
            InitializeComponent();
            this.adapter = adapter;
        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReceiptSave_Click(object sender, EventArgs e)
        {
            #region 변수 모음집
            int cnt = 0;
            string Name, telH, telB, CustYear, CustMonth, CustDay;
            string Model, Num, CC, Year;
            string Staff;
            List<string> repairList = new List<string>();
            List<RepairItem> repairItems = new List<RepairItem>();
            //<>는 제네릭이라 불리며, 응용 클래스이다. 어떠한 자료형도 넣을 수 있지만 중간에 변경하는 것은 불가능하다

            Dictionary<object, string> dicInput =
                new Dictionary<object, string>();

            UICheckBox[] checkbox = new UICheckBox[]
            {
                chk1, chk2, chk3, chk4, chk5,
                chk6, chk7, chk8, chk9, chk10
            };

            Name = custName.Text;
            telH = custTelH.SelectedText;
            telB = custTelB.Text;
            CustYear = custYear.SelectedText;
            CustMonth = custMonth.SelectedText;
            CustDay = custDay.SelectedText;
            Model = CarModel.SelectedText;
            Num = carNumber.Text;
            CC = carCC.SelectedText;
            Year = carYear.SelectedText;
            Staff = staffName.SelectedText;

            string[] arrData = new string[]
            {
                Name, telH, telB, CustYear, CustMonth, CustDay, Model, Num, CC, Year, Staff
            };

            object[] arrObj = new object[]
            {
                custName, custTelH, custTelB, custYear, custMonth, custDay,
                CarModel, carNumber, carCC, carYear, staffName
            };

            string[] arrMsg = new string[]
            {
                "이름을 입력하세요.", "전화번호 앞자리를 선택하세요.", "전화번호 뒷자리를 입력하세요.",
                "년도를 선택하세요.", "월을 선택하세요.", "일을 선택하세요.", "차량 모델명을 선택하세요.",
                "차량 번호를 입력하세요.", "차량 배기량을 선택하세요.", "차량 연식을 선택하세요.",
                "담당자 이름을 입력하세요."
            };
            #endregion


            for (int i = 0; i < arrData.Length; i++)
            {
                dicInput.Add(arrObj[i], arrData[i]);
            }

            foreach (KeyValuePair<object, string> item in dicInput)
            {
                if (item.Value.Equals("") || item.Value.Equals("선택"))
                {
                    setFocus(item.Key as Control, arrMsg[cnt]);
                    return;
                }
            }
            int sum = 0;

            for (int i = RepairTable.ENGINE_OIL; i < RepairTable.ETC_COST+1; i++)
            {
                if (checkbox[i].Checked)
                {
                    repairItems.Add(new RepairItem(i, checkbox[i].Text, RepairTable.fixMoney[i]));
                    sum += RepairTable.fixMoney[i];
                }
            }

            # region 잘못된 이름, 전화번호 입력, 수리항목 체크여부 확인
            if (repairItems.Count == 0)
            {
                MessageBox.Show("수리항목을 체크하세요.");
                return;
            }
      
            Regex regex = new Regex(@"^[가-힣]{3}");
            Match m = regex.Match(Name);
            if (m.Success == false)
            {
                setFocus(custName, Properties.Resources.ERR_NAME_WRONG);
                return;
            }

            string telAll = telH + telB;

            if (telAll.Length == 10 || telAll.Length == 11)
            {
                Regex regex2 = new Regex(@"01{1}[016789]{1}[0-9]{7,8}");
                Match m2 = regex2.Match(telAll);
                if (m2.Success == false)
                {
                    MessageBox.Show("잘못된 전화번호");
                    return;
                }
                else
                {
                    MessageBox.Show("올바른 자리수를 입력하세요");
                    return;
                }
            }
            #endregion  



            adapter.addReceipt(new Receipt(new Customer(Name, (telH+telB), (CustYear+CustMonth+CustDay)),
                                                        new Car(Model, Num, CC, Year),
                                                        DateTime.Now.ToString("yyyy년MM월dd일"),
                                                        Staff, repairItems, sum));

            //adapter.viewReceipt();

            adapter.viewReceipt();

            adapter.addReceiptDb();

            #region 쓰레기통
            /*
            Customer cust = new Customer(Name,
                                        (telH + "-" + telB),
                                        (CustYear + "년 " + CustMonth + "월 " + CustDay + "일"));

            Car car = new Car(Model, Num, CC, Year);

            Receipt receipt = new Receipt(cust, car, (DateTime.Today).ToString(), Staff, repairItems);

            ReceiptAdapter receiptAdapter = new ReceiptAdapter();

            receiptAdapter.addReceipt(receipt);

            receiptAdapter.viewReceipt();*/
            #endregion

        }
        private void setFocus(Control cont, string msg)
        {
            MessageBox.Show(msg);
            ActiveControl = cont;
            ActiveControl.Focus();
            cont.Text = "";
        }
    }
}
