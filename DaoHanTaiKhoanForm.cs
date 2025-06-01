using System;
using System.Linq;
using System.Windows.Forms;
using static guibankapp.Menu;

namespace guibankapp
{
    public partial class DaoHanTaiKhoanForm : Form
    {
        public DaoHanTaiKhoanForm()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnDaoHan_Click(object sender, EventArgs e)
        {
            string soTaiKhoan = txtSoTaiKhoan.Text.Trim();

            if (string.IsNullOrEmpty(soTaiKhoan))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản!", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tìm tài khoản tiết kiệm trong danh sách khách hàng
            TaiKhoanTietKiem taiKhoan = null;
            KhachHang khachHang = null;
            foreach (var kh in danhSachKhachHang)
            {
                taiKhoan = kh.DanhSachTaiKhoan
                    .OfType<TaiKhoanTietKiem>()
                    .FirstOrDefault(tk => tk.SoTaiKhoan.Equals(soTaiKhoan, StringComparison.OrdinalIgnoreCase));
                if (taiKhoan != null)
                {
                    khachHang = kh;
                    break;
                }
            }

            if (taiKhoan == null)
            {
                MessageBox.Show("Tài khoản không tồn tại hoặc không phải tài khoản tiết kiệm!", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tính lãi kỳ hiện tại
            double laiDuKien = taiKhoan.TinhLai();
            double soDuCu = taiKhoan.SoDu;

            // Cộng lãi vào số dư
            taiKhoan.SoDu += laiDuKien;

            // Đặt lại ngày tạo tài khoản
            taiKhoan.NgayTao = DateTime.Now;

            // Lưu giao dịch đáo hạn
            if (danhSachGiaoDich != null)
            {
                var giaoDich = new GiaoDich(taiKhoan.SoTaiKhoan, null, "Đáo hạn", laiDuKien);
                danhSachGiaoDich.Add(giaoDich);
            }

            // Hiển thị kết quả
            lblKetQua.Text = $"Đáo hạn thành công!\n" +
                           $"Số dư cũ: {soDuCu:N0} VND\n" +
                           $"Lãi kỳ trước: {laiDuKien:N0} VND\n" +
                           $"Số dư mới: {taiKhoan.SoDu:N0} VND\n" +
                           $"Kỳ hạn: {taiKhoan.KyHan} tháng\n" +
                           $"Ngày bắt đầu kỳ mới: {taiKhoan.NgayTao:dd/MM/yyyy}";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DaoHanTaiKhoanForm_Load(object sender, EventArgs e)
        {

        }

        private void lblSoTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {

        }

        private void txtSoTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}