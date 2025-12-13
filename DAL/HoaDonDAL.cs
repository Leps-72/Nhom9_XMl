using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;
using QuanLyQuanCaPhe.Helper;
using QuanLyQuanCaPhe.Models;

namespace QuanLyQuanCaPhe.DAL
{
    public class HoaDonDAL
    {
        public HoaDonDAL()
        {
            Utility.EnsureDataFiles();
        }

        public void SaveHoaDon(HoaDon hd, List<ChiTietHoaDon> ctList)
        {
            // 1) HoaDon.xml
            var docHD = XDocument.Load(Utility.PathHoaDon);

            var node = docHD.Descendants("HoaDon")
                .FirstOrDefault(x => (string)x.Attribute("MaHD") == hd.MaHD);

            if (node == null)
            {
                node = new XElement("HoaDon",
                    new XAttribute("MaHD", hd.MaHD),
                    new XElement("NgayLap", hd.NgayLap.ToString("s")),
                    new XElement("TongTien", hd.TongTien.ToString(CultureInfo.InvariantCulture)),
                    new XElement("GiamGiaPercent", hd.GiamGiaPercent.ToString(CultureInfo.InvariantCulture)),
                    new XElement("ThanhTien", hd.ThanhTien.ToString(CultureInfo.InvariantCulture)),
                    new XElement("HinhThucThanhToan", hd.HinhThucThanhToan)
                );
                docHD.Root.Add(node);
            }
            else
            {
                node.SetElementValue("NgayLap", hd.NgayLap.ToString("s"));
                node.SetElementValue("TongTien", hd.TongTien.ToString(CultureInfo.InvariantCulture));
                node.SetElementValue("GiamGiaPercent", hd.GiamGiaPercent.ToString(CultureInfo.InvariantCulture));
                node.SetElementValue("ThanhTien", hd.ThanhTien.ToString(CultureInfo.InvariantCulture));
                node.SetElementValue("HinhThucThanhToan", hd.HinhThucThanhToan);
            }

            docHD.Save(Utility.PathHoaDon);

            // 2) ChiTietHoaDon.xml (xóa cũ của MaHD rồi thêm mới)
            var docCT = XDocument.Load(Utility.PathChiTietHoaDon);

            docCT.Root.Elements("ChiTiet")
                .Where(x => (string)x.Element("MaHD") == hd.MaHD)
                .Remove();

            foreach (var ct in ctList)
            {
                var ctNode = new XElement("ChiTiet",
                    new XElement("MaHD", hd.MaHD),
                    new XElement("MaMon", ct.MaMon),
                    new XElement("TenMon", ct.TenMon),
                    new XElement("SoLuong", ct.SoLuong),
                    new XElement("DonGia", ct.DonGia.ToString(CultureInfo.InvariantCulture)),
                    new XElement("ThanhTien", ct.ThanhTien.ToString(CultureInfo.InvariantCulture))
                );

                docCT.Root.Add(ctNode);
            }

            docCT.Save(Utility.PathChiTietHoaDon);
        }
        public List<HoaDon> GetHoaDonByDate(DateTime tuNgay, DateTime denNgay)
        {
            var docHD = XDocument.Load(Utility.PathHoaDon);

            var list = docHD.Descendants("HoaDon")
                .Select(x =>
                {
                    // Ngày lập
                    DateTime ngayLap;
                    DateTime.TryParse(
                        (string)x.Element("NgayLap"),
                        out ngayLap
                    );

                    // Tổng tiền
                    decimal tongTien;
                    decimal.TryParse(
                        (string)x.Element("TongTien"),
                        NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out tongTien
                    );

                    // Giảm giá %
                    decimal giamGiaPercent;
                    decimal.TryParse(
                        (string)x.Element("GiamGiaPercent"),
                        NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out giamGiaPercent
                    );

                    // Thành tiền
                    decimal thanhTien;
                    decimal.TryParse(
                        (string)x.Element("ThanhTien"),
                        NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out thanhTien
                    );

                    return new HoaDon
                    {
                        MaHD = (string)x.Attribute("MaHD") ?? "",
                        NgayLap = ngayLap,
                        TongTien = tongTien,
                        GiamGiaPercent = giamGiaPercent,
                        ThanhTien = thanhTien,
                        HinhThucThanhToan = (string)x.Element("HinhThucThanhToan") ?? ""
                    };
                })
                .Where(hd =>
                    hd.NgayLap.Date >= tuNgay.Date &&
                    hd.NgayLap.Date <= denNgay.Date
                )
                .ToList();

            return list;
        }
        public List<HoaDon> GetAllHoaDon()
        {
            var docHD = XDocument.Load(Utility.PathHoaDon);

            var list = docHD.Descendants("HoaDon")
                .Select(x =>
                {
                    // Ngày lập
                    DateTime ngayLap;
                    DateTime.TryParse(
                        (string)x.Element("NgayLap"),
                        out ngayLap
                    );

                    // Tổng tiền
                    decimal tongTien;
                    decimal.TryParse(
                        (string)x.Element("TongTien"),
                        NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out tongTien
                    );

                    // Giảm giá %
                    decimal giamGiaPercent;
                    decimal.TryParse(
                        (string)x.Element("GiamGiaPercent"),
                        NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out giamGiaPercent
                    );

                    // Thành tiền
                    decimal thanhTien;
                    decimal.TryParse(
                        (string)x.Element("ThanhTien"),
                        NumberStyles.Any,
                        CultureInfo.InvariantCulture,
                        out thanhTien
                    );

                    return new HoaDon
                    {
                        MaHD = (string)x.Attribute("MaHD") ?? "",
                        NgayLap = ngayLap,
                        TongTien = tongTien,
                        GiamGiaPercent = giamGiaPercent,
                        ThanhTien = thanhTien,
                        HinhThucThanhToan = (string)x.Element("HinhThucThanhToan") ?? ""
                    };
                })
                .ToList();

            return list;
        }
    }
}
