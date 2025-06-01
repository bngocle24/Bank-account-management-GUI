using System;
using System.Windows.Forms;
using static guibankapp.Menu;

namespace guibankapp
{
    public partial class ThongKeTaiKhoanForm : Form
    {
        public ThongKeTaiKhoanForm()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            HienThiThongKeTaiKhoan();
        }

        private void HienThiThongKeTaiKhoan()
        {
            listViewThongKe.View = View.Details;
            listViewThongKe.FullRowSelect = true;
            listViewThongKe.Columns.Add("Loại tài khoản", 200);
            listViewThongKe.Columns.Add("Số lượng", 100);

            int soTaiKhoanThanhToan = 0;
            int soTaiKhoanTietKiem = 0;
            int soTaiKhoanVayVon = 0;

            // Đếm số lượng từng loại tài khoản
            foreach (var kh in danhSachKhachHang)
            {
                foreach (var tk in kh.DanhSachTaiKhoan)
                {
                    if (tk is TaiKhoanThanhToan)
                        soTaiKhoanThanhToan++;
                    else if (tk is TaiKhoanTietKiem)
                        soTaiKhoanTietKiem++;
                    else if (tk is TaiKhoanVayVon)
                        soTaiKhoanVayVon++;
                }
            }

            // Hiển thị thống kê
            listViewThongKe.Items.Add(new ListViewItem(new[] { "Tài khoản thanh toán", soTaiKhoanThanhToan.ToString() }));
            listViewThongKe.Items.Add(new ListViewItem(new[] { "Tài khoản tiết kiệm", soTaiKhoanTietKiem.ToString() }));
            listViewThongKe.Items.Add(new ListViewItem(new[] { "Tài khoản vay vốn", soTaiKhoanVayVon.ToString() }));
            listViewThongKe.Items.Add(new ListViewItem(new[] { "Tổng số tài khoản", (soTaiKhoanThanhToan + soTaiKhoanTietKiem + soTaiKhoanVayVon).ToString() }));
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongKeTaiKhoanForm_Load(object sender, EventArgs e)
        {
        }
    }
}