namespace guibankapp
{
    partial class ThongKeTaiKhoanForm
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
            this.listViewThongKe = new System.Windows.Forms.ListView();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewThongKe
            // 
            this.listViewThongKe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewThongKe.BackColor = System.Drawing.Color.Ivory;
            this.listViewThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewThongKe.HideSelection = false;
            this.listViewThongKe.Location = new System.Drawing.Point(21, 18);
            this.listViewThongKe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewThongKe.Name = "listViewThongKe";
            this.listViewThongKe.Size = new System.Drawing.Size(567, 432);
            this.listViewThongKe.TabIndex = 0;
            this.listViewThongKe.UseCompatibleStateImageBehavior = false;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDong.BackColor = System.Drawing.Color.LightCoral;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(649, 198);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(109, 68);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Dong";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // ThongKeTaiKhoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 461);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.listViewThongKe);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ThongKeTaiKhoanForm";
            this.Text = "ThongKeTaiKhoanForm";
            this.Load += new System.EventHandler(this.ThongKeTaiKhoanForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewThongKe;
        private System.Windows.Forms.Button btnDong;
    }
}