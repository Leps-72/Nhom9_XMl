using QuanLyQuanCaPhe.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyQuanCaPhe.GUI
{
    public partial class Form_ThongKeMon : Form
    {
        private DataGridView dgvThongKeMon;
        private Chart chartMon;
        private ChiTietHoaDonDAL dal = new ChiTietHoaDonDAL();
        public Form_ThongKeMon()
        {
            InitializeComponent();
            InitializeForm();
            for (int i = 1; i <= 12; i++)
                cboThang.Items.Add(i);

            cboNam.Items.Add(2025);
            this.Load += Form_ThongKeMon_Load;
            this.BackgroundImage = Properties.Resources.background6;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }
        private void Form_ThongKeMon_Load(object sender, EventArgs e)
        {
            // Set giá trị mặc định là tháng và năm hiện tại
            cboThang.SelectedItem = DateTime.Today.Month;
            cboNam.SelectedItem = DateTime.Today.Year;

            // Gắn event
            cboThang.SelectedIndexChanged += (s, e) => LoadDataTheoThangNam();
            cboNam.SelectedIndexChanged += (s, e) => LoadDataTheoThangNam();

            // Load dữ liệu mặc định
            LoadDataTheoThangNam();
        }

        private void InitializeForm()
        {
            this.Text = "Thống kê món bán";
            this.Size = new Size(1264, 550);

            int padding = 10;       // khoảng cách ngang & giữa 2 control
            int topPadding = 200;    // khoảng cách từ top
            int totalParts = 2 + 5; // tỷ lệ 2:5
            int clientWidth = this.ClientSize.Width - 3 * padding; // tổng chiều rộng trừ padding

            int dgvWidth = clientWidth * 2 / totalParts;
            int chartWidth = clientWidth * 5 / totalParts;
            int controlHeight = this.ClientSize.Height - topPadding - 2 * padding; // giảm chiều cao để có padding top

            // ===== DataGridView (bên trái) =====
            dgvThongKeMon = new DataGridView
            {
                Location = new Point(padding, topPadding),
                Size = new Size(dgvWidth, controlHeight),
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false
            };
            this.Controls.Add(dgvThongKeMon);

            // ===== Chart (bên phải) =====
            chartMon = new Chart
            {
                Location = new Point(dgvWidth + 2 * padding, topPadding),
                Size = new Size(chartWidth, controlHeight)
            };
            this.Controls.Add(chartMon);
        }
        private void LoadDataTheoThangNam()
        {
            int thang = (int)cboThang.SelectedItem;
            int nam = (int)cboNam.SelectedItem;

            // Lấy toàn bộ chi tiết hóa đơn
            var chiTietList = dal.ThongKeTheoMonFull(); // List<ChiTietHoaDon> có MaHD, TenMon, SoLuong, ThanhTien

            // Lấy toàn bộ hóa đơn
            var hoaDonDAL = new HoaDonDAL();
            var hoaDonList = hoaDonDAL.GetAllHoaDon(); // List<HoaDon> có MaHD + NgayLap

            // Join ChiTiet + HoaDon để lấy NgayLap theo tháng/năm
            var data = (from ct in chiTietList
                        join hd in hoaDonList on ct.MaHD equals hd.MaHD
                        where hd.NgayLap.Month == thang && hd.NgayLap.Year == nam
                        group ct by ct.TenMon into g
                        select new
                        {
                            TenMon = g.Key,
                            TongSoLuong = g.Sum(x => x.SoLuong),
                            TongDoanhThu = g.Sum(x => x.ThanhTien)
                        }).ToList();

            // Bind DataGridView
            dgvThongKeMon.DataSource = data;
            dgvThongKeMon.Columns["TenMon"].HeaderText = "Tên món";
            dgvThongKeMon.Columns["TongSoLuong"].HeaderText = "Số lượng";
            dgvThongKeMon.Columns["TongDoanhThu"].HeaderText = "Doanh thu";
            dgvThongKeMon.Columns["TongDoanhThu"].DefaultCellStyle.Format = "N0";
            // ===== HEADER =====
            dgvThongKeMon.EnableHeadersVisualStyles = false;
            dgvThongKeMon.ColumnHeadersDefaultCellStyle.BackColor = Color.RoyalBlue;     // nâu cà phê
            dgvThongKeMon.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvThongKeMon.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 8, FontStyle.Bold);
            dgvThongKeMon.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvThongKeMon.ColumnHeadersHeight = 40;
            dgvThongKeMon.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvThongKeMon.RowHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;

            // ===== GIÃN FULL CỘT =====
            dgvThongKeMon.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            // ===== BODY =====
            dgvThongKeMon.BackgroundColor = Color.White;
            dgvThongKeMon.GridColor = Color.LightGray;

            dgvThongKeMon.DefaultCellStyle.BackColor = Color.White;
            dgvThongKeMon.DefaultCellStyle.ForeColor = Color.Black;
            dgvThongKeMon.DefaultCellStyle.SelectionBackColor =
                Color.SkyBlue;
            dgvThongKeMon.DefaultCellStyle.SelectionForeColor = Color.Black;

            // ===== DÒNG XEN KẼ (đẹp hơn) =====
            dgvThongKeMon.AlternatingRowsDefaultCellStyle.BackColor =
                Color.LightBlue;

            // ===== DÒNG (ROW) =====
            dgvThongKeMon.DefaultCellStyle.Font =
                new Font("Segoe UI", 8);

            dgvThongKeMon.RowTemplate.Height = 36;
            dgvThongKeMon.RowsDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // ===== READ ONLY + ĐẸP =====
            dgvThongKeMon.ReadOnly = true;
            dgvThongKeMon.AllowUserToAddRows = false;
            dgvThongKeMon.AllowUserToResizeRows = false;

            // Bind Chart
            chartMon.Series.Clear();
            chartMon.ChartAreas.Clear();
            chartMon.Legends.Clear();

            ChartArea area = new ChartArea("ChartArea1");
            area.AxisX.Interval = 1;
            area.AxisX.LabelStyle.Angle = -45;
            chartMon.ChartAreas.Add(area);

            // Kiểm tra dữ liệu trước khi vẽ series
            if (data != null && data.Count > 0)
            {
                Legend legend = new Legend("Legend1");
                chartMon.Legends.Add(legend);

                Series series = new Series("Doanh thu")
                {
                    ChartType = SeriesChartType.Column,
                    IsValueShownAsLabel = true,
                    Font = new Font("Segoe UI", 7, FontStyle.Bold),
                    LegendText = "Doanh thu theo món"
                };

                foreach (var item in data)
                {
                    series.Points.AddXY(item.TenMon, item.TongDoanhThu);
                }

                chartMon.Series.Add(series);
            }

        }

    }
}
