using System;
using System.Linq;
using System.Windows.Forms;
using static guibankapp.Menu;

namespace guibankapp
{
    public partial class ThanhToanHangThangForm : Form
    {
        public ThanhToanHangThangForm()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
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
                MessageBox.Show("Số tiền thanh toán không hợp lệ!", "Lỗi",
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

            // Thực hiện thanh toán
            double noConLaiCu = taiKhoan.NoConLai;
            if (taiKhoan.ThanhToanHangThang(soTien))
            {
                double laiHangThang = noConLaiCu * (taiKhoan.LaiSuatVay / 100) / 12;
                double gocDuocGiam = soTien - laiHangThang;

                lblKetQua.Text = $"Thanh toán thành công!\n" +
                               $"Số tiền thanh toán: {soTien:N0} VND\n" +
                               $"Lãi hằng tháng: {laiHangThang:N0} VND\n" +
                               $"Gốc được giảm: {(gocDuocGiam > 0 ? gocDuocGiam : 0):N0} VND\n" +
                               $"Nợ còn lại: {taiKhoan.NoConLai:N0} VND";
            }
            else
            {
                lblKetQua.Text = "Thanh toán thất bại!";
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThanhToanHangThangForm_Load(object sender, EventArgs e)
        {

        }
    }
}