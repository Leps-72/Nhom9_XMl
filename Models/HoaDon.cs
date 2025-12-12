using System;

namespace QuanLyQuanCaPhe.Models
{
    public class HoaDon
    {
        public string MaHD { get; set; } = "";
        public DateTime NgayLap { get; set; } = DateTime.Now;

        public decimal TongTien { get; set; }
        public decimal GiamGiaPercent { get; set; }  // 0..100
        public decimal ThanhTien { get; set; }

        public string HinhThucThanhToan { get; set; } = "TienMat"; // TienMat/ChuyenKhoan/The
    }
}
