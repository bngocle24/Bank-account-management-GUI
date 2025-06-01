using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static guibankapp.Menu;

namespace guibankapp
{
    public partial class Menu : Form
    {
        
        
        public static List<KhachHang> danhSachKhachHang = new List<KhachHang>();
        public static List<GiaoDich> danhSachGiaoDich = new List<GiaoDich>();
        public Menu()
        {
            InitializeComponent();
            // Thêm code thay đổi hình nền ở đây
            this.BackgroundImage = Properties.Resources.Screenshot;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.FormClosing += Menu_FormClosing; // Đăng ký sự kiện FormClosing
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Không cần hỏi lưu dữ liệu ở đây nữa
        }
        public class GiaoDich
        {
            public string MaGiaoDich { get; set; }
            public string SoTaiKhoan { get; set; }
            public string SoTaiKhoanDich { get; set; } // Dành cho chuyển khoản
            public string LoaiGiaoDich { get; set; } // Nạp, Rút, Chuyển khoản
            public double SoTien { get; set; }
            public DateTime ThoiGian { get; set; }

            public GiaoDich(string soTaiKhoan, string soTaiKhoanDich, string loaiGiaoDich, double soTien)
            {
                MaGiaoDich = "GD" + DateTime.Now.ToString("yyyyMMddHHmmss");
                SoTaiKhoan = soTaiKhoan;
                SoTaiKhoanDich = soTaiKhoanDich;
                LoaiGiaoDich = loaiGiaoDich;
                SoTien = soTien;
                ThoiGian = DateTime.Now;
            }
        }
        

        
       
        private void button1_Click(object sender, EventArgs e)
        {
            // Hiển thị ContextMenuStrip khi nhấn nút Run
            contextMenuStrip1.Show(button1, new Point(-190, 50));
        }

        private void taoHoSoChoKhachHangMoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Taohosochokhachhangmoi formTaoHoSo = new Taohosochokhachhangmoi())
            {
                // Hiển thị form dưới dạng dialog
                var result = formTaoHoSo.ShowDialog(this); // Truyền form cha là Menu

                if (result == DialogResult.OK)
                {
                    // Thêm khách hàng mới vào danh sách
                    KhachHang khachMoi = new KhachHang(
                        formTaoHoSo.HoTen,
                        formTaoHoSo.CMND,
                        formTaoHoSo.DiaChi,
                        formTaoHoSo.SoDienThoai,
                        formTaoHoSo.Email
                    );

                    danhSachKhachHang.Add(khachMoi);

                    MessageBox.Show($"Đã thêm khách hàng mới: {khachMoi.HoTen}\nMã KH: {khachMoi.MaKhachHang}",
                                  "Thành công",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Information);
                }
            }
        }
        private void xemDanhSachKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (danhSachKhachHang.Count == 0)
            {
                MessageBox.Show("Danh sách khách hàng trống!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            XemDanhSachKhachHang formDSKH = new XemDanhSachKhachHang();
            formDSKH.ShowDialog(); // Sử dụng ShowDialog để không mất dữ liệu
        }
        public class KhachHang
        {
            public string MaKhachHang { get; }
            public string HoTen { get; set; }
            public string CMND { get; set; }
            public string DiaChi { get; set; }
            public string SoDienThoai { get; set; }
            public string Email { get; set; }
            public List<TaiKhoan> DanhSachTaiKhoan { get; } = new List<TaiKhoan>();

            public KhachHang(string hoTen, string cmnd, string diaChi, string soDienThoai, string email)
            {
                HoTen = hoTen;
                CMND = cmnd;
                DiaChi = diaChi;
                SoDienThoai = soDienThoai;
                Email = email;
                MaKhachHang = "KH" + DateTime.Now.ToString("yyyyMMddHHmmss"); // Tạo mã KH ngẫu nhiên

            }
            public KhachHang(string hoTen, string cmnd, string diaChi, string soDienThoai, string email, string maKhachHang) : this(hoTen, cmnd, diaChi, soDienThoai, email)
            {
                MaKhachHang = maKhachHang;
            }
        }

        // Các phương thức khác giữ nguyên
        public abstract class TaiKhoan
        {
            public string SoTaiKhoan { get; protected set; }
            public double SoDu { get; set; } // Cho phép set công khai
            public DateTime NgayTao { get; set; } // Cho phép set công khai
            public string LoaiTaiKhoan { get; protected set; }

            public TaiKhoan(double soDu)
            {
                SoDu = soDu;
                NgayTao = DateTime.Now;
                SoTaiKhoan = "TK" + DateTime.Now.ToString("yyyyMMddHHmmss");
            }
            public virtual string GetAccountInfo()
            {
                return $"Số TK: {SoTaiKhoan}, Loại: {LoaiTaiKhoan}, Số dư: {SoDu:N0} VND, Ngày tạo: {NgayTao:yyyy-MM-dd}";
            }
        }

        public class TaiKhoanThanhToan : TaiKhoan
        {
            public TaiKhoanThanhToan(double soDu) : base(soDu)
            {
                LoaiTaiKhoan = "Thanh toán";
            }
            public TaiKhoanThanhToan(double soDu, string soTaiKhoan) : base(soDu)
            {
                SoTaiKhoan = soTaiKhoan;
                LoaiTaiKhoan = "Thanh toán";
            }
            public override string GetAccountInfo()
            {
                return base.GetAccountInfo() + ", Tài khoản thanh toán";
            }
            public bool NapTien(double soTien)
            {
                if (soTien <= 0)
                {
                    MessageBox.Show("Số tiền nạp phải lớn hơn 0", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                this.SoDu += soTien;
                return true;
            }
            public bool RutTien(double soTien)
            {
                if (soTien <= 0)
                {
                    MessageBox.Show("Số tiền rút phải lớn hơn 0", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                if (soTien > this.SoDu)
                {
                    MessageBox.Show("Số dư không đủ để rút", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                this.SoDu -= soTien;
                return true;
            }
            public bool ChuyenKhoan(TaiKhoan taiKhoanDich, double soTien)
            {
                if (soTien <= 0)
                {
                    MessageBox.Show("Số tiền chuyển phải lớn hơn 0", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (soTien > this.SoDu)
                {
                    MessageBox.Show("Số dư không đủ để chuyển khoản", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if (!(taiKhoanDich is TaiKhoanThanhToan))
                {
                    MessageBox.Show("Tài khoản đích không phải tài khoản thanh toán", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                this.SoDu -= soTien;
                taiKhoanDich.SoDu += soTien;
                return true;
            }
        }

        public class TaiKhoanTietKiem : TaiKhoan
        {
            public int KyHan { get; private set; }
            public double LaiSuat { get; private set; }
            public List<(DateTime ThoiGian, double Phi)> LichSuPhiRutTruocHan { get; } = new List<(DateTime, double)>();

            public TaiKhoanTietKiem(double soDu, int kyHan, double laiSuat) : base(soDu)
            {
                KyHan = kyHan;
                LaiSuat = laiSuat;
                LoaiTaiKhoan = "Tiết kiệm";
            }
            public TaiKhoanTietKiem(double soDu, int kyHan, double laiSuat, string soTaiKhoan) : base(soDu)
            {
                KyHan = kyHan;
                LaiSuat = laiSuat;
                SoTaiKhoan = soTaiKhoan;
                LoaiTaiKhoan = "Tiết kiệm";
            }
            public override string GetAccountInfo()
            {
                return base.GetAccountInfo() + $", Kỳ hạn: {KyHan} tháng, Lãi suất: {LaiSuat}%";
            }
            public double TinhLai()
            {
                return SoDu * (LaiSuat / 100) * (KyHan / 12.0);
            }

            public bool RutTienTruocHan(double soTien, double phiRutTruocHan = 0.5)
            {
                if (soTien <= 0)
                {
                    MessageBox.Show("Số tiền rút phải lớn hơn 0!", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                double phi = soTien * (phiRutTruocHan / 100);
                double tongTien = soTien + phi;

                if (tongTien <= SoDu)
                {
                    SoDu -= tongTien;

                    // Ghi nhận phí vào LichSuPhiRutTruocHan
                    LichSuPhiRutTruocHan.Add((DateTime.Now, phi));

                    // Ghi nhận giao dịch rút tiền
                    var giaoDichRut = new GiaoDich(SoTaiKhoan, null, "Rút trước hạn", soTien);
                    danhSachGiaoDich.Add(giaoDichRut);

                    // Ghi nhận giao dịch phí
                    var giaoDichPhi = new GiaoDich(SoTaiKhoan, null, "Phí rút trước hạn", phi);
                    danhSachGiaoDich.Add(giaoDichPhi);

                    return true;
                }

                MessageBox.Show("Số dư không đủ để rút (tính cả phí rút trước hạn)!", "Lỗi",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            public double TinhTongPhiRutTruocHan()
            {
                return LichSuPhiRutTruocHan.Sum(phi => phi.Phi);
            }

            public List<(DateTime ThoiGian, double Phi)> GetLichSuPhiRutTruocHan()
            {
                return LichSuPhiRutTruocHan;
            }
        }

        public class TaiKhoanVayVon : TaiKhoan
        {
            public int KyHanVay { get; private set; }
            public double LaiSuatVay { get; private set; }
            public double SoTienVay { get; private set; }
            public double NoConLai { get; private set; }
            public double LaiPhaiTra { get; private set; }
            public List<(DateTime ThoiGian, double SoTien)> LichSuTraNo { get; } = new List<(DateTime, double)>();

            public TaiKhoanVayVon(double soTienVay, int kyHanVay, double laiSuatVay) : base(-soTienVay)
            {
                SoTienVay = soTienVay;
                KyHanVay = kyHanVay;
                LaiSuatVay = laiSuatVay;
                NoConLai = soTienVay;
                LaiPhaiTra = TinhLaiPhaiTra();
                LoaiTaiKhoan = "Vay vốn";
            }
            public TaiKhoanVayVon(double soTienVay, int kyHanVay, double laiSuatVay, string soTaiKhoan) : base(-soTienVay)
            {
                SoTienVay = soTienVay;
                KyHanVay = kyHanVay;
                LaiSuatVay = laiSuatVay;
                NoConLai = soTienVay;
                LaiPhaiTra = TinhLaiPhaiTra();
                SoTaiKhoan = soTaiKhoan;
                LoaiTaiKhoan = "Vay vốn";
            }
            public override string GetAccountInfo()
            {
                return base.GetAccountInfo() + $", Số tiền vay: {SoTienVay:N0} VND, Nợ còn lại: {NoConLai:N0} VND";
            }
            public double TinhLai()
            {
                return SoTienVay * (LaiSuatVay / 100) * (KyHanVay / 12.0);
            }

            public (double GocHangThang, double LaiHangThang, double TongThanhToan) TinhToanThanhToanHangThang()
            {
                double laiHangThang = NoConLai * (LaiSuatVay / 100) / 12;
                double gocHangThang = SoTienVay / KyHanVay;
                double tongThanhToan = laiHangThang + gocHangThang;
                return (gocHangThang, laiHangThang, tongThanhToan);
            }

            public bool ThanhToanHangThang(double soTien)
            {
                if (soTien <= 0)
                {
                    MessageBox.Show("Số tiền thanh toán phải lớn hơn 0!", "Lỗi",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                LichSuTraNo.Add((DateTime.Now, soTien));
                NoConLai = SoTienVay;
                foreach (var payment in LichSuTraNo)
                {
                    double lai = NoConLai * (LaiSuatVay / 100) / 12;
                    double goc = payment.SoTien - lai;
                    if (goc > 0)
                    {
                        NoConLai -= goc;
                    }
                }

                SoDu = -NoConLai;
                LaiPhaiTra = TinhLaiPhaiTra();

                var giaoDich = new GiaoDich(SoTaiKhoan, null, "Trả nợ vay", soTien);
                danhSachGiaoDich.Add(giaoDich);
                return true;
            }

            private double TinhLaiPhaiTra()
            {
                return NoConLai * (LaiSuatVay / 100) / 12;
            }
        }
        private void capNhatThongTinKhachHangToolStripMenuItem_Click(object sender, EventArgs e) {
            if (danhSachKhachHang.Count == 0)
            {
                MessageBox.Show("Danh sách khách hàng trống!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Sử dụng form TraCuuKhachHangTheoMa đã có
            using (var formTraCuu = new TraCuuKhachHangTheoMa())
            {
                if (formTraCuu.ShowDialog() == DialogResult.OK && formTraCuu.KhachHangDuocChon != null)
                {
                    // Mở form cập nhật thông tin
                    using (var formCapNhat = new CapNhatThongTinKhachHang(formTraCuu.KhachHangDuocChon))
                    {
                        formCapNhat.ShowDialog();
                    }
                }
            }
        }
        private void toolStripMenuItem3_Click(object sender, EventArgs e) { }
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (danhSachKhachHang.Count == 0)
            {
                MessageBox.Show("Danh sách khách hàng trống!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var form = new TinhLaiDuKienForm();
            form.ShowDialog();
        }
        //private void xemDanhSachKhachHangToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void timKiemKhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (danhSachKhachHang.Count == 0)
            {
                MessageBox.Show("Danh sách khách hàng trống!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hiển thị form chọn phương thức tìm kiếm
            using (var formChonTimKiem = new FormChonTimKiem())
            {
                if (formChonTimKiem.ShowDialog() == DialogResult.OK)
                {
                    KhachHang khachHang = null;

                    if (formChonTimKiem.LuaChon == 1) // Tìm theo mã KH
                    {
                        using (var form = new TraCuuKhachHangTheoMa())
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                khachHang = form.KhachHangDuocChon;
                            }
                        }
                    }
                    else // Tìm theo CCCD và họ tên
                    {
                        using (var form = new TraCuuKhachHangTheoCCCDHoTen())
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                khachHang = form.KhachHangDuocChon;
                            }
                        }
                    }

                    if (khachHang != null)
                    {
                        // Hiển thị form chi tiết khách hàng
                        using (var formChiTiet = new ChiTietKhachHang(khachHang))
                        {
                            formChiTiet.ShowDialog();
                        }
                    }
                }
            }
        }
        private void moTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (danhSachKhachHang.Count == 0)
            {
                MessageBox.Show("Chưa có khách hàng nào. Vui lòng tạo hồ sơ khách hàng trước.");
                return;
            }

            // Hiển thị form chọn phương thức tìm kiếm
            using (var formChonTimKiem = new FormChonTimKiem())
            {
                if (formChonTimKiem.ShowDialog() == DialogResult.OK)
                {
                    Menu.KhachHang khachHang = null;

                    if (formChonTimKiem.LuaChon == 1) // Tìm theo mã KH
                    {
                        using (var form = new TraCuuKhachHangTheoMa())
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                khachHang = form.KhachHangDuocChon;
                            }
                        }
                    }
                    else // Tìm theo CCCD và họ tên
                    {
                        using (var form = new TraCuuKhachHangTheoCCCDHoTen())
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                khachHang = form.KhachHangDuocChon;
                            }
                        }
                    }

                    if (khachHang != null)
                    {
                        // Mở form chọn loại tài khoản
                        using (var formChonTK = new ChonLoaiTaiKhoan(khachHang))
                        {
                            if (formChonTK.ShowDialog() == DialogResult.OK && formChonTK.TaiKhoanDuocTao != null)
                            {
                                // Thêm tài khoản vào danh sách của khách hàng
                                khachHang.DanhSachTaiKhoan.Add(formChonTK.TaiKhoanDuocTao);

                                MessageBox.Show($"Đã mở tài khoản {formChonTK.TaiKhoanDuocTao.LoaiTaiKhoan} thành công!\n" +
                                              $"Số tài khoản: {formChonTK.TaiKhoanDuocTao.SoTaiKhoan}");
                            }
                        }
                    }
                }
            }
        }
        private void xemthongtintaikhoan_Click(object sender, EventArgs e)
        {
            if (danhSachKhachHang.Count == 0)
            {
                MessageBox.Show("Danh sách khách hàng trống!");
                return;
            }

            // Hiển thị form chọn phương thức tìm kiếm
            using (var formChonTimKiem = new FormChonTimKiem())
            {
                if (formChonTimKiem.ShowDialog() == DialogResult.OK)
                {
                    KhachHang khachHang = null;

                    if (formChonTimKiem.LuaChon == 1) // Tìm theo mã KH
                    {
                        using (var form = new TraCuuKhachHangTheoMa())
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                khachHang = form.KhachHangDuocChon;
                            }
                        }
                    }
                    else // Tìm theo CCCD và họ tên
                    {
                        using (var form = new TraCuuKhachHangTheoCCCDHoTen())
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                khachHang = form.KhachHangDuocChon;
                            }
                        }
                    }

                    if (khachHang != null && khachHang.DanhSachTaiKhoan.Count > 0)
                    {
                        // Thêm đoạn mã hiển thị MessageBox
                        StringBuilder accountInfo = new StringBuilder();
                        accountInfo.AppendLine($"Thông tin tài khoản của khách hàng {khachHang.HoTen}:");
                        foreach (TaiKhoan tk in khachHang.DanhSachTaiKhoan)
                        {
                            accountInfo.AppendLine(tk.GetAccountInfo()); // Gọi phương thức ảo
                        }
                        MessageBox.Show(accountInfo.ToString(), "Thông tin tài khoản",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Giữ nguyên form hiển thị nếu cần
                        using (var formXemTK = new XemThongTinTaiKhoan(khachHang.DanhSachTaiKhoan))
                        {
                            formXemTK.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Khách hàng không có tài khoản nào!");
                    }
                }
            }
        }
        private void xoataikhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (danhSachKhachHang.Count == 0)
            {
                MessageBox.Show("Danh sách khách hàng trống!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Hiển thị form chọn phương thức tìm kiếm khách hàng
            using (var formChonTimKiem = new FormChonTimKiem())
            {
                if (formChonTimKiem.ShowDialog() == DialogResult.OK)
                {
                    KhachHang khachHang = null;

                    if (formChonTimKiem.LuaChon == 1) // Tìm theo mã KH
                    {
                        using (var form = new TraCuuKhachHangTheoMa())
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                khachHang = form.KhachHangDuocChon;
                            }
                        }
                    }
                    else // Tìm theo CCCD và họ tên
                    {
                        using (var form = new TraCuuKhachHangTheoCCCDHoTen())
                        {
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                khachHang = form.KhachHangDuocChon;
                            }
                        }
                    }

                    if (khachHang != null && khachHang.DanhSachTaiKhoan.Count > 0)
                    {
                        // Hiển thị form nhập số tài khoản cần xóa
                        using (var formTraCuuTK = new TraCuuTheoSoTaiKhoan(khachHang))
                        {
                            if (formTraCuuTK.ShowDialog() == DialogResult.OK && formTraCuuTK.TaiKhoanDuocChon != null)
                            {
                                // Xác nhận xóa
                                DialogResult confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa tài khoản {formTraCuuTK.TaiKhoanDuocChon.SoTaiKhoan}?",
                                                                   "Xác nhận xóa",
                                                                   MessageBoxButtons.YesNo,
                                                                   MessageBoxIcon.Warning);

                                if (confirm == DialogResult.Yes)
                                {
                                    // Thực hiện xóa
                                    khachHang.DanhSachTaiKhoan.Remove(formTraCuuTK.TaiKhoanDuocChon);
                                    MessageBox.Show("Đã xóa tài khoản thành công!", "Thành công",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Khách hàng không có tài khoản nào!", "Thông báo",
                                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void timKiemKhachHangBangCCCDVaHoTenToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void naptienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new NapTienForm();
            form.ShowDialog();
        }
        private void ruttienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new RutTienForm();
            form.ShowDialog();
        }
        private void chuyenKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (danhSachKhachHang.Count == 0)
            {
                MessageBox.Show("Danh sách khách hàng trống!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var form = new ChuyenKhoanForm();
            form.ShowDialog();
        }

        private void xemLichSuGiaoDichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (danhSachGiaoDich.Count == 0)
            {
                MessageBox.Show("Chưa có giao dịch nào!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var form = new XemLichSuGiaoDichForm();
            form.ShowDialog();
        }
        private void baoCaoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (danhSachKhachHang.Count == 0)
            {
                MessageBox.Show("Danh sách khách hàng trống!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var form = new BaoCaoDoanhThuForm();
            form.ShowDialog();
        }
        private void thongKeTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (danhSachKhachHang.Count == 0)
            {
                MessageBox.Show("Danh sách khách hàng trống!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var form = new ThongKeTaiKhoanForm();
            form.ShowDialog();
        }
        private void daohan_Click(object sender, EventArgs e)
        {
            if (danhSachKhachHang.Count == 0)
            {
                MessageBox.Show("Danh sách khách hàng trống!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var form = new DaoHanTaiKhoanForm();
            form.ShowDialog();
        }
        private void xemthongtintaikhoan1_Click(object sender, EventArgs e)
        {
            if (danhSachKhachHang.Count == 0)
            {
                MessageBox.Show("Danh sách khách hàng trống!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var form = new XemThongTinTaiKhoanForm();
            form.ShowDialog();
        }
        private void rutTienTruocHan_Click(object sender, EventArgs e)
        {
            if (danhSachKhachHang.Count == 0)
            {
                MessageBox.Show("Danh sách khách hàng trống!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var form = new RutTienTruocHanForm();
            form.ShowDialog();
        }
        private void xemKeHoachThanhToan_Click(object sender, EventArgs e)
        {
            if (danhSachKhachHang.Count == 0)
            {
                MessageBox.Show("Danh sách khách hàng trống!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var form = new XemKeHoachThanhToanForm();
            form.ShowDialog();
        }
        private void thanhToanHangThang_Click(object sender, EventArgs e)
        {
            if (danhSachKhachHang.Count == 0)
            {
                MessageBox.Show("Danh sách khách hàng trống!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var form = new ThanhToanHangThangForm();
            form.ShowDialog();
        }
        private void xemLichSuTraNo_Click(object sender, EventArgs e)
        {
            if (danhSachKhachHang.Count == 0)
            {
                MessageBox.Show("Danh sách khách hàng trống!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var form = new XemLichSuTraNoForm();
            form.ShowDialog();
        }
        private void xemThongTinTaiKhoanVayVon_Click(object sender, EventArgs e)
        {
            if (danhSachKhachHang.Count == 0)
            {
                MessageBox.Show("Danh sách khách hàng trống!", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var form = new XemThongTinTaiKhoanVayVonForm();
            form.ShowDialog();
        }
        

        

        // Phương thức hỗ trợ tìm tài khoản
        private TaiKhoan TimTaiKhoan(string soTK)
        {
            foreach (var kh in danhSachKhachHang)
            {
                var tk = kh.DanhSachTaiKhoan.FirstOrDefault(t => t.SoTaiKhoan == soTK);
                if (tk != null) return tk;
            }
            return null;
        }

        
        private void LuuDuLieu()
        {
            try
            {
                // Đường dẫn tới thư mục Data
                string dataDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
                if (!Directory.Exists(dataDir))
                    Directory.CreateDirectory(dataDir);

                // Lưu thông tin khách hàng và tài khoản
                LuuKhachHangVaTaiKhoan(Path.Combine(dataDir, "khachhang_data.csv"));

                // Lưu giao dịch
                LuuGiaoDich(Path.Combine(dataDir, "giaodich_data.csv"));

                // Lưu phí rút trước hạn
                LuuPhiRutTruocHan(Path.Combine(dataDir, "phiruttruoc_data.csv"));

                MessageBox.Show("Đã lưu dữ liệu thành công!", "Thông báo",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu dữ liệu: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LuuKhachHangVaTaiKhoan(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                // Viết tiêu đề
                writer.WriteLine("MaKhachHang,HoTen,CMND,DiaChi,SoDienThoai,Email,SoTaiKhoan,LoaiTaiKhoan,SoDu,NgayTao,KyHan,LaiSuat,SoTienVay");

                foreach (var kh in danhSachKhachHang)
                {
                    foreach (var tk in kh.DanhSachTaiKhoan)
                    {
                        string line = $"{kh.MaKhachHang},{EscapeCsv(kh.HoTen)},{kh.CMND},{EscapeCsv(kh.DiaChi)},{kh.SoDienThoai},{kh.Email}," +
                                      $"{tk.SoTaiKhoan},{tk.LoaiTaiKhoan},{tk.SoDu},{tk.NgayTao:yyyy-MM-dd HH:mm:ss}";
                        if (tk is TaiKhoanTietKiem tkTietKiem)
                        {
                            line += $",{tkTietKiem.KyHan},{tkTietKiem.LaiSuat},";
                        }
                        else if (tk is TaiKhoanVayVon tkVayVon)
                        {
                            line += $",{tkVayVon.KyHanVay},{tkVayVon.LaiSuatVay},{tkVayVon.SoTienVay}";
                        }
                        else
                        {
                            line += ",,,";
                        }
                        writer.WriteLine(line);
                    }

                    // Nếu khách hàng không có tài khoản, vẫn lưu thông tin khách hàng
                    if (kh.DanhSachTaiKhoan.Count == 0)
                    {
                        string line = $"{kh.MaKhachHang},{EscapeCsv(kh.HoTen)},{kh.CMND},{EscapeCsv(kh.DiaChi)},{kh.SoDienThoai},{kh.Email},,,,,,";
                        writer.WriteLine(line);
                    }
                }
            }
        }

        private void LuuGiaoDich(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true, Encoding.UTF8))
            {
                // Nếu file mới, viết tiêu đề
                if (new FileInfo(filePath).Length == 0)
                {
                    writer.WriteLine("MaGiaoDich,SoTaiKhoan,SoTaiKhoanDich,LoaiGiaoDich,SoTien,ThoiGian");
                }

                foreach (var gd in danhSachGiaoDich)
                {
                    string line = $"{gd.MaGiaoDich},{gd.SoTaiKhoan},{gd.SoTaiKhoanDich ?? ""},{EscapeCsv(gd.LoaiGiaoDich)},{gd.SoTien},{gd.ThoiGian:yyyy-MM-dd HH:mm:ss}";
                    writer.WriteLine(line);
                }
            }
        }

        private void LuuPhiRutTruocHan(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                writer.WriteLine("SoTaiKhoan,ThoiGian,Phi");

                foreach (var kh in danhSachKhachHang)
                {
                    foreach (var tk in kh.DanhSachTaiKhoan.OfType<TaiKhoanTietKiem>())
                    {
                        foreach (var phi in tk.LichSuPhiRutTruocHan)
                        {
                            string line = $"{tk.SoTaiKhoan},{phi.ThoiGian:yyyy-MM-dd HH:mm:ss},{phi.Phi}";
                            writer.WriteLine(line);
                        }
                    }
                }
            }
        }
        private void DocDuLieu()
        {
            try
            {
                string dataDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

                // Đọc khách hàng và tài khoản
                DocKhachHangVaTaiKhoan(Path.Combine(dataDir, "khachhang_data.csv"));

                // Đọc giao dịch
                DocGiaoDich(Path.Combine(dataDir, "giaodich_data.csv"));

                // Đọc phí rút trước hạn
                DocPhiRutTruocHan(Path.Combine(dataDir, "phiruttruoc_data.csv"));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc dữ liệu: {ex.Message}", "Lỗi",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DocKhachHangVaTaiKhoan(string filePath)
        {
            if (!File.Exists(filePath)) return;

            danhSachKhachHang.Clear();
            var khachHangDict = new Dictionary<string, KhachHang>();

            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                reader.ReadLine(); // Bỏ qua tiêu đề
                while (!reader.EndOfStream)
                {
                    string[] fields = ParseCsvLine(reader.ReadLine());
                    if (fields.Length < 6) continue;

                    string maKhachHang = fields[0];
                    string hoTen = fields[1];
                    string cmnd = fields[2];
                    string diaChi = fields[3];
                    string soDienThoai = fields[4];
                    string email = fields[5];

                    if (!khachHangDict.ContainsKey(maKhachHang))
                    {
                        var khachHang = new KhachHang(hoTen, cmnd, diaChi, soDienThoai, email, maKhachHang);
                        khachHangDict[maKhachHang] = khachHang;
                        danhSachKhachHang.Add(khachHang);
                    }

                    if (fields.Length >= 7 && !string.IsNullOrEmpty(fields[6]))
                    {
                        string soTaiKhoan = fields[6];
                        string loaiTaiKhoan = fields[7];
                        double soDu = double.Parse(fields[8]);
                        DateTime ngayTao = DateTime.ParseExact(fields[9], "yyyy-MM-dd HH:mm:ss", null);

                        TaiKhoan taiKhoan = null;
                        if (loaiTaiKhoan == "Tiết kiệm" && fields.Length >= 11)
                        {
                            int kyHan = int.Parse(fields[10]);
                            double laiSuat = double.Parse(fields[11]);
                            taiKhoan = new TaiKhoanTietKiem(soDu, kyHan, laiSuat, soTaiKhoan);
                        }
                        else if (loaiTaiKhoan == "Vay vốn" && fields.Length >= 13)
                        {
                            int kyHan = int.Parse(fields[10]);
                            double laiSuat = double.Parse(fields[11]);
                            double soTienVay = double.Parse(fields[12]);
                            taiKhoan = new TaiKhoanVayVon(soTienVay, kyHan, laiSuat, soTaiKhoan);
                        }
                        else if (loaiTaiKhoan == "Thanh toán")
                        {
                            taiKhoan = new TaiKhoanThanhToan(soDu, soTaiKhoan);
                        }

                        if (taiKhoan != null)
                        {
                            taiKhoan.NgayTao = ngayTao;
                            khachHangDict[maKhachHang].DanhSachTaiKhoan.Add(taiKhoan);
                        }
                    }
                }
            }
        }

        private void DocGiaoDich(string filePath)
        {
            if (!File.Exists(filePath)) return;

            danhSachGiaoDich.Clear();
            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                reader.ReadLine(); // Bỏ qua tiêu đề
                while (!reader.EndOfStream)
                {
                    string[] fields = ParseCsvLine(reader.ReadLine());
                    if (fields.Length < 6) continue;

                    string maGiaoDich = fields[0];
                    string soTaiKhoan = fields[1];
                    string soTaiKhoanDich = string.IsNullOrEmpty(fields[2]) ? null : fields[2];
                    string loaiGiaoDich = fields[3];
                    double soTien = double.Parse(fields[4]);
                    DateTime thoiGian = DateTime.ParseExact(fields[5], "yyyy-MM-dd HH:mm:ss", null);

                    var giaoDich = new GiaoDich(soTaiKhoan, soTaiKhoanDich, loaiGiaoDich, soTien)
                    {
                        MaGiaoDich = maGiaoDich,
                        ThoiGian = thoiGian
                    };
                    danhSachGiaoDich.Add(giaoDich);
                }
            }
        }

        private void DocPhiRutTruocHan(string filePath)
        {
            if (!File.Exists(filePath)) return;

            using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
            {
                reader.ReadLine(); // Bỏ qua tiêu đề
                while (!reader.EndOfStream)
                {
                    string[] fields = ParseCsvLine(reader.ReadLine());
                    if (fields.Length < 3) continue;

                    string soTaiKhoan = fields[0];
                    DateTime thoiGian = DateTime.ParseExact(fields[1], "yyyy-MM-dd HH:mm:ss", null);
                    double phi = double.Parse(fields[2]);

                    foreach (var kh in danhSachKhachHang)
                    {
                        var taiKhoan = kh.DanhSachTaiKhoan.OfType<TaiKhoanTietKiem>()
                                        .FirstOrDefault(tk => tk.SoTaiKhoan == soTaiKhoan);
                        if (taiKhoan != null)
                        {
                            taiKhoan.LichSuPhiRutTruocHan.Add((thoiGian, phi));
                        }
                    }
                }
            }
        }

        private string[] ParseCsvLine(string line)
        {
            List<string> fields = new List<string>();
            bool inQuotes = false;
            string field = "";

            for (int i = 0; i < line.Length; i++)
            {
                char c = line[i];

                if (c == '"')
                {
                    inQuotes = !inQuotes;
                }
                else if (c == ',' && !inQuotes)
                {
                    fields.Add(field);
                    field = "";
                }
                else
                {
                    field += c;
                }
            }
            fields.Add(field);

            return fields.ToArray();
        }

        private string EscapeCsv(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";
            if (input.Contains(",") || input.Contains("\"") || input.Contains("\n"))
            {
                return $"\"{input.Replace("\"", "\"\"")}\"";
            }
            return input;
        }
        private void Menu_Load_1(object sender, EventArgs e)
        {
            DocDuLieu();
        }
        private void thoatluudulieu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu dữ liệu trước khi thoát?", "Xác nhận",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LuuDuLieu();
            }
            Application.Exit(); // Thoát chương trình
        }

        private void quanlytaikhoantietkiem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
