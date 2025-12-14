using QuanLyQuanCaPhe.DAL;
using QuanLyQuanCaPhe.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyQuanCaPhe.GUI
{
    public partial class Form_TinhLuong : Form
    {
        private NhanVienDAL nvDAL = new NhanVienDAL();
        private string fileChamCong = Path.Combine(Application.StartupPath, "DataFiles", "ChamCong.xml");
        private string fileLuong = Path.Combine(Application.StartupPath, "DataFiles", "LuongThang.xml");

        private List<LuongThang> dsLuong = new List<LuongThang>();

        public Form_TinhLuong()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            KhoiTaoComboBoxThang();
            LoadNhanVienVaoComboBox();
            LoadLuongTuXML();
            HienThiDanhSachLuong();
            this.BackgroundImage = Properties.Resources.background7;
            this.BackgroundImageLayout = ImageLayout.Stretch;// Hiển thị TẤT CẢ các tháng
        }

        public class LuongThang
        {
            public string MaNV { get; set; }
            public string HoTen { get; set; }
            public double TongGio { get; set; }
            public int SoNgay { get; set; }
            public decimal LuongGio { get; set; }
            public decimal TongLuong { get; set; }
            public int Thang { get; set; }
            public int Nam { get; set; }
            public string ThangNam => $"{Thang:00}/{Nam}"; // Hiển thị đẹp: 11/2025, 12/2025
        }

        // ComboBox chỉ để chọn tháng TÍNH LƯƠNG MỚI, không lọc hiển thị
        private void KhoiTaoComboBoxThang()
        {
            cboThang.Items.Clear();
            DateTime today = DateTime.Now;
            for (int i = 0; i < 12; i++)
            {
                DateTime thang = today.AddMonths(-i);
                cboThang.Items.Add(new { Text = thang.ToString("MM/yyyy"), Value = thang });
            }
            cboThang.DisplayMember = "Text";
            cboThang.ValueMember = "Value";
            cboThang.SelectedIndex = 0; // Mặc định tháng hiện tại
        }

        private void LoadNhanVienVaoComboBox()
        {
            var ds = nvDAL.LayTatCaNhanVien();
            cboNhanVien.DataSource = ds;
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MaNV";
        }

        private void LoadLuongTuXML()
        {
            dsLuong.Clear();
            if (File.Exists(fileLuong))
            {
                var doc = XDocument.Load(fileLuong);
                dsLuong.AddRange(doc.Root.Elements("Luong")
                    .Select(x => new LuongThang
                    {
                        MaNV = x.Element("MaNV")?.Value ?? "",
                        HoTen = x.Element("HoTen")?.Value ?? "",
                        TongGio = double.Parse(x.Element("TongGio")?.Value ?? "0"),
                        SoNgay = int.Parse(x.Element("SoNgay")?.Value ?? "0"),
                        LuongGio = decimal.Parse(x.Element("LuongGio")?.Value ?? "0"),
                        TongLuong = decimal.Parse(x.Element("TongLuong")?.Value ?? "0"),
                        Thang = int.Parse(x.Element("Thang")?.Value ?? "1"),
                        Nam = int.Parse(x.Element("Nam")?.Value ?? DateTime.Now.Year.ToString())
                    }));
            }
        }

        // HIỂN THỊ TẤT CẢ CÁC THÁNG (KHÔNG LỌC)
        private void HienThiDanhSachLuong()
        {
            dgvLuong.DataSource = null;
            dgvLuong.DataSource = dsLuong.OrderByDescending(l => l.Nam).ThenByDescending(l => l.Thang).ToList();

            if (dgvLuong.Columns.Count > 0)
            {
                dgvLuong.Columns["MaNV"].HeaderText = "Mã NV";
                dgvLuong.Columns["HoTen"].HeaderText = "Họ tên";
                dgvLuong.Columns["TongGio"].HeaderText = "Tổng giờ";
                dgvLuong.Columns["SoNgay"].HeaderText = "Số ngày";
                dgvLuong.Columns["LuongGio"].HeaderText = "Lương/giờ (VND)";
                dgvLuong.Columns["TongLuong"].HeaderText = "Tổng lương (VND)";
                dgvLuong.Columns["ThangNam"].HeaderText = "Tháng/Năm";

                // Định dạng tiền tệ
                dgvLuong.Columns["LuongGio"].DefaultCellStyle.Format = "N0";
                dgvLuong.Columns["TongLuong"].DefaultCellStyle.Format = "N0";
            }
            // ===== HEADER =====
            dgvLuong.CellPainting += dgv_CellPainting;
            dgvLuong.EnableHeadersVisualStyles = false;
            dgvLuong.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvLuong.ColumnHeadersHeight = 40;
            dgvLuong.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvLuong.RowHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;

            // ===== GIÃN FULL CỘT =====
            dgvLuong.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            // ===== BODY =====
            dgvLuong.BackgroundColor = Color.White;
            dgvLuong.GridColor = Color.LightGray;

            dgvLuong.DefaultCellStyle.BackColor = Color.White;
            dgvLuong.DefaultCellStyle.ForeColor = Color.Black;
            dgvLuong.DefaultCellStyle.SelectionBackColor =
                Color.SkyBlue;
            dgvLuong.DefaultCellStyle.SelectionForeColor = Color.Black;

            // ===== DÒNG XEN KẼ (đẹp hơn) =====
            dgvLuong.AlternatingRowsDefaultCellStyle.BackColor =
                Color.LightBlue;

            // ===== DÒNG (ROW) =====
            dgvLuong.DefaultCellStyle.Font =
                new Font("Segoe UI", 8);

            dgvLuong.RowTemplate.Height = 36;
            dgvLuong.RowsDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // ===== READ ONLY + ĐẸP =====
            dgvLuong.ReadOnly = true;
            dgvLuong.AllowUserToAddRows = false;
            dgvLuong.AllowUserToResizeRows = false;
        }

        // Khi đổi tháng → không cần làm gì (vì không lọc nữa)
        // Bạn có thể xóa sự kiện cboThang_SelectedIndexChanged nếu có

        private void btnTinhLuong_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedIndex == -1 || cboThang.SelectedItem == null)
            {
                MessageBox.Show("Chọn nhân viên và tháng tính lương!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtLuongGio.Text, out decimal luongGio) || luongGio <= 0)
            {
                MessageBox.Show("Nhập lương/giờ hợp lệ!", "Lỗi");
                return;
            }

            if (!int.TryParse(txtSoNgay.Text, out int soNgay) || soNgay <= 0)
            {
                MessageBox.Show("Nhập số ngày hợp lệ!", "Lỗi");
                return;
            }

            var selectedThang = (dynamic)cboThang.SelectedItem;
            DateTime thangChon = selectedThang.Value;
            int thang = thangChon.Month;
            int nam = thangChon.Year;

            string maNV = cboNhanVien.SelectedValue.ToString();
            string hoTen = cboNhanVien.Text;

            // Tính tổng giờ trong tháng được chọn
            double tongGio = 0;
            if (File.Exists(fileChamCong))
            {
                var doc = XDocument.Load(fileChamCong);
                var records = doc.Root.Elements("ChamCong")
                    .Where(x =>
                    {
                        var ma = x.Element("MaNV")?.Value;
                        var ngayStr = x.Element("NgayLam")?.Value;
                        if (ma != maNV || string.IsNullOrEmpty(ngayStr)) return false;
                        if (DateTime.TryParse(ngayStr, out DateTime ngay))
                        {
                            return ngay.Month == thang && ngay.Year == nam;
                        }
                        return false;
                    });

                tongGio = records.Sum(x => double.Parse(x.Element("SoGio")?.Value ?? "0"));
            }

            if (tongGio == 0)
            {
                MessageBox.Show($"Không có dữ liệu chấm công cho {hoTen} trong tháng {thang}/{nam}!", "Thông báo");
                return;
            }

            decimal tongLuong = luongGio * (decimal)tongGio * soNgay;

            // Kiểm tra đã tồn tại lương tháng này chưa
            var existing = dsLuong.FirstOrDefault(l => l.MaNV == maNV && l.Thang == thang && l.Nam == nam);
            if (existing != null)
            {
                if (MessageBox.Show($"Đã tồn tại lương tháng {thang}/{nam} cho {hoTen}.\nBạn có muốn ghi đè không?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                existing.TongGio = tongGio;
                existing.SoNgay = soNgay;
                existing.LuongGio = luongGio;
                existing.TongLuong = tongLuong;
            }
            else
            {
                dsLuong.Add(new LuongThang
                {
                    MaNV = maNV,
                    HoTen = hoTen,
                    TongGio = tongGio,
                    SoNgay = soNgay,
                    LuongGio = luongGio,
                    TongLuong = tongLuong,
                    Thang = thang,
                    Nam = nam
                });
            }

            LuuLuongVaoXML();
            HienThiDanhSachLuong(); // Hiển thị lại tất cả (bao gồm dòng mới)

            MessageBox.Show($"Đã lưu lương tháng {thang}/{nam} cho {hoTen}: {tongLuong:N0} VND", "Thành công");
        }

        private void LuuLuongVaoXML()
        {
            var root = new XElement("DanhSachLuong",
                dsLuong.Select(l => new XElement("Luong",
                    new XElement("MaNV", l.MaNV),
                    new XElement("HoTen", l.HoTen),
                    new XElement("TongGio", l.TongGio),
                    new XElement("SoNgay", l.SoNgay),
                    new XElement("LuongGio", l.LuongGio),
                    new XElement("TongLuong", l.TongLuong),
                    new XElement("Thang", l.Thang),
                    new XElement("Nam", l.Nam)
                ))
            );

            Directory.CreateDirectory(Path.GetDirectoryName(fileLuong));
            new XDocument(root).Save(fileLuong);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLuongGio_TextChanged(object sender, EventArgs e)
        {

        }
        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Chỉ vẽ header cột
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    e.CellBounds,
                    Color.FromArgb(0, 122, 255),   // màu trên
                    Color.FromArgb(0, 80, 200),    // màu dưới
                    LinearGradientMode.Horizontal))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                }

                // Vẽ viền
                using (Pen pen = new Pen(Color.White))
                {
                    e.Graphics.DrawRectangle(pen, e.CellBounds);
                }

                // Vẽ chữ
                TextRenderer.DrawText(
                    e.Graphics,
                    e.FormattedValue.ToString(),
                    new Font("Segoe UI", 8, FontStyle.Bold),
                    e.CellBounds,
                    Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );

                e.Handled = true;
            }
        }
    }
}