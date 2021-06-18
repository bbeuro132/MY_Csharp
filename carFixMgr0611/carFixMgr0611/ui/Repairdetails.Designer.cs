
namespace carFixMgr0611.ui
{
    partial class Repairdetails
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
            this.CloseButton = new Sunny.UI.UIButton();
            this.RepairGridView = new Sunny.UI.UIDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.RepairGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.CloseButton.Location = new System.Drawing.Point(412, 403);
            this.CloseButton.MinimumSize = new System.Drawing.Size(1, 1);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 35);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "종료";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RepairGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.RepairGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RepairGridView.BackgroundColor = System.Drawing.Color.White;
            this.RepairGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RepairGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RepairGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RepairGridView.EnableHeadersVisualStyles = false;
            this.RepairGridView.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.RepairGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.RepairGridView.Location = new System.Drawing.Point(12, 75);
            this.RepairGridView.Name = "RepairGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RepairGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.RepairGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.RepairGridView.RowTemplate.Height = 29;
            this.RepairGridView.SelectedIndex = -1;
            this.RepairGridView.ShowGridLine = true;
            this.RepairGridView.Size = new System.Drawing.Size(394, 363);
            this.RepairGridView.TabIndex = 1;
            // 
            // Repairdetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.ControlBox = false;
            this.Controls.Add(this.RepairGridView);
            this.Controls.Add(this.CloseButton);
            this.Name = "Repairdetails";
            this.Text = "수리내역 보여주기";
            ((System.ComponentModel.ISupportInitialize)(this.RepairGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton CloseButton;
        private Sunny.UI.UIDataGridView RepairGridView;
    }
}