using System;
using System.Windows.Forms;
using static guibankapp.Menu;

namespace guibankapp
{
    public partial class ChonLoaiTaiKhoan : Form
    {
        public Menu.KhachHang KhachHang { get; }
        public TaiKhoan TaiKhoanDuocTao { get; private set; }

        public ChonLoaiTaiKhoan(Menu.KhachHang khachHang)
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            KhachHang = khachHang;
            lblKhachHang.Text = $"{khachHang.HoTen} (Mã KH: {khachHang.MaKhachHang})";
        }

        private void btnTaiKhoanThanhToan_Click(object sender, EventArgs e)
        {
            using (var form = new TaiKhoanThanhToanForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    TaiKhoanDuocTao = new TaiKhoanThanhToan(form.SoDu);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btnTaiKhoanTietKiem_Click(object sender, EventArgs e)
        {
            using (var form = new TaiKhoanTietKiemForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    TaiKhoanDuocTao = new TaiKhoanTietKiem(form.SoDu, form.KyHan, form.LaiSuat);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btnTaiKhoanVayVon_Click(object sender, EventArgs e)
        {
            using (var form = new TaiKhoanVayVonForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    TaiKhoanDuocTao = new TaiKhoanVayVon(form.SoTienVay, form.KyHan, form.LaiSuat);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ChonLoaiTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}