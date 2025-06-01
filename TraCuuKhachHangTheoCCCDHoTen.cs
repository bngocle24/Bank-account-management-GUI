using static guibankapp.Menu;  // Thêm dòng này
using System;
using System.Windows.Forms;
using System.Linq;

namespace guibankapp
{
    public partial class TraCuuKhachHangTheoCCCDHoTen : Form
    {
        public KhachHang KhachHangDuocChon { get; private set; }  // Đã bỏ Menu.

        public TraCuuKhachHangTheoCCCDHoTen()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        // Thêm phương thức xử lý sự kiện Load
        private void TraCuuKhachHangTheoCCCDHoTen_Load(object sender, EventArgs e)
        {
            txtCCCD.Focus(); // Tự động focus vào ô nhập CCCD khi form load
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string cccd = txtCCCD.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();

            if (string.IsNullOrEmpty(cccd) || string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ CCCD và Họ tên", "Thông báo",
                             MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sửa lại dòng này, bỏ Menu. vì đã có using static
            KhachHangDuocChon = danhSachKhachHang.FirstOrDefault(kh =>
                kh.CMND.Equals(cccd, StringComparison.OrdinalIgnoreCase) &&
                kh.HoTen.Equals(hoTen, StringComparison.OrdinalIgnoreCase));

            if (KhachHangDuocChon != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng phù hợp", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCCCD.Focus();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}