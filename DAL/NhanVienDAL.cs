using System; // Cần thiết cho DateTime
using System.Xml.Linq;
using System.Linq;
using System.IO;
using QuanLyQuanCaPhe.Models;
using QuanLyQuanCaPhe.Helper;
using System.Collections.Generic;

namespace QuanLyQuanCaPhe.DAL
{
    public class NhanVienDAL
    {
        // Đảm bảo đường dẫn file XML được lấy chính xác
        private string xmlPath = Utility.GetXmlFilePath("NhanVien.xml");

        // Hàm đọc toàn bộ danh sách nhân viên từ XML
        public List<NhanVien> LayTatCaNhanVien()
        {
            if (!File.Exists(xmlPath)) return new List<NhanVien>();

            XDocument doc = XDocument.Load(xmlPath);
            return doc.Root.Elements("NhanVien")
                .Select(nv => new NhanVien
                {
                    MaNV = nv.Attribute("MaNV").Value,
                    HoTen = nv.Element("HoTen").Value,
                    TenDangNhap = nv.Element("TenDangNhap").Value,
                    MatKhau = nv.Element("MatKhau").Value, // Đã được mã hóa
                    QuyenTruyCap = nv.Element("QuyenTruyCap").Value,
                    // Xử lý NgayVaoLam nếu có
                    NgayVaoLam = DateTime.Parse(nv.Element("NgayVaoLam")?.Value ?? DateTime.Now.ToString())
                }).ToList();
        }

        // Hàm tìm kiếm Nhân viên để Đăng nhập
        public NhanVien KiemTraDangNhap(string tenDN, string matKhauDaMaHoa)
        {
            var danhSach = LayTatCaNhanVien();
            // LINQ to Objects: tìm kiếm trong danh sách đã load
            return danhSach.FirstOrDefault(nv =>
                       nv.TenDangNhap.Equals(tenDN, StringComparison.OrdinalIgnoreCase) &&
                       nv.MatKhau == matKhauDaMaHoa);
        }

        // 🎯 ĐỊNH NGHĨA DUY NHẤT HÀM THÊM NHÂN VIÊN
        public bool ThemNhanVien(NhanVien newNV)
        {
            if (!File.Exists(xmlPath)) return false;

            XDocument doc = XDocument.Load(xmlPath);

            // 1. Kiểm tra trùng Tên đăng nhập
            if (doc.Root.Elements("NhanVien").Any(nv => nv.Element("TenDangNhap").Value.Equals(newNV.TenDangNhap, StringComparison.OrdinalIgnoreCase)))
            {
                return false; // Tên đăng nhập đã tồn tại
            }

            // 2. Tạo mã NV mới
            newNV.MaNV = TaoMaNhanVienMoi(doc);

            // 3. Tạo XElement mới từ đối tượng NhanVien
            XElement nvElement = new XElement("NhanVien",
                new XAttribute("MaNV", newNV.MaNV),
                new XElement("HoTen", newNV.HoTen),
                new XElement("TenDangNhap", newNV.TenDangNhap),
                new XElement("MatKhau", newNV.MatKhau), // Phải là mật khẩu đã mã hóa
                new XElement("QuyenTruyCap", newNV.QuyenTruyCap),
                new XElement("NgayVaoLam", newNV.NgayVaoLam.ToString("yyyy-MM-dd"))
            );

            // 4. Thêm vào và Lưu
            doc.Root.Add(nvElement);
            doc.Save(xmlPath); // Ghi lại vào file XML
            return true;
        }

        public bool SuaNhanVien(NhanVien nvSua)
        {
            if (!File.Exists(xmlPath)) return false;

            XDocument doc = XDocument.Load(xmlPath);
            var element = doc.Root.Elements("NhanVien")
                .FirstOrDefault(x => x.Attribute("MaNV").Value == nvSua.MaNV);

            if (element != null)
            {
                element.Element("HoTen").Value = nvSua.HoTen;
                element.Element("QuyenTruyCap").Value = nvSua.QuyenTruyCap;
                // có thể sửa thêm TenDangNhap, MatKhau nếu cần
                doc.Save(xmlPath);
                return true;
            }
            return false;
        }

        public bool XoaNhanVien(string maNV)
        {
            if (!File.Exists(xmlPath)) return false;

            XDocument doc = XDocument.Load(xmlPath);
            var element = doc.Root.Elements("NhanVien")
                .FirstOrDefault(x => x.Attribute("MaNV").Value == maNV);

            if (element != null && maNV != "NV001") // không xóa admin
            {
                element.Remove();
                doc.Save(xmlPath);
                return true;
            }
            return false;
        }
        // 🎯 ĐỊNH NGHĨA DUY NHẤT HÀM TẠO MÃ NV TỰ ĐỘNG
        private string TaoMaNhanVienMoi(XDocument doc)
        {
            var lastMaNV = doc.Root.Elements("NhanVien")
                                 .Attributes("MaNV")
                                 .Select(a => a.Value)
                                 .OrderByDescending(v => v)
                                 .FirstOrDefault();

            if (lastMaNV == null) return "NV001"; // Nếu là nhân viên đầu tiên

            try
            {
                // Ví dụ: NV002 -> lấy "002"
                string numberPart = lastMaNV.Substring(2);

                // Tăng số lên 1
                int newNumber = int.Parse(numberPart) + 1;

                // Trả về mã NV mới với định dạng 3 chữ số (ví dụ: "NV003")
                return "NV" + newNumber.ToString("D3");
            }
            catch
            {
                // Trường hợp lỗi Parse (ví dụ: dữ liệu XML bị lỗi định dạng mã NV)
                return "NV" + (doc.Root.Elements("NhanVien").Count() + 1).ToString("D3");
            }
        }
    }
}