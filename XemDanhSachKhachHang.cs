using System;
using System.Windows.Forms;

namespace guibankapp
{
    public partial class XemDanhSachKhachHang : Form
    {
        public XemDanhSachKhachHang()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            InitializeListView();
            LoadDanhSachKhachHang();
        }

        private void InitializeListView()
        {
            listViewKhachHang.View = View.Details;
            listViewKhachHang.FullRowSelect = true;
            listViewKhachHang.Columns.Add("Mã KH", 100);
            listViewKhachHang.Columns.Add("Họ tên", 150);
            listViewKhachHang.Columns.Add("CMND", 120);
            listViewKhachHang.Columns.Add("Số điện thoại", 120);
            listViewKhachHang.Columns.Add("Địa chỉ", 200);
            listViewKhachHang.Columns.Add("Email", 150);
        }

        private void LoadDanhSachKhachHang()
        {
            listViewKhachHang.Items.Clear();

            // Truy cập danh sách từ Menu
            foreach (var kh in guibankapp.Menu.danhSachKhachHang)
            {
                var item = new ListViewItem(kh.MaKhachHang);
                item.SubItems.Add(kh.HoTen);
                item.SubItems.Add(kh.CMND);
                item.SubItems.Add(kh.SoDienThoai);
                item.SubItems.Add(kh.DiaChi);
                item.SubItems.Add(kh.Email);

                listViewKhachHang.Items.Add(item);
            }
        }

        // Thêm phương thức xử lý sự kiện Load
        private void XemDanhSachKhachHang_Load(object sender, EventArgs e)
        {
            // Có thể để trống hoặc thêm code khởi tạo nếu cần
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XemDanhSachKhachHang_Load_1(object sender, EventArgs e)
        {

        }

        private void listViewKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}