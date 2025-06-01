#include <iostream>
#include <iomanip>
#include <vector>
#include <string>
#include <algorithm>
#include <ctime>
#include <cstdlib>
#include <limits>
#include <map>
#include <fstream>
#include <sstream>

using namespace std;

// Hằng số
const int COLUMN_WIDTH = 30;

// Lớp giao dịch
class GiaoDich {
private:
    string maGiaoDich;
    string soTaiKhoan;
    string thoiGian;
    string loaiGiaoDich; // "Nap tien", "Rut tien", "Chuyen khoan"
    double soTien;
    string taiKhoanLienQuan; // Số tài khoản đích (nếu là chuyển khoản)
public:
    GiaoDich(string soTaiKhoan, string loai, double soTien, string tkLienQuan = "")
        : soTaiKhoan(soTaiKhoan), loaiGiaoDich(loai), soTien(soTien), taiKhoanLienQuan(tkLienQuan) {
        time_t now = time(0);
        thoiGian = ctime(&now);
        maGiaoDich = "GD" + to_string(rand() % 9000 + 1000);
    }

    void hienThi() const {
        cout << setw(COLUMN_WIDTH) << left << "Ma GD: " << maGiaoDich << endl;
        cout << setw(COLUMN_WIDTH) << left << "Thoi gian: " << thoiGian;
        cout << setw(COLUMN_WIDTH) << left << "Loai GD: " << loaiGiaoDich << endl;
        cout << setw(COLUMN_WIDTH) << left << "So tai khoan: " << soTaiKhoan << endl;
        if (!taiKhoanLienQuan.empty()) {
            cout << setw(COLUMN_WIDTH) << left << "Tai khoan dich: " << taiKhoanLienQuan << endl;
        }
        cout << setw(COLUMN_WIDTH) << left << "So tien: " << fixed << setprecision(2) << soTien << " VND" << endl;
    }

    string getThoiGian() const { return thoiGian; }
    string getSoTaiKhoan() const { return soTaiKhoan; }
    string getLoaiGiaoDich() const { return loaiGiaoDich; }
    double getSoTien() const { return soTien; }
    string getTaiKhoanLienQuan() const { return taiKhoanLienQuan; }
    string getMaGiaoDich() const { return maGiaoDich; }
    void setThoiGian(const string& tg) { thoiGian = tg; }
    void setMaGiaoDich(const string& ma) { maGiaoDich = ma; }
};

// Lớp cơ sở cho tài khoản ngân hàng
class TaiKhoan {
protected:
    string soTaiKhoan;
    double soDu;
    string ngayTao;
    vector<GiaoDich> lichSuGiaoDich;
public:
    TaiKhoan(double soDu) : soDu(soDu) {
        time_t now = time(0);
        ngayTao = ctime(&now);
        soTaiKhoan = "TK" + to_string(rand() % 900000 + 100000);
    }
    virtual ~TaiKhoan() {}
    virtual void hienThiThongTin() const = 0;
    virtual string getLoaiTaiKhoan() const = 0;
    string getSoTaiKhoan() const { return soTaiKhoan; }
    void setSoTaiKhoan(const string& soTK) { soTaiKhoan = soTK; }
    double getSoDu() const { return soDu; }
    virtual void napTien(double soTien) { soDu += soTien; }
    virtual bool rutTien(double soTien) {
        if (soTien <= soDu) {
            soDu -= soTien;
            return true;
        }
        return false;
    }

    void themGiaoDich(const GiaoDich& gd) {
        lichSuGiaoDich.push_back(gd);
    }

    void hienThiLichSuGiaoDich(bool theoNgay = false, string ngay = "") const {
        if (lichSuGiaoDich.empty()) {
            cout << "Khong co giao dich nao" << endl;
            return;
        }

        cout << "\nLICH SU GIAO DICH (" << soTaiKhoan << "):\n";
        cout << string(80, '-') << endl;

        for (const auto& gd : lichSuGiaoDich) {
            if (!theoNgay || (theoNgay && gd.getThoiGian().find(ngay) != string::npos)) {
                gd.hienThi();
                cout << string(80, '-') << endl;
            }
        }
    }
    const vector<GiaoDich>& getLichSuGiaoDich() const { return lichSuGiaoDich; }
};

// Lớp tài khoản tiết kiệm
class TaiKhoanTietKiem : public TaiKhoan {
private:
    int kyHan; // Số tháng
    double laiSuat;
    vector<pair<string, double>> lichSuPhiRutTruocHan; // Lưu phí rút trước hạn
public:
    TaiKhoanTietKiem(double soDu, int kyHan, double laiSuat)
        : TaiKhoan(soDu), kyHan(kyHan), laiSuat(laiSuat) {}

    void hienThiThongTin() const override {
        cout << setw(COLUMN_WIDTH) << left << "So tai khoan: " << soTaiKhoan << endl;
        cout << setw(COLUMN_WIDTH) << left << "Loai tai khoan: " << "Tiet kiem" << endl;
        cout << setw(COLUMN_WIDTH) << left << "Ky han: " << kyHan << " thang" << endl;
        cout << setw(COLUMN_WIDTH) << left << "Lai suat: " << fixed << setprecision(2) << laiSuat << "%" << endl;
        cout << setw(COLUMN_WIDTH) << left << "So du: " << fixed << setprecision(2) << soDu << " VND" << endl;
        cout << setw(COLUMN_WIDTH) << left << "Ngay tao: " << ngayTao;
    }

    double tinhLaiDuKien() const {
        return soDu * (laiSuat / 100) * (kyHan / 12.0);
    }

    void daoHan() {
        double lai = tinhLaiDuKien();
        soDu += lai;
        cout << "Dao han thanh cong! So du moi: " << fixed << setprecision(2) << soDu << " VND\n";
        cout << "Lai du kien ky han moi: " << tinhLaiDuKien() << " VND\n";
    }

    bool rutTienTruocHan(double soTien, double phiRutTruocHan = 0.5) {
        double phi = soTien * (phiRutTruocHan / 100);
        double tongTien = soTien + phi;

        if (tongTien <= soDu) {
            soDu -= tongTien;
            ghiNhanPhiRutTruocHan(phi); // Ghi nhận phí
            cout << "Rut tien truoc han thanh cong! Phi rut truoc han: " << phi << " VND\n";
            return true;
        }
        cout << "So du khong du de rut (tinh ca phi rut truoc han)\n";
        return false;
    }

    void ghiNhanPhiRutTruocHan(double phi) {
        time_t now = time(0);
        string thoiGian = ctime(&now);
        lichSuPhiRutTruocHan.emplace_back(thoiGian, phi);
    }

    double tinhTongPhiRutTruocHan() const {
        double tongPhi = 0;
        for (const auto& phi : lichSuPhiRutTruocHan) {
            tongPhi += phi.second;
        }
        return tongPhi;
    }
    void themPhiRutTruocHan(const string& thoiGian, double phi) {
        lichSuPhiRutTruocHan.emplace_back(thoiGian, phi);
    }
    const vector<pair<string, double>>& getLichSuPhiRutTruocHan() const {
        return lichSuPhiRutTruocHan;
    }

    string getLoaiTaiKhoan() const override { return "Tiet kiem"; }
    int getKyHan() const { return kyHan; }
    double getLaiSuat() const { return laiSuat; }
};

// Lớp tài khoản thanh toán
class TaiKhoanThanhToan : public TaiKhoan {
private:
    double phiDichVu;
    vector<pair<string, double>> lichSuPhiDichVu; // Lưu phí dịch vụ
public:
    TaiKhoanThanhToan(double soDu, double phiDichVu = 0)
        : TaiKhoan(soDu), phiDichVu(phiDichVu) {}

    double tinhLaiDuKien1Nam() const {
        return soDu * (0.2 / 100);
    }

    void hienThiThongTin() const override {
        cout << setw(COLUMN_WIDTH) << left << "So tai khoan: " << soTaiKhoan << endl;
        cout << setw(COLUMN_WIDTH) << left << "Loai tai khoan: " << "Thanh toan" << endl;
        cout << setw(COLUMN_WIDTH) << left << "Phi dich vu: " << fixed << setprecision(2) << phiDichVu << " VND/thang" << endl;
        cout << setw(COLUMN_WIDTH) << left << "So du: " << fixed << setprecision(2) << soDu << " VND" << endl;
        cout << setw(COLUMN_WIDTH) << left << "Lai suat (%/nam):" << fixed << setprecision(2) << "0.2%" << endl;
        cout << setw(COLUMN_WIDTH) << left << "Lai du kien (1 nam): " << fixed << setprecision(2) << tinhLaiDuKien1Nam() << " VND" << endl;
        cout << setw(COLUMN_WIDTH) << left << "Ngay tao: " << ngayTao;
    }

    void ghiNhanPhiDichVu() {
        time_t now = time(0);
        string thoiGian = ctime(&now);
        lichSuPhiDichVu.emplace_back(thoiGian, phiDichVu);
    }

    double tinhTongPhiDichVu() const {
        double tongPhi = 0;
        for (const auto& phi : lichSuPhiDichVu) {
            tongPhi += phi.second;
        }
        return tongPhi;
    }
    void themPhiDichVu(const string& thoiGian, double phi) {
        lichSuPhiDichVu.emplace_back(thoiGian, phi);
    }
    const vector<pair<string, double>>& getLichSuPhiDichVu() const {
        return lichSuPhiDichVu;
    }

    string getLoaiTaiKhoan() const override { return "Thanh toan"; }
};

// Lớp tài khoản vay vốn
class TaiKhoanVayVon : public TaiKhoan {
private:
    int kyHan;
    double laiSuat;
    vector<pair<string, double>> lichSuTraNo;
    double tongNoGoc;
    double noConLai;
    double laiPhaiTra;
public:
    TaiKhoanVayVon(double soTienVay, int kyHan, double laiSuat)
        : TaiKhoan(-soTienVay), kyHan(kyHan), laiSuat(laiSuat),
        tongNoGoc(soTienVay), noConLai(soTienVay), laiPhaiTra(0) {
        tinhLaiPhaiTra();
    }

    void hienThiThongTin() const override {
        cout << setw(COLUMN_WIDTH) << left << "So tai khoan: " << soTaiKhoan << endl;
        cout << setw(COLUMN_WIDTH) << left << "Loai tai khoan: " << "Vay von" << endl;
        cout << setw(COLUMN_WIDTH) << left << "Ky han: " << kyHan << " thang" << endl;
        cout << setw(COLUMN_WIDTH) << left << "Lai suat: " << fixed << setprecision(2) << laiSuat << "%/nam" << endl;
        cout << setw(COLUMN_WIDTH) << left << "So tien vay: " << fixed << setprecision(2) << tongNoGoc << " VND" << endl;
        cout << setw(COLUMN_WIDTH) << left << "No con lai: " << fixed << setprecision(2) << noConLai << " VND" << endl;
        cout << setw(COLUMN_WIDTH) << left << "Lai phai tra: " << fixed << setprecision(2) << laiPhaiTra << " VND" << endl;
        cout << setw(COLUMN_WIDTH) << left << "Ngay tao: " << ngayTao;
    }

    void tinhLaiPhaiTra() {
        laiPhaiTra = noConLai * (laiSuat / 100) / 12;
    }

    void tinhToanThanhToanHangThang() {
        double laiHangThang = noConLai * (laiSuat / 100) / 12;
        double gocHangThang = tongNoGoc / kyHan;
        double tongThanhToan = laiHangThang + gocHangThang;

        cout << "\nKE HOACH THANH TOAN:\n";
        cout << "----------------------------------------\n";
        cout << "Tong no goc: " << fixed << setprecision(2) << tongNoGoc << " VND\n";
        cout << "Ky han: " << kyHan << " thang\n";
        cout << "Lai suat: " << laiSuat << "%/nam\n";
        cout << "----------------------------------------\n";
        cout << "Thanh toan hang thang:\n";
        cout << "- Goc: " << gocHangThang << " VND\n";
        cout << "- Lai: ~" << laiHangThang << " VND (giam dan)\n";
        cout << "----------------------------------------\n";
        cout << "Tong thanh toan hang thang: ~" << tongThanhToan << " VND\n";
        cout << "----------------------------------------\n";
    }

    void thanhToanHangThang(double soTien) {
        double laiHangThang = noConLai * (laiSuat / 100) / 12;
        double gocDuocGiam = soTien - laiHangThang;

        if (gocDuocGiam > 0) {
            noConLai -= gocDuocGiam;
        }

        time_t now = time(0);
        string ngayThanhToan = ctime(&now);
        ngayThanhToan.pop_back();
        lichSuTraNo.emplace_back(ngayThanhToan, soTien);

        themGiaoDich(GiaoDich(soTaiKhoan, "Tra no vay", soTien));

        cout << "Thanh toan thanh cong!\n";
        cout << "No con lai: " << noConLai << " VND\n";

        tinhLaiPhaiTra();
    }

    void xemLichSuTraNo() const {
        if (lichSuTraNo.empty()) {
            cout << "Chua co lich su thanh toan\n";
            return;
        }

        cout << "\nLICH SU THANH TOAN:\n";
        cout << "----------------------------------------\n";
        cout << setw(25) << left << "Ngay" << setw(15) << right << "So tien" << endl;
        cout << "----------------------------------------\n";

        for (const auto& payment : lichSuTraNo) {
            cout << setw(25) << left << payment.first
                << setw(15) << right << fixed << setprecision(2) << payment.second << " VND\n";
        }

        cout << "----------------------------------------\n";
        cout << "No con lai: " << noConLai << " VND\n";
        cout << "Lai phai tra thang nay: " << laiPhaiTra << " VND\n";
        cout << "----------------------------------------\n";
    }

    void themThanhToanVaoLichSu(const string& ngay, double soTien) {
        string ngayDaXuLy = ngay;
        if (ngayDaXuLy.back() == '\n') {
            ngayDaXuLy.pop_back();
        }

        lichSuTraNo.emplace_back(ngayDaXuLy, soTien);

        noConLai = tongNoGoc;
        for (const auto& payment : lichSuTraNo) {
            double lai = noConLai * (laiSuat / 100) / 12;
            double goc = payment.second - lai;
            noConLai -= goc;
        }
    }

    bool rutTien(double soTien) override {
        cout << "Khong the rut tien tu tai khoan vay von!" << endl;
        return false;
    }

    void napTien(double soTien) override {
        soDu += soTien;
    }

    string getLoaiTaiKhoan() const override { return "Vay von"; }
    int getKyHan() const { return kyHan; }
    double getLaiSuat() const { return laiSuat; }
    const vector<pair<string, double>>& getLichSuTraNo() const {
        return lichSuTraNo;
    }
};

// Lớp khách hàng
class KhachHang {
private:
    string maKhachHang;
    string hoTen;
    string cmnd;
    string diaChi;
    string soDienThoai;
    string email;
    vector<TaiKhoan*> danhSachTaiKhoan;
public:
    KhachHang(string hoTen, string cmnd, string diaChi, string soDienThoai, string email)
        : hoTen(hoTen), cmnd(cmnd), diaChi(diaChi), soDienThoai(soDienThoai), email(email) {
        maKhachHang = "KH" + to_string(rand() % 9000 + 1000);
    }

    ~KhachHang() {
        for (auto tk : danhSachTaiKhoan) {
            delete tk;
        }
    }

    void themTaiKhoan(TaiKhoan* taiKhoan) {
        danhSachTaiKhoan.push_back(taiKhoan);
    }

    void xoaTaiKhoan(string soTaiKhoan) {
        auto it = find_if(danhSachTaiKhoan.begin(), danhSachTaiKhoan.end(),
            [soTaiKhoan](TaiKhoan* tk) { return tk->getSoTaiKhoan() == soTaiKhoan; });

        if (it != danhSachTaiKhoan.end()) {
            delete* it;
            danhSachTaiKhoan.erase(it);
            cout << "Da xoa tai khoan " << soTaiKhoan << endl;
        }
        else {
            cout << "Khong tim thay tai khoan" << endl;
        }
    }

    void hienThiThongTin() const {
        cout << string(60, '-') << endl;
        cout << setw(COLUMN_WIDTH) << left << "Ma khach hang: " << maKhachHang << endl;
        cout << setw(COLUMN_WIDTH) << left << "Ho ten: " << hoTen << endl;
        cout << setw(COLUMN_WIDTH) << left << "CMND: " << cmnd << endl;
        cout << setw(COLUMN_WIDTH) << left << "Dia chi: " << diaChi << endl;
        cout << setw(COLUMN_WIDTH) << left << "So dien thoai: " << soDienThoai << endl;
        cout << setw(COLUMN_WIDTH) << left << "Email: " << email << endl;
        cout << string(60, '-') << endl;

        if (danhSachTaiKhoan.empty()) {
            cout << "Khach hang chua co tai khoan nao" << endl;
        }
        else {
            cout << "Danh sach tai khoan:" << endl;
            for (const auto& tk : danhSachTaiKhoan) {
                tk->hienThiThongTin();
                cout << string(60, '-') << endl;
            }
        }
    }

    void capNhatThongTin() {
        cout << "Cap nhat thong tin khach hang " << hoTen << ":" << endl;
        cout << "Dia chi moi (" << diaChi << "): ";
        getline(cin >> ws, diaChi);
        cout << "So dien thoai moi (" << soDienThoai << "): ";
        getline(cin >> ws, soDienThoai);
        cout << "Email moi (" << email << "): ";
        getline(cin >> ws, email);
        cout << "Cap nhat thanh cong!" << endl;
    }

    void setMaKhachHang(const string& maKH) { maKhachHang = maKH; }
    string getMaKhachHang() const { return maKhachHang; }
    string getHoTen() const { return hoTen; }
    string getCMND() const { return cmnd; }
    string getSoDienThoai() const { return soDienThoai; }
    string getDiaChi() const { return diaChi; }
    string getEmail() const { return email; }
    vector<TaiKhoan*> getDanhSachTaiKhoan() const { return danhSachTaiKhoan; }
};

// Lớp quản lý ngân hàng
class QuanLyNganHang {
private:
    vector<KhachHang*> danhSachKhachHang;
    map<int, double> bangLaiSuat;

    void khoiTaoBangLaiSuat() {
        bangLaiSuat = {
            {0,  0.20},   // Khong ky han
            {1,  2.10},
            {2,  2.10},
            {3,  2.40},
            {4,  2.40},
            {5,  2.40},
            {6,  3.50},
            {7,  3.50},
            {8,  3.50},
            {9,  3.50},
            {10, 3.50},
            {11, 3.50},
            {12, 4.70},
            {13, 4.70},
            {15, 4.70},
            {18, 4.70},
            {24, 4.80},
            {-1, 0.20}    // Tiền gửi thanh toán
        };
    }

    TaiKhoan* timTaiKhoan(const string& soTK) {
        for (auto kh : danhSachKhachHang) {
            for (auto tk : kh->getDanhSachTaiKhoan()) {
                if (tk->getSoTaiKhoan() == soTK) {
                    return tk;
                }
            }
        }
        return nullptr;
    }

    KhachHang* timKhachHang(const string& maKH) {
        for (auto kh : danhSachKhachHang) {
            if (kh->getMaKhachHang() == maKH) {
                return kh;
            }
        }
        return nullptr;
    }

    KhachHang* timKhachHangBangCCCD(string cmnd, string hoTen = "") {
        for (auto kh : danhSachKhachHang) {
            if (kh->getCMND() == cmnd && (hoTen.empty() || kh->getHoTen() == hoTen)) {
                return kh;
            }
        }
        return nullptr;
    }

    void luuKhachHangVaTaiKhoan(ofstream& file) {
        for (const auto& kh : danhSachKhachHang) {
            file << kh->getMaKhachHang() << ","
                << kh->getHoTen() << ","
                << kh->getCMND() << ","
                << kh->getDiaChi() << ","
                << kh->getSoDienThoai() << ","
                << kh->getEmail() << "\n";

            for (const auto& tk : kh->getDanhSachTaiKhoan()) {
                file << tk->getSoTaiKhoan() << ","
                    << tk->getLoaiTaiKhoan() << ","
                    << tk->getSoDu();

                if (auto tietKiem = dynamic_cast<TaiKhoanTietKiem*>(tk)) {
                    file << "," << tietKiem->getKyHan() << "," << tietKiem->getLaiSuat();
                }
                else if (auto vayVon = dynamic_cast<TaiKhoanVayVon*>(tk)) {
                    file << "," << vayVon->getKyHan() << "," << vayVon->getLaiSuat();
                }
                file << "\n";
            }
            file << "---\n";
        }
    }

    void luuGiaoDich(ofstream& transFile) {
        bool coGiaoDich = false;
    
        // Kiểm tra xem có giao dịch nào để lưu không
        for (const auto& kh : danhSachKhachHang) {
            for (const auto& tk : kh->getDanhSachTaiKhoan()) {
                if (!tk->getLichSuGiaoDich().empty()) {
                    coGiaoDich = true;
                    break;
                }
                // Kiểm tra lịch sử phí rút trước hạn (tài khoản tiết kiệm)
                if (auto tkTietKiem = dynamic_cast<TaiKhoanTietKiem*>(tk)) {
                    if (!tkTietKiem->getLichSuPhiRutTruocHan().empty()) {
                        coGiaoDich = true;
                        break;
                    }
                }
                // Kiểm tra lịch sử thanh toán (tài khoản vay)
                if (auto tkVay = dynamic_cast<TaiKhoanVayVon*>(tk)) {
                    const auto& lichSuTraNo = tkVay->getLichSuTraNo();
                    if (!lichSuTraNo.empty()) {
                        coGiaoDich = true;
                        break;
                    }
                }
            }
            if (coGiaoDich) break;
        }
    
        if (!coGiaoDich) {
            cout << "Khong co giao dich nao de luu\n";
            return;
        }
    
        // Lưu các giao dịch thông thường
        for (const auto& kh : danhSachKhachHang) {
            for (const auto& tk : kh->getDanhSachTaiKhoan()) {
                for (const auto& gd : tk->getLichSuGiaoDich()) {
                    string thoiGian = gd.getThoiGian();
                    replace(thoiGian.begin(), thoiGian.end(), '\n', ' ');
                    thoiGian.erase(remove(thoiGian.begin(), thoiGian.end(), '\r'), thoiGian.end());
    
                    transFile << tk->getSoTaiKhoan() << ","
                        << gd.getMaGiaoDich() << ","
                        << thoiGian << ","
                        << gd.getLoaiGiaoDich() << ","
                        << gd.getSoTien() << ","
                        << gd.getTaiKhoanLienQuan() << "\n";
                }
    
                // Lưu lịch sử rút tiền trước hạn (tài khoản tiết kiệm)
                if (auto tkTietKiem = dynamic_cast<TaiKhoanTietKiem*>(tk)) {
                    for (const auto& phi : tkTietKiem->getLichSuPhiRutTruocHan()) {
                        string thoiGian = phi.first;
                        replace(thoiGian.begin(), thoiGian.end(), '\n', ' ');
                        thoiGian.erase(remove(thoiGian.begin(), thoiGian.end(), '\r'), thoiGian.end());
    
                        transFile << tk->getSoTaiKhoan() << ","
                            << "PHI" + to_string(rand() % 9000 + 1000) << ","
                            << thoiGian << ","
                            << "Phi rut truoc han" << ","
                            << phi.second << ","
                            << "" << "\n";
                    }
                }
    
                // Lưu lịch sử thanh toán (tài khoản vay)
                if (auto tkVay = dynamic_cast<TaiKhoanVayVon*>(tk)) {
                    const auto& lichSuTraNo = tkVay->getLichSuTraNo();
                    for (const auto& payment : lichSuTraNo) {
                        string thoiGian = payment.first;
                        replace(thoiGian.begin(), thoiGian.end(), '\n', ' ');
                        thoiGian.erase(remove(thoiGian.begin(), thoiGian.end(), '\r'), thoiGian.end());

                        transFile << tk->getSoTaiKhoan() << ","
                            << "TT" + to_string(rand() % 9000 + 1000) << ","
                            << thoiGian << ","
                            << "Tra no vay" << ","
                            << payment.second << ","
                            << "" << "\n";
                    }
                }
            }
        }
    }

    void luuPhiDichVu(ofstream& phiFile) {
        for (const auto& kh : danhSachKhachHang) {
            for (const auto& tk : kh->getDanhSachTaiKhoan()) {
                if (auto tkThanhToan = dynamic_cast<TaiKhoanThanhToan*>(tk)) {
                    for (const auto& phi : tkThanhToan->getLichSuPhiDichVu()) {
                        string thoiGian = phi.first;
                        replace(thoiGian.begin(), thoiGian.end(), '\n', ' ');
                        thoiGian.erase(remove(thoiGian.begin(), thoiGian.end(), '\r'), thoiGian.end());
                        phiFile << tk->getSoTaiKhoan() << "," << thoiGian << "," << phi.second << "\n";
                    }
                }
                else if (auto tkTietKiem = dynamic_cast<TaiKhoanTietKiem*>(tk)) {
                    for (const auto& phi : tkTietKiem->getLichSuPhiRutTruocHan()) {
                        string thoiGian = phi.first;
                        replace(thoiGian.begin(), thoiGian.end(), '\n', ' ');
                        thoiGian.erase(remove(thoiGian.begin(), thoiGian.end(), '\r'), thoiGian.end());
                        phiFile << tk->getSoTaiKhoan() << "," << thoiGian << "," << phi.second << "\n";
                    }
                }
            }
        }
    }

    const string DATA_FILE = "nganhang_data.csv";
    const string TRANSACTION_FILE = "giao_dich_data.csv";
    const string PHI_FILE = "phi_dich_vu_data.csv";

    void luuDuLieu() {
        try {
            ofstream file(DATA_FILE);
            if (!file) {
                cerr << "Loi: Khong the mo file " << DATA_FILE << " de ghi" << endl;
                return;
            }
            luuKhachHangVaTaiKhoan(file);
            file.close();

            ofstream transFile(TRANSACTION_FILE, ios::out | ios::app);  // Thay ios::trunc bằng ios::app
            if (!transFile) {
                cerr << "Loi: Khong the mo file " << TRANSACTION_FILE << " de ghi" << endl;
                return;
            }
            luuGiaoDich(transFile);
            transFile.close();

            ofstream phiFile(PHI_FILE, ios::out | ios::trunc);
            if (!phiFile) {
                cerr << "Loi: Khong the mo file " << PHI_FILE << " de ghi" << endl;
                return;
            }
            luuPhiDichVu(phiFile);
            phiFile.close();

            cout << "Da luu du lieu thanh cong!\n";
        }
        catch (const exception& e) {
            cerr << "Loi khi luu du lieu: " << e.what() << endl;
        }
    }

    void docDuLieu() {
        try {
            ifstream file(DATA_FILE);
            if (!file.is_open()) {
                cout << "Khong tim thay file du lieu. Tao du lieu moi.\n";
                return;
            }

            string line;
            KhachHang* currentKh = nullptr;

            while (getline(file, line)) {
                if (line.empty()) continue;

                if (line == "---") {
                    currentKh = nullptr;
                    continue;
                }

                if (!currentKh) {
                    vector<string> tokens;
                    string token;
                    stringstream ss(line);

                    while (getline(ss, token, ',')) {
                        tokens.push_back(token);
                    }

                    if (tokens.size() < 6) continue;

                    currentKh = new KhachHang(tokens[1], tokens[2], tokens[3], tokens[4], tokens[5]);
                    currentKh->setMaKhachHang(tokens[0]);
                    danhSachKhachHang.push_back(currentKh);
                }
                else {
                    vector<string> tokens;
                    string token;
                    stringstream ss(line);

                    while (getline(ss, token, ',')) {
                        tokens.push_back(token);
                    }

                    if (tokens.size() < 3) continue;

                    string soTK = tokens[0];
                    string loaiTK = tokens[1];
                    double soDu = stod(tokens[2]);

                    TaiKhoan* tk = nullptr;
                    if (loaiTK == "Tiet kiem" && tokens.size() >= 5) {
                        int kyHan = stoi(tokens[3]);
                        double laiSuat = stod(tokens[4]);
                        tk = new TaiKhoanTietKiem(soDu, kyHan, laiSuat);
                    }
                    else if (loaiTK == "Thanh toan") {
                        tk = new TaiKhoanThanhToan(soDu);
                    }
                    else if (loaiTK == "Vay von" && tokens.size() >= 5) {
                        int kyHan = stoi(tokens[3]);
                        double laiSuat = stod(tokens[4]);
                        tk = new TaiKhoanVayVon(-soDu, kyHan, laiSuat);
                    }

                    if (tk && currentKh) {
                        tk->setSoTaiKhoan(soTK);
                        currentKh->themTaiKhoan(tk);
                    }
                }
            }
            file.close();

            ifstream transFile(TRANSACTION_FILE);
            if (transFile.is_open()) {
                while (getline(transFile, line)) {
                    vector<string> tokens;
                    string token;
                    stringstream ss(line);

                    while (getline(ss, token, ',')) {
                        tokens.push_back(token);
                    }

                    if (tokens.size() < 6) continue;

                    string soTK = tokens[0];
                    double soTien = stod(tokens[4]);
                    string tkLienQuan = tokens[5];

                    TaiKhoan* tk = timTaiKhoan(soTK);
                    if (tk) {
                        string thoiGian = tokens[2];
                        if (thoiGian.back() == ',') {
                            thoiGian.pop_back();
                        }
                        thoiGian += "\n";
                        GiaoDich gd(soTK, tokens[3], soTien, tkLienQuan);
                        gd.setThoiGian(thoiGian);
                        gd.setMaGiaoDich(tokens[1]);
                        tk->themGiaoDich(gd);

                        if (tokens[3] == "Tra no vay" && tk->getLoaiTaiKhoan() == "Vay von") {
                            TaiKhoanVayVon* tkVay = dynamic_cast<TaiKhoanVayVon*>(tk);
                            tkVay->themThanhToanVaoLichSu(thoiGian, soTien);
                        }
                    }
                }
                transFile.close();
            }

            ifstream phiFile(PHI_FILE);
            if (phiFile.is_open()) {
                while (getline(phiFile, line)) {
                    vector<string> tokens;
                    string token;
                    stringstream ss(line);

                    while (getline(ss, token, ',')) {
                        tokens.push_back(token);
                    }

                    if (tokens.size() < 3) continue;

                    string soTK = tokens[0];
                    string thoiGian = tokens[1];
                    double phi = stod(tokens[2]);

                    TaiKhoan* tk = timTaiKhoan(soTK);
                    if (tk) {
                        thoiGian += "\n";
                        if (auto tkThanhToan = dynamic_cast<TaiKhoanThanhToan*>(tk)) {
                            tkThanhToan->themPhiDichVu(thoiGian, phi); // Sửa dòng 735
                        }
                        else if (auto tkTietKiem = dynamic_cast<TaiKhoanTietKiem*>(tk)) {
                            tkTietKiem->themPhiRutTruocHan(thoiGian, phi); // Sửa dòng 738
                        }
                    }
                }
                phiFile.close();
            }
        }
        catch (const exception& e) {
            cerr << "Loi khi doc du lieu: " << e.what() << endl;
        }
    }

    void quanLyTaiKhoanTietKiem() {
        while (true) {
            cout << "\nQUAN LY TAI KHOAN TIET KIEM:\n";
            cout << "1. Tinh lai suat du kien sau ky han\n";
            cout << "2. Dao han\n";
            cout << "3. Rut tien truoc han\n";
            cout << "4. Xem thong tin tai khoan\n";
            cout << "5. Quay lai\n";
            cout << "Lua chon: ";

            int luaChon;
            cin >> luaChon;

            string soTK;
            TaiKhoan* taiKhoan;

            switch (luaChon) {
            case 1:
            case 2:
            case 3:
            case 4: {
                cout << "Nhap so tai khoan tiet kiem: ";
                cin >> soTK;
                taiKhoan = timTaiKhoan(soTK);

                if (taiKhoan && taiKhoan->getLoaiTaiKhoan() == "Tiet kiem") {
                    TaiKhoanTietKiem* tkTietKiem = dynamic_cast<TaiKhoanTietKiem*>(taiKhoan);

                    switch (luaChon) {
                    case 1:
                        cout << "Lai suat du kien sau ky han: "
                            << tkTietKiem->tinhLaiDuKien() << " VND\n";
                        break;
                    case 2:
                        tkTietKiem->daoHan();
                        break;
                    case 3: {
                        double soTien;
                        cout << "Nhap so tien muon rut: ";
                        cin >> soTien;
                        tkTietKiem->rutTienTruocHan(soTien);
                        break;
                    }
                    case 4:
                        tkTietKiem->hienThiThongTin();
                        break;
                    }
                }
                else {
                    cout << "Khong phai tai khoan tiet kiem hoac khong ton tai\n";
                }
                break;
            }
            case 5:
                return;
            default:
                cout << "Lua chon khong hop le\n";
            }
        }
    }

    void quanLyTaiKhoanVay() {
        while (true) {
            cout << "\nQUAN LY TAI KHOAN VAY:\n";
            cout << "1. Xem ke hoach thanh toan\n";
            cout << "2. Thanh toan hang thang\n";
            cout << "3. Xem lich su tra no\n";
            cout << "4. Xem thong tin tai khoan\n";
            cout << "5. Quay lai\n";
            cout << "Lua chon: ";

            int luaChon;
            cin >> luaChon;

            string soTK;
            TaiKhoan* taiKhoan;

            switch (luaChon) {
            case 1:
            case 2:
            case 3:
            case 4: {
                cout << "Nhap so tai khoan vay: ";
                cin >> soTK;
                taiKhoan = timTaiKhoan(soTK);

                if (taiKhoan && taiKhoan->getLoaiTaiKhoan() == "Vay von") {
                    TaiKhoanVayVon* tkVay = dynamic_cast<TaiKhoanVayVon*>(taiKhoan);

                    switch (luaChon) {
                    case 1:
                        tkVay->tinhToanThanhToanHangThang();
                        break;
                    case 2: {
                        double soTien;
                        cout << "Nhap so tien thanh toan: ";
                        cin >> soTien;
                        tkVay->thanhToanHangThang(soTien);
                        break;
                    }
                    case 3:
                        tkVay->xemLichSuTraNo();
                        break;
                    case 4:
                        tkVay->hienThiThongTin();
                        break;
                    }
                }
                else {
                    cout << "Khong phai tai khoan vay hoac khong ton tai\n";
                }
                break;
            }
            case 5:
                return;
            default:
                cout << "Lua chon khong hop le\n";
            }
        }
    }

    void baoCaoDoanhThu() {
        double tongLai = 0, tongPhi = 0;
        cout << "\nBAO CAO DOANH THU:\n";
        cout << string(80, '-') << endl;

        for (const auto& kh : danhSachKhachHang) {
            cout << "Khach hang: " << kh->getHoTen() << " (" << kh->getMaKhachHang() << ")\n";
            double laiKH = 0, phiKH = 0;

            for (const auto& tk : kh->getDanhSachTaiKhoan()) {
                if (auto tkTietKiem = dynamic_cast<TaiKhoanTietKiem*>(tk)) {
                    double lai = tkTietKiem->tinhLaiDuKien();
                    laiKH += lai;
                    phiKH += tkTietKiem->tinhTongPhiRutTruocHan();
                    cout << "- Tai khoan tiet kiem (" << tk->getSoTaiKhoan() << "): Lai = " << lai << ", Phi = " << tkTietKiem->tinhTongPhiRutTruocHan() << " VND\n";
                }
                else if (auto tkThanhToan = dynamic_cast<TaiKhoanThanhToan*>(tk)) {
                    double lai = tkThanhToan->tinhLaiDuKien1Nam();
                    laiKH += lai;
                    phiKH += tkThanhToan->tinhTongPhiDichVu();
                    cout << "- Tai khoan thanh toan (" << tk->getSoTaiKhoan() << "): Lai = " << lai << ", Phi = " << tkThanhToan->tinhTongPhiDichVu() << " VND\n";
                }
            }

            tongLai += laiKH;
            tongPhi += phiKH;
            cout << "Tong (KH): Lai = " << laiKH << ", Phi = " << phiKH << " VND\n\n";
        }

        cout << string(80, '-') << endl;
        cout << "TONG DOANH THU:\n";
        cout << "- Lai tu tien gui: " << tongLai << " VND\n";
        cout << "- Phi giao dich/dich vu: " << tongPhi << " VND\n";
        cout << "- Tong cong: " << tongLai + tongPhi << " VND\n";
        cout << string(80, '-') << endl;
    }

    void thongKeKhachHang() {
        cout << "\nTHONG KE KHACH HANG:\n";
        cout << string(80, '-') << endl;
        cout << "Tong so khach hang: " << danhSachKhachHang.size() << endl;

        int tongTKThanhToan = 0, tongTKTietKiem = 0, tongTKVayVon = 0;
        for (const auto& kh : danhSachKhachHang) {
            int tkThanhToan = 0, tkTietKiem = 0, tkVayVon = 0;
            for (const auto& tk : kh->getDanhSachTaiKhoan()) {
                if (tk->getLoaiTaiKhoan() == "Thanh toan") tkThanhToan++;
                else if (tk->getLoaiTaiKhoan() == "Tiet kiem") tkTietKiem++;
                else if (tk->getLoaiTaiKhoan() == "Vay von") tkVayVon++;
            }
            tongTKThanhToan += tkThanhToan;
            tongTKTietKiem += tkTietKiem;
            tongTKVayVon += tkVayVon;

            cout << "\nKhach hang: " << kh->getHoTen() << " (" << kh->getMaKhachHang() << ")\n";
            cout << "- Tai khoan thanh toan: " << tkThanhToan << endl;
            cout << "- Tai khoan tiet kiem: " << tkTietKiem << endl;
            cout << "- Tai khoan vay von: " << tkVayVon << endl;
        }

        cout << string(80, '-') << endl;
        cout << "TONG SO TAI KHOAN:\n";
        cout << "- Thanh toan: " << tongTKThanhToan << endl;
        cout << "- Tiet kiem: " << tongTKTietKiem << endl;
        cout << "- Vay von: " << tongTKVayVon << endl;
        cout << "- Tong cong: " << (tongTKThanhToan + tongTKTietKiem + tongTKVayVon) << endl;
        cout << string(80, '-') << endl;
    }

public:
    QuanLyNganHang() {
        khoiTaoBangLaiSuat();
        srand(time(0));
        docDuLieu();
    }

    ~QuanLyNganHang() {
        for (auto kh : danhSachKhachHang) {
            delete kh;
        }
    }

    void themKhachHang() {
        string hoTen, cmnd, diaChi, soDienThoai, email;

        cout << "Nhap thong tin khach hang moi:" << endl;
        cout << "Ho ten: ";
        getline(cin >> ws, hoTen);
        cout << "CMND/CCCD: ";
        getline(cin >> ws, cmnd);
        cout << "Dia chi: ";
        getline(cin >> ws, diaChi);
        cout << "So dien thoai: ";
        getline(cin >> ws, soDienThoai);
        cout << "Email: ";
        getline(cin >> ws, email);

        danhSachKhachHang.push_back(new KhachHang(hoTen, cmnd, diaChi, soDienThoai, email));
        cout << "Tao khach hang thanh cong! Ma khach hang: "
            << danhSachKhachHang.back()->getMaKhachHang() << endl;
    }

    void moTaiKhoan() {
        if (danhSachKhachHang.empty()) {
            cout << "Chua co khach hang nao. Vui long tao khach hang truoc." << endl;
            return;
        }

        int luaChonTim;
        cout << "Tim kiem khach hang bang:\n";
        cout << "1. Ma khach hang\n";
        cout << "2. CCCD va ho ten\n";
        cout << "Lua chon: ";
        cin >> luaChonTim;

        KhachHang* kh = nullptr;

        if (luaChonTim == 1) {
            string maKH;
            cout << "Nhap ma khach hang: ";
            cin >> maKH;
            kh = timKhachHang(maKH);
        }
        else if (luaChonTim == 2) {
            string cmnd, hoTen;
            cout << "Nhap so CCCD: ";
            cin >> cmnd;
            cout << "Nhap ho ten: ";
            cin.ignore();
            getline(cin, hoTen);
            kh = timKhachHangBangCCCD(cmnd, hoTen);
        }
        else {
            cout << "Lua chon khong hop le!" << endl;
            return;
        }

        if (kh) {
            cout << "Tim thay khach hang. Ma KH: " << kh->getMaKhachHang() << endl;
            cout << "Ho ten: " << kh->getHoTen() << endl;
        }
        else {
            cout << "Khong tim thay khach hang" << endl;
            return;
        }

        int loaiTK;
        cout << "Chon loai tai khoan:" << endl;
        cout << "1. Tai khoan thanh toan" << endl;
        cout << "2. Tai khoan tiet kiem" << endl;
        cout << "3. Tai khoan vay von" << endl;
        cout << "Lua chon: ";
        cin >> loaiTK;

        double soDu;
        cout << "Nhap so du ban dau: ";
        cin >> soDu;

        TaiKhoan* taiKhoan = nullptr;
        if (loaiTK == 1) {
            taiKhoan = new TaiKhoanThanhToan(soDu);
        }
        else if (loaiTK == 2) {
            int kyHan;
            cout << "Nhap ky han (thang): ";
            cin >> kyHan;

            double laiSuat = 0;
            if (bangLaiSuat.find(kyHan) != bangLaiSuat.end()) {
                laiSuat = bangLaiSuat[kyHan];
            }
            else {
                cout << "Khong co ky han nay, mac dinh lai suat 0.5%" << endl;
                laiSuat = 0.5;
            }

            taiKhoan = new TaiKhoanTietKiem(soDu, kyHan, laiSuat);
        }
        else if (loaiTK == 3) {
            double soTienVay;
            cout << "Nhap so tien vay: ";
            cin >> soTienVay;

            int kyHan;
            cout << "Nhap ky han vay (thang): ";
            cin >> kyHan;

            double laiSuat = (kyHan <= 12) ? 4.8 : 5.5;
            taiKhoan = new TaiKhoanVayVon(soTienVay, kyHan, laiSuat);
        }
        else {
            cout << "Lua chon khong hop le" << endl;
            return;
        }

        kh->themTaiKhoan(taiKhoan);
        cout << "Mo tai khoan thanh cong! So tai khoan: " << taiKhoan->getSoTaiKhoan() << endl;
    }

    void hienThiBangLaiSuat() const {
        vector<pair<string, double>> cot1 = {
            {"Khong ky han", bangLaiSuat.at(0)},
            {"1 thang",      bangLaiSuat.at(1)},
            {"2 thang",      bangLaiSuat.at(2)},
            {"3 thang",      bangLaiSuat.at(3)},
            {"4 thang",      bangLaiSuat.at(4)},
            {"5 thang",      bangLaiSuat.at(5)},
            {"6 thang",      bangLaiSuat.at(6)},
            {"7 thang",      bangLaiSuat.at(7)},
            {"8 thang",      bangLaiSuat.at(8)}
        };

        vector<pair<string, double>> cot2 = {
            {"9 thang",              bangLaiSuat.at(9)},
            {"10 thang",             bangLaiSuat.at(10)},
            {"11 thang",             bangLaiSuat.at(11)},
            {"12 thang",             bangLaiSuat.at(12)},
            {"13 thang",             bangLaiSuat.at(13)},
            {"15 thang",             bangLaiSuat.at(15)},
            {"18 thang",             bangLaiSuat.at(18)},
            {"24 thang",             bangLaiSuat.at(24)},
            {"Tien gui thanh toan",  bangLaiSuat.at(-1)}
        };

        cout << "\n\n";
        cout << "+-------------------------------+------------------------+-------------------------------+------------------------+\n";
        cout << "| Ky han tien gui/tiet kiem     | Muc lai suat (VND)     | Ky han tien gui/tiet kiem     | Muc lai suat (VND)     |\n";
        cout << "+-------------------------------+------------------------+-------------------------------+------------------------+\n";

        for (int i = 0; i < 9; ++i) {
            cout << "| " << setw(30) << left << cot1[i].first
                << "| " << setw(22) << left << fixed << setprecision(2) << cot1[i].second << "%"
                << "| " << setw(30) << left << cot2[i].first
                << "| " << setw(22) << left << fixed << setprecision(2) << cot2[i].second << "%"
                << "|\n";
        }

        cout << "+-------------------------------+------------------------+-------------------------------+------------------------+\n\n";
        cout << "\n\n";
        cout << "+---------------------------------------------+\n";
        cout << "| LAI SUAT CHO VAY THONG THUONG               |\n";
        cout << "+---------------------------------------------+\n";
        cout << "| Cho vay ngan han (<=12 thang) |  4.8%/nam   |\n";
        cout << "| Cho vay trung/dai han         |  5.5%/nam   |\n";
        cout << "+---------------------------------------------+\n";
    }

    void xemDanhSachKhachHang() const {
        if (danhSachKhachHang.empty()) {
            cout << "Danh sach khach hang trong" << endl;
            return;
        }

        cout << "\nDANH SACH KHACH HANG:\n";
        cout << string(80, '-') << endl;
        cout << setw(15) << left << "Ma KH"
            << setw(25) << "Ho ten"
            << setw(20) << "CMND"
            << setw(20) << "So DT" << endl;
        cout << string(80, '-') << endl;

        for (const auto& kh : danhSachKhachHang) {
            cout << setw(15) << left << kh->getMaKhachHang()
                << setw(25) << kh->getHoTen()
                << setw(20) << kh->getCMND()
                << setw(20) << kh->getSoDienThoai() << endl;
        }
        cout << string(80, '-') << endl;
    }

    void timKiemKhachHang() {
        int luaChon;
        cout << "Tim kiem theo:" << endl;
        cout << "1. Ma khach hang" << endl;
        cout << "2. Ho ten" << endl;
        cout << "3. CMND" << endl;
        cout << "Lua chon: ";
        cin >> luaChon;

        string tuKhoa;
        cout << "Nhap tu khoa tim kiem: ";
        cin >> ws;
        getline(cin, tuKhoa);

        bool found = false;
        for (const auto& kh : danhSachKhachHang) {
            bool match = false;
            switch (luaChon) {
            case 1: match = kh->getMaKhachHang() == tuKhoa; break;
            case 2: match = kh->getHoTen().find(tuKhoa) != string::npos; break;
            case 3: match = kh->getCMND() == tuKhoa; break;
            default: cout << "Lua chon khong hop le" << endl; return;
            }

            if (match) {
                kh->hienThiThongTin();
                found = true;
            }
        }

        if (!found) {
            cout << "Khong tim thay khach hang phu hop" << endl;
        }
    }

    void quanLyKhachHang() {
        while (true) {
            cout << "\nQUAN LY KHACH HANG:\n";
            cout << "1. Tao ho so cho khach hang moi\n";
            cout << "2. Xem danh sach khach hang\n";
            cout << "3. Tim kiem khach hang\n";
            cout << "4. Cap nhat thong tin khach hang\n";
            cout << "5. Mo tai khoan\n";
            cout << "6. Xem thong tin tai khoan\n";
            cout << "7. Xoa tai khoan\n";
            cout << "8. Quay lai\n";
            cout << "Lua chon: ";

            int luaChon;
            cin >> luaChon;

            switch (luaChon) {
            case 1: themKhachHang(); break;
            case 2: xemDanhSachKhachHang(); break;
            case 3: timKiemKhachHang(); break;
            case 4: {
                string maKH;
                cout << "Nhap ma khach hang: ";
                cin >> maKH;
                auto kh = timKhachHang(maKH);
                if (kh) {
                    kh->capNhatThongTin();
                }
                else {
                    cout << "Khong tim thay khach hang" << endl;
                }
                break;
            }
            case 5: moTaiKhoan(); break;
            case 6: {
                int luaChonTim;
                cout << "Tim kiem khach hang bang:\n";
                cout << "1. Ma khach hang\n";
                cout << "2. CCCD va ho ten\n";
                cout << "Lua chon: ";
                cin >> luaChonTim;

                KhachHang* kh = nullptr;

                if (luaChonTim == 1) {
                    string maKH;
                    cout << "Nhap ma khach hang: ";
                    cin >> maKH;
                    kh = timKhachHang(maKH);
                }
                else if (luaChonTim == 2) {
                    string cmnd, hoTen;
                    cout << "Nhap so CCCD: ";
                    cin >> cmnd;
                    cout << "Nhap ho ten: ";
                    cin.ignore();
                    getline(cin, hoTen);
                    kh = timKhachHangBangCCCD(cmnd, hoTen);
                }
                else {
                    cout << "Lua chon khong hop le!" << endl;
                    break;
                }

                if (kh) {
                    cout << "\nTIM THAY KHACH HANG:\n";
                    cout << "Ma KH: " << kh->getMaKhachHang() << endl;
                    cout << "Ho ten: " << kh->getHoTen() << endl;
                    cout << "------------------------" << endl;
                    kh->hienThiThongTin();
                }
                else {
                    cout << "Khong tim thay khach hang" << endl;
                }
                break;
            }
            case 7: {
                string maKH, soTK;
                cout << "Nhap ma khach hang: ";
                cin >> maKH;
                auto kh = timKhachHang(maKH);
                if (kh) {
                    cout << "Nhap so tai khoan can xoa: ";
                    cin >> soTK;
                    cout << "Ban co chac chan muon xoa tai khoan " << soTK << "? (y/n): ";
                    char confirm;
                    cin >> confirm;
                    if (confirm == 'y' || confirm == 'Y') {
                        kh->xoaTaiKhoan(soTK);
                    }
                }
                else {
                    cout << "Khong tim thay khach hang" << endl;
                }
                break;
            }
            case 8: return;
            default: cout << "Lua chon khong hop le" << endl;
            }
        }
    }

    void thucHienGiaoDich() {
        while (true) {
            cout << "\nQUAN LY GIAO DICH:\n";
            cout << "1. Nap tien\n";
            cout << "2. Rut tien\n";
            cout << "3. Chuyen khoan\n";
            cout << "4. Xem lich su giao dich\n";
            cout << "5. Quay lai\n";
            cout << "Lua chon: ";

            int luaChon;
            cin >> luaChon;

            string soTK;
            double soTien;
            TaiKhoan* taiKhoan;

            switch (luaChon) {
            case 1:
                cout << "Nhap so tai khoan: ";
                cin >> soTK;
                taiKhoan = timTaiKhoan(soTK);
                if (taiKhoan) {
                    cout << "Nhap so tien nap: ";
                    cin >> soTien;
                    taiKhoan->napTien(soTien);
                    taiKhoan->themGiaoDich(GiaoDich(soTK, "Nap tien", soTien));
                    if (auto tkThanhToan = dynamic_cast<TaiKhoanThanhToan*>(taiKhoan)) {
                        tkThanhToan->ghiNhanPhiDichVu();
                    }
                    cout << "Nap tien thanh cong!" << endl;
                }
                else {
                    cout << "Khong tim thay tai khoan" << endl;
                }
                break;

            case 2:
                cout << "Nhap so tai khoan: ";
                cin >> soTK;
                taiKhoan = timTaiKhoan(soTK);
                if (taiKhoan) {
                    cout << "Nhap so tien rut: ";
                    cin >> soTien;
                    if (taiKhoan->rutTien(soTien)) {
                        taiKhoan->themGiaoDich(GiaoDich(soTK, "Rut tien", soTien));
                        if (auto tkThanhToan = dynamic_cast<TaiKhoanThanhToan*>(taiKhoan)) {
                            tkThanhToan->ghiNhanPhiDichVu();
                        }
                        cout << "Rut tien thanh cong!" << endl;
                    }
                    else {
                        cout << "So du khong du" << endl;
                    }
                }
                else {
                    cout << "Khong tim thay tai khoan" << endl;
                }
                break;

            case 3: {
                string soTKDich;
                cout << "Nhap so tai khoan nguon: ";
                cin >> soTK;
                taiKhoan = timTaiKhoan(soTK);

                if (taiKhoan) {
                    cout << "Nhap so tai khoan dich: ";
                    cin >> soTKDich;

                    if (soTK == soTKDich) {
                        cout << "Khong the chuyen khoan den cung tai khoan" << endl;
                        continue;
                    }

                    auto taiKhoanDich = timTaiKhoan(soTKDich);
                    if (taiKhoanDich) {
                        cout << "Nhap so tien chuyen: ";
                        cin >> soTien;
                        if (taiKhoan->rutTien(soTien)) {
                            taiKhoanDich->napTien(soTien);
                            taiKhoan->themGiaoDich(GiaoDich(soTK, "Chuyen khoan", soTien, soTKDich));
                            taiKhoanDich->themGiaoDich(GiaoDich(soTKDich, "Nhan tien", soTien, soTK));
                            if (auto tkThanhToan = dynamic_cast<TaiKhoanThanhToan*>(taiKhoan)) {
                                tkThanhToan->ghiNhanPhiDichVu();
                            }
                            cout << "Chuyen khoan thanh cong!" << endl;
                        }
                        else {
                            cout << "So du khong du" << endl;
                        }
                    }
                    else {
                        cout << "Khong tim thay tai khoan dich" << endl;
                    }
                }
                else {
                    cout << "Khong tim thay tai khoan nguon" << endl;
                }
                break;
            }

            case 4:
                cout << "Nhap so tai khoan: ";
                cin >> soTK;
                taiKhoan = timTaiKhoan(soTK);
                if (taiKhoan) {
                    taiKhoan->hienThiLichSuGiaoDich();
                }
                else {
                    cout << "Khong tim thay tai khoan" << endl;
                }
                break;

            case 5:
                return;

            default:
                cout << "Lua chon khong hop le" << endl;
            }
        }
    }

    void menuChinh() {
        while (true) {
            cout << "\nHE THONG QUAN LY NGAN HANG\n";
            cout << "1. Xem bang lai suat\n";
            cout << "2. Quan ly khach hang\n";
            cout << "3. Quan ly giao dich\n";
            cout << "4. Quan ly tai khoan tiet kiem\n";
            cout << "5. Quan ly tai khoan vay\n";
            cout << "6. Bao cao doanh thu\n";
            cout << "7. Thong ke khach hang\n";
            cout << "0. Thoat (luu lai du lieu)\n";
            cout << "Lua chon: ";

            int luaChon;
            cin >> luaChon;

            switch (luaChon) {
            case 1: hienThiBangLaiSuat(); break;
            case 2: quanLyKhachHang(); break;
            case 3: thucHienGiaoDich(); break;
            case 4: quanLyTaiKhoanTietKiem(); break;
            case 5: quanLyTaiKhoanVay(); break;
            case 6: baoCaoDoanhThu(); break;
            case 7: thongKeKhachHang(); break;
            case 0: luuDuLieu();
                cout << "Da luu du lieu vao file. Tam biet!\n";
                return;
            default: cout << "Lua chon khong hop le" << endl;
            }
        }
    }
};

int main() {
    QuanLyNganHang nganHang;
    nganHang.menuChinh();
    return 0;
}