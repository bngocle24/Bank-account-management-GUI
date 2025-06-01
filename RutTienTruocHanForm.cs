using System;
using System.Linq;
using System.Windows.Forms;
using static guibankapp.Menu;

namespace guibankapp
{
    public partial class RutTienTruocHanForm : Form
    {
        public RutTienTruocHanForm()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnRutTien_Click(object sender, EventArgs e)
        {
            string soTaiKhoan = txtSoTaiKhoan.Text.Trim();
            if (string.IsNullOrEmpty(soTaiKhoan))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản!", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtSoTien.Text, out double soTien) || soTien <= 0)
            {
                MessageBox.Show("Số tiền rút không hợp lệ!", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tìm tài khoản tiết kiệm
            TaiKhoanTietKiem taiKhoan = null;
            foreach (var kh in danhSachKhachHang)
            {
                taiKhoan = kh.DanhSachTaiKhoan
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

            // Thực hiện rút tiền trước hạn
            double phiRutTruocHan = 0.5;
            double soDuCu = taiKhoan.SoDu;
            if (taiKhoan.RutTienTruocHan(soTien, phiRutTruocHan))
            {
                double phi = soTien * (phiRutTruocHan / 100);
                lblKetQua.Text = $"Rút tiền trước hạn thành công!\n" +
                               $"Số tiền rút: {soTien:N0} VND\n" +
                               $"Phí rút trước hạn: {phi:N0} VND\n" +
                               $"Số dư cũ: {soDuCu:N0} VND\n" +
                               $"Số dư mới: {taiKhoan.SoDu:N0} VND\n" +
                               $"Tổng phí rút trước hạn: {taiKhoan.TinhTongPhiRutTruocHan():N0} VND";
            }
            else
            {
                lblKetQua.Text = "Rút tiền thất bại! Số dư không đủ.";
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RutTienTruocHanForm_Load(object sender, EventArgs e)
        {

        }
    }
}