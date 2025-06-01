namespace guibankapp
{
    partial class XemThongTinTaiKhoanVayVonForm
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
            this.btnXem = new System.Windows.Forms.Button();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSoTaiKhoan
            // 
            this.lblSoTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoTaiKhoan.AutoSize = true;
            this.lblSoTaiKhoan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTaiKhoan.Location = new System.Drawing.Point(98, 29);
            this.lblSoTaiKhoan.Name = "lblSoTaiKhoan";
            this.lblSoTaiKhoan.Size = new System.Drawing.Size(140, 25);
            this.lblSoTaiKhoan.TabIndex = 0;
            this.lblSoTaiKhoan.Text = "Số tài khoản:";
            // 
            // txtSoTaiKhoan
            // 
            this.txtSoTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTaiKhoan.Location = new System.Drawing.Point(445, 29);
            this.txtSoTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            this.txtSoTaiKhoan.Size = new System.Drawing.Size(219, 26);
            this.txtSoTaiKhoan.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXem.BackColor = System.Drawing.Color.LightGreen;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.Location = new System.Drawing.Point(103, 358);
            this.btnXem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(181, 57);
            this.btnXem.TabIndex = 2;
            this.btnXem.Text = "Xem thông tin";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // lblKetQua
            // 
            this.lblKetQua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKetQua.BackColor = System.Drawing.Color.Ivory;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(168, 84);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(447, 249);
            this.lblKetQua.TabIndex = 3;
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKetQua.Click += new System.EventHandler(this.lblKetQua_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDong.BackColor = System.Drawing.Color.LightCoral;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(483, 358);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(181, 57);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // XemThongTinTaiKhoanVayVonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 447);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.txtSoTaiKhoan);
            this.Controls.Add(this.lblSoTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "XemThongTinTaiKhoanVayVonForm";
            this.Text = "Xem Thông Tin Tài Khoản Vay Vốn";
            this.Load += new System.EventHandler(this.XemThongTinTaiKhoanVayVonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblSoTaiKhoan;
        private System.Windows.Forms.TextBox txtSoTaiKhoan;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnDong;
    }
}