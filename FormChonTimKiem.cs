using System;
using System.Windows.Forms;

namespace guibankapp
{
    public partial class FormChonTimKiem : Form
    {
        public int LuaChon { get; private set; } = 0;

        public FormChonTimKiem()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot1;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void btnTheoMaKH_Click(object sender, EventArgs e)
        {
            LuaChon = 1;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnTheoCCCDHoTen_Click(object sender, EventArgs e)
        {
            LuaChon = 2;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormChonTimKiem_Load(object sender, EventArgs e)
        {

        }
    }
}