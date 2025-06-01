using System;
using System.Windows.Forms;
using static guibankapp.Menu;

namespace guibankapp
{
    public partial class XemLichSuGiaoDichForm : Form
    {
        public XemLichSuGiaoDichForm()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            HienThiLichSuGiaoDich();
        }

        private void HienThiLichSuGiaoDich()
        {
            listViewGiaoDich.View = View.Details;
            listViewGiaoDich.FullRowSelect = true;
            listViewGiaoDich.Columns.Add("Mã GD", 100);
            listViewGiaoDich.Columns.Add("Loại GD", 100);
            listViewGiaoDich.Columns.Add("TK Nguồn", 120);
            listViewGiaoDich.Columns.Add("TK Đích", 120);
            listViewGiaoDich.Columns.Add("Số tiền", 100);
            listViewGiaoDich.Columns.Add("Thời gian", 120);

            foreach (var gd in danhSachGiaoDich)
            {
                var item = new ListViewItem(gd.MaGiaoDich);
                item.SubItems.Add(gd.LoaiGiaoDich);
                item.SubItems.Add(gd.SoTaiKhoan);
                item.SubItems.Add(gd.SoTaiKhoanDich ?? "N/A");
                item.SubItems.Add(gd.SoTien.ToString("N0"));
                item.SubItems.Add(gd.ThoiGian.ToString("dd/MM/yyyy HH:mm:ss"));
                listViewGiaoDich.Items.Add(item);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XemLichSuGiaoDichForm_Load(object sender, EventArgs e)
        {
        }
    }
}