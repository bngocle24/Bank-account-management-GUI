using System;
using System.Linq;
using System.Windows.Forms;
using static guibankapp.Menu;

namespace guibankapp
{
    public partial class XemThongTinTaiKhoanVayVonForm : Form
    {
        public XemThongTinTaiKhoanVayVonForm()
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

            // Hiển thị thông tin tài khoản
            string thongTin = $"Số tài khoản: {taiKhoan.SoTaiKhoan}\n" +
                            $"Loại tài khoản: {taiKhoan.LoaiTaiKhoan}\n" +
                            $"Kỳ hạn: {taiKhoan.KyHanVay} tháng\n" +
                            $"Lãi suất: {taiKhoan.LaiSuatVay:F2}%/năm\n" +
                            $"Số tiền vay: {taiKhoan.SoTienVay:N0} VND\n" +
                            $"Nợ còn lại: {taiKhoan.NoConLai:N0} VND\n" +
                            $"Lãi phải trả tháng này: {taiKhoan.LaiPhaiTra:N0} VND\n" +
                            $"Ngày tạo: {taiKhoan.NgayTao:dd/MM/yyyy}";

            lblKetQua.Text = thongTin;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XemThongTinTaiKhoanVayVonForm_Load(object sender, EventArgs e)
        {

        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {

        }
    }
}