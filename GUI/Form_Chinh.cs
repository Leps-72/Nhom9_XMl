using QuanLyQuanCaPhe.GUI; // sửa nếu namespace khác
using QuanLyQuanCaPhe.Helper;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;

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
            this.BackgroundImage = Properties.Resources.bautroi;

            // Dòng này làm ảnh full form, đẹp nhất (thử từng cái nếu cần)
            this.BackgroundImageLayout = ImageLayout.Stretch;
            InitializeComponent();
            this.userName = tenDangNhap;
            this.hoTen = hoTenNhanVien;
            this.userRole = quyen;

            SetActiveMenu(heThongToolStripMenuItem);
            TaoGiaoDienChinh();
            //PhanQuyenMenu();
            CapNhatStatusBar();
        }
        private void TaoGiaoDienChinh()
        {
            // Form chính
            this.Text = "QUẢN LÝ QUÁN CÀ PHÊ - WELCOME";
            this.BackColor = Color.FromArgb(245, 242, 237);

            // ❌ KHÔNG DÙNG MDI
            // this.IsMdiContainer = true;

            // ===== MENUSTRIP (đã có trong Designer) =====
            menuStrip1.Dock = DockStyle.Top;
            menuStrip1.BringToFront();
            //menuStrip1.Renderer = new MenuStripFullBorderRenderer(); làm border mà k cần rồi


            // ===== STATUS STRIP =====
            statusStrip = new StatusStrip
            {
                Dock = DockStyle.Bottom
            };

            lblUser = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel
            {
                Alignment = ToolStripItemAlignment.Right
            };

            statusStrip.Items.Add(lblUser);
            statusStrip.Items.Add(new ToolStripStatusLabel { Spring = true });
            statusStrip.Items.Add(lblTime);

            this.Controls.Add(statusStrip);

            // ===== PANEL NỘI DUNG (QUAN TRỌNG NHẤT) =====
            panelNoiDung = new Panel
            {
                Dock = DockStyle.Fill,
                BackgroundImage = Properties.Resources.background,
                BackgroundImageLayout = ImageLayout.Stretch
            };

            this.Controls.Add(panelNoiDung);
            panelNoiDung.BringToFront();   // 🔴 BẮT BUỘC

            // ===== TIMER =====
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
            this.BackgroundImage = Properties.Resources.bautroi;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void doanhThuNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new Form_TinhLuong());
            SetActiveMenu(thongKeToolStripMenuItem);
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
            SetActiveMenu(quanLyToolStripMenuItem);
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_BanHang f = new Form_BanHang();
            f.Show();
            SetActiveMenu(banHangToolStripMenuItem);
        }

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_QuanLySanPhamDanhMuc f = new Form_QuanLySanPhamDanhMuc();
            f.Show();
            SetActiveMenu(quanLyToolStripMenuItem);
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
            SetActiveMenu(quanLyToolStripMenuItem);
        }

        private void doanhThuMonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new Form_ThongKeMon());
            SetActiveMenu(thongKeToolStripMenuItem);
        }

        private void doanhThuNgayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MoFormCon(new Form_ThongKeNgay());
            SetActiveMenu(thongKeToolStripMenuItem);
            
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                new Form_DangNhap().Show(); // quay lại form đăng nhập
            }
        }

        private void thoatToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thoát phần mềm?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void heThongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelNoiDung.Controls.Clear();
            SetActiveMenu(heThongToolStripMenuItem);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void SetActiveMenu(ToolStripMenuItem activeItem)
        {
            foreach (ToolStripMenuItem item in menuStrip1.Items)
            {
                item.BackColor = Color.Black;
                item.ForeColor = Color.FromArgb(224, 224, 224); 
            }

            activeItem.BackColor = Color.FromArgb(224, 224, 224); 
            activeItem.ForeColor = Color.Black;     
        }

    }
}