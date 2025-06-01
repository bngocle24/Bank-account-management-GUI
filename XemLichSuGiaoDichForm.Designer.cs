namespace guibankapp
{
    partial class XemLichSuGiaoDichForm
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
            this.listViewGiaoDich = new System.Windows.Forms.ListView();
            this.btnDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewGiaoDich
            // 
            this.listViewGiaoDich.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listViewGiaoDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewGiaoDich.HideSelection = false;
            this.listViewGiaoDich.Location = new System.Drawing.Point(39, 27);
            this.listViewGiaoDich.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewGiaoDich.Name = "listViewGiaoDich";
            this.listViewGiaoDich.Size = new System.Drawing.Size(477, 359);
            this.listViewGiaoDich.TabIndex = 0;
            this.listViewGiaoDich.UseCompatibleStateImageBehavior = false;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDong.BackColor = System.Drawing.Color.LightCoral;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Location = new System.Drawing.Point(598, 169);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(71, 57);
            this.btnDong.TabIndex = 1;
            this.btnDong.Text = "Dong";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // XemLichSuGiaoDichForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 413);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.listViewGiaoDich);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "XemLichSuGiaoDichForm";
            this.Text = "XemLichSuGiaoDichForm";
            this.Load += new System.EventHandler(this.XemLichSuGiaoDichForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewGiaoDich;
        private System.Windows.Forms.Button btnDong;
    }
}