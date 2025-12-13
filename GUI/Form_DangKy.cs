using QuanLyQuanCaPhe.DAL;     // Để sử dụng NhanVienDAL
using QuanLyQuanCaPhe.Helper;
using QuanLyQuanCaPhe.Models;  // Để sử dụng Class NhanVien
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

namespace QuanLyQuanCaPhe.GUI
{
    public partial class Form_DangKy : Form
    {
        private NhanVienDAL nvDAL = new NhanVienDAL();

        public Form_DangKy()
        {
            InitializeComponent();

            // GẮN SỰ KIỆN CHO CẢ 3 TEXTBOX TRONG CONSTRUCTOR

            // Họ và Tên
            txtHoTen.GotFocus += txt_Enter;
            txtHoTen.LostFocus += txt_Leave;

            // Tên đăng nhập
            txtTenDangNhap.GotFocus += txt_Enter;
            txtTenDangNhap.LostFocus += txt_Leave;

            // Mật khẩu
            txtMatKhau.GotFocus += txtMatKhau_Enter;
            txtMatKhau.LostFocus += txtMatKhau_Leave;
            this.AcceptButton = btnDangKy;
        }

        // --- CODE XỬ LÝ PLACEHOLDER TỔNG QUÁT CHO HỌ TÊN VÀ TÊN DN ---

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            // Kiểm tra xem text hiện tại có phải là placeholder không
            if (tb.Text == "Họ và Tên" || tb.Text == "Tên đăng nhập")
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;
            }
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            // Nếu trường trống khi thoát focus, đặt lại placeholder
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                if (tb.Name == "txtHoTen")
                {
                    tb.Text = "Họ và Tên";
                }
                else if (tb.Name == "txtTenDangNhap")
                {
                    tb.Text = "Tên đăng nhập";
                }
                tb.ForeColor = Color.Gray;
            }
        }

        // --- CODE XỬ LÝ PLACEHOLDER RIÊNG CHO MẬT KHẨU (Có PasswordChar) ---

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
                // BẬT PasswordChar khi người dùng bắt đầu nhập
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                txtMatKhau.Text = "Mật khẩu";
                txtMatKhau.ForeColor = Color.Gray;
                // TẮT PasswordChar khi hiển thị placeholder
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void Form_DangKy_Load(object sender, EventArgs e)
        {

            this.DoubleBuffered = true; // chống giật
            this.Paint += Form_DangNhap_Paint;
            PictureBox picUser = new PictureBox
            {
                Image = Properties.Resources.expresso,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(70, 70),
                Location = new Point(170, 10),
                BackColor= Color.Transparent
            };
            this.Controls.Add(picUser);
            picUser.SendToBack();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Định nghĩa các hằng số placeholder
            const string PL_HOTEN = "Họ và Tên";
            const string PL_TEN_DN = "Tên đăng nhập";
            const string PL_MAT_KHAU = "Mật khẩu";

            // Lấy dữ liệu
            string hoTen = txtHoTen.Text.Trim();
            string tenDN = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            // 1. KIỂM TRA PLACEHOLDER VÀ RỖNG
            if (hoTen == PL_HOTEN || string.IsNullOrEmpty(hoTen) ||
                tenDN == PL_TEN_DN || string.IsNullOrEmpty(tenDN) ||
                matKhau == PL_MAT_KHAU || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin vào các trường.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. TẠO ĐỐI TƯỢNG NHANVIEN VÀ MÃ HÓA MẬT KHẨU
                NhanVien newNV = new NhanVien
                {
                    HoTen = hoTen,
                    TenDangNhap = tenDN,
                    // 🚨 MÃ HÓA MẬT KHẨU BẰNG Utility.MaHoaMD5
                    MatKhau = Utility.MaHoaMD5(matKhau),
                    QuyenTruyCap = "BanHang", // Quyền mặc định cho người tự đăng ký
                    NgayVaoLam = DateTime.Now
                };

                // 3. GỌI HÀM THÊM MỚI TỪ DAL (Sẽ ghi vào NhanVien.xml)
                if (nvDAL.ThemNhanVien(newNV))
                {
                    // Đăng ký thành công
                    MessageBox.Show($"Đăng ký tài khoản thành công!\nTên đăng nhập: {newNV.TenDangNhap}\nMã NV: {newNV.MaNV}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Đóng form sau khi thành công
                }
                else
                {
                    // Đăng ký thất bại (Lỗi thường gặp là Tên đăng nhập đã tồn tại)
                    MessageBox.Show("Lỗi: Tên đăng nhập đã tồn tại trong hệ thống. Vui lòng chọn tên khác.", "Lỗi Đăng ký", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi ngoại lệ (ví dụ: không tìm thấy file XML, lỗi đọc/ghi)
                MessageBox.Show("Lỗi hệ thống khi thực hiện đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form_DangNhap_Paint(object sender, PaintEventArgs e)
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
    }
}
