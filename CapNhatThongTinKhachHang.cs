using System;
using System.Windows.Forms;
using static guibankapp.Menu;

namespace guibankapp
{
    public partial class CapNhatThongTinKhachHang : Form
    {
        private KhachHang khachHang;

        public CapNhatThongTinKhachHang(KhachHang kh)
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.khachHang = kh;
            HienThiThongTinHienTai();
        }

        private void HienThiThongTinHienTai()
        {
            // Hiển thị thông tin hiện tại
            lblMaKH.Text = khachHang.MaKhachHang;
            lblHoTen.Text = khachHang.HoTen;
            lblCMND.Text = khachHang.CMND;
            txtDiaChi.Text = khachHang.DiaChi;
            txtSoDienThoai.Text = khachHang.SoDienThoai;
            txtEmail.Text = khachHang.Email;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Validate dữ liệu
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cập nhật thông tin
            khachHang.DiaChi = txtDiaChi.Text;
            khachHang.SoDienThoai = txtSoDienThoai.Text;
            khachHang.Email = txtEmail.Text;

            MessageBox.Show("Cập nhật thông tin thành công!", "Thành công",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CapNhatThongTinKhachHang_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}