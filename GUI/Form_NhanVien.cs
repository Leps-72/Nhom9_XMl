using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using QuanLyQuanCaPhe.DAL;
using QuanLyQuanCaPhe.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using QuanLyQuanCaPhe.Helper;

namespace QuanLyQuanCaPhe.GUI
{
    public partial class Form_NhanVien : Form
    {
        private NhanVienDAL nvDAL = new NhanVienDAL();
        private List<ChamCong> dsChamCong = new List<ChamCong>();
        private string fileChamCong = Path.Combine(Application.StartupPath, "DataFiles", "ChamCong.xml");

        public Form_NhanVien()
        {
            InitializeComponent();
            LoadNhanVienVaoComboBox();
            LoadLoaiNhanVien();
            LoadChamCong();
            HienThiBangChamCong();
            this.Dock = DockStyle.Fill;
            this.WindowState = FormWindowState.Maximized;
            LoadNhanVienVaoComboBox();
            HienThiBangChamCong();
        }
        // Đặt trong constructor hoặc Form_Load đều được
        private void LoadLoaiNhanVien()
        {
            string file = Path.Combine(Application.StartupPath, "DataFiles", "LoaiNhanVien.xml");

            var ds = XDocument.Load(file)
                              .Root
                              .Elements("Loai")
                              .Select(x => new
                              {
                                  MaLoai = x.Element("MaLoai")?.Value,
                                  TenLoai = x.Element("TenLoai")?.Value
                              })
                              .ToList();

            cboLoaiNV.DataSource = ds;
            cboLoaiNV.DisplayMember = "TenLoai";
            cboLoaiNV.ValueMember = "MaLoai";
        }
        // Load danh sách nhân viên vào ComboBox
        private void LoadNhanVienVaoComboBox()
        {
            var ds = nvDAL.LayTatCaNhanVien();
            cboNhanVien.DataSource = ds;
            cboNhanVien.DisplayMember = "HoTen";    // hiện tên
            cboNhanVien.ValueMember = "MaNV";       // giá trị là mã NV
        }

        // Khi chọn nhân viên → tự hiện mã NV
        private void cboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue != null)
            {
                txtMaNV.Text = cboNhanVien.SelectedValue.ToString();
            }
        }

        // Load dữ liệu chấm công từ XML
        private void LoadChamCong()
        {
            dsChamCong.Clear();
            if (File.Exists(fileChamCong))
            {
                var doc = XDocument.Load(fileChamCong);
                dsChamCong.AddRange(doc.Root.Elements("ChamCong")
                    .Select(x => new ChamCong
                    {
                        MaNV = x.Element("MaNV")?.Value ?? "",
                        HoTen = x.Element("HoTen")?.Value ?? "",
                        NgayLam = DateTime.Parse(x.Element("NgayLam")?.Value ?? DateTime.Today.ToString()),
                        GioVao = TimeSpan.Parse(x.Element("GioVao")?.Value ?? "08:00"),
                        GioRa = TimeSpan.Parse(x.Element("GioRa")?.Value ?? "17:00"),
                        SoGio = double.Parse(x.Element("SoGio")?.Value ?? "0")
                    }));
            }
        }

        // Hiển thị bảng chấm công
        private void HienThiBangChamCong()
        {
            dgvChamCong.DataSource = null;
            dgvChamCong.DataSource = dsChamCong.OrderByDescending(x => x.NgayLam).ToList();
        }

        // Nút Chấm công – đoạn lưu XML đã SỬA HOÀN HẢO
        private void btnChamCong_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboNhanVien.SelectedIndex == -1)
                {
                    MessageBox.Show("Vui lòng chọn nhân viên!", "Chưa chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string inputVao = txtGioVao.Text.Trim();
                string inputRa = txtGioRa.Text.Trim();

                // Tự động thêm :00 nếu chỉ gõ số (8 → 08:00, 15 → 15:00)
                if (!string.IsNullOrEmpty(inputVao))
                {
                    if (int.TryParse(inputVao, out int hVao) && hVao >= 0 && hVao <= 23)
                        inputVao = hVao.ToString("00") + ":00";
                    else if (!inputVao.Contains(":"))
                        inputVao += ":00";
                }

                if (!string.IsNullOrEmpty(inputRa))
                {
                    if (int.TryParse(inputRa, out int hRa) && hRa >= 0 && hRa <= 23)
                        inputRa = hRa.ToString("00") + ":00";
                    else if (!inputRa.Contains(":"))
                        inputRa += ":00";
                }

                if (!TimeSpan.TryParse(inputVao, out TimeSpan gioVao) ||
                    !TimeSpan.TryParse(inputRa, out TimeSpan gioRa))
                {
                    MessageBox.Show("Giờ không hợp lệ! Nhập số từ 0-23 hoặc định dạng HH:mm",
                                    "Lỗi giờ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (gioRa <= gioVao)
                {
                    MessageBox.Show("Giờ ra phải lớn hơn giờ vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double soGio = Math.Round((gioRa - gioVao).TotalHours, 1);
                var nv = (NhanVien)cboNhanVien.SelectedItem;

                var chamCongMoi = new ChamCong
                {
                    MaNV = nv.MaNV,
                    HoTen = nv.HoTen,
                    LoaiNhanVien = cboLoaiNV.Text,
                    NgayLam = dtpNgayLam.Value.Date,
                    GioVao = gioVao,
                    GioRa = gioRa,
                    SoGio = soGio
                };

                dsChamCong.Add(chamCongMoi);

                // Lưu vào XML
                var root = new XElement("DanhSachChamCong",
                    dsChamCong.Select(c => new XElement("ChamCong",
                        new XElement("MaNV", c.MaNV),
                        new XElement("HoTen", c.HoTen),
                        new XElement("LoaiNhanVien", c.LoaiNhanVien),
                        new XElement("NgayLam", c.NgayLam.ToString("yyyy-MM-dd")),
                        new XElement("GioVao", c.GioVao.ToString(@"hh\:mm")),
                        new XElement("GioRa", c.GioRa.ToString(@"hh\:mm")),
                        new XElement("SoGio", c.SoGio)
                    ))
                );

                Directory.CreateDirectory(Path.GetDirectoryName(fileChamCong));
                new XDocument(new XDeclaration("1.0", "utf-8", "yes"), root).Save(fileChamCong);

                MessageBox.Show($"Đã chấm công thành công cho {nv.HoTen}!\nLàm {soGio} giờ",
                                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadChamCong();           // Đọc lại dữ liệu từ file
                HienThiBangChamCong(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("LỖI: " + ex.Message + "\n" + ex.StackTrace,
                                "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Làm mới form
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void LamMoiForm()
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            cboLoaiNV.SelectedIndex = -1;
        }

        // Khi click vào dòng trong DataGridView để lấy dữ liệu lên form

        private void Form_NhanVien_Load(object sender, EventArgs e)
        {

        }

        private void dgvChamCong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}