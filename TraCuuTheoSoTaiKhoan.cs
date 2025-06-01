using System;
using System.Windows.Forms;
using static guibankapp.Menu;

namespace guibankapp
{
    public partial class TraCuuTheoSoTaiKhoan : Form
    {
        public TaiKhoan TaiKhoanDuocChon { get; private set; }
        private KhachHang khachHang;

        public TraCuuTheoSoTaiKhoan(KhachHang kh)
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.khachHang = kh;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string soTK = txtSoTaiKhoan.Text.Trim();

            if (string.IsNullOrEmpty(soTK))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TaiKhoanDuocChon = khachHang.DanhSachTaiKhoan.Find(tk => tk.SoTaiKhoan.Equals(soTK));

            if (TaiKhoanDuocChon != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy tài khoản với số đã nhập", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TraCuuTheoSoTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}