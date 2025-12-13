using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using QuanLyQuanCaPhe.Helper;
using QuanLyQuanCaPhe.Models;

namespace QuanLyQuanCaPhe.DAL
{
    public class DanhMucDAL
    {
        public DanhMucDAL() => Utility.EnsureDanhMucFile();

        public List<DanhMuc> GetAll()
        {
            var doc = XDocument.Load(Utility.PathDanhMuc);
            return doc.Descendants("DanhMuc")
                .Select(x => new DanhMuc
                {
                    MaDM = (string?)x.Element("MaDM") ?? "",
                    TenDM = (string?)x.Element("TenDM") ?? "",
                    MoTa = (string?)x.Element("MoTa") ?? ""
                })
                .Where(d => !string.IsNullOrWhiteSpace(d.MaDM))
                .OrderBy(d => d.MaDM)
                .ToList();
        }

        public Dictionary<string, string> GetMapMaDM_TenDM()
            => GetAll().ToDictionary(x => x.MaDM, x => x.TenDM);

        public bool Exists(string maDM)
        {
            var doc = XDocument.Load(Utility.PathDanhMuc);
            return doc.Descendants("DanhMuc").Any(x => (string?)x.Element("MaDM") == maDM);
        }

        public void Add(DanhMuc dm)
        {
            var doc = XDocument.Load(Utility.PathDanhMuc);
            doc.Root!.Add(new XElement("DanhMuc",
                new XElement("MaDM", dm.MaDM),
                new XElement("TenDM", dm.TenDM),
                new XElement("MoTa", dm.MoTa)
            ));
            doc.Save(Utility.PathDanhMuc);
        }

        public bool Update(DanhMuc dm)
        {
            var doc = XDocument.Load(Utility.PathDanhMuc);
            var node = doc.Descendants("DanhMuc").FirstOrDefault(x => (string?)x.Element("MaDM") == dm.MaDM);
            if (node == null) return false;

            node.SetElementValue("TenDM", dm.TenDM);
            node.SetElementValue("MoTa", dm.MoTa);

            doc.Save(Utility.PathDanhMuc);
            return true;
        }

        public bool Delete(string maDM)
        {
            var doc = XDocument.Load(Utility.PathDanhMuc);
            var node = doc.Descendants("DanhMuc").FirstOrDefault(x => (string?)x.Element("MaDM") == maDM);
            if (node == null) return false;

            node.Remove();
            doc.Save(Utility.PathDanhMuc);
            return true;
        }
    }
}
