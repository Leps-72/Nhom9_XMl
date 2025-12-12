using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using QuanLyQuanCaPhe.DAL;
using QuanLyQuanCaPhe.Helper;
using QuanLyQuanCaPhe.Models;

namespace QuanLyQuanCaPhe.GUI
{
    public partial class Form_HoaDon : Form
    {
        private readonly HoaDonDAL _dal = new HoaDonDAL();

        private string _maHD = "";
        private List<ChiTietHoaDon> _ct = new List<ChiTietHoaDon>();

        public Form_HoaDon()
        {
            InitializeComponent();

            Load += Form_HoaDon_Load;
            btnXacNhan.Click += btnXacNhan_Click;
            btnDong.Click += (s, e) => Close();

            txtGiamGia.TextChanged += (s, e) => TinhThanhTien();
            cboHinhThuc.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        // Form khác (order) truyền danh sách món trực tiếp
        public void SetChiTietFromOrder(IEnumerable<(string maMon, string tenMon, int soLuong, decimal donGia)> items)
        {
            _ct = items.Select(x => new ChiTietHoaDon
            {
                MaMon = x.maMon,
                TenMon = x.tenMon,
                SoLuong = x.soLuong,
                DonGia = x.donGia,
                ThanhTien = x.soLuong * x.donGia
            }).ToList();

            BindGrid();
            TinhTongTien();
            TinhThanhTien();
        }

        private void Form_HoaDon_Load(object sender, EventArgs e)
        {
            cboHinhThuc.Items.Clear();
            cboHinhThuc.Items.Add("Tiền mặt");
            cboHinhThuc.Items.Add("Chuyển khoản");
            cboHinhThuc.Items.Add("Thẻ");
            if (cboHinhThuc.Items.Count > 0) cboHinhThuc.SelectedIndex = 0;

            SetupGrid();

            _maHD = Utility.NextMaHD();
            Text = $"Form_HoaDon - {_maHD}";
        }

        private void SetupGrid()
        {
            dgvChiTietHD.AutoGenerateColumns = false;
            dgvChiTietHD.AllowUserToAddRows = false;
            dgvChiTietHD.AllowUserToDeleteRows = false;
            dgvChiTietHD.ReadOnly = true;
            dgvChiTietHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietHD.MultiSelect = false;
            dgvChiTietHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvChiTietHD.Columns.Clear();

            dgvChiTietHD.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "MaMon",
                HeaderText = "Mã món",
                DataPropertyName = "MaMon",
                FillWeight = 15
            });
            dgvChiTietHD.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TenMon",
                HeaderText = "Tên món",
                DataPropertyName = "TenMon",
                FillWeight = 40
            });
            dgvChiTietHD.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SoLuong",
                HeaderText = "Số lượng",
                DataPropertyName = "SoLuong",
                FillWeight = 12
            });
            dgvChiTietHD.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DonGia",
                HeaderText = "Đơn giá",
                DataPropertyName = "DonGia",
                FillWeight = 16,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });
            dgvChiTietHD.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ThanhTien",
                HeaderText = "Thành tiền",
                DataPropertyName = "ThanhTien",
                FillWeight = 17,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" }
            });
        }

        private void BindGrid()
        {
            dgvChiTietHD.DataSource = null;
            dgvChiTietHD.DataSource = _ct.Select(x => new
            {
                x.MaMon,
                x.TenMon,
                x.SoLuong,
                DonGia = x.DonGia,
                ThanhTien = x.ThanhTien
            }).ToList();
        }

        private void TinhTongTien()
        {
            decimal tong = _ct.Sum(x => x.ThanhTien);
            txtTongTien.Text = tong.ToString("N0", CultureInfo.InvariantCulture);
        }

        private void TinhThanhTien()
        {
            decimal tong = Utility.SafeDecimal(txtTongTien.Text);
            decimal giam = Utility.SafeDecimal(txtGiamGia.Text);
            if (giam < 0) giam = 0;
            if (giam > 100) giam = 100;

            decimal thanh = tong - (tong * giam / 100m);
            if (thanh < 0) thanh = 0;

            txtThanhTien.Text = thanh.ToString("N0", CultureInfo.InvariantCulture);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (_ct.Count == 0)
            {
                MessageBox.Show("Chưa có món trong hóa đơn.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboHinhThuc.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn hình thức thanh toán.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TinhTongTien();
            TinhThanhTien();

            var ok = MessageBox.Show("Xác nhận lưu hóa đơn?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ok != DialogResult.Yes) return;

            var hd = new HoaDon
            {
                MaHD = _maHD,
                NgayLap = DateTime.Now,
                TongTien = Utility.SafeDecimal(txtTongTien.Text),
                GiamGiaPercent = Utility.SafeDecimal(txtGiamGia.Text),
                ThanhTien = Utility.SafeDecimal(txtThanhTien.Text),
                HinhThucThanhToan = Utility.NormalizePayment(cboHinhThuc.Text)
            };

            foreach (var ct in _ct) ct.MaHD = _maHD;

            _dal.SaveHoaDon(hd, _ct);

            MessageBox.Show($"Lưu thành công! Mã HĐ: {_maHD}", "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnXacNhan.Enabled = false;
            Text = $"Form_HoaDon - {_maHD} (Đã lưu)";
        }
    }
}
