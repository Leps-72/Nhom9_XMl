using System.Security.Cryptography;
using System.Text;
using System.IO;
using System;

namespace QuanLyQuanCaPhe.Helper
{
    public static class Utility // Phải là static
    {
        public static string GetXmlFilePath(string fileName)
        {
            string appDir = AppDomain.CurrentDomain.BaseDirectory;
            // Giả sử file XML nằm trong thư mục DataFiles bên cạnh thư mục bin/Debug
            return Path.Combine(appDir, "DataFiles", fileName);
        }
        // 🚨 CHỮ KÝ PHẢI LÀ public static
        public static string MaHoaMD5(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.ASCII.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        // ... (Các hàm khác) ...
    }
}