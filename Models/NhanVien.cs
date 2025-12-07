using System;

namespace QuanLyQuanCaPhe.Models
{
    public class NhanVien
    {
        // Thuộc tính ánh xạ với attribute MaNV
        public string MaNV { get; set; }
        public string HoTen { get; set; }
        public string TenDangNhap { get; set; }
        // Lưu ý: Trong code, ta dùng property MatKhau, nhưng khi lưu/đọc XML 
        // phải đảm bảo nó đã được mã hóa.
        public string MatKhau { get; set; }
        public string QuyenTruyCap { get; set; } // Ví dụ: QuanLy, BanHang
        public DateTime NgayVaoLam { get; set; }
    }
}