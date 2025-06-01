using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace guibankapp
{
    public partial class TaiKhoanTietKiemForm : Form
    {
        public double SoDu { get; private set; }
        public int KyHan { get; private set; }
        public double LaiSuat { get; private set; }
        public double TinhLai()
        {
            // Tính lãi đơn: Lãi = Số dư * Lãi suất * (Kỳ hạn / 12)
            return SoDu * (LaiSuat / 100) * (KyHan / 12.0);
        }
        private Dictionary<int, double> bangLaiSuat = new Dictionary<int, double>
        {
            {0, 0.20}, {1, 2.10}, {2, 2.10}, {3, 2.40}, {4, 2.40}, {5, 2.40},
            {6, 3.50}, {7, 3.50}, {8, 3.50}, {9, 3.50}, {10, 3.50}, {11, 3.50},
            {12, 4.70}, {13, 4.70}, {15, 4.70}, {18, 4.70}, {24, 4.80}
        };

        public TaiKhoanTietKiemForm()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            // Thêm các kỳ hạn vào combobox
            foreach (var kyHan in bangLaiSuat.Keys)
            {
                if (kyHan != 0) // Bỏ qua kỳ hạn 0 (không kỳ hạn)
                    cboKyHan.Items.Add(kyHan);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtSoDu.Text, out double soDu) || soDu < 0)
            {
                MessageBox.Show("Số dư không hợp lệ");
                return;
            }

            if (cboKyHan.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn kỳ hạn");
                return;
            }

            SoDu = soDu;
            KyHan = (int)cboKyHan.SelectedItem;
            LaiSuat = bangLaiSuat[KyHan];

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TaiKhoanTietKiemForm_Load(object sender, EventArgs e)
        {

        }
    }
}