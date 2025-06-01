using System;
using System.Linq;
using System.Windows.Forms;
using static guibankapp.Menu;

namespace guibankapp
{
    public partial class ChuyenKhoanForm : Form
    {
        public ChuyenKhoanForm()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string soTaiKhoanNguon = txtSoTaiKhoanNguon.Text.Trim();
            string soTaiKhoanDich = txtSoTaiKhoanDich.Text.Trim();
            if (string.IsNullOrEmpty(soTaiKhoanNguon) || string.IsNullOrEmpty(soTaiKhoanDich))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ số tài khoản nguồn và đích", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtSoTien.Text, out double soTien) || soTien <= 0)
            {
                MessageBox.Show("Số tiền chuyển không hợp lệ", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TaiKhoanThanhToan taiKhoanNguon = null;
            TaiKhoan taiKhoanDich = null;
            foreach (var kh in danhSachKhachHang)
            {
                if (taiKhoanNguon == null)
                    taiKhoanNguon = kh.DanhSachTaiKhoan.OfType<TaiKhoanThanhToan>()
                        .FirstOrDefault(tk => tk.SoTaiKhoan == soTaiKhoanNguon);
                if (taiKhoanDich == null)
                    taiKhoanDich = kh.DanhSachTaiKhoan
                        .FirstOrDefault(tk => tk.SoTaiKhoan == soTaiKhoanDich);
            }

            if (taiKhoanNguon == null || taiKhoanDich == null)
            {
                MessageBox.Show("Tài khoản nguồn hoặc đích không tồn tại", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (taiKhoanNguon.ChuyenKhoan(taiKhoanDich, soTien))
            {
                danhSachGiaoDich.Add(new GiaoDich(soTaiKhoanNguon, soTaiKhoanDich, "Chuyển khoản", soTien));
                MessageBox.Show($"Chuyển khoản thành công!\nSố dư mới: {taiKhoanNguon.SoDu:N0} VND",
                              "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Chuyển khoản thất bại", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChuyenKhoanForm_Load(object sender, EventArgs e)
        {
        }

        private void ChuyenKhoanForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}