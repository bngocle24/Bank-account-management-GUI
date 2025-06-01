using System;
using System.Windows.Forms;

namespace guibankapp
{
    public partial class ChiTietKhachHang : Form
    {
        private Menu.KhachHang khachHang;

        public ChiTietKhachHang(Menu.KhachHang kh)
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            khachHang = kh;
            HienThiThongTin();
        }

        private void HienThiThongTin()
        {
            // Hiển thị thông tin cơ bản
            lblMaKH.Text = khachHang.MaKhachHang;
            lblHoTen.Text = khachHang.HoTen;
            lblCMND.Text = khachHang.CMND;
            lblDiaChi.Text = khachHang.DiaChi;
            lblSoDT.Text = khachHang.SoDienThoai;
            lblEmail.Text = khachHang.Email;
            lblSoTaiKhoan.Text = khachHang.DanhSachTaiKhoan.Count.ToString();

            // Hiển thị danh sách tài khoản
            listViewTaiKhoan.View = View.Details;
            listViewTaiKhoan.Columns.Add("Số TK", 120);
            listViewTaiKhoan.Columns.Add("Loại TK", 100);
            listViewTaiKhoan.Columns.Add("Số dư", 100);
            listViewTaiKhoan.Columns.Add("Ngày tạo", 120);
            listViewTaiKhoan.Columns.Add("Chi tiết", 150);

            foreach (var tk in khachHang.DanhSachTaiKhoan)
            {
                var item = new ListViewItem(tk.SoTaiKhoan);
                item.SubItems.Add(tk.LoaiTaiKhoan);
                item.SubItems.Add(tk.SoDu.ToString("N0"));
                item.SubItems.Add(tk.NgayTao.ToString("dd/MM/yyyy"));

                // Thêm thông tin chi tiết tùy loại tài khoản
                string chiTiet = "";
                if (tk is Menu.TaiKhoanTietKiem tktk)
                {
                    chiTiet = $"Kỳ hạn: {tktk.KyHan} tháng, LS: {tktk.LaiSuat}%";
                }
                else if (tk is Menu.TaiKhoanVayVon tkvv)
                {
                    chiTiet = $"Kỳ hạn: {tkvv.KyHanVay} tháng, LS: {tkvv.LaiSuatVay}%";
                }

                item.SubItems.Add(chiTiet);
                listViewTaiKhoan.Items.Add(item);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChiTietKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void lblMaKH_Click(object sender, EventArgs e)
        {

        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }
    }
}