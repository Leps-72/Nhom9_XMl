using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using QuanLyQuanCaPhe.Helper;
using QuanLyQuanCaPhe.Models;

namespace QuanLyQuanCaPhe.DAL
{
    internal class ChiTietHoaDonDAL
    {
        public ChiTietHoaDonDAL()
        {
            Utility.EnsureDataFiles();
        }

        public List<ThongKeMon> ThongKeTheoMon()
        {
            var doc = XDocument.Load(Utility.PathChiTietHoaDon);

            var data = doc.Descendants("ChiTiet")
                .Select(x =>
                {
                    int soLuong;
                    int.TryParse((string)x.Element("SoLuong"), out soLuong);

                    decimal thanhTien;
                    decimal.TryParse(
                        (string)x.Element("ThanhTien"),
                        NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out thanhTien
                    );

                    return new
                    {
                        TenMon = (string)x.Element("TenMon") ?? "",
                        SoLuong = soLuong,
                        ThanhTien = thanhTien
                    };
                })
                .GroupBy(x => x.TenMon)
                .Select(g => new ThongKeMon
                {
                    TenMon = g.Key,
                    TongSoLuong = g.Sum(x => x.SoLuong),
                    TongDoanhThu = g.Sum(x => x.ThanhTien)
                })
                .OrderByDescending(x => x.TongDoanhThu)
                .ToList();

            return data;
        }
        public List<ChiTietHoaDon> ThongKeTheoMonFull()
        {
            var doc = XDocument.Load(Utility.PathChiTietHoaDon);
            return doc.Descendants("ChiTiet").Select(x => new ChiTietHoaDon
            {
                MaHD = (string)x.Element("MaHD"),
                TenMon = (string)x.Element("TenMon"),
                SoLuong = int.Parse((string)x.Element("SoLuong")),
                ThanhTien = decimal.Parse((string)x.Element("ThanhTien"), CultureInfo.InvariantCulture)
            }).ToList();
        }

    }
}
