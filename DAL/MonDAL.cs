using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using QuanLyQuanCaPhe.Helper;
using QuanLyQuanCaPhe.Models;

namespace QuanLyQuanCaPhe.DAL
{
    public class MonDAL
    {
        public MonDAL() => Utility.EnsureMonFile();

        public List<Mon> GetAll()
        {
            var doc = XDocument.Load(Utility.PathMon);
            return doc.Descendants("Mon")
                .Select(x => new Mon
                {
                    MaMon = (string?)x.Element("MaMon") ?? "",
                    TenMon = (string?)x.Element("TenMon") ?? "",
                    MaDM = (string?)x.Element("MaDM") ?? "",
                    DonGia = decimal.TryParse((string?)x.Element("DonGia"), out var dg) ? dg : 0m
                })
                .Where(m => !string.IsNullOrWhiteSpace(m.MaMon))
                .OrderBy(m => m.MaMon)
                .ToList();
        }

        public bool Exists(string maMon)
        {
            var doc = XDocument.Load(Utility.PathMon);
            return doc.Descendants("Mon").Any(x => (string?)x.Element("MaMon") == maMon);
        }

        public void Add(Mon m)
        {
            var doc = XDocument.Load(Utility.PathMon);
            doc.Root!.Add(new XElement("Mon",
                new XElement("MaMon", m.MaMon),
                new XElement("TenMon", m.TenMon),
                new XElement("MaDM", m.MaDM),
                new XElement("DonGia", m.DonGia)
            ));
            doc.Save(Utility.PathMon);
        }

        public bool Update(Mon m)
        {
            var doc = XDocument.Load(Utility.PathMon);
            var node = doc.Descendants("Mon").FirstOrDefault(x => (string?)x.Element("MaMon") == m.MaMon);
            if (node == null) return false;

            node.SetElementValue("TenMon", m.TenMon);
            node.SetElementValue("MaDM", m.MaDM);
            node.SetElementValue("DonGia", m.DonGia);

            doc.Save(Utility.PathMon);
            return true;
        }

        public bool Delete(string maMon)
        {
            var doc = XDocument.Load(Utility.PathMon);
            var node = doc.Descendants("Mon").FirstOrDefault(x => (string?)x.Element("MaMon") == maMon);
            if (node == null) return false;

            node.Remove();
            doc.Save(Utility.PathMon);
            return true;
        }

        public int CountByMaDM(string maDM)
        {
            var doc = XDocument.Load(Utility.PathMon);
            return doc.Descendants("Mon").Count(x => (string?)x.Element("MaDM") == maDM);
        }
    }
}
