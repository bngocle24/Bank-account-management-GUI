using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace guibankapp
{
    public partial class XemBangLaiSuat : Form
    {
        private Dictionary<int, double> bangLaiSuat;

        public XemBangLaiSuat()
        {
            InitializeComponent();
            KhoiTaoBangLaiSuat();
            HienThiBangLaiSuat();
        }

        private void KhoiTaoBangLaiSuat()
        {
            bangLaiSuat = new Dictionary<int, double>
            {
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

        private void HienThiBangLaiSuat()
        {
            // Tạo bảng HTML để hiển thị
            string html = @"
            <html>
            <head>
                <style>
                    table {
                        border-collapse: collapse;
                        width: 100%;
                    }
                    th, td {
                        border: 1px solid black;
                        padding: 8px;
                        text-align: left;
                    }
                    th {
                        background-color: #f2f2f2;
                    }
                    .title {
                        font-weight: bold;
                        text-align: center;
                        font-size: 16px;
                    }
                </style>
            </head>
            <body>
                <table>
                    <tr>
                        <th colspan='4' class='title'>BẢNG LÃI SUẤT TIỀN GỬI TIẾT KIỆM</th>
                    </tr>
                    <tr>
                        <th>Kỳ hạn</th>
                        <th>Lãi suất (%)</th>
                        <th>Kỳ hạn</th>
                        <th>Lãi suất (%)</th>
                    </tr>";

            // Thêm dữ liệu vào bảng
            var cot1 = new List<string> { "Không kỳ hạn", "1 tháng", "2 tháng", "3 tháng", "4 tháng", "5 tháng", "6 tháng", "7 tháng", "8 tháng" };
            var cot2 = new List<string> { "9 tháng", "10 tháng", "11 tháng", "12 tháng", "13 tháng", "15 tháng", "18 tháng", "24 tháng", "Tiền gửi thanh toán" };
            var keys = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 15, 18, 24, -1 };

            for (int i = 0; i < 9; i++)
            {
                html += $@"
                    <tr>
                        <td>{cot1[i]}</td>
                        <td>{bangLaiSuat[keys[i]]:0.00}%</td>
                        <td>{cot2[i]}</td>
                        <td>{bangLaiSuat[keys[i + 9]]:0.00}%</td>
                    </tr>";
            }

            // Thêm phần lãi suất cho vay
            html += @"
                </table>
                <br>
                <table>
                    <tr>
                        <th colspan='2' class='title'>LÃI SUẤT CHO VAY THÔNG THƯỜNG</th>
                    </tr>
                    <tr>
                        <td>Cho vay ngắn hạn (&lt;=12 tháng)</td>
                        <td>4.8%/năm</td>
                    </tr>
                    <tr>
                        <td>Cho vay trung/dài hạn</td>
                        <td>5.5%/năm</td>
                    </tr>
                </table>
            </body>
            </html>";

            // Hiển thị HTML trong WebBrowser
            webBrowser1.DocumentText = html;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}