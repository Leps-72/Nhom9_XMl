using QuanLyQuanCaPhe.DAL;
using QuanLyQuanCaPhe.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace QuanLyQuanCaPhe
{
    public partial class Form_QuanLySanPhamDanhMuc : Form
    {
        private readonly MonDAL _monDal = new MonDAL();
        private readonly DanhMucDAL _dmDal = new DanhMucDAL();

        private List<Mon> _mons = new();
        private List<DanhMuc> _dms = new();
        private Dictionary<string, string> _mapDM = new();

        private bool _spIsAdding = false;
        private bool _dmIsAdding = false;
        public Form_QuanLySanPhamDanhMuc()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            EnableDoubleBuffering(tabControl1);

            foreach (TabPage tab in tabControl1.TabPages)
            {
                EnableDoubleBuffering(tab);
            }

            Load += Form_Load;

            // SP events
            dgvSanPham.CellClick += (s, e) => FillSPFromGrid();
            btnLamMoiSP.Click += (s, e) => ResetSPForm();
            btnThemSP.Click += (s, e) => BeginAddSP();
            btnSuaSP.Click += (s, e) => BeginEditSP();
            btnXoaSP.Click += (s, e) => DeleteSP();
            btnLuuSP.Click += (s, e) => SaveSP();
            txtTimSP.TextChanged += (s, e) => BindSanPham();

            // DM events
            dgvDanhMuc.CellClick += (s, e) => FillDMFromGrid();
            btnLamMoiDM.Click += (s, e) => ResetDMForm();
            btnThemDM.Click += (s, e) => BeginAddDM();
            btnSuaDM.Click += (s, e) => BeginEditDM();
            btnXoaDM.Click += (s, e) => DeleteDM();
            btnLuuDM.Click += (s, e) => SaveDM();
            this.AcceptButton = btnTimSP;
            tabPage1.BackgroundImage = Properties.Resources.background5;
            tabPage1.BackgroundImageLayout = ImageLayout.Stretch;
            tabPage2.BackgroundImage = Properties.Resources.background5;
            tabPage2.BackgroundImageLayout = ImageLayout.Stretch;
            this.Paint += Form_Paint;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SetupGrid();
            ReloadAll();
            ResetSPForm();
            ResetDMForm();
            
        }

        private void SetupGrid()
        {
            // dgvSanPham
            dgvSanPham.AutoGenerateColumns = false;
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.ReadOnly = true;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.MultiSelect = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvSanPham.EnableHeadersVisualStyles = false;
            dgvSanPham.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvSanPham.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);
            dgvSanPham.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvSanPham.ColumnHeadersHeight = 36;

            dgvSanPham.Columns.Clear();
            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaMon", HeaderText = "Mã", DataPropertyName = "MaMon", FillWeight = 15 });
            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenMon", HeaderText = "Tên món", DataPropertyName = "TenMon", FillWeight = 45 });
            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn { Name = "DanhMuc", HeaderText = "Danh mục", DataPropertyName = "DanhMuc", FillWeight = 20 });
            dgvSanPham.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DonGia",
                HeaderText = "Đơn giá",
                DataPropertyName = "DonGia",
                FillWeight = 20,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
            });
            dgvSanPham.CellPainting += dgv_CellPainting;

            // ===== HEADER =====
            dgvSanPham.EnableHeadersVisualStyles = false;
            dgvSanPham.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvSanPham.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 8, FontStyle.Bold);
            dgvSanPham.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvSanPham.ColumnHeadersHeight = 40;
            dgvSanPham.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSanPham.RowHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;

            // ===== GIÃN FULL CỘT =====
            dgvSanPham.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            // ===== BODY =====
            dgvSanPham.BackgroundColor = Color.White;
            dgvSanPham.GridColor = Color.LightGray;

            dgvSanPham.DefaultCellStyle.BackColor = Color.White;
            dgvSanPham.DefaultCellStyle.ForeColor = Color.Black;
            dgvSanPham.DefaultCellStyle.SelectionBackColor =
                Color.SkyBlue;
            dgvSanPham.DefaultCellStyle.SelectionForeColor = Color.Black;

            // ===== DÒNG XEN KẼ (đẹp hơn) =====
            dgvSanPham.AlternatingRowsDefaultCellStyle.BackColor =
                Color.LightBlue;

            // ===== DÒNG (ROW) =====
            dgvSanPham.DefaultCellStyle.Font =
                new Font("Segoe UI", 8);

            dgvSanPham.RowTemplate.Height = 36;
            dgvSanPham.RowsDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // ===== READ ONLY + ĐẸP =====
            dgvSanPham.ReadOnly = true;
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToResizeRows = false;

            // dgvDanhMuc
            dgvDanhMuc.AutoGenerateColumns = false;
            dgvDanhMuc.AllowUserToAddRows = false;
            dgvDanhMuc.ReadOnly = true;
            dgvDanhMuc.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhMuc.MultiSelect = false;
            dgvDanhMuc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDanhMuc.EnableHeadersVisualStyles = false;
            dgvDanhMuc.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgvDanhMuc.DefaultCellStyle.Font = new Font("Segoe UI", 9.5f);
            dgvDanhMuc.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvDanhMuc.ColumnHeadersHeight = 36;

            dgvDanhMuc.Columns.Clear();
            dgvDanhMuc.Columns.Add(new DataGridViewTextBoxColumn { Name = "MaDM", HeaderText = "Mã DM", DataPropertyName = "MaDM", FillWeight = 20 });
            dgvDanhMuc.Columns.Add(new DataGridViewTextBoxColumn { Name = "TenDM", HeaderText = "Tên danh mục", DataPropertyName = "TenDM", FillWeight = 40 });
            dgvDanhMuc.Columns.Add(new DataGridViewTextBoxColumn { Name = "MoTa", HeaderText = "Mô tả", DataPropertyName = "MoTa", FillWeight = 40 });
            dgvDanhMuc.CellPainting += dgv_CellPainting;

            // ===== HEADER =====
            dgvDanhMuc.EnableHeadersVisualStyles = false;
            dgvDanhMuc.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvDanhMuc.ColumnHeadersHeight = 40;
            dgvDanhMuc.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDanhMuc.RowHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;

            // ===== GIÃN FULL CỘT =====
            dgvDanhMuc.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            // ===== BODY =====
            dgvDanhMuc.BackgroundColor = Color.White;
            dgvDanhMuc.GridColor = Color.LightGray;

            dgvDanhMuc.DefaultCellStyle.BackColor = Color.White;
            dgvDanhMuc.DefaultCellStyle.ForeColor = Color.Black;
            dgvDanhMuc.DefaultCellStyle.SelectionBackColor =
                Color.SkyBlue;
            dgvDanhMuc.DefaultCellStyle.SelectionForeColor = Color.Black;

            // ===== DÒNG XEN KẼ (đẹp hơn) =====
            dgvDanhMuc.AlternatingRowsDefaultCellStyle.BackColor =
                Color.LightBlue;

            // ===== DÒNG (ROW) =====
            dgvDanhMuc.DefaultCellStyle.Font =
                new Font("Segoe UI", 8);

            dgvDanhMuc.RowTemplate.Height = 36;
            dgvDanhMuc.RowsDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // ===== READ ONLY + ĐẸP =====
            dgvDanhMuc.ReadOnly = true;
            dgvDanhMuc.AllowUserToAddRows = false;
            dgvDanhMuc.AllowUserToResizeRows = false;
        }

        private void ReloadAll()
        {
            _dms = _dmDal.GetAll();
            _mapDM = _dmDal.GetMapMaDM_TenDM();
            _mons = _monDal.GetAll();

            // combo danh mục cho tab SP
            cboDanhMucSP.DataSource = null;
            cboDanhMucSP.DisplayMember = "TenDM";
            cboDanhMucSP.ValueMember = "MaDM";
            cboDanhMucSP.DataSource = _dms;

            BindDanhMuc();
            BindSanPham();
        }

        // ===================== BIND =====================
        private void BindSanPham()
        {
            string key = (txtTimSP.Text ?? "").Trim().ToLower();

            var q = _mons.AsEnumerable();
            if (!string.IsNullOrWhiteSpace(key))
                q = q.Where(m => (m.MaMon ?? "").ToLower().Contains(key) || (m.TenMon ?? "").ToLower().Contains(key));

            dgvSanPham.DataSource = q.Select(m => new
            {
                m.MaMon,
                m.TenMon,
                DanhMuc = _mapDM.ContainsKey(m.MaDM) ? _mapDM[m.MaDM] : m.MaDM,
                m.DonGia
            }).ToList();
        }

        private void BindDanhMuc()
        {
            dgvDanhMuc.DataSource = _dms.Select(d => new { d.MaDM, d.TenDM, d.MoTa }).ToList();
        }

        // ===================== SP CRUD =====================
        private void ResetSPForm()
        {
            _spIsAdding = false;
            txtMaMon.Text = "";
            txtTenMon.Text = "";
            txtDonGia.Text = "";
            if (cboDanhMucSP.Items.Count > 0) cboDanhMucSP.SelectedIndex = 0;

            txtMaMon.ReadOnly = true;
        }

        private void BeginAddSP()
        {
            _spIsAdding = true;
            txtMaMon.ReadOnly = false;
            txtMaMon.Text = "";
            txtTenMon.Text = "";
            txtDonGia.Text = "";
            txtMaMon.Focus();
        }

        private void BeginEditSP()
        {
            if (string.IsNullOrWhiteSpace(txtMaMon.Text))
            {
                MessageBox.Show("Chọn 1 sản phẩm để sửa.");
                return;
            }
            _spIsAdding = false;
            txtMaMon.ReadOnly = true;
        }

        private void FillSPFromGrid()
        {
            if (dgvSanPham.CurrentRow == null) return;
            txtMaMon.Text = dgvSanPham.CurrentRow.Cells["MaMon"].Value?.ToString() ?? "";
            txtTenMon.Text = dgvSanPham.CurrentRow.Cells["TenMon"].Value?.ToString() ?? "";
            txtDonGia.Text = dgvSanPham.CurrentRow.Cells["DonGia"].Value?.ToString() ?? "";

            // set combo theo tên DM
            var tenDM = dgvSanPham.CurrentRow.Cells["DanhMuc"].Value?.ToString() ?? "";
            var found = _dms.FirstOrDefault(x => x.TenDM == tenDM);
            if (found != null) cboDanhMucSP.SelectedValue = found.MaDM;

            txtMaMon.ReadOnly = true;
            _spIsAdding = false;
        }

        private void SaveSP()
        {
            string ma = (txtMaMon.Text ?? "").Trim();
            string ten = (txtTenMon.Text ?? "").Trim();
            string maDM = (cboDanhMucSP.SelectedValue?.ToString() ?? "").Trim();
            string donGiaText = (txtDonGia.Text ?? "").Trim();

            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(maDM))
            {
                MessageBox.Show("Vui lòng nhập Mã món, Tên món và chọn Danh mục.");
                return;
            }

            if (!decimal.TryParse(donGiaText, NumberStyles.Any, CultureInfo.InvariantCulture, out var dg) &&
                !decimal.TryParse(donGiaText, NumberStyles.Any, new CultureInfo("vi-VN"), out dg))
            {
                MessageBox.Show("Đơn giá không hợp lệ.");
                return;
            }

            var m = new Mon { MaMon = ma, TenMon = ten, MaDM = maDM, DonGia = dg };

            if (_spIsAdding)
            {
                if (_monDal.Exists(ma))
                {
                    MessageBox.Show("Mã món đã tồn tại.");
                    return;
                }
                _monDal.Add(m);
            }
            else
            {
                if (!_monDal.Update(m))
                {
                    MessageBox.Show("Không tìm thấy món để cập nhật.");
                    return;
                }
            }

            ReloadAll();
            // chọn lại dòng vừa lưu
            SelectRow(dgvSanPham, "MaMon", ma);
            FillSPFromGrid();
        }

        private void DeleteSP()
        {
            string ma = (txtMaMon.Text ?? "").Trim();
            if (string.IsNullOrWhiteSpace(ma))
            {
                MessageBox.Show("Chọn 1 sản phẩm để xóa.");
                return;
            }

            var ok = MessageBox.Show($"Xóa món {ma}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok != DialogResult.Yes) return;

            if (!_monDal.Delete(ma))
            {
                MessageBox.Show("Không tìm thấy món để xóa.");
                return;
            }

            ReloadAll();
            ResetSPForm();
        }

        // ===================== DM CRUD =====================
        private void ResetDMForm()
        {
            _dmIsAdding = false;
            txtMaDM.Text = "";
            txtTenDM.Text = "";
            txtMoTaDM.Text = "";
            txtMaDM.ReadOnly = true;
        }

        private void BeginAddDM()
        {
            _dmIsAdding = true;
            txtMaDM.ReadOnly = false;
            txtMaDM.Text = "";
            txtTenDM.Text = "";
            txtMoTaDM.Text = "";
            txtMaDM.Focus();
        }

        private void BeginEditDM()
        {
            if (string.IsNullOrWhiteSpace(txtMaDM.Text))
            {
                MessageBox.Show("Chọn 1 danh mục để sửa.");
                return;
            }
            _dmIsAdding = false;
            txtMaDM.ReadOnly = true;
        }

        private void FillDMFromGrid()
        {
            if (dgvDanhMuc.CurrentRow == null) return;
            txtMaDM.Text = dgvDanhMuc.CurrentRow.Cells["MaDM"].Value?.ToString() ?? "";
            txtTenDM.Text = dgvDanhMuc.CurrentRow.Cells["TenDM"].Value?.ToString() ?? "";
            txtMoTaDM.Text = dgvDanhMuc.CurrentRow.Cells["MoTa"].Value?.ToString() ?? "";

            txtMaDM.ReadOnly = true;
            _dmIsAdding = false;
        }

        private void SaveDM()
        {
            string ma = (txtMaDM.Text ?? "").Trim();
            string ten = (txtTenDM.Text ?? "").Trim();
            string mota = (txtMoTaDM.Text ?? "").Trim();

            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("Vui lòng nhập Mã DM và Tên DM.");
                return;
            }

            var dm = new DanhMuc { MaDM = ma, TenDM = ten, MoTa = mota };

            if (_dmIsAdding)
            {
                if (_dmDal.Exists(ma))
                {
                    MessageBox.Show("Mã danh mục đã tồn tại.");
                    return;
                }
                _dmDal.Add(dm);
            }
            else
            {
                if (!_dmDal.Update(dm))
                {
                    MessageBox.Show("Không tìm thấy danh mục để cập nhật.");
                    return;
                }
            }

            ReloadAll();
            SelectRow(dgvDanhMuc, "MaDM", ma);
            FillDMFromGrid();
        }

        private void DeleteDM()
        {
            string ma = (txtMaDM.Text ?? "").Trim();
            if (string.IsNullOrWhiteSpace(ma))
            {
                MessageBox.Show("Chọn 1 danh mục để xóa.");
                return;
            }

            // chặn xóa nếu còn món thuộc danh mục
            int used = _monDal.CountByMaDM(ma);
            if (used > 0)
            {
                MessageBox.Show($"Không thể xóa. Danh mục này đang có {used} món.");
                return;
            }

            var ok = MessageBox.Show($"Xóa danh mục {ma}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok != DialogResult.Yes) return;

            if (!_dmDal.Delete(ma))
            {
                MessageBox.Show("Không tìm thấy danh mục để xóa.");
                return;
            }

            ReloadAll();
            ResetDMForm();
        }

        // ===================== UTIL =====================
        private static void SelectRow(DataGridView dgv, string colName, string value)
        {
            foreach (DataGridViewRow r in dgv.Rows)
            {
                if ((r.Cells[colName].Value?.ToString() ?? "") == value)
                {
                    r.Selected = true;
                    dgv.CurrentCell = r.Cells[colName];
                    dgv.FirstDisplayedScrollingRowIndex = Math.Max(0, r.Index);
                    break;
                }
            }
        }
        private void Form_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = this.ClientRectangle;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(92, 64, 51),      // nâu cà phê đậm
                Color.FromArgb(245, 240, 230),   // kem sáng
                LinearGradientMode.Horizontal))    // trên → dưới
            {
                e.Graphics.FillRectangle(brush, rect);
            }
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
        private void EnableDoubleBuffering(Control control)
        {
            typeof(Control).InvokeMember(
                "DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null,
                control,
                new object[] { true });
        }


    }

}
