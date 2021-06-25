using carFixMgr0611.common;
using carFixMgr0611.handler;
using carFixMgr0611.ui;
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

namespace carFixMgr0611
{
    public partial class MainForm : MaterialForm// Form 클래스에서 상속개념
    {
        OraHandler ora;
        ReceiptAdapter adapter;

        public MainForm()//생성자
        {
            InitializeComponent();
            CommUtil.initTheme(this);
            ora = new OraHandler();
            adapter = new ReceiptAdapter(ora);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void custInfoAdd_Click(object sender, EventArgs e)
        {
            new ReceiptForm(adapter).ShowDialog();
            
        }

        private void custFixView_Click(object sender, EventArgs e)
        {
            //adapter.viewReceiptDb();
            new ReceiptView(adapter).ShowDialog();
        }

        private void custFixAdmin_Click(object sender, EventArgs e)
        {
            //adapter.addReceiptDb();
        }

        private void custRandData_Click(object sender, EventArgs e)
        {

        }

        private void custAppInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("차량 관리 프로그램입니다.\n최종 업데이트일 : 21. 06. 16");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
