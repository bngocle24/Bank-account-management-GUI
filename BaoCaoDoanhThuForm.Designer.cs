namespace guibankapp
{
    partial class BaoCaoDoanhThuForm
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
            this.listViewDoanhThu = new System.Windows.Forms.ListView();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewDoanhThu
            // 
            this.listViewDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewDoanhThu.HideSelection = false;
            this.listViewDoanhThu.Location = new System.Drawing.Point(8, 8);
            this.listViewDoanhThu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewDoanhThu.Name = "listViewDoanhThu";
            this.listViewDoanhThu.Size = new System.Drawing.Size(553, 413);
            this.listViewDoanhThu.TabIndex = 0;
            this.listViewDoanhThu.UseCompatibleStateImageBehavior = false;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDong.BackColor = System.Drawing.Color.LightCoral;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(617, 179);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(98, 36);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "DONG";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // BaoCaoDoanhThuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 427);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.listViewDoanhThu);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BaoCaoDoanhThuForm";
            this.Text = "BaoCaoDoanhThu";
            this.Load += new System.EventHandler(this.BaoCaoDoanhThuForm_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewDoanhThu;
        private System.Windows.Forms.Button btnDong;
    }
}