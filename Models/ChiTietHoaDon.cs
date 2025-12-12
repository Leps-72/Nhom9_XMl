namespace QuanLyQuanCaPhe.Models
{
    public class ChiTietHoaDon
    {
        public string MaHD { get; set; } = "";
        public string MaMon { get; set; } = "";
        public string TenMon { get; set; } = "";
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }  // SoLuong * DonGia
    }
}
