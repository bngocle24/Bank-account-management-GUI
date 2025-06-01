namespace guibankapp
{
    partial class XemDanhSachKhachHang
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
            this.listViewKhachHang = new System.Windows.Forms.ListView();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewKhachHang
            // 
            this.listViewKhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewKhachHang.BackColor = System.Drawing.Color.OldLace;
            this.listViewKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewKhachHang.HideSelection = false;
            this.listViewKhachHang.Location = new System.Drawing.Point(23, 32);
            this.listViewKhachHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewKhachHang.Name = "listViewKhachHang";
            this.listViewKhachHang.Size = new System.Drawing.Size(677, 356);
            this.listViewKhachHang.TabIndex = 0;
            this.listViewKhachHang.UseCompatibleStateImageBehavior = false;
            this.listViewKhachHang.View = System.Windows.Forms.View.Details;
            this.listViewKhachHang.SelectedIndexChanged += new System.EventHandler(this.listViewKhachHang_SelectedIndexChanged);
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDong.BackColor = System.Drawing.Color.LightCoral;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(746, 183);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(72, 46);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Dong";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // XemDanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 422);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.listViewKhachHang);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "XemDanhSachKhachHang";
            this.Text = "XemDanhSachKhachHang";
            this.Load += new System.EventHandler(this.XemDanhSachKhachHang_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewKhachHang;
        private System.Windows.Forms.Button btnDong;
    }
}