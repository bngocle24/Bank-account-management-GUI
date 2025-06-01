namespace guibankapp
{
    partial class FormChonTimKiem
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
            this.btnTheoMaKH = new System.Windows.Forms.Button();
            this.btnTheoCCCDHoTen = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTheoMaKH
            // 
            this.btnTheoMaKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTheoMaKH.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnTheoMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheoMaKH.Location = new System.Drawing.Point(187, 27);
            this.btnTheoMaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTheoMaKH.Name = "btnTheoMaKH";
            this.btnTheoMaKH.Size = new System.Drawing.Size(163, 61);
            this.btnTheoMaKH.TabIndex = 0;
            this.btnTheoMaKH.Text = "Theo Ma Khach Hang";
            this.btnTheoMaKH.UseVisualStyleBackColor = false;
            this.btnTheoMaKH.Click += new System.EventHandler(this.btnTheoMaKH_Click);
            // 
            // btnTheoCCCDHoTen
            // 
            this.btnTheoCCCDHoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTheoCCCDHoTen.BackColor = System.Drawing.Color.Plum;
            this.btnTheoCCCDHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheoCCCDHoTen.Location = new System.Drawing.Point(187, 110);
            this.btnTheoCCCDHoTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTheoCCCDHoTen.Name = "btnTheoCCCDHoTen";
            this.btnTheoCCCDHoTen.Size = new System.Drawing.Size(163, 61);
            this.btnTheoCCCDHoTen.TabIndex = 1;
            this.btnTheoCCCDHoTen.Text = "Theo CCCD hoac Ho ten";
            this.btnTheoCCCDHoTen.UseVisualStyleBackColor = false;
            this.btnTheoCCCDHoTen.Click += new System.EventHandler(this.btnTheoCCCDHoTen_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHuy.BackColor = System.Drawing.Color.LightCoral;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(187, 193);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(163, 61);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Huy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FormChonTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnTheoCCCDHoTen);
            this.Controls.Add(this.btnTheoMaKH);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormChonTimKiem";
            this.Text = "FormChonTimKiem";
            this.Load += new System.EventHandler(this.FormChonTimKiem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTheoMaKH;
        private System.Windows.Forms.Button btnTheoCCCDHoTen;
        private System.Windows.Forms.Button btnHuy;
    }
}