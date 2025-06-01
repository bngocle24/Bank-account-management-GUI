namespace guibankapp
{
    partial class XemThongTinTaiKhoan
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
            this.listViewTaiKhoan = new System.Windows.Forms.ListView();
            this.colSoTK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoaiTK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoDu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLaiSuatTK = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colKyHan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLaiSuatVay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewTaiKhoan
            // 
            this.listViewTaiKhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewTaiKhoan.BackColor = System.Drawing.Color.Ivory;
            this.listViewTaiKhoan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSoTK,
            this.colLoaiTK,
            this.colSoDu,
            this.colLaiSuatTK,
            this.colKyHan,
            this.colLaiSuatVay});
            this.listViewTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTaiKhoan.FullRowSelect = true;
            this.listViewTaiKhoan.GridLines = true;
            this.listViewTaiKhoan.HideSelection = false;
            this.listViewTaiKhoan.Location = new System.Drawing.Point(65, 35);
            this.listViewTaiKhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewTaiKhoan.Name = "listViewTaiKhoan";
            this.listViewTaiKhoan.Size = new System.Drawing.Size(686, 335);
            this.listViewTaiKhoan.TabIndex = 0;
            this.listViewTaiKhoan.UseCompatibleStateImageBehavior = false;
            this.listViewTaiKhoan.View = System.Windows.Forms.View.Details;
            // 
            // colSoTK
            // 
            this.colSoTK.Text = "So TK";
            this.colSoTK.Width = 120;
            // 
            // colLoaiTK
            // 
            this.colLoaiTK.Text = "Loai TK";
            this.colLoaiTK.Width = 100;
            // 
            // colSoDu
            // 
            this.colSoDu.Text = "So Du";
            this.colSoDu.Width = 100;
            // 
            // colLaiSuatTK
            // 
            this.colLaiSuatTK.Text = "Lai suat TK";
            this.colLaiSuatTK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colLaiSuatTK.Width = 115;
            // 
            // colKyHan
            // 
            this.colKyHan.Text = "Ky han";
            this.colKyHan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colKyHan.Width = 80;
            // 
            // colLaiSuatVay
            // 
            this.colLaiSuatVay.Text = "Lai suat vay";
            this.colLaiSuatVay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colLaiSuatVay.Width = 130;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDong.BackColor = System.Drawing.Color.LightCoral;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(822, 174);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 55);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Dong";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // XemThongTinTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 404);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.listViewTaiKhoan);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "XemThongTinTaiKhoan";
            this.Text = "XemThongTinTaiKhoan";
            this.Load += new System.EventHandler(this.XemThongTinTaiKhoan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewTaiKhoan;
        private System.Windows.Forms.ColumnHeader colSoTK;
        private System.Windows.Forms.ColumnHeader colLoaiTK;
        private System.Windows.Forms.ColumnHeader colSoDu;
        private System.Windows.Forms.ColumnHeader colLaiSuatTK;
        private System.Windows.Forms.ColumnHeader colKyHan;
        private System.Windows.Forms.ColumnHeader colLaiSuatVay;
        private System.Windows.Forms.Button btnDong;
    }
}