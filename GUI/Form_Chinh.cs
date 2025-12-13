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
using System.Drawing;
using System.Windows.Forms;
using QuanLyQuanCaPhe.GUI; // sửa nếu namespace khác

namespace QuanLyQuanCaPhe.GUI
{
    public partial class Form_Chinh : Form
    {
        private string userName;      // Tên đăng nhập
        private string hoTen;         // Họ tên nhân viên
        private string userRole;      // Quyền: "QuanLy" hoặc "BanHang"

        private Panel panelNoiDung;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel lblUser;
        private ToolStripStatusLabel lblTime;

        // Constructor nhận đủ thông tin từ Form Đăng nhập
        public Form_Chinh(string tenDangNhap, string hoTenNhanVien, string quyen)
        {
            InitializeComponent();
            this.userName = tenDangNhap;
            this.hoTen = hoTenNhanVien;
            this.userRole = quyen;

            TaoGiaoDienChinh();
            //PhanQuyenMenu();
            CapNhatStatusBar();
        }

        private void TaoGiaoDienChinh()
        {
            // Form chính
            this.Text = "QUẢN LÝ QUÁN CÀ PHÊ - WELCOME";
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(245, 242, 237); // màu kem cà phê nhẹ
            this.IsMdiContainer = true;

            // Panel chứa các form con
            panelNoiDung = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            this.Controls.Add(panelNoiDung);

            // StatusStrip dưới cùng
            statusStrip = new StatusStrip();
            lblUser = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            lblTime.Alignment = ToolStripItemAlignment.Right;

            statusStrip.Items.Add(lblUser);
            statusStrip.Items.Add(new ToolStripStatusLabel { Spring = true });
            statusStrip.Items.Add(lblTime);
            this.Controls.Add(statusStrip);

            // Timer cập nhật giờ
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 1000 };
            timer.Tick += (s, e) => lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            timer.Start();
        }

        private void CapNhatStatusBar()
        {
            lblUser.Text = $"Người dùng: {hoTen} ({userName}) - Quyền: {(userRole == "QuanLy" ? "Quản Lý" : "Bán Hàng")}";
        }

        // ẨN/HIỆN MENU THEO QUYỀN
        private void PhanQuyenMenu()
        {
            // Nếu không phải Quản lý → ẩn các menu nhạy cảm
            if (userRole != "QuanLy")
            {
                quanLyToolStripMenuItem.Visible = false;     // toàn bộ menu Quản lý
                thongKeToolStripMenuItem.Visible = false;    // Thống kê
                saoLưuPhụcHồiDữLiệuToolStripMenuItem.Visible = false; // Sao lưu
            }
        }

        // HÀM MỞ FORM CON (đẹp, không bị chồng form)
        private void MoFormCon(Form formCon)
        {
            // Đóng form cũ nếu có
            foreach (Form f in panelNoiDung.Controls.OfType<Form>().ToList())
            {
                f.Close();
                f.Dispose();
            }

            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;
            formCon.BackColor = Color.White;

            panelNoiDung.Controls.Add(formCon);
            formCon.Show();
            formCon.BringToFront();
        }

        // ==================== CÁC SỰ KIỆN MENU ====================

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                new Form_DangNhap().Show(); // quay lại form đăng nhập
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát phần mềm?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Ví dụ các menu con
        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new Form_NhanVien());
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new Form_QuanLySanPhamDanhMuc());
        }

        private void bànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new Form_Ban());
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new Form_BanHang()); // màn hình order chính
        }

        private void doanhThuTheoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new Form_ThongKeNgay());
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "PHẦN MỀM QUẢN LÝ QUÁN CÀ PHÊ\n" +
                "Phiên bản 1.0 - 2025\n" +
                "Nhóm thực hiện: [Tên bạn & các thành viên]\n" +
                "Chúc quán luôn đông khách!",
                "Giới thiệu",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void côngCụToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form_Chinh_Load(object sender, EventArgs e)
        {

        }


        private void dangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DangNhap f = new Form_DangNhap();
            f.ShowDialog(); // mở kiểu modal, phải đóng mới dùng tiếp được

            // Nếu đăng nhập thành công → cập nhật lại thông tin trên status bar
            // (Bạn sẽ thêm sau khi làm xong phần đăng nhập)
        }
        private void dangKyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_DangKy f = new Form_DangKy();
            f.ShowDialog(); // mở modal, tập trung đăng ký
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát phần mềm?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void doanhThuNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_NhanVien frm = new Form_NhanVien();
            frm.TopLevel = false;                    // BẮT BUỘC
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            // Xóa hết form con cũ
            panelNoiDung.Controls.Clear();           // ← panelNoiDung là Panel bạn để ở giữa Form_Chinh

            panelNoiDung.Controls.Add(frm);
            frm.Show();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_BanHang f = new Form_BanHang();
            f.FormClosed += (s, args) =>
            {
                this.Show();
            };
            f.Show();
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_QuanLySanPhamDanhMuc f = new Form_QuanLySanPhamDanhMuc();
            f.Show();
        }

        private void banToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem Form_Ban đã mở chưa, nếu có rồi thì focus lên
            Form_Ban frm = Application.OpenForms.OfType<Form_Ban>().FirstOrDefault();
            if (frm != null)
            {
                frm.BringToFront();
                frm.WindowState = FormWindowState.Normal;
                return;
            }

            // Nếu chưa mở thì mở mới
            frm = new Form_Ban
            {
                StartPosition = FormStartPosition.CenterScreen,
                WindowState = FormWindowState.Normal
            };
            frm.Show(); // hoặc frm.ShowDialog() nếu muốn modal
        }
    }
}