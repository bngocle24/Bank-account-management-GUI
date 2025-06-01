using System;
using System.Windows.Forms;

namespace guibankapp
{
    public partial class TaiKhoanThanhToanForm : Form
    {
        public double SoDu { get; private set; }

        public TaiKhoanThanhToanForm()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtSoDu.Text, out double soDu) || soDu < 0)
            {
                MessageBox.Show("Số dư không hợp lệ");
                return;
            }

            SoDu = soDu;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TaiKhoanThanhToanForm_Load(object sender, EventArgs e)
        {

        }
    }
}