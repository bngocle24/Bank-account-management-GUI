using System;
using System.Linq;
using System.Windows.Forms;
using static guibankapp.Menu;

namespace guibankapp
{
    public partial class TinhLaiDuKienForm : Form
    {
        public TinhLaiDuKienForm()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnTinhLai_Click(object sender, EventArgs e)
        {
            string soTaiKhoan = txtSoTaiKhoan.Text.Trim();

            if (string.IsNullOrEmpty(soTaiKhoan))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản!", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tìm tài khoản tiết kiệm trong toàn bộ danh sách khách hàng
            TaiKhoanTietKiem taiKhoan = null;
            foreach (var khachHang in danhSachKhachHang)
            {
                taiKhoan = khachHang.DanhSachTaiKhoan
                    .OfType<TaiKhoanTietKiem>()
                    .FirstOrDefault(tk => tk.SoTaiKhoan.Equals(soTaiKhoan, StringComparison.OrdinalIgnoreCase));
                if (taiKhoan != null)
                    break;
            }

            if (taiKhoan == null)
            {
                MessageBox.Show("Tài khoản không tồn tại hoặc không phải tài khoản tiết kiệm!", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double laiDuKien = taiKhoan.TinhLai();
            lblKetQua.Text = $"Lãi dự kiến: {laiDuKien:N0} VND\n" +
                           $"Số dư: {taiKhoan.SoDu:N0} VND\n" +
                           $"Kỳ hạn: {taiKhoan.KyHan} tháng\n" +
                           $"Lãi suất: {taiKhoan.LaiSuat}%/năm";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TinhLaiDuKienForm_Load(object sender, EventArgs e)
        {
            // Có thể thêm logic khởi tạo nếu cần
        }
    }
}