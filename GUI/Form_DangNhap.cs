using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Windows.Forms;
using System.Drawing;
using QuanLyQuanCaPhe.DAL;
using QuanLyQuanCaPhe.Helper;
using QuanLyQuanCaPhe.Models;

namespace QuanLyQuanCaPhe.GUI
{
    public partial class Form_DangNhap : Form
    {
        private NhanVienDAL nvDAL = new NhanVienDAL();
        public Form_Chinh formChinhInstance; // thêm dòng này thêm vào đầu class
        public Form_DangNhap()
        {
            InitializeComponent();

            // Gắn sự kiện cho txtTenDangNhap
            txtTenDangNhap.GotFocus += txtTenDangNhap_Enter;
            txtTenDangNhap.LostFocus += txtTenDangNhap_Leave;

            // Gắn sự kiện cho txtMatKhau
            txtMatKhau.GotFocus += txtMatKhau_Enter;
            txtMatKhau.LostFocus += txtMatKhau_Leave;
        }
        private void txtTenDangNhap_Enter(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Tên đăng nhập")
            {
                txtTenDangNhap.Text = "";
                txtTenDangNhap.ForeColor = Color.Black; // Chuyển sang màu đen khi nhập
            }
        }

        // Khi thoát khỏi Tên đăng nhập (LostFocus)
        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                txtTenDangNhap.Text = "Tên đăng nhập";
                txtTenDangNhap.ForeColor = Color.Gray; // Chuyển sang màu xám
            }
        }
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

        // Khi thoát khỏi Mật khẩu (LostFocus)
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

        private void Form_DangNhap_Load(object sender, EventArgs e)
        {

        }
        private void lnkDangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // 1. Đặt trạng thái đã ghé thăm (tùy chọn)
            lnkDangKy.LinkVisited = true;

            // 2. Mở Form Đăng ký dưới dạng Dialog
            // Dùng ShowDialog() để người dùng tập trung hoàn thành đăng ký hoặc hủy bỏ trước khi tiếp tục
            Form_DangKy fDangKy = new Form_DangKy();
            fDangKy.ShowDialog();

            // 3. (Tùy chọn) Sau khi đóng Form Đăng ký, làm mới form Đăng nhập
            // Ví dụ: Xóa các trường Tên đăng nhập/Mật khẩu cũ nếu có
            txtTenDangNhap.Text = "Tên đăng nhập";
            txtMatKhau.Text = "Mật khẩu";
            txtTenDangNhap.ForeColor = System.Drawing.Color.Gray;
            txtMatKhau.ForeColor = System.Drawing.Color.Gray;
            txtMatKhau.PasswordChar = '\0';
        }
        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu và kiểm tra Placeholder Text
            string tenDN = txtTenDangNhap.Text.Trim();
            string matKhauNhap = txtMatKhau.Text.Trim();

            const string PLACEHOLDER_TEN_DN = "Tên đăng nhập";
            const string PLACEHOLDER_MAT_KHAU = "Mật khẩu";

            // Kiểm tra xem người dùng có nhập dữ liệu hay chỉ là Placeholder Text
            if (tenDN == PLACEHOLDER_TEN_DN || string.IsNullOrEmpty(tenDN) ||
                matKhauNhap == PLACEHOLDER_MAT_KHAU || string.IsNullOrEmpty(matKhauNhap))
            {
                MessageBox.Show("Vui lòng nhập Tên đăng nhập và Mật khẩu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. Mã hóa mật khẩu nhập vào (Sử dụng Utility.MaHoaMD5)
                string matKhauDaMaHoa = Utility.MaHoaMD5(matKhauNhap);

                // 3. Gọi hàm kiểm tra đăng nhập từ lớp DAL
                // Hàm này sẽ load NhanVien.xml và so sánh Tên DN + Mật khẩu đã mã hóa
                NhanVien user = nvDAL.KiemTraDangNhap(tenDN, matKhauDaMaHoa);

                if (user != null)
                {
                    // Đăng nhập thành công
                    MessageBox.Show($"Đăng nhập thành công! Quyền: {user.QuyenTruyCap}.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Mở Form chính và truyền quyền truy cập
                    Form_Chinh formChinh = new Form_Chinh(
                     tenDN,           // tên đăng nhập
                     user.HoTen,      // họ tên nhân viên
                     user.QuyenTruyCap // quyền: QuanLy hoặc BanHang
                    );

                    formChinh.Show();
                }
                else
                {
                    // Đăng nhập thất bại
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng. Vui lòng thử lại.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu file XML không đọc được, sai định dạng, hoặc các lỗi khác
                MessageBox.Show("Lỗi trong quá trình xử lý đăng nhập: " + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
