using static guibankapp.Menu;
using System;
using System.Linq;
using System.Windows.Forms;

namespace guibankapp
{
    public partial class TraCuuKhachHangTheoMa : Form
    {
        public Menu.KhachHang KhachHangDuocChon { get; private set; }

        public TraCuuKhachHangTheoMa()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        // Thêm phương thức xử lý sự kiện Load
        private void TraCuuKhachHangTheoMa_Load(object sender, EventArgs e)
        {
            // Khởi tạo các giá trị hoặc thiết lập ban đầu nếu cần
            txtMaKhachHang.Focus(); // Tự động focus vào ô nhập mã KH
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKhachHang.Text.Trim();

            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng nhập mã khách hàng", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKhachHang.Focus();
                return;
            }

            KhachHangDuocChon = danhSachKhachHang.FirstOrDefault(kh =>
    kh.MaKhachHang.Equals(maKH, StringComparison.OrdinalIgnoreCase));

            if (KhachHangDuocChon != null)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show($"Không tìm thấy khách hàng với mã: {maKH}", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhachHang.SelectAll();
                txtMaKhachHang.Focus();
            }
        }
    }
}