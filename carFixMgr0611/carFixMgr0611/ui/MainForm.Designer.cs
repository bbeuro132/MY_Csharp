
namespace carFixMgr0611
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.custInfoAdd = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.custFixView = new CxFlatUI.CxFlatRoundButton();
            this.custFixAdmin = new CxFlatUI.CxFlatRoundButton();
            this.custRandData = new CxFlatUI.CxFlatRoundButton();
            this.custAppInfo = new CxFlatUI.CxFlatRoundButton();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 583);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // custInfoAdd
            // 
            this.custInfoAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custInfoAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.custInfoAdd.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custInfoAdd.Location = new System.Drawing.Point(641, 89);
            this.custInfoAdd.MinimumSize = new System.Drawing.Size(1, 1);
            this.custInfoAdd.Name = "custInfoAdd";
            this.custInfoAdd.Size = new System.Drawing.Size(218, 57);
            this.custInfoAdd.Symbol = 62141;
            this.custInfoAdd.TabIndex = 0;
            this.custInfoAdd.Text = "고객정보 접수";
            this.custInfoAdd.Click += new System.EventHandler(this.custInfoAdd_Click);
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uiSymbolButton2.FillColor = System.Drawing.Color.Firebrick;
            this.uiSymbolButton2.FillDisableColor = System.Drawing.Color.White;
            this.uiSymbolButton2.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.uiSymbolButton2.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.uiSymbolButton2.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.uiSymbolButton2.Font = new System.Drawing.Font("휴먼모음T", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiSymbolButton2.ForeColor = System.Drawing.SystemColors.Window;
            this.uiSymbolButton2.IsCircle = true;
            this.uiSymbolButton2.Location = new System.Drawing.Point(945, 8);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.RectColor = System.Drawing.Color.Firebrick;
            this.uiSymbolButton2.Size = new System.Drawing.Size(75, 42);
            this.uiSymbolButton2.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton2.Symbol = 61457;
            this.uiSymbolButton2.TabIndex = 2;
            this.uiSymbolButton2.Click += new System.EventHandler(this.mainExit_Click);
            // 
            // custFixView
            // 
            this.custFixView.BackColor = System.Drawing.Color.Transparent;
            this.custFixView.ButtonType = CxFlatUI.ButtonType.Success;
            this.custFixView.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custFixView.Location = new System.Drawing.Point(623, 184);
            this.custFixView.Name = "custFixView";
            this.custFixView.Size = new System.Drawing.Size(251, 70);
            this.custFixView.TabIndex = 4;
            this.custFixView.Text = "수리 내역";
            this.custFixView.TextColor = System.Drawing.Color.White;
            this.custFixView.Click += new System.EventHandler(this.custFixView_Click);
            // 
            // custFixAdmin
            // 
            this.custFixAdmin.BackColor = System.Drawing.Color.Transparent;
            this.custFixAdmin.ButtonType = CxFlatUI.ButtonType.Waring;
            this.custFixAdmin.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custFixAdmin.ForeColor = System.Drawing.Color.Black;
            this.custFixAdmin.Location = new System.Drawing.Point(623, 383);
            this.custFixAdmin.Name = "custFixAdmin";
            this.custFixAdmin.Size = new System.Drawing.Size(251, 70);
            this.custFixAdmin.TabIndex = 5;
            this.custFixAdmin.Text = "관리자 모드";
            this.custFixAdmin.TextColor = System.Drawing.Color.White;
            this.custFixAdmin.Click += new System.EventHandler(this.custFixAdmin_Click);
            // 
            // custRandData
            // 
            this.custRandData.BackColor = System.Drawing.Color.Transparent;
            this.custRandData.ButtonType = CxFlatUI.ButtonType.Primary;
            this.custRandData.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custRandData.Location = new System.Drawing.Point(623, 282);
            this.custRandData.Name = "custRandData";
            this.custRandData.Size = new System.Drawing.Size(251, 70);
            this.custRandData.TabIndex = 6;
            this.custRandData.Text = "랜덤 데이터 추가";
            this.custRandData.TextColor = System.Drawing.Color.White;
            this.custRandData.Click += new System.EventHandler(this.custRandData_Click);
            // 
            // custAppInfo
            // 
            this.custAppInfo.BackColor = System.Drawing.Color.Transparent;
            this.custAppInfo.ButtonType = CxFlatUI.ButtonType.Primary;
            this.custAppInfo.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.custAppInfo.Location = new System.Drawing.Point(623, 482);
            this.custAppInfo.Name = "custAppInfo";
            this.custAppInfo.Size = new System.Drawing.Size(251, 70);
            this.custAppInfo.TabIndex = 7;
            this.custAppInfo.Text = "앱 정보";
            this.custAppInfo.TextColor = System.Drawing.Color.White;
            this.custAppInfo.Click += new System.EventHandler(this.custAppInfo_Click);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.uiSymbolLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel1.Location = new System.Drawing.Point(12, 12);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(233, 38);
            this.uiSymbolLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolLabel1.Symbol = 61881;
            this.uiSymbolLabel1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uiSymbolLabel1.SymbolSize = 36;
            this.uiSymbolLabel1.TabIndex = 8;
            this.uiSymbolLabel1.Text = "카센터 관리 앱 v1.0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.uiSymbolButton2;
            this.ClientSize = new System.Drawing.Size(1022, 647);
            this.ControlBox = false;
            this.Controls.Add(this.uiSymbolLabel1);
            this.Controls.Add(this.custAppInfo);
            this.Controls.Add(this.custRandData);
            this.Controls.Add(this.custFixAdmin);
            this.Controls.Add(this.custFixView);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.custInfoAdd);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UISymbolButton custInfoAdd;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private CxFlatUI.CxFlatRoundButton custFixView;
        private CxFlatUI.CxFlatRoundButton custFixAdmin;
        private CxFlatUI.CxFlatRoundButton custRandData;
        private CxFlatUI.CxFlatRoundButton custAppInfo;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}

