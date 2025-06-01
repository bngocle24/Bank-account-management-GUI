namespace guibankapp
{
    partial class RutTienTruocHanForm
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
            this.lblSoTien = new System.Windows.Forms.Label();
            this.txtSoTien = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnRutTien = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSoTaiKhoan
            // 
            this.lblSoTaiKhoan.AutoSize = true;
            this.lblSoTaiKhoan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTaiKhoan.Location = new System.Drawing.Point(98, 31);
            this.lblSoTaiKhoan.Name = "lblSoTaiKhoan";
            this.lblSoTaiKhoan.Size = new System.Drawing.Size(140, 25);
            this.lblSoTaiKhoan.TabIndex = 0;
            this.lblSoTaiKhoan.Text = "Số tài khoản:";
            // 
            // txtSoTaiKhoan
            // 
            this.txtSoTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTaiKhoan.Location = new System.Drawing.Point(416, 31);
            this.txtSoTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            this.txtSoTaiKhoan.Size = new System.Drawing.Size(239, 26);
            this.txtSoTaiKhoan.TabIndex = 1;
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTien.Location = new System.Drawing.Point(98, 100);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(118, 25);
            this.lblSoTien.TabIndex = 2;
            this.lblSoTien.Text = "Số tiền rút:";
            // 
            // txtSoTien
            // 
            this.txtSoTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Location = new System.Drawing.Point(416, 100);
            this.txtSoTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(239, 26);
            this.txtSoTien.TabIndex = 3;
            // 
            // lblKetQua
            // 
            this.lblKetQua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKetQua.BackColor = System.Drawing.Color.Ivory;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(202, 149);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(349, 203);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRutTien
            // 
            this.btnRutTien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRutTien.BackColor = System.Drawing.Color.LightGreen;
            this.btnRutTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutTien.Location = new System.Drawing.Point(103, 379);
            this.btnRutTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRutTien.Name = "btnRutTien";
            this.btnRutTien.Size = new System.Drawing.Size(141, 43);
            this.btnRutTien.TabIndex = 5;
            this.btnRutTien.Text = "Rút tiền";
            this.btnRutTien.UseVisualStyleBackColor = false;
            this.btnRutTien.Click += new System.EventHandler(this.btnRutTien_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDong.BackColor = System.Drawing.Color.LightCoral;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(514, 379);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(141, 43);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // RutTienTruocHanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 446);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnRutTien);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtSoTien);
            this.Controls.Add(this.lblSoTien);
            this.Controls.Add(this.txtSoTaiKhoan);
            this.Controls.Add(this.lblSoTaiKhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "RutTienTruocHanForm";
            this.Text = "Rút Tiền Trước Hạn";
            this.Load += new System.EventHandler(this.RutTienTruocHanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblSoTaiKhoan;
        private System.Windows.Forms.TextBox txtSoTaiKhoan;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.TextBox txtSoTien;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnRutTien;
        private System.Windows.Forms.Button btnDong;
    }
}