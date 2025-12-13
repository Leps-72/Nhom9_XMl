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

namespace QuanLyQuanCaPhe
{
    public partial class Form_ThongKeNgay : Form
    {
        HoaDonDAL hoaDonDAL = new HoaDonDAL();
        public Form_ThongKeNgay()
        {
            InitializeComponent();
        }
        private void Form_ThongKeNgay_Load(object sender, EventArgs e)
        {
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
            dgvDoanhThu.EnableHeadersVisualStyles = false;
            dgvDoanhThu.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 12, FontStyle.Bold);

            dgvDoanhThu.ColumnHeadersDefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            dgvDoanhThu.ColumnHeadersHeight = 40;

            // ===== GIÃN FULL CỘT =====
            dgvDoanhThu.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

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

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                MessageBox.Show("Từ ngày không được lớn hơn đến ngày!", "Lỗi");
                return;
            }

            LoadData();
        }
    }
}
