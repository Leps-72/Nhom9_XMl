using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using QuanLyQuanCaPhe.DAL;
using QuanLyQuanCaPhe.Models;

namespace QuanLyQuanCaPhe.GUI
{
    public partial class Form_BanHang : Form
    {
        private readonly MonDAL _monDal = new MonDAL();
        private readonly DanhMucDAL _dmDal = new DanhMucDAL();

        private Dictionary<string, string> _mapMaDM_TenDM = new(); // MaDM -> TenDM
        private List<Mon> _allMon = new();
        private List<OrderItem> _order = new();

        public Form_BanHang()
        {
            InitializeComponent();

            Load += Form_BanHang_Load;

            cboDanhMuc.SelectedIndexChanged += (s, e) => ApplyFilterMon();
            txtTimMon.TextChanged += (s, e) => ApplyFilterMon();

            dgvMon.CellDoubleClick += dgvMon_CellDoubleClick;

            dgvOrder.CellEndEdit += dgvOrder_CellEndEdit;
            dgvOrder.DataError += (s, e) => { e.ThrowException = false; };

            btnLamMoi.Click += (s, e) => LamMoiOrder();
            btnXoaMon.Click += (s, e) => XoaMonDangChon();

            btnHuyOrder.Click += (s, e) => HuyOrder();
            btnDong.Click += (s, e) => Close();

            btnThanhToan.Click += (s, e) => ThanhToan();
        }

        private void Form_BanHang_Load(object sender, EventArgs e)
        {
            txtNhanVien.ReadOnly = true;
            txtTongSoLuong.ReadOnly = true;
            txtTongTien.ReadOnly = true;

            cboDanhMuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBan.DropDownStyle = ComboBoxStyle.DropDownList;

            SetupDgvMon();
            SetupDgvOrder();
            SetupDgvFont();
            TuningDgvLayout();

            // ===== Load danh mục + map =====
            var dsDM = _dmDal.GetAll();
            _mapMaDM_TenDM = _dmDal.GetMapMaDM_TenDM();

            // Đổ cboDanhMuc theo TenDM
            var tenDMs = dsDM.Select(x => x.TenDM).Where(s => !string.IsNullOrWhiteSpace(s))
                             .Distinct().OrderBy(s => s).ToList();
            tenDMs.Insert(0, "Tất cả");
            cboDanhMuc.DataSource = tenDMs;

            // ===== Load món từ XML (Mon.xml đã dùng MaDM) =====
            _allMon = _monDal.GetAll();

            LoadBanDemo();              // vì bạn chưa có Ban.xml
            txtNhanVien.Text = "NV01";  // tạm (sau lấy từ đăng nhập)

            ApplyFilterMon();
            BindOrder();
            UpdateTong();
        }

        // ====== CỘT dgvMon ======
        private void SetupDgvMon()
        {
            dgvMon.AutoGenerateColumns = false;
            dgvMon.AllowUserToAddRows = false;
            dgvMon.ReadOnly = true;
            dgvMon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMon.MultiSelect = false;
            dgvMon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvMon.Columns.Clear();

            dgvMon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaMon",
                HeaderText = "Mã món",
                DataPropertyName = "MaMon",
                FillWeight = 15
            });

            dgvMon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenMon",
                HeaderText = "Tên món",
                DataPropertyName = "TenMon",
                FillWeight = 45
            });
            /*
            // ✅ Hiển thị tên danh mục cho dễ nhìn
            dgvMon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DanhMuc",
                HeaderText = "Danh mục",
                DataPropertyName = "DanhMuc",
                FillWeight = 20
            });*/

            dgvMon.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DonGia",
                HeaderText = "Đơn giá",
                DataPropertyName = "DonGia",
                FillWeight = 20,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
        }

        // ====== CỘT dgvOrder ======
        private void SetupDgvOrder()
        {
            dgvOrder.AutoGenerateColumns = false;
            dgvOrder.AllowUserToAddRows = false;
            dgvOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrder.MultiSelect = false;
            dgvOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvOrder.Columns.Clear();

            dgvOrder.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaMon",
                HeaderText = "Mã món",
                DataPropertyName = "MaMon",
                Visible = false
            });

            dgvOrder.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenMon",
                HeaderText = "Tên món",
                DataPropertyName = "TenMon",
                FillWeight = 45,
                ReadOnly = true
            });

            dgvOrder.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoLuong",
                HeaderText = "SL",
                DataPropertyName = "SoLuong",
                FillWeight = 12
            });

            dgvOrder.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DonGia",
                HeaderText = "Đơn giá",
                DataPropertyName = "DonGia",
                FillWeight = 18,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dgvOrder.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ThanhTien",
                HeaderText = "Thành tiền",
                DataPropertyName = "ThanhTien",
                FillWeight = 25,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    Format = "N0",
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });
        }

        private void SetupDgvFont()
        {
            dgvMon.EnableHeadersVisualStyles = false;
            dgvMon.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvMon.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvMon.RowTemplate.Height = 32;

            dgvOrder.EnableHeadersVisualStyles = false;
            dgvOrder.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvOrder.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvOrder.RowTemplate.Height = 32;
        }

        // ====== Bàn demo (chưa có Ban.xml) ======
        private void LoadBanDemo()
        {
            cboBan.Items.Clear();
            cboBan.Items.Add("B01");
            cboBan.Items.Add("B02");
            cboBan.Items.Add("B03");
            if (cboBan.Items.Count > 0) cboBan.SelectedIndex = 0;
        }

        // ====== Lọc món theo danh mục + tìm ======
        private void ApplyFilterMon()
        {
            string tenDM = cboDanhMuc.Text?.Trim() ?? "Tất cả";
            string key = (txtTimMon.Text ?? "").Trim().ToLower();

            var q = _allMon.AsEnumerable();

            // lọc theo danh mục: TenDM -> MaDM
            if (tenDM != "Tất cả")
            {
                string maDM = _mapMaDM_TenDM.FirstOrDefault(kv => kv.Value == tenDM).Key;
                if (!string.IsNullOrWhiteSpace(maDM))
                    q = q.Where(m => m.MaDM == maDM);
                else
                    q = Enumerable.Empty<Mon>();
            }

            if (!string.IsNullOrWhiteSpace(key))
                q = q.Where(m =>
                    (m.TenMon ?? "").ToLower().Contains(key) ||
                    (m.MaMon ?? "").ToLower().Contains(key));

            dgvMon.DataSource = q.Select(m => new { m.MaMon, m.TenMon, m.DonGia }).ToList();
        }

        // ====== Double click món -> thêm vào order ======
        private void dgvMon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var maMon = dgvMon.Rows[e.RowIndex].Cells["MaMon"].Value?.ToString() ?? "";
            if (string.IsNullOrWhiteSpace(maMon)) return;

            var mon = _allMon.FirstOrDefault(x => x.MaMon == maMon);
            if (mon == null) return;

            var exist = _order.FirstOrDefault(x => x.MaMon == mon.MaMon);
            if (exist != null)
            {
                exist.SoLuong += 1;
            }
            else
            {
                _order.Add(new OrderItem
                {
                    MaMon = mon.MaMon,
                    TenMon = mon.TenMon,
                    SoLuong = 1,
                    DonGia = mon.DonGia
                });
            }

            BindOrder();
            UpdateTong();
        }

        // ====== Sửa SL trong dgvOrder -> cập nhật ======
        private void dgvOrder_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvOrder.Columns[e.ColumnIndex].Name != "SoLuong") return;

            var maMon = dgvOrder.Rows[e.RowIndex].Cells["MaMon"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(maMon)) return;

            var item = _order.FirstOrDefault(x => x.MaMon == maMon);
            if (item == null) return;

            int sl = 1;
            var cellVal = dgvOrder.Rows[e.RowIndex].Cells["SoLuong"].Value?.ToString();
            if (!int.TryParse(cellVal, out sl) || sl < 1) sl = 1;

            item.SoLuong = sl;

            BindOrder();
            UpdateTong();
        }

        private void BindOrder()
        {
            dgvOrder.DataSource = null;
            dgvOrder.DataSource = _order.Select(x => new
            {
                x.MaMon,
                x.TenMon,
                x.SoLuong,
                DonGia = x.DonGia,
                ThanhTien = x.ThanhTien
            }).ToList();
        }

        // ====== Tính tổng ======
        private void UpdateTong()
        {
            int tongSL = _order.Sum(x => x.SoLuong);
            decimal tongTien = _order.Sum(x => x.ThanhTien);

            txtTongSoLuong.Text = tongSL.ToString();
            txtTongTien.Text = tongTien.ToString("N0", CultureInfo.InvariantCulture);
        }

        // ====== Xóa món đang chọn ======
        private void XoaMonDangChon()
        {
            if (dgvOrder.CurrentRow == null) return;

            var maMon = dgvOrder.CurrentRow.Cells["MaMon"].Value?.ToString();
            if (string.IsNullOrWhiteSpace(maMon)) return;

            _order.RemoveAll(x => x.MaMon == maMon);

            BindOrder();
            UpdateTong();
        }

        // ====== Làm mới order (xóa hết món) ======
        private void LamMoiOrder()
        {
            _order.Clear();
            BindOrder();
            UpdateTong();
        }

        // ====== Hủy order ======
        private void HuyOrder()
        {
            var ok = MessageBox.Show("Bạn muốn hủy toàn bộ order?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok != DialogResult.Yes) return;

            LamMoiOrder();
        }

        // ====== Thanh toán -> mở Form_HoaDon và truyền list món ======
        private void ThanhToan()
        {
            if (_order.Count == 0)
            {
                MessageBox.Show("Chưa có món để thanh toán.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboBan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn bàn.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var list = _order.Select(x => (x.MaMon, x.TenMon, x.SoLuong, x.DonGia)).ToList();

            var f = new Form_HoaDon();
            f.SetChiTietFromOrder(list);
            f.ShowDialog();
        }
        private void TuningDgvLayout()
        {
            // ===== dgvMon =====
            dgvMon.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvMon.ColumnHeadersHeight = 36;
            dgvMon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dgvMon.Columns["MaMon"].FillWeight = 30;
            dgvMon.Columns["TenMon"].FillWeight = 45;
            dgvMon.Columns["DonGia"].FillWeight = 35;

            // ===== dgvOrder =====
            dgvOrder.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dgvOrder.ColumnHeadersHeight = 36;
            dgvOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            dgvOrder.Columns["TenMon"].FillWeight = 40;
            dgvOrder.Columns["SoLuong"].FillWeight = 15;
            dgvOrder.Columns["DonGia"].FillWeight = 20;
            dgvOrder.Columns["ThanhTien"].FillWeight = 25;
        }
    }
}
