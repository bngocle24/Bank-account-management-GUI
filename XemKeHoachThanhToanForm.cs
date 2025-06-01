using System;
using System.Linq;
using System.Windows.Forms;
using static guibankapp.Menu;

namespace guibankapp
{
    public partial class XemKeHoachThanhToanForm : Form
    {
        public XemKeHoachThanhToanForm()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string soTaiKhoan = txtSoTaiKhoan.Text.Trim();
            if (string.IsNullOrEmpty(soTaiKhoan))
            {
                MessageBox.Show("Vui lòng nhập số tài khoản!", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tìm tài khoản vay vốn
            TaiKhoanVayVon taiKhoan = null;
            foreach (var kh in danhSachKhachHang)
            {
                taiKhoan = kh.DanhSachTaiKhoan
                    .OfType<TaiKhoanVayVon>()
                    .FirstOrDefault(tk => tk.SoTaiKhoan.Equals(soTaiKhoan, StringComparison.OrdinalIgnoreCase));
                if (taiKhoan != null)
                    break;
            }

            if (taiKhoan == null)
            {
                MessageBox.Show("Tài khoản không tồn tại hoặc không phải tài khoản vay vốn!", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tính toán kế hoạch thanh toán
            var (gocHangThang, laiHangThang, tongThanhToan) = taiKhoan.TinhToanThanhToanHangThang();

            // Hiển thị thông tin
            string thongTin = "KẾ HOẠCH THANH TOÁN\n" +
                            "----------------------------------------\n" +
                            $"Tổng nợ gốc: {taiKhoan.SoTienVay:N0} VND\n" +
                            $"Kỳ hạn: {taiKhoan.KyHanVay} tháng\n" +
                            $"Lãi suất: {taiKhoan.LaiSuatVay}%/năm\n" +
                            "----------------------------------------\n" +
                            "Thanh toán hằng tháng:\n" +
                            $"- Gốc: {gocHangThang:N0} VND\n" +
                            $"- Lãi: ~{laiHangThang:N0} VND (giảm dần)\n" +
                            "----------------------------------------\n" +
                            $"Tổng thanh toán hằng tháng: ~{tongThanhToan:N0} VND\n" +
                            "----------------------------------------";

            lblKetQua.Text = thongTin;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XemKeHoachThanhToanForm_Load(object sender, EventArgs e)
        {

        }
    }
}