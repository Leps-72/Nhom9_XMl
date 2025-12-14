using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace QuanLyQuanCaPhe.GUI
{
    public partial class Form_Ban : Form
    {
        // Thay chuỗi kết nối nếu bạn dùng server khác
        private string connectionString = "Server=CHAODAIKA\\THAITHANHTU2340;Database=QuanLyQuanCaPhe;User Id=sa;Password=12345;TrustServerCertificate=True;";

        public Form_Ban()
        {
            InitializeComponent();
            TaiDanhSachBan(); // Tự động load khi mở form
        }

        private void TaiDanhSachBan()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"SELECT MaBan, TenBan, KhuVuc, TrangThai, GhiChu FROM Ban ORDER BY MaBan";
                    SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvBan.DataSource = dt;

                    // Đặt lại tiêu đề cột tiếng Việt đẹp
                    dgvBan.Columns["MaBan"].HeaderText = "Mã bàn";
                    dgvBan.Columns["TenBan"].HeaderText = "Tên bàn";
                    dgvBan.Columns["KhuVuc"].HeaderText = "Khu vực";
                    dgvBan.Columns["TrangThai"].HeaderText = "Trạng thái";
                    dgvBan.Columns["GhiChu"].HeaderText = "Ghi chú";

                    // Tô màu trạng thái
                    foreach (DataGridViewRow row in dgvBan.Rows)
                    {
                        if (row.Cells["TrangThai"].Value != null)
                        {
                            string tt = row.Cells["TrangThai"].Value.ToString();
                            switch (tt)
                            {
                                case "Trống":
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(129, 199, 132);
                                    row.DefaultCellStyle.ForeColor = Color.White;
                                    break;
                                case "Đang phục vụ":
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 7);
                                    row.DefaultCellStyle.ForeColor = Color.Black;
                                    break;
                                case "Đã đặt trước":
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
                                    row.DefaultCellStyle.ForeColor = Color.White;
                                    break;
                                default:
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(239, 83, 80);
                                    row.DefaultCellStyle.ForeColor = Color.White;
                                    break;
                            }
                        }
                    }
                    dgvBan.CellPainting += dgv_CellPainting;
                    dgvBan.EnableHeadersVisualStyles = false;
                    dgvBan.ColumnHeadersDefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;

                    dgvBan.ColumnHeadersHeight = 40;
                    dgvBan.ColumnHeadersHeightSizeMode =
                        DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                    dgvBan.RowHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;

                    // ===== GIÃN FULL CỘT =====
                    dgvBan.AutoSizeColumnsMode =
                        DataGridViewAutoSizeColumnsMode.Fill;
                    // ===== BODY =====
                    dgvBan.BackgroundColor = Color.White;
                    dgvBan.GridColor = Color.LightGray;

                    dgvBan.DefaultCellStyle.BackColor = Color.White;
                    dgvBan.DefaultCellStyle.ForeColor = Color.Black;
                    dgvBan.DefaultCellStyle.SelectionBackColor =
                        Color.SkyBlue;
                    dgvBan.DefaultCellStyle.SelectionForeColor = Color.Black;

                    // ===== DÒNG XEN KẼ (đẹp hơn) =====
                    dgvBan.AlternatingRowsDefaultCellStyle.BackColor =
                        Color.LightBlue;

                    // ===== DÒNG (ROW) =====
                    dgvBan.DefaultCellStyle.Font =
                        new Font("Segoe UI", 8);

                    dgvBan.RowTemplate.Height = 36;
                    dgvBan.RowsDefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleCenter;

                    // ===== READ ONLY + ĐẸP =====
                    dgvBan.ReadOnly = true;
                    dgvBan.AllowUserToAddRows = false;
                    dgvBan.AllowUserToResizeRows = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Khi click chọn dòng trong DataGridView → điền vào các ô nhập liệu
        private void dgvBan_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBan.CurrentRow != null)
            {
                txtMaBan.Text = dgvBan.CurrentRow.Cells["MaBan"].Value?.ToString() ?? "";
                txtTenBan.Text = dgvBan.CurrentRow.Cells["TenBan"].Value?.ToString() ?? "";
                txtKhuVuc.Text = dgvBan.CurrentRow.Cells["KhuVuc"].Value?.ToString() ?? "";
                cboTrangThai.Text = dgvBan.CurrentRow.Cells["TrangThai"].Value?.ToString() ?? "Trống";
                txtGhiChu.Text = dgvBan.CurrentRow.Cells["GhiChu"].Value?.ToString() ?? "";

                // Không cho sửa mã bàn
                txtMaBan.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        // Nút Thêm mới
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBan.Text) || string.IsNullOrWhiteSpace(txtTenBan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã bàn và Tên bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"INSERT INTO Ban (MaBan, TenBan, KhuVuc, TrangThai, GhiChu)
                                   VALUES (@MaBan, @TenBan, @KhuVuc, @TrangThai, @GhiChu)";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaBan", txtMaBan.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenBan", txtTenBan.Text.Trim());
                    cmd.Parameters.AddWithValue("@KhuVuc", string.IsNullOrWhiteSpace(txtKhuVuc.Text) ? (object)DBNull.Value : txtKhuVuc.Text.Trim());
                    cmd.Parameters.AddWithValue("@TrangThai", cboTrangThai.Text);
                    cmd.Parameters.AddWithValue("@GhiChu", string.IsNullOrWhiteSpace(txtGhiChu.Text) ? (object)DBNull.Value : txtGhiChu.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Thêm bàn thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TaiDanhSachBan();
                    LamMoiForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Nút Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBan.Text))
            {
                MessageBox.Show("Chọn bàn cần sửa!", "Thông báo");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"UPDATE Ban SET 
                                   TenBan = @TenBan, 
                                   KhuVuc = @KhuVuc, 
                                   TrangThai = @TrangThai, 
                                   GhiChu = @GhiChu 
                                   WHERE MaBan = @MaBan";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@MaBan", txtMaBan.Text);
                    cmd.Parameters.AddWithValue("@TenBan", txtTenBan.Text.Trim());
                    cmd.Parameters.AddWithValue("@KhuVuc", string.IsNullOrWhiteSpace(txtKhuVuc.Text) ? (object)DBNull.Value : txtKhuVuc.Text.Trim());
                    cmd.Parameters.AddWithValue("@TrangThai", cboTrangThai.Text);
                    cmd.Parameters.AddWithValue("@GhiChu", string.IsNullOrWhiteSpace(txtGhiChu.Text) ? (object)DBNull.Value : txtGhiChu.Text.Trim());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công!", "Thành công");
                    TaiDanhSachBan();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaBan.Text))
            {
                MessageBox.Show("Chọn bàn cần xóa!");
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa bàn \"{txtTenBan.Text}\" không?", "Xác nhận xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Ban WHERE MaBan = @MaBan", conn);
                        cmd.Parameters.AddWithValue("@MaBan", txtMaBan.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa thành công!");
                        TaiDanhSachBan();
                        LamMoiForm();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa bàn đang có hóa đơn hoặc lỗi: " + ex.Message);
                }
            }
        }

        // Nút Làm mới (để thêm bàn mới)
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LamMoiForm();
        }

        private void LamMoiForm()
        {
            txtMaBan.Clear();
            txtTenBan.Clear();
            txtKhuVuc.Clear();
            txtGhiChu.Clear();
            cboTrangThai.SelectedIndex = 0;

            txtMaBan.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            dgvBan.ClearSelection();
        }

        // Đừng quên gắn sự kiện cho các nút trong Designer hoặc ở đây cũng được
        private void Form_Ban_Load(object sender, EventArgs e)
        {
            // Nếu bạn chưa gắn sự kiện trong Designer thì gắn ở đây
            dgvBan.SelectionChanged += dgvBan_SelectionChanged;
            btnThem.Click += btnThem_Click;
            btnSua.Click += btnSua_Click;
            btnXoa.Click += btnXoa_Click;
            btnLamMoi.Click += btnLamMoi_Click;
        }

        private void dgvBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Chỉ vẽ header cột
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(
                    e.CellBounds,
                    Color.Black,   // màu trên
                    Color.FromArgb(0, 150, 136),    // màu dưới
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
                    new Font("Segoe UI", 9, FontStyle.Bold),
                    e.CellBounds,
                    Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );

                e.Handled = true;
            }
        }
    }
}