using System;
using System.Windows.Forms;

namespace guibankapp
{
    public partial class Taohosochokhachhangmoi : Form
    {
        // Properties để lưu trữ thông tin khách hàng
        public string HoTen { get; private set; }
        public string CMND { get; private set; }
        public string DiaChi { get; private set; }
        public string SoDienThoai { get; private set; }
        public string Email { get; private set; }

        public Taohosochokhachhangmoi()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        // Thêm phương thức xử lý sự kiện Load form
        private void Taohosochokhachhangmoi_Load(object sender, EventArgs e)
        {
            // Khởi tạo ban đầu nếu cần
        }

        // Thêm phương thức xử lý click label (nếu cần)
        private void label1_Click(object sender, EventArgs e)
        {
            // Xử lý khi click vào label1 (nếu cần)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra dữ liệu
                if (string.IsNullOrWhiteSpace(nhaphovaten.Text) ||
                    string.IsNullOrWhiteSpace(nhapcccdhoaccmnd.Text) ||
                    string.IsNullOrWhiteSpace(nhapdiachicanhan.Text) ||
                    string.IsNullOrWhiteSpace(nhapsodienthoaicanhan.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin bắt buộc!", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Gán giá trị
                HoTen = nhaphovaten.Text;
                CMND = nhapcccdhoaccmnd.Text;
                DiaChi = nhapdiachicanhan.Text;
                SoDienThoai = nhapsodienthoaicanhan.Text;
                Email = nhapemailcanhan.Text;

                // Đánh dấu form hoàn thành thành công
                this.DialogResult = DialogResult.OK;

                // Đóng form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu thông tin: {ex.Message}", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Nút hủy bỏ
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}