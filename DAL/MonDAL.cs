using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using QuanLyQuanCaPhe.Helper;
using QuanLyQuanCaPhe.Models;

namespace QuanLyQuanCaPhe.DAL
{
    public class MonDAL
    {
        public MonDAL()
        {
            Utility.EnsureMonFile();
        }

        public List<Mon> GetAll()
        {
            var doc = XDocument.Load(Utility.PathMon);

            return doc.Descendants("Mon")
                .Select(x => new Mon
                {
                    MaMon = (string)x.Element("MaMon") ?? "",
                    TenMon = (string)x.Element("TenMon") ?? "",
                    DanhMuc = (string)x.Element("DanhMuc") ?? "",
                    DonGia = decimal.TryParse((string)x.Element("DonGia"), out var dg) ? dg : 0
                })
                .ToList();
        }

        public List<string> GetDanhMuc()
        {
            return GetAll()
                .Select(m => m.DanhMuc)
                .Where(s => !string.IsNullOrWhiteSpace(s))
                .Distinct()
                .OrderBy(s => s)
                .ToList();
        }
    }
}
