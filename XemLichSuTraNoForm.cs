using System;
using System.Linq;
using System.Windows.Forms;
using static guibankapp.Menu;

namespace guibankapp
{
    public partial class XemLichSuTraNoForm : Form
    {
        public XemLichSuTraNoForm()
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

            // Hiển thị lịch sử trả nợ
            if (!taiKhoan.LichSuTraNo.Any())
            {
                lblKetQua.Text = "Chưa có lịch sử thanh toán.";
                return;
            }

            string thongTin = "LỊCH SỬ THANH TOÁN\n" +
                            "----------------------------------------\n" +
                            $"{"Ngày",-25} {"Số tiền",15}\n" +
                            "----------------------------------------\n";

            foreach (var payment in taiKhoan.LichSuTraNo)
            {
                thongTin += $"{payment.ThoiGian:dd/MM/yyyy HH:mm:ss,-25} {payment.SoTien,15:N0} VND\n";
            }

            thongTin += "----------------------------------------\n" +
                      $"Nợ còn lại: {taiKhoan.NoConLai:N0} VND\n" +
                      $"Lãi phải trả tháng này: {taiKhoan.LaiPhaiTra:N0} VND\n" +
                      "----------------------------------------";

            lblKetQua.Text = thongTin;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XemLichSuTraNoForm_Load(object sender, EventArgs e)
        {

        }
    }
}