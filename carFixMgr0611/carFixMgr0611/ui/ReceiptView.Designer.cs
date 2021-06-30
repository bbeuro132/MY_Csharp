
namespace carFixMgr0611.ui
{
    partial class ReceiptView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.viewList = new System.Windows.Forms.ListView();
            this.L_Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.L_indate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.L_TotalPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.L_StaffName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.L_CarNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.L_CustName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.viewGrid = new Sunny.UI.UIDataGridView();
            this.gCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRepair = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.viewSelect = new Sunny.UI.UIComboBox();
            this.viewSearch = new CxFlatUI.CxFlatTextBox();
            this.vSearchItem = new Sunny.UI.UISymbolButton();
            this.vSearchAll = new Sunny.UI.UISymbolButton();
            this.vDelete = new Sunny.UI.UISymbolButton();
            this.vConfirm = new Sunny.UI.UISymbolButton();
            this.vModify = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.closeButton = new Sunny.UI.UISymbolButton();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // viewList
            // 
            this.viewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.L_Count,
            this.L_indate,
            this.L_TotalPrice,
            this.L_StaffName,
            this.L_CarNum,
            this.L_CustName});
            this.viewList.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.viewList.FullRowSelect = true;
            this.viewList.HideSelection = false;
            this.viewList.Location = new System.Drawing.Point(12, 126);
            this.viewList.Name = "viewList";
            this.viewList.Size = new System.Drawing.Size(776, 115);
            this.viewList.TabIndex = 0;
            this.viewList.UseCompatibleStateImageBehavior = false;
            this.viewList.View = System.Windows.Forms.View.Details;
            this.viewList.SelectedIndexChanged += new System.EventHandler(this.viewList_SelectedIndexChanged);
            // 
            // L_Count
            // 
            this.L_Count.Text = "번호";
            // 
            // L_indate
            // 
            this.L_indate.Text = "접수날짜";
            this.L_indate.Width = 150;
            // 
            // L_TotalPrice
            // 
            this.L_TotalPrice.Text = "총결제금액";
            this.L_TotalPrice.Width = 150;
            // 
            // L_StaffName
            // 
            this.L_StaffName.Text = "담당자";
            this.L_StaffName.Width = 110;
            // 
            // L_CarNum
            // 
            this.L_CarNum.Text = "차량번호";
            this.L_CarNum.Width = 97;
            // 
            // L_CustName
            // 
            this.L_CustName.Text = "고객명";
            this.L_CustName.Width = 110;
            // 
            // viewGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.viewGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewGrid.BackgroundColor = System.Drawing.Color.White;
            this.viewGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewGrid.ColumnHeadersHeight = 32;
            this.viewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.viewGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gCount,
            this.gRepair,
            this.gPrice});
            this.viewGrid.EnableHeadersVisualStyles = false;
            this.viewGrid.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.viewGrid.Location = new System.Drawing.Point(12, 326);
            this.viewGrid.Name = "viewGrid";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.viewGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.viewGrid.RowTemplate.Height = 29;
            this.viewGrid.SelectedIndex = -1;
            this.viewGrid.ShowGridLine = true;
            this.viewGrid.Size = new System.Drawing.Size(776, 207);
            this.viewGrid.TabIndex = 1;
            // 
            // gCount
            // 
            this.gCount.HeaderText = "번호";
            this.gCount.Name = "gCount";
            // 
            // gRepair
            // 
            this.gRepair.HeaderText = "수리항목";
            this.gRepair.Name = "gRepair";
            // 
            // gPrice
            // 
            this.gPrice.HeaderText = "수리비용";
            this.gPrice.Name = "gPrice";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(12, 82);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(147, 35);
            this.uiSymbolLabel1.TabIndex = 2;
            this.uiSymbolLabel1.Text = "검색항목";
            // 
            // viewSelect
            // 
            this.viewSelect.FillColor = System.Drawing.Color.White;
            this.viewSelect.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.viewSelect.Items.AddRange(new object[] {
            "고객명",
            "차량번호"});
            this.viewSelect.Location = new System.Drawing.Point(166, 82);
            this.viewSelect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.viewSelect.MinimumSize = new System.Drawing.Size(63, 0);
            this.viewSelect.Name = "viewSelect";
            this.viewSelect.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.viewSelect.Size = new System.Drawing.Size(150, 29);
            this.viewSelect.TabIndex = 3;
            this.viewSelect.Text = "검색항목 선택";
            this.viewSelect.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // viewSearch
            // 
            this.viewSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.viewSearch.Hint = "검색어 입력";
            this.viewSearch.Location = new System.Drawing.Point(324, 82);
            this.viewSearch.MaxLength = 32767;
            this.viewSearch.Multiline = false;
            this.viewSearch.Name = "viewSearch";
            this.viewSearch.PasswordChar = '\0';
            this.viewSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.viewSearch.SelectedText = "";
            this.viewSearch.SelectionLength = 0;
            this.viewSearch.SelectionStart = 0;
            this.viewSearch.Size = new System.Drawing.Size(211, 38);
            this.viewSearch.TabIndex = 4;
            this.viewSearch.TabStop = false;
            this.viewSearch.UseSystemPasswordChar = false;
            // 
            // vSearchItem
            // 
            this.vSearchItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vSearchItem.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.vSearchItem.Location = new System.Drawing.Point(556, 82);
            this.vSearchItem.MinimumSize = new System.Drawing.Size(1, 1);
            this.vSearchItem.Name = "vSearchItem";
            this.vSearchItem.Size = new System.Drawing.Size(91, 35);
            this.vSearchItem.TabIndex = 5;
            this.vSearchItem.Text = "검색";
            this.vSearchItem.Click += new System.EventHandler(this.vSearchItem_Click);
            // 
            // vSearchAll
            // 
            this.vSearchAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vSearchAll.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.vSearchAll.Location = new System.Drawing.Point(653, 82);
            this.vSearchAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.vSearchAll.Name = "vSearchAll";
            this.vSearchAll.Size = new System.Drawing.Size(135, 35);
            this.vSearchAll.TabIndex = 6;
            this.vSearchAll.Text = "전체 검색";
            this.vSearchAll.Click += new System.EventHandler(this.vSearchAll_Click);
            // 
            // vDelete
            // 
            this.vDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vDelete.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.vDelete.Location = new System.Drawing.Point(697, 285);
            this.vDelete.MinimumSize = new System.Drawing.Size(1, 1);
            this.vDelete.Name = "vDelete";
            this.vDelete.Size = new System.Drawing.Size(91, 35);
            this.vDelete.TabIndex = 8;
            this.vDelete.Text = "삭제";
            // 
            // vConfirm
            // 
            this.vConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vConfirm.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.vConfirm.Location = new System.Drawing.Point(503, 285);
            this.vConfirm.MinimumSize = new System.Drawing.Size(1, 1);
            this.vConfirm.Name = "vConfirm";
            this.vConfirm.Size = new System.Drawing.Size(91, 35);
            this.vConfirm.TabIndex = 7;
            this.vConfirm.Text = "완료";
            // 
            // vModify
            // 
            this.vModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.vModify.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.vModify.Location = new System.Drawing.Point(600, 285);
            this.vModify.MinimumSize = new System.Drawing.Size(1, 1);
            this.vModify.Name = "vModify";
            this.vModify.Size = new System.Drawing.Size(91, 35);
            this.vModify.TabIndex = 9;
            this.vModify.Text = "수정";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(12, 285);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(147, 35);
            this.uiSymbolLabel2.TabIndex = 10;
            this.uiSymbolLabel2.Text = "상세수리내역";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.FillColor = System.Drawing.Color.Firebrick;
            this.closeButton.FillDisableColor = System.Drawing.Color.White;
            this.closeButton.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeButton.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeButton.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.closeButton.Font = new System.Drawing.Font("휴먼모음T", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.Window;
            this.closeButton.IsCircle = true;
            this.closeButton.Location = new System.Drawing.Point(713, 12);
            this.closeButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.closeButton.Name = "closeButton";
            this.closeButton.RectColor = System.Drawing.Color.Firebrick;
            this.closeButton.Size = new System.Drawing.Size(75, 42);
            this.closeButton.Style = Sunny.UI.UIStyle.Custom;
            this.closeButton.Symbol = 61457;
            this.closeButton.TabIndex = 11;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiSymbolLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel3.Location = new System.Drawing.Point(12, 16);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(186, 38);
            this.uiSymbolLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel3.Symbol = 61881;
            this.uiSymbolLabel3.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel3.SymbolSize = 36;
            this.uiSymbolLabel3.TabIndex = 12;
            this.uiSymbolLabel3.Text = "고객 정보 등록";
            // 
            // ReceiptView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.ControlBox = false;
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.vModify);
            this.Controls.Add(this.vDelete);
            this.Controls.Add(this.vConfirm);
            this.Controls.Add(this.vSearchAll);
            this.Controls.Add(this.vSearchItem);
            this.Controls.Add(this.viewSearch);
            this.Controls.Add(this.viewSelect);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.viewGrid);
            this.Controls.Add(this.viewList);
            this.Name = "ReceiptView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.ReceiptView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView viewList;
        private Sunny.UI.UIDataGridView viewGrid;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UIComboBox viewSelect;
        private CxFlatUI.CxFlatTextBox viewSearch;
        private Sunny.UI.UISymbolButton vSearchItem;
        private Sunny.UI.UISymbolButton vSearchAll;
        private Sunny.UI.UISymbolButton vDelete;
        private Sunny.UI.UISymbolButton vConfirm;
        private Sunny.UI.UISymbolButton vModify;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolButton closeButton;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private System.Windows.Forms.ColumnHeader L_Count;
        private System.Windows.Forms.ColumnHeader L_indate;
        private System.Windows.Forms.ColumnHeader L_TotalPrice;
        private System.Windows.Forms.ColumnHeader L_StaffName;
        private System.Windows.Forms.ColumnHeader L_CustName;
        private System.Windows.Forms.DataGridViewTextBoxColumn gCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn gRepair;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPrice;
        private System.Windows.Forms.ColumnHeader L_CarNum;
    }
}