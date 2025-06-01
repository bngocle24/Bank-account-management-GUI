using System;

namespace guibankapp
{
    partial class Menu
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
        private void xembanglaisuat_Click(object sender, EventArgs e)
        {
            XemBangLaiSuat formBangLaiSuat = new XemBangLaiSuat();
            formBangLaiSuat.ShowDialog();
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xembanglaisuat = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlykhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.taohosochokhachhangmoi = new System.Windows.Forms.ToolStripMenuItem();
            this.xemdanhsachkhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.timkiemkhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.capnhatthongtinkhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.motaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.xemthongtintaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.xoataikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.quaylai = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlygiaodich = new System.Windows.Forms.ToolStripMenuItem();
            this.naptien = new System.Windows.Forms.ToolStripMenuItem();
            this.ruttien = new System.Windows.Forms.ToolStripMenuItem();
            this.chuyenkhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.xemlichsugiaodich = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlytaikhoantietkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.tinhlaidukiensaukyhan = new System.Windows.Forms.ToolStripMenuItem();
            this.daohan = new System.Windows.Forms.ToolStripMenuItem();
            this.ruttientruochan = new System.Windows.Forms.ToolStripMenuItem();
            this.xemthongtintaikhoan1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quanlytaikhoanvay = new System.Windows.Forms.ToolStripMenuItem();
            this.xemkehoachthanhtoan = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhtoanhangthang = new System.Windows.Forms.ToolStripMenuItem();
            this.xemlichsutrano = new System.Windows.Forms.ToolStripMenuItem();
            this.xemthongtintaikhoan2 = new System.Windows.Forms.ToolStripMenuItem();
            this.baocaodoanhthu = new System.Windows.Forms.ToolStripMenuItem();
            this.thongkekhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatluudulieu = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xembanglaisuat,
            this.quanlykhachhang,
            this.quanlygiaodich,
            this.quanlytaikhoantietkiem,
            this.quanlytaikhoanvay,
            this.baocaodoanhthu,
            this.thongkekhachhang,
            this.thoatluudulieu});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(372, 404);
            // 
            // xembanglaisuat
            // 
            this.xembanglaisuat.AutoSize = false;
            this.xembanglaisuat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.xembanglaisuat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xembanglaisuat.BackgroundImage")));
            this.xembanglaisuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xembanglaisuat.Image = ((System.Drawing.Image)(resources.GetObject("xembanglaisuat.Image")));
            this.xembanglaisuat.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.xembanglaisuat.Name = "xembanglaisuat";
            this.xembanglaisuat.Size = new System.Drawing.Size(280, 50);
            this.xembanglaisuat.Text = "1. Xem bang lai suat";
            this.xembanglaisuat.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.xembanglaisuat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.xembanglaisuat.Click += new System.EventHandler(this.xembanglaisuat_Click);
            // 
            // quanlykhachhang
            // 
            this.quanlykhachhang.AccessibleName = "";
            this.quanlykhachhang.AutoSize = false;
            this.quanlykhachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.quanlykhachhang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quanlykhachhang.BackgroundImage")));
            this.quanlykhachhang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.taohosochokhachhangmoi,
            this.xemdanhsachkhachhang,
            this.timkiemkhachhang,
            this.capnhatthongtinkhachhang,
            this.motaikhoan,
            this.xemthongtintaikhoan,
            this.xoataikhoan,
            this.quaylai});
            this.quanlykhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanlykhachhang.Image = ((System.Drawing.Image)(resources.GetObject("quanlykhachhang.Image")));
            this.quanlykhachhang.Name = "quanlykhachhang";
            this.quanlykhachhang.Size = new System.Drawing.Size(280, 50);
            this.quanlykhachhang.Text = "2. Quan ly khach hang";
            // 
            // taohosochokhachhangmoi
            // 
            this.taohosochokhachhangmoi.AutoSize = false;
            this.taohosochokhachhangmoi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.taohosochokhachhangmoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("taohosochokhachhangmoi.BackgroundImage")));
            this.taohosochokhachhangmoi.Name = "taohosochokhachhangmoi";
            this.taohosochokhachhangmoi.Size = new System.Drawing.Size(313, 30);
            this.taohosochokhachhangmoi.Text = "2.1. Tao ho so cho khach hang moi";
            this.taohosochokhachhangmoi.Click += new System.EventHandler(this.taoHoSoChoKhachHangMoiToolStripMenuItem_Click);
            // 
            // xemdanhsachkhachhang
            // 
            this.xemdanhsachkhachhang.AutoSize = false;
            this.xemdanhsachkhachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.xemdanhsachkhachhang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xemdanhsachkhachhang.BackgroundImage")));
            this.xemdanhsachkhachhang.Name = "xemdanhsachkhachhang";
            this.xemdanhsachkhachhang.Size = new System.Drawing.Size(313, 30);
            this.xemdanhsachkhachhang.Text = "2.2. Xem danh sach khach hang";
            this.xemdanhsachkhachhang.Click += new System.EventHandler(this.xemDanhSachKhachHangToolStripMenuItem_Click);
            // 
            // timkiemkhachhang
            // 
            this.timkiemkhachhang.AutoSize = false;
            this.timkiemkhachhang.BackColor = System.Drawing.Color.Fuchsia;
            this.timkiemkhachhang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("timkiemkhachhang.BackgroundImage")));
            this.timkiemkhachhang.Name = "timkiemkhachhang";
            this.timkiemkhachhang.Size = new System.Drawing.Size(313, 30);
            this.timkiemkhachhang.Text = "2.3. Tim kiem khach hang";
            this.timkiemkhachhang.Click += new System.EventHandler(this.timKiemKhachHangToolStripMenuItem_Click);
            // 
            // capnhatthongtinkhachhang
            // 
            this.capnhatthongtinkhachhang.AutoSize = false;
            this.capnhatthongtinkhachhang.BackColor = System.Drawing.Color.Lavender;
            this.capnhatthongtinkhachhang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("capnhatthongtinkhachhang.BackgroundImage")));
            this.capnhatthongtinkhachhang.Name = "capnhatthongtinkhachhang";
            this.capnhatthongtinkhachhang.Size = new System.Drawing.Size(313, 30);
            this.capnhatthongtinkhachhang.Text = "2.4. Cap nhat thong tin khach hang";
            this.capnhatthongtinkhachhang.Click += new System.EventHandler(this.capNhatThongTinKhachHangToolStripMenuItem_Click);
            // 
            // motaikhoan
            // 
            this.motaikhoan.AutoSize = false;
            this.motaikhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.motaikhoan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("motaikhoan.BackgroundImage")));
            this.motaikhoan.Name = "motaikhoan";
            this.motaikhoan.Size = new System.Drawing.Size(313, 30);
            this.motaikhoan.Text = "2.5. Mo tai khoan";
            this.motaikhoan.Click += new System.EventHandler(this.moTaiKhoanToolStripMenuItem_Click);
            // 
            // xemthongtintaikhoan
            // 
            this.xemthongtintaikhoan.AutoSize = false;
            this.xemthongtintaikhoan.BackColor = System.Drawing.SystemColors.GrayText;
            this.xemthongtintaikhoan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xemthongtintaikhoan.BackgroundImage")));
            this.xemthongtintaikhoan.Name = "xemthongtintaikhoan";
            this.xemthongtintaikhoan.Size = new System.Drawing.Size(313, 30);
            this.xemthongtintaikhoan.Text = "2.6. Xem thong tin tai khoan";
            this.xemthongtintaikhoan.Click += new System.EventHandler(this.xemthongtintaikhoan_Click);
            // 
            // xoataikhoan
            // 
            this.xoataikhoan.AutoSize = false;
            this.xoataikhoan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.xoataikhoan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xoataikhoan.BackgroundImage")));
            this.xoataikhoan.Name = "xoataikhoan";
            this.xoataikhoan.Size = new System.Drawing.Size(313, 30);
            this.xoataikhoan.Text = "2.7. Xoa tai khoan ";
            this.xoataikhoan.Click += new System.EventHandler(this.xoataikhoanToolStripMenuItem_Click);
            // 
            // quaylai
            // 
            this.quaylai.AutoSize = false;
            this.quaylai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.quaylai.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quaylai.BackgroundImage")));
            this.quaylai.Name = "quaylai";
            this.quaylai.Size = new System.Drawing.Size(313, 30);
            this.quaylai.Text = "2.8. Quay lai";
            // 
            // quanlygiaodich
            // 
            this.quanlygiaodich.AutoSize = false;
            this.quanlygiaodich.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.quanlygiaodich.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quanlygiaodich.BackgroundImage")));
            this.quanlygiaodich.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.naptien,
            this.ruttien,
            this.chuyenkhoan,
            this.xemlichsugiaodich});
            this.quanlygiaodich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanlygiaodich.Image = ((System.Drawing.Image)(resources.GetObject("quanlygiaodich.Image")));
            this.quanlygiaodich.Name = "quanlygiaodich";
            this.quanlygiaodich.Size = new System.Drawing.Size(280, 50);
            this.quanlygiaodich.Text = "3. Quan ly giao dich ";
            this.quanlygiaodich.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // naptien
            // 
            this.naptien.AutoSize = false;
            this.naptien.BackColor = System.Drawing.Color.Yellow;
            this.naptien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("naptien.BackgroundImage")));
            this.naptien.Name = "naptien";
            this.naptien.Size = new System.Drawing.Size(248, 30);
            this.naptien.Text = "3.1. Nap tien ";
            this.naptien.Click += new System.EventHandler(this.naptienToolStripMenuItem_Click);
            // 
            // ruttien
            // 
            this.ruttien.AutoSize = false;
            this.ruttien.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ruttien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ruttien.BackgroundImage")));
            this.ruttien.Name = "ruttien";
            this.ruttien.Size = new System.Drawing.Size(248, 30);
            this.ruttien.Text = "3.2. Rut tien";
            this.ruttien.Click += new System.EventHandler(this.ruttienToolStripMenuItem_Click);
            // 
            // chuyenkhoan
            // 
            this.chuyenkhoan.AutoSize = false;
            this.chuyenkhoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.chuyenkhoan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chuyenkhoan.BackgroundImage")));
            this.chuyenkhoan.Name = "chuyenkhoan";
            this.chuyenkhoan.Size = new System.Drawing.Size(248, 30);
            this.chuyenkhoan.Text = "3.3 Chuyen khoan";
            this.chuyenkhoan.Click += new System.EventHandler(this.chuyenKhoanToolStripMenuItem_Click);
            // 
            // xemlichsugiaodich
            // 
            this.xemlichsugiaodich.AutoSize = false;
            this.xemlichsugiaodich.BackColor = System.Drawing.SystemColors.Info;
            this.xemlichsugiaodich.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xemlichsugiaodich.BackgroundImage")));
            this.xemlichsugiaodich.Name = "xemlichsugiaodich";
            this.xemlichsugiaodich.Size = new System.Drawing.Size(248, 30);
            this.xemlichsugiaodich.Text = "3.4. Xem lich su giao dich";
            this.xemlichsugiaodich.Click += new System.EventHandler(this.xemLichSuGiaoDichToolStripMenuItem_Click);
            // 
            // quanlytaikhoantietkiem
            // 
            this.quanlytaikhoantietkiem.AutoSize = false;
            this.quanlytaikhoantietkiem.BackColor = System.Drawing.Color.Lime;
            this.quanlytaikhoantietkiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quanlytaikhoantietkiem.BackgroundImage")));
            this.quanlytaikhoantietkiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tinhlaidukiensaukyhan,
            this.daohan,
            this.ruttientruochan,
            this.xemthongtintaikhoan1});
            this.quanlytaikhoantietkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanlytaikhoantietkiem.Image = ((System.Drawing.Image)(resources.GetObject("quanlytaikhoantietkiem.Image")));
            this.quanlytaikhoantietkiem.Name = "quanlytaikhoantietkiem";
            this.quanlytaikhoantietkiem.Size = new System.Drawing.Size(280, 50);
            this.quanlytaikhoantietkiem.Text = "4. Quan ly tai khoan tiet kiem";
            this.quanlytaikhoantietkiem.Click += new System.EventHandler(this.quanlytaikhoantietkiem_Click);
            // 
            // tinhlaidukiensaukyhan
            // 
            this.tinhlaidukiensaukyhan.AutoSize = false;
            this.tinhlaidukiensaukyhan.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tinhlaidukiensaukyhan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tinhlaidukiensaukyhan.BackgroundImage")));
            this.tinhlaidukiensaukyhan.Name = "tinhlaidukiensaukyhan";
            this.tinhlaidukiensaukyhan.Size = new System.Drawing.Size(281, 30);
            this.tinhlaidukiensaukyhan.Text = "4.1.Tinh lai du kien sau ky han";
            this.tinhlaidukiensaukyhan.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // daohan
            // 
            this.daohan.AutoSize = false;
            this.daohan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.daohan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("daohan.BackgroundImage")));
            this.daohan.Name = "daohan";
            this.daohan.Size = new System.Drawing.Size(281, 30);
            this.daohan.Text = "4.2. Dao han";
            this.daohan.Click += new System.EventHandler(this.daohan_Click);
            // 
            // ruttientruochan
            // 
            this.ruttientruochan.AutoSize = false;
            this.ruttientruochan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ruttientruochan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ruttientruochan.BackgroundImage")));
            this.ruttientruochan.Name = "ruttientruochan";
            this.ruttientruochan.Size = new System.Drawing.Size(281, 30);
            this.ruttientruochan.Text = "4.3. Rut tien truoc han";
            this.ruttientruochan.Click += new System.EventHandler(this.rutTienTruocHan_Click);
            // 
            // xemthongtintaikhoan1
            // 
            this.xemthongtintaikhoan1.AutoSize = false;
            this.xemthongtintaikhoan1.BackColor = System.Drawing.SystemColors.Info;
            this.xemthongtintaikhoan1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xemthongtintaikhoan1.BackgroundImage")));
            this.xemthongtintaikhoan1.Name = "xemthongtintaikhoan1";
            this.xemthongtintaikhoan1.Size = new System.Drawing.Size(281, 30);
            this.xemthongtintaikhoan1.Text = "4.4 Xem thong tin tai khoan";
            this.xemthongtintaikhoan1.Click += new System.EventHandler(this.xemthongtintaikhoan1_Click);
            // 
            // quanlytaikhoanvay
            // 
            this.quanlytaikhoanvay.AutoSize = false;
            this.quanlytaikhoanvay.BackColor = System.Drawing.SystemColors.Highlight;
            this.quanlytaikhoanvay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quanlytaikhoanvay.BackgroundImage")));
            this.quanlytaikhoanvay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemkehoachthanhtoan,
            this.thanhtoanhangthang,
            this.xemlichsutrano,
            this.xemthongtintaikhoan2});
            this.quanlytaikhoanvay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanlytaikhoanvay.Image = ((System.Drawing.Image)(resources.GetObject("quanlytaikhoanvay.Image")));
            this.quanlytaikhoanvay.Name = "quanlytaikhoanvay";
            this.quanlytaikhoanvay.Size = new System.Drawing.Size(280, 50);
            this.quanlytaikhoanvay.Text = "5. Quan ly tai khoan vay";
            // 
            // xemkehoachthanhtoan
            // 
            this.xemkehoachthanhtoan.AutoSize = false;
            this.xemkehoachthanhtoan.BackColor = System.Drawing.Color.Fuchsia;
            this.xemkehoachthanhtoan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xemkehoachthanhtoan.BackgroundImage")));
            this.xemkehoachthanhtoan.Name = "xemkehoachthanhtoan";
            this.xemkehoachthanhtoan.Size = new System.Drawing.Size(274, 30);
            this.xemkehoachthanhtoan.Text = "5.1. Xem ke hoach thanh toan";
            this.xemkehoachthanhtoan.Click += new System.EventHandler(this.xemKeHoachThanhToan_Click);
            // 
            // thanhtoanhangthang
            // 
            this.thanhtoanhangthang.AutoSize = false;
            this.thanhtoanhangthang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.thanhtoanhangthang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thanhtoanhangthang.BackgroundImage")));
            this.thanhtoanhangthang.Name = "thanhtoanhangthang";
            this.thanhtoanhangthang.Size = new System.Drawing.Size(274, 30);
            this.thanhtoanhangthang.Text = "5.2. Thanh toan hang thang";
            this.thanhtoanhangthang.Click += new System.EventHandler(this.thanhToanHangThang_Click);
            // 
            // xemlichsutrano
            // 
            this.xemlichsutrano.AutoSize = false;
            this.xemlichsutrano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xemlichsutrano.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xemlichsutrano.BackgroundImage")));
            this.xemlichsutrano.Name = "xemlichsutrano";
            this.xemlichsutrano.Size = new System.Drawing.Size(274, 30);
            this.xemlichsutrano.Text = "5.3. Xem lich su tra no";
            this.xemlichsutrano.Click += new System.EventHandler(this.xemLichSuTraNo_Click);
            // 
            // xemthongtintaikhoan2
            // 
            this.xemthongtintaikhoan2.AutoSize = false;
            this.xemthongtintaikhoan2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.xemthongtintaikhoan2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("xemthongtintaikhoan2.BackgroundImage")));
            this.xemthongtintaikhoan2.Name = "xemthongtintaikhoan2";
            this.xemthongtintaikhoan2.Size = new System.Drawing.Size(274, 30);
            this.xemthongtintaikhoan2.Text = "5.4. Xem thong tin tai khoan";
            this.xemthongtintaikhoan2.Click += new System.EventHandler(this.xemThongTinTaiKhoanVayVon_Click);
            // 
            // baocaodoanhthu
            // 
            this.baocaodoanhthu.AutoSize = false;
            this.baocaodoanhthu.BackColor = System.Drawing.SystemColors.GrayText;
            this.baocaodoanhthu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("baocaodoanhthu.BackgroundImage")));
            this.baocaodoanhthu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baocaodoanhthu.Image = ((System.Drawing.Image)(resources.GetObject("baocaodoanhthu.Image")));
            this.baocaodoanhthu.Name = "baocaodoanhthu";
            this.baocaodoanhthu.Size = new System.Drawing.Size(280, 50);
            this.baocaodoanhthu.Text = "6. Bao cao doanh thu";
            this.baocaodoanhthu.Click += new System.EventHandler(this.baoCaoDoanhThuToolStripMenuItem_Click);
            // 
            // thongkekhachhang
            // 
            this.thongkekhachhang.AutoSize = false;
            this.thongkekhachhang.BackColor = System.Drawing.Color.Yellow;
            this.thongkekhachhang.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thongkekhachhang.BackgroundImage")));
            this.thongkekhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thongkekhachhang.Image = ((System.Drawing.Image)(resources.GetObject("thongkekhachhang.Image")));
            this.thongkekhachhang.Name = "thongkekhachhang";
            this.thongkekhachhang.Size = new System.Drawing.Size(280, 50);
            this.thongkekhachhang.Text = "7. Thong ke khach hang";
            this.thongkekhachhang.Click += new System.EventHandler(this.thongKeTaiKhoanToolStripMenuItem_Click);
            // 
            // thoatluudulieu
            // 
            this.thoatluudulieu.AutoSize = false;
            this.thoatluudulieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.thoatluudulieu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thoatluudulieu.BackgroundImage")));
            this.thoatluudulieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoatluudulieu.Image = ((System.Drawing.Image)(resources.GetObject("thoatluudulieu.Image")));
            this.thoatluudulieu.Name = "thoatluudulieu";
            this.thoatluudulieu.Size = new System.Drawing.Size(280, 50);
            this.thoatluudulieu.Text = "0. Thoat (luu lai du lieu)";
            this.thoatluudulieu.Click += new System.EventHandler(this.thoatluudulieu_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(489, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "START\r\n";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(-214, -188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1778, 977);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(489, -83);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(345, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(540, 123);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1023, 666);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-172, 143);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(802, 646);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 583);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Load_1);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem xembanglaisuat;
        private System.Windows.Forms.ToolStripMenuItem quanlykhachhang;
        private System.Windows.Forms.ToolStripMenuItem taohosochokhachhangmoi;
        private System.Windows.Forms.ToolStripMenuItem xemdanhsachkhachhang;
        private System.Windows.Forms.ToolStripMenuItem timkiemkhachhang;
        private System.Windows.Forms.ToolStripMenuItem capnhatthongtinkhachhang;
        private System.Windows.Forms.ToolStripMenuItem motaikhoan;
        private System.Windows.Forms.ToolStripMenuItem xemthongtintaikhoan;
        private System.Windows.Forms.ToolStripMenuItem xoataikhoan;
        private System.Windows.Forms.ToolStripMenuItem quaylai;
        private System.Windows.Forms.ToolStripMenuItem quanlygiaodich;
        private System.Windows.Forms.ToolStripMenuItem quanlytaikhoantietkiem;
        private System.Windows.Forms.ToolStripMenuItem quanlytaikhoanvay;
        private System.Windows.Forms.ToolStripMenuItem baocaodoanhthu;
        private System.Windows.Forms.ToolStripMenuItem thongkekhachhang;
        private System.Windows.Forms.ToolStripMenuItem thoatluudulieu;
        private System.Windows.Forms.ToolStripMenuItem naptien;
        private System.Windows.Forms.ToolStripMenuItem ruttien;
        private System.Windows.Forms.ToolStripMenuItem chuyenkhoan;
        private System.Windows.Forms.ToolStripMenuItem xemlichsugiaodich;
        private System.Windows.Forms.ToolStripMenuItem tinhlaidukiensaukyhan;
        private System.Windows.Forms.ToolStripMenuItem daohan;
        private System.Windows.Forms.ToolStripMenuItem ruttientruochan;
        private System.Windows.Forms.ToolStripMenuItem xemthongtintaikhoan1;
        private System.Windows.Forms.ToolStripMenuItem xemkehoachthanhtoan;
        private System.Windows.Forms.ToolStripMenuItem thanhtoanhangthang;
        private System.Windows.Forms.ToolStripMenuItem xemlichsutrano;
        private System.Windows.Forms.ToolStripMenuItem xemthongtintaikhoan2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

