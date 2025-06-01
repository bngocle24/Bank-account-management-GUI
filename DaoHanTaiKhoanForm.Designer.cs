namespace guibankapp
{
    partial class DaoHanTaiKhoanForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblSoTaiKhoan = new System.Windows.Forms.Label();
            this.txtSoTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnDaoHan = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSoTaiKhoan
            // 
            this.lblSoTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoTaiKhoan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTaiKhoan.Location = new System.Drawing.Point(81, 81);
            this.lblSoTaiKhoan.Name = "lblSoTaiKhoan";
            this.lblSoTaiKhoan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSoTaiKhoan.Size = new System.Drawing.Size(188, 20);
            this.lblSoTaiKhoan.TabIndex = 0;
            this.lblSoTaiKhoan.Text = "Số tài khoản:";
            this.lblSoTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSoTaiKhoan.Click += new System.EventHandler(this.lblSoTaiKhoan_Click);
            // 
            // txtSoTaiKhoan
            // 
            this.txtSoTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTaiKhoan.Location = new System.Drawing.Point(414, 78);
            this.txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            this.txtSoTaiKhoan.Size = new System.Drawing.Size(216, 26);
            this.txtSoTaiKhoan.TabIndex = 1;
            this.txtSoTaiKhoan.TextChanged += new System.EventHandler(this.txtSoTaiKhoan_TextChanged);
            // 
            // lblKetQua
            // 
            this.lblKetQua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKetQua.BackColor = System.Drawing.Color.Khaki;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(213, 138);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(271, 117);
            this.lblKetQua.TabIndex = 2;
            this.lblKetQua.Text = "label";
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKetQua.Click += new System.EventHandler(this.lblKetQua_Click);
            // 
            // btnDaoHan
            // 
            this.btnDaoHan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDaoHan.BackColor = System.Drawing.Color.LightGreen;
            this.btnDaoHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaoHan.Location = new System.Drawing.Point(85, 293);
            this.btnDaoHan.Name = "btnDaoHan";
            this.btnDaoHan.Size = new System.Drawing.Size(133, 56);
            this.btnDaoHan.TabIndex = 3;
            this.btnDaoHan.Text = "Đáo hạn";
            this.btnDaoHan.UseVisualStyleBackColor = false;
            this.btnDaoHan.Click += new System.EventHandler(this.btnDaoHan_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDong.BackColor = System.Drawing.Color.LightCoral;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(497, 293);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(133, 56);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // DaoHanTaiKhoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 485);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnDaoHan);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtSoTaiKhoan);
            this.Controls.Add(this.lblSoTaiKhoan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DaoHanTaiKhoanForm";
            this.Text = "Đáo Hạn Tài Khoản Tiết Kiệm";
            this.Load += new System.EventHandler(this.DaoHanTaiKhoanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblSoTaiKhoan;
        private System.Windows.Forms.TextBox txtSoTaiKhoan;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnDaoHan;
        private System.Windows.Forms.Button btnDong;
    }
}