using System;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using System.Linq;

namespace QuanLyQuanCaPhe.Helper
{
    public static class Utility
    {
        // Folder thật của bạn: ...\bin\Debug\net8.0-windows\Data\DataFiles\
        public static string DataDir
            => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DataFiles");

        public static string GetXmlFilePath(string fileName)
            => Path.Combine(DataDir, fileName);

        public static string PathMon => GetXmlFilePath("Mon.xml");
        public static string PathHoaDon => GetXmlFilePath("HoaDon.xml");
        public static string PathChiTietHoaDon => GetXmlFilePath("ChiTietHoaDon.xml");

        public static void EnsureDataFiles()
        {
            if (!Directory.Exists(DataDir)) Directory.CreateDirectory(DataDir);

            if (!File.Exists(PathHoaDon))
                new XDocument(new XElement("HoaDons")).Save(PathHoaDon);

            if (!File.Exists(PathChiTietHoaDon))
                new XDocument(new XElement("ChiTietHoaDons")).Save(PathChiTietHoaDon);
        }

        public static void EnsureMonFile()
        {
            if (!Directory.Exists(DataDir)) Directory.CreateDirectory(DataDir);

            if (!File.Exists(PathMon))
                new XDocument(new XElement("Mons")).Save(PathMon);
        }

        public static string MaHoaMD5(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                    sb.Append(hashBytes[i].ToString("x2"));

                return sb.ToString();
            }
        }

        public static int SafeInt(string? s) => int.TryParse(s, out var v) ? v : 0;

        public static decimal SafeDecimal(string? s)
        {
            if (string.IsNullOrWhiteSpace(s)) return 0m;
            s = s.Trim().Replace(",", "").Replace(".", "");
            if (decimal.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out var v)) return v;
            if (decimal.TryParse(s, NumberStyles.Any, new CultureInfo("vi-VN"), out v)) return v;
            return 0m;
        }

        public static string NormalizePayment(string text)
        {
            text = (text ?? "").Trim();
            if (text.Equals("Tiền mặt", StringComparison.OrdinalIgnoreCase)) return "TienMat";
            if (text.Equals("Chuyển khoản", StringComparison.OrdinalIgnoreCase)) return "ChuyenKhoan";
            if (text.Equals("Thẻ", StringComparison.OrdinalIgnoreCase)) return "The";
            return text.Replace(" ", "");
        }

        public static string NextMaHD()
        {
            EnsureDataFiles();

            var doc = XDocument.Load(PathHoaDon);
            int max = doc.Descendants("HoaDon")
                .Select(h => (string?)h.Attribute("MaHD"))
                .Where(s => !string.IsNullOrWhiteSpace(s) && s!.StartsWith("HD"))
                .Select(s => SafeInt(new string(s!.Skip(2).ToArray())))
                .DefaultIfEmpty(0)
                .Max();

            return "HD" + (max + 1).ToString("D3");
        }
    }
}
