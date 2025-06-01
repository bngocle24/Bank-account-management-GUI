namespace guibankapp
{
    partial class TinhLaiDuKienForm
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
            this.lblSoTaiKhoan = new System.Windows.Forms.Label();
            this.txtSoTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.btnTinhLai = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSoTaiKhoan
            // 
            this.lblSoTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSoTaiKhoan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTaiKhoan.Location = new System.Drawing.Point(93, 55);
            this.lblSoTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoTaiKhoan.Name = "lblSoTaiKhoan";
            this.lblSoTaiKhoan.Size = new System.Drawing.Size(147, 22);
            this.lblSoTaiKhoan.TabIndex = 0;
            this.lblSoTaiKhoan.Text = "So tai khoan";
            // 
            // txtSoTaiKhoan
            // 
            this.txtSoTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTaiKhoan.Location = new System.Drawing.Point(357, 55);
            this.txtSoTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoTaiKhoan.Name = "txtSoTaiKhoan";
            this.txtSoTaiKhoan.Size = new System.Drawing.Size(143, 22);
            this.txtSoTaiKhoan.TabIndex = 1;
            // 
            // lblKetQua
            // 
            this.lblKetQua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKetQua.BackColor = System.Drawing.Color.Khaki;
            this.lblKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetQua.Location = new System.Drawing.Point(181, 121);
            this.lblKetQua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(233, 122);
            this.lblKetQua.TabIndex = 2;
            this.lblKetQua.Text = "label1";
            this.lblKetQua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTinhLai
            // 
            this.btnTinhLai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTinhLai.BackColor = System.Drawing.Color.LightGreen;
            this.btnTinhLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhLai.Location = new System.Drawing.Point(97, 281);
            this.btnTinhLai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTinhLai.Name = "btnTinhLai";
            this.btnTinhLai.Size = new System.Drawing.Size(143, 39);
            this.btnTinhLai.TabIndex = 4;
            this.btnTinhLai.Text = "Tinh lai du kien";
            this.btnTinhLai.UseVisualStyleBackColor = false;
            this.btnTinhLai.Click += new System.EventHandler(this.btnTinhLai_Click);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDong.BackColor = System.Drawing.Color.LightCoral;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(357, 281);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(143, 39);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "Dong";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // TinhLaiDuKienForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 382);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTinhLai);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.txtSoTaiKhoan);
            this.Controls.Add(this.lblSoTaiKhoan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "TinhLaiDuKienForm";
            this.Text = "TinhLaiDuKienForm";
            this.Load += new System.EventHandler(this.TinhLaiDuKienForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoTaiKhoan;
        private System.Windows.Forms.TextBox txtSoTaiKhoan;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.Button btnTinhLai;
        private System.Windows.Forms.Button btnDong;
    }
}