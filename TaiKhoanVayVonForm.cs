using System;
using System.Windows.Forms;

namespace guibankapp
{
    public partial class TaiKhoanVayVonForm : Form
    {
        public double SoTienVay { get; private set; }
        public int KyHan { get; private set; }
        public double LaiSuat { get; private set; }

        public TaiKhoanVayVonForm()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtSoTienVay.Text, out double soTienVay) || soTienVay <= 0)
            {
                MessageBox.Show("Số tiền vay không hợp lệ");
                return;
            }

            if (!int.TryParse(txtKyHan.Text, out int kyHan) || kyHan <= 0)
            {
                MessageBox.Show("Kỳ hạn không hợp lệ");
                return;
            }

            SoTienVay = soTienVay;
            KyHan = kyHan;
            LaiSuat = (kyHan <= 12) ? 4.8 : 5.5;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TaiKhoanVayVonForm_Load(object sender, EventArgs e)
        {
        }
    }
}