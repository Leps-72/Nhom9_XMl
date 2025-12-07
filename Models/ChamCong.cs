// File: Models/ChamCong.cs
using System;

namespace QuanLyQuanCaPhe.Models
{
    public class ChamCong
    {
        public string MaNV { get; set; } = "";
        public string HoTen { get; set; } = "";
        public string LoaiNhanVien { get; set; } = "";
        public DateTime NgayLam { get; set; } = DateTime.Today;
        public TimeSpan GioVao { get; set; } = TimeSpan.FromHours(8);
        public TimeSpan GioRa { get; set; } = TimeSpan.FromHours(17);
        public double SoGio { get; set; } = 0;

        // Để hiển thị đẹp trong DataGridView
        public string ThoiGian => $"{GioVao:hh\\:mm} - {GioRa:hh\\:mm}";
        public string TongGio => $"{SoGio:0.0} giờ";
    }
}