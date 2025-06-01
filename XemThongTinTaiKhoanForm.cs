using System;
using System.Linq;
using System.Windows.Forms;
using static guibankapp.Menu;

namespace guibankapp
{
    public partial class XemThongTinTaiKhoanForm : Form
    {
        public XemThongTinTaiKhoanForm()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string soTaiKhoan = txtSoTaiKhoan.Text.Trim();
            if (string.IsNullOrEmpty(soTaiKhoan))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản!", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tìm tài khoản
            TaiKhoan taiKhoan = null;
            foreach (var kh in danhSachKhachHang)
            {
                taiKhoan = kh.DanhSachTaiKhoan
                    .FirstOrDefault(tk => tk.SoTaiKhoan.Equals(soTaiKhoan, StringComparison.OrdinalIgnoreCase));
                if (taiKhoan != null)
                    break;
            }

            if (taiKhoan == null)
            {
                MessageBox.Show("Tài khoản không tồn tại!", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hiển thị thông tin tài khoản
            string thongTin = $"Số tài khoản: {taiKhoan.SoTaiKhoan}\n" +
                            $"Loại tài khoản: {taiKhoan.LoaiTaiKhoan}\n" +
                            $"Số dư: {taiKhoan.SoDu:N0} VND\n" +
                            $"Ngày tạo: {taiKhoan.NgayTao:dd/MM/yyyy}";

            if (taiKhoan is TaiKhoanTietKiem tkTietKiem)
            {
                thongTin += $"\nKỳ hạn: {tkTietKiem.KyHan} tháng\n" +
                          $"Lãi suất: {tkTietKiem.LaiSuat}%/năm\n" +
                          $"Tổng phí rút trước hạn: {tkTietKiem.TinhTongPhiRutTruocHan():N0} VND";
            }
            else if (taiKhoan is TaiKhoanVayVon tkVayVon)
            {
                thongTin += $"\nKỳ hạn vay: {tkVayVon.KyHanVay} tháng\n" +
                          $"Lãi suất vay: {tkVayVon.LaiSuatVay}%/năm\n" +
                          $"Số tiền vay: {tkVayVon.SoTienVay:N0} VND";
            }

            lblKetQua.Text = thongTin;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XemThongTinTaiKhoanForm_Load(object sender, EventArgs e)
        {

        }
    }
}