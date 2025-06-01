using System;
using System.Windows.Forms;
using System.Collections.Generic;
using static guibankapp.Menu;

namespace guibankapp
{
    public partial class XemThongTinTaiKhoan : Form
    {
        private List<TaiKhoan> danhSachTaiKhoan;

        public XemThongTinTaiKhoan(List<TaiKhoan> danhSach)
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.danhSachTaiKhoan = danhSach;
            HienThiDanhSachTaiKhoan();
        }

        private void HienThiDanhSachTaiKhoan()
        {
            listViewTaiKhoan.Items.Clear();

            foreach (var tk in danhSachTaiKhoan)
            {
                var item = new ListViewItem(tk.SoTaiKhoan);
                item.SubItems.Add(tk.LoaiTaiKhoan);
                item.SubItems.Add(tk.SoDu.ToString("N0"));

                if (tk is TaiKhoanTietKiem tktk)
                {
                    item.SubItems.Add(tktk.LaiSuat.ToString("0.00") + "%");
                    item.SubItems.Add(tktk.KyHan + " tháng");
                    item.SubItems.Add("");
                }
                else if (tk is TaiKhoanVayVon tkvv)
                {
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                    item.SubItems.Add(tkvv.LaiSuatVay.ToString("0.00") + "%");
                }
                else
                {
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                    item.SubItems.Add("");
                }

                listViewTaiKhoan.Items.Add(item);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XemThongTinTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}