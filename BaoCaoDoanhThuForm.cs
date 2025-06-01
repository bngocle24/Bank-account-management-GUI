using System;
using System.Windows.Forms;
using static guibankapp.Menu;

namespace guibankapp
{
    public partial class BaoCaoDoanhThuForm : Form
    {
        public BaoCaoDoanhThuForm()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            HienThiBaoCaoDoanhThu();
        }

        private void HienThiBaoCaoDoanhThu()
        {
            listViewDoanhThu.View = View.Details;
            listViewDoanhThu.FullRowSelect = true;
            listViewDoanhThu.Columns.Add("Loại tài khoản", 120);
            listViewDoanhThu.Columns.Add("Số tài khoản", 120);
            listViewDoanhThu.Columns.Add("Tiền lãi (VND)", 120);

            double tongLaiTietKiem = 0;
            double tongLaiVayVon = 0;

            // Hiển thị chi tiết từng tài khoản
            foreach (var kh in danhSachKhachHang)
            {
                foreach (var tk in kh.DanhSachTaiKhoan)
                {
                    if (tk is TaiKhoanTietKiem tkTietKiem)
                    {
                        double lai = tkTietKiem.TinhLai();
                        tongLaiTietKiem += lai;
                        var item = new ListViewItem("Tiết kiệm");
                        item.SubItems.Add(tkTietKiem.SoTaiKhoan);
                        item.SubItems.Add(lai.ToString("N0"));
                        listViewDoanhThu.Items.Add(item);
                    }
                    else if (tk is TaiKhoanVayVon tkVayVon)
                    {
                        double lai = tkVayVon.TinhLai();
                        tongLaiVayVon += lai;
                        var item = new ListViewItem("Vay vốn");
                        item.SubItems.Add(tkVayVon.SoTaiKhoan);
                        item.SubItems.Add(lai.ToString("N0"));
                        listViewDoanhThu.Items.Add(item);
                    }
                }
            }

            // Thêm dòng trống để phân cách
            listViewDoanhThu.Items.Add(new ListViewItem(new string[] { "", "", "" }));

            // Thêm dòng tổng kết
            listViewDoanhThu.Items.Add(new ListViewItem(new[] { "Tổng lãi tiết kiệm", "", tongLaiTietKiem.ToString("N0") }));
            listViewDoanhThu.Items.Add(new ListViewItem(new[] { "Tổng lãi vay vốn", "", tongLaiVayVon.ToString("N0") }));
            listViewDoanhThu.Items.Add(new ListViewItem(new[] { "Tổng doanh thu", "", (tongLaiVayVon - tongLaiTietKiem).ToString("N0") }));
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BaoCaoDoanhThuForm_Load(object sender, EventArgs e)
        {
        }

        private void BaoCaoDoanhThuForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}