using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCaPhe.Models
{
    public class OrderItem
    {
        public string MaMon { get; set; } = "";
        public string TenMon { get; set; } = "";
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien => SoLuong * DonGia;
    }
}
