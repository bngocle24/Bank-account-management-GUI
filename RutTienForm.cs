using System;
using System.Linq;
using System.Windows.Forms;
using static guibankapp.Menu;

namespace guibankapp
{
    public partial class RutTienForm : Form
    {
        public RutTienForm()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra số tài khoản
            string soTaiKhoan = txtSoTaiKhoan.Text.Trim();
            if (string.IsNullOrEmpty(soTaiKhoan))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Kiểm tra số tiền
            if (!double.TryParse(txtSoTien.Text, out double soTien) || soTien <= 0)
            {
                MessageBox.Show("Số tiền rút không hợp lệ", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Tìm tài khoản và thực hiện rút tiền
            bool rutTienThanhCong = false;

            foreach (var kh in danhSachKhachHang)
            {
                var taiKhoan = kh.DanhSachTaiKhoan
                    .OfType<TaiKhoanThanhToan>()
                    .FirstOrDefault(tk => tk.SoTaiKhoan == soTaiKhoan);

                if (taiKhoan != null && taiKhoan.RutTien(soTien))
                {
                    rutTienThanhCong = true;
                    // Trong khối if (taiKhoan != null && taiKhoan.RutTien(soTien))
                    danhSachGiaoDich.Add(new GiaoDich(soTaiKhoan, null, "Rút tiền", soTien));
                    MessageBox.Show($"Rút tiền thành công!\nSố dư mới: {taiKhoan.SoDu:N0} VND",
                                  "Thành công",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
            }

            if (!rutTienThanhCong)
            {
                MessageBox.Show("Rút tiền thất bại. Kiểm tra lại số tài khoản hoặc số dư", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RutTienForm_Load(object sender, EventArgs e)
        {

        }
    }
}