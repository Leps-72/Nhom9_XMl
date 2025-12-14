using QuanLyQuanCaPhe.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyQuanCaPhe
{
    public partial class Form_ThongKeNgay : Form
    {
        HoaDonDAL hoaDonDAL = new HoaDonDAL();
        public Form_ThongKeNgay()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.BackgroundImage = Properties.Resources.background7;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void Form_ThongKeNgay_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            dtpTuNgay.Value = DateTime.Today;
            dtpDenNgay.Value = DateTime.Today;
            LoadData();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            var list = hoaDonDAL.GetHoaDonByDate(dtpTuNgay.Value, dtpDenNgay.Value);

            var data = list
                .GroupBy(hd => hd.NgayLap.Date)
                .Select(g => new
                {
                    Ngay = g.Key.ToString("dd/MM/yyyy"),
                    SoHoaDon = g.Count(),
                    DoanhThu = g.Sum(x => x.ThanhTien)
                })
                .ToList();

            dgvDoanhThu.DataSource = data;

            dgvDoanhThu.Columns["Ngay"].HeaderText = "Ngày";
            dgvDoanhThu.Columns["SoHoaDon"].HeaderText = "Số hóa đơn";
            dgvDoanhThu.Columns["DoanhThu"].HeaderText = "Doanh thu";

            decimal tong = data.Sum(x => x.DoanhThu);
            txtTongDoanhThu.Text = tong.ToString("N0") + " VNĐ";
            // ===== HEADER =====
            dgvDoanhThu.CellPainting += dgv_CellPainting1;
            dgvDoanhThu.EnableHeadersVisualStyles = false;
            dgvDoanhThu.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvDoanhThu.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvDoanhThu.ColumnHeadersHeight = 40;
            dgvDoanhThu.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDoanhThu.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(230, 215, 200);

            // ===== GIÃN FULL CỘT =====
            dgvDoanhThu.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            // ===== BODY =====
            dgvDoanhThu.BackgroundColor = Color.White;
            dgvDoanhThu.GridColor = Color.LightGray;

            dgvDoanhThu.DefaultCellStyle.BackColor = Color.White;
            dgvDoanhThu.DefaultCellStyle.ForeColor = Color.Black;
            dgvDoanhThu.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(220, 200, 180);
            dgvDoanhThu.DefaultCellStyle.SelectionForeColor = Color.Black;

            // ===== DÒNG XEN KẼ (đẹp hơn) =====
            dgvDoanhThu.AlternatingRowsDefaultCellStyle.BackColor =
                Color.FromArgb(250, 245, 240);

            // ===== DÒNG (ROW) =====
            dgvDoanhThu.DefaultCellStyle.Font =
                new Font("Segoe UI", 11);

            dgvDoanhThu.RowTemplate.Height = 36;
            dgvDoanhThu.RowsDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // ===== READ ONLY + ĐẸP =====
            dgvDoanhThu.ReadOnly = true;
            dgvDoanhThu.AllowUserToAddRows = false;
            dgvDoanhThu.AllowUserToResizeRows = false;

        }

        private void dgv_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                MessageBox.Show("Từ ngày không được lớn hơn đến ngày!", "Lỗi");
                return;
            }

            LoadData();
        }

        private void txtTongDoanhThu_Click(object sender, EventArgs e)
        {

        }
        private void dgv_CellPainting1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Chỉ vẽ header cột
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    e.CellBounds,
                    Color.FromArgb(92, 64, 51),   // màu trên
                    Color.FromArgb(170, 140, 120),    // màu dưới
                    LinearGradientMode.Horizontal))
                {
                    e.Graphics.FillRectangle(brush, e.CellBounds);
                }

                // Vẽ viền
                using (Pen pen = new Pen(Color.White))
                {
                    e.Graphics.DrawRectangle(pen, e.CellBounds);
                }
                TextRenderer.DrawText(
                    e.Graphics,
                    e.FormattedValue.ToString(),
                    new Font("Segoe UI", 12, FontStyle.Bold),
                    e.CellBounds,
                    Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
                e.Handled = true;
            }
        }
    }
}
