namespace QuanLyQuanCaPhe.GUI
{
    partial class Form_Chinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            heThongToolStripMenuItem = new ToolStripMenuItem();
            quanLyToolStripMenuItem = new ToolStripMenuItem();
            nhanVienToolStripMenuItem = new ToolStripMenuItem();
            banToolStripMenuItem = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            banHangToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            thongKeToolStripMenuItem = new ToolStripMenuItem();
            doanhThuNgayToolStripMenuItem = new ToolStripMenuItem();
            doanhThuMonToolStripMenuItem = new ToolStripMenuItem();
            doanhThuNhanVienToolStripMenuItem = new ToolStripMenuItem();
            congCuToolStripMenuItem = new ToolStripMenuItem();
            doiMatKhauToolStripMenuItem = new ToolStripMenuItem();
            saoLưuPhụcHồiDữLiệuToolStripMenuItem = new ToolStripMenuItem();
            dangXuatToolStripMenuItem = new ToolStripMenuItem();
            thoatToolStripMenuItem = new ToolStripMenuItem();
            troGiupToolStripMenuItem = new ToolStripMenuItem();
            giớiThiệuToolStripMenuItem = new ToolStripMenuItem();
            thôngTinPhầnMềmToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            panel1 = new Panel();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Black;
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { heThongToolStripMenuItem, quanLyToolStripMenuItem, banHangToolStripMenuItem, thongKeToolStripMenuItem, congCuToolStripMenuItem, troGiupToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(0);
            menuStrip1.Size = new Size(1182, 27);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // heThongToolStripMenuItem
            // 
            heThongToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            heThongToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            heThongToolStripMenuItem.Size = new Size(103, 27);
            heThongToolStripMenuItem.Text = "Trang chủ";
            heThongToolStripMenuItem.Click += heThongToolStripMenuItem_Click;
            // 
            // quanLyToolStripMenuItem
            // 
            quanLyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nhanVienToolStripMenuItem, banToolStripMenuItem, danhMụcToolStripMenuItem });
            quanLyToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            quanLyToolStripMenuItem.Size = new Size(85, 27);
            quanLyToolStripMenuItem.Text = "Quản lý";
            // 
            // nhanVienToolStripMenuItem
            // 
            nhanVienToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            nhanVienToolStripMenuItem.ForeColor = SystemColors.ControlText;
            nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            nhanVienToolStripMenuItem.Size = new Size(255, 26);
            nhanVienToolStripMenuItem.Text = "Nhân viên";
            nhanVienToolStripMenuItem.Click += nhanVienToolStripMenuItem_Click;
            // 
            // banToolStripMenuItem
            // 
            banToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            banToolStripMenuItem.ForeColor = SystemColors.ControlText;
            banToolStripMenuItem.Name = "banToolStripMenuItem";
            banToolStripMenuItem.Size = new Size(255, 26);
            banToolStripMenuItem.Text = "Bàn";
            banToolStripMenuItem.Click += banToolStripMenuItem_Click;
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(255, 26);
            danhMụcToolStripMenuItem.Text = "Danh mục và Sản phẩm";
            danhMụcToolStripMenuItem.Click += danhMụcToolStripMenuItem_Click;
            // 
            // banHangToolStripMenuItem
            // 
            banHangToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { orderToolStripMenuItem });
            banHangToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            banHangToolStripMenuItem.Name = "banHangToolStripMenuItem";
            banHangToolStripMenuItem.Size = new Size(99, 27);
            banHangToolStripMenuItem.Text = "Bán hàng";
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(224, 26);
            orderToolStripMenuItem.Text = "Order";
            orderToolStripMenuItem.Click += orderToolStripMenuItem_Click;
            // 
            // thongKeToolStripMenuItem
            // 
            thongKeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doanhThuNgayToolStripMenuItem, doanhThuMonToolStripMenuItem, doanhThuNhanVienToolStripMenuItem });
            thongKeToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            thongKeToolStripMenuItem.Name = "thongKeToolStripMenuItem";
            thongKeToolStripMenuItem.Size = new Size(99, 27);
            thongKeToolStripMenuItem.Text = "Thống kê";
            // 
            // doanhThuNgayToolStripMenuItem
            // 
            doanhThuNgayToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            doanhThuNgayToolStripMenuItem.Name = "doanhThuNgayToolStripMenuItem";
            doanhThuNgayToolStripMenuItem.Size = new Size(269, 26);
            doanhThuNgayToolStripMenuItem.Text = "Doanh thu theo ngày";
            doanhThuNgayToolStripMenuItem.Click += doanhThuNgayToolStripMenuItem_Click;
            // 
            // doanhThuMonToolStripMenuItem
            // 
            doanhThuMonToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            doanhThuMonToolStripMenuItem.Name = "doanhThuMonToolStripMenuItem";
            doanhThuMonToolStripMenuItem.Size = new Size(269, 26);
            doanhThuMonToolStripMenuItem.Text = "Doanh thu theo món";
            doanhThuMonToolStripMenuItem.Click += doanhThuMonToolStripMenuItem_Click;
            // 
            // doanhThuNhanVienToolStripMenuItem
            // 
            doanhThuNhanVienToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            doanhThuNhanVienToolStripMenuItem.Name = "doanhThuNhanVienToolStripMenuItem";
            doanhThuNhanVienToolStripMenuItem.Size = new Size(269, 26);
            doanhThuNhanVienToolStripMenuItem.Text = "Tính tiền lương nhân viên";
            doanhThuNhanVienToolStripMenuItem.Click += doanhThuNhanVienToolStripMenuItem_Click;
            // 
            // congCuToolStripMenuItem
            // 
            congCuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doiMatKhauToolStripMenuItem, saoLưuPhụcHồiDữLiệuToolStripMenuItem, dangXuatToolStripMenuItem, thoatToolStripMenuItem });
            congCuToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            congCuToolStripMenuItem.Name = "congCuToolStripMenuItem";
            congCuToolStripMenuItem.Size = new Size(89, 27);
            congCuToolStripMenuItem.Text = "Công cụ";
            congCuToolStripMenuItem.Click += côngCụToolStripMenuItem_Click;
            // 
            // doiMatKhauToolStripMenuItem
            // 
            doiMatKhauToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            doiMatKhauToolStripMenuItem.Size = new Size(224, 26);
            doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // saoLưuPhụcHồiDữLiệuToolStripMenuItem
            // 
            saoLưuPhụcHồiDữLiệuToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            saoLưuPhụcHồiDữLiệuToolStripMenuItem.Name = "saoLưuPhụcHồiDữLiệuToolStripMenuItem";
            saoLưuPhụcHồiDữLiệuToolStripMenuItem.Size = new Size(224, 26);
            saoLưuPhụcHồiDữLiệuToolStripMenuItem.Text = "Phục hồi dữ liệu";
            // 
            // dangXuatToolStripMenuItem
            // 
            dangXuatToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            dangXuatToolStripMenuItem.Name = "dangXuatToolStripMenuItem";
            dangXuatToolStripMenuItem.Size = new Size(224, 26);
            dangXuatToolStripMenuItem.Text = "Đăng xuất";
            dangXuatToolStripMenuItem.Click += dangXuatToolStripMenuItem_Click;
            // 
            // thoatToolStripMenuItem
            // 
            thoatToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            thoatToolStripMenuItem.Size = new Size(224, 26);
            thoatToolStripMenuItem.Text = "Thoát";
            thoatToolStripMenuItem.Click += thoatToolStripMenuItem_Click_1;
            // 
            // troGiupToolStripMenuItem
            // 
            troGiupToolStripMenuItem.BackColor = Color.Black;
            troGiupToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { giớiThiệuToolStripMenuItem, thôngTinPhầnMềmToolStripMenuItem });
            troGiupToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            troGiupToolStripMenuItem.Name = "troGiupToolStripMenuItem";
            troGiupToolStripMenuItem.Size = new Size(93, 27);
            troGiupToolStripMenuItem.Text = "Trợ giúp";
            // 
            // giớiThiệuToolStripMenuItem
            // 
            giớiThiệuToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            giớiThiệuToolStripMenuItem.Size = new Size(236, 26);
            giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            // 
            // thôngTinPhầnMềmToolStripMenuItem
            // 
            thôngTinPhầnMềmToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            thôngTinPhầnMềmToolStripMenuItem.Name = "thôngTinPhầnMềmToolStripMenuItem";
            thôngTinPhầnMềmToolStripMenuItem.Size = new Size(236, 26);
            thôngTinPhầnMềmToolStripMenuItem.Text = "Thông tin phần mềm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(414, 71);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Location = new Point(0, 501);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1182, 24);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(1182, 526);
            panel1.TabIndex = 1;
            // 
            // Form_Chinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bautroi;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1182, 553);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form_Chinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Chinh";
            Load += Form_Chinh_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem heThongToolStripMenuItem;
        private ToolStripMenuItem quanLyToolStripMenuItem;
        private ToolStripMenuItem nhanVienToolStripMenuItem;
        private ToolStripMenuItem banToolStripMenuItem;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem banHangToolStripMenuItem;
        private ToolStripMenuItem thongKeToolStripMenuItem;
        private ToolStripMenuItem congCuToolStripMenuItem;
        private ToolStripMenuItem troGiupToolStripMenuItem;
        private ToolStripMenuItem doanhThuNgayToolStripMenuItem;
        private ToolStripMenuItem doanhThuMonToolStripMenuItem;
        private ToolStripMenuItem doanhThuNhanVienToolStripMenuItem;
        private ToolStripMenuItem doiMatKhauToolStripMenuItem;
        private ToolStripMenuItem saoLưuPhụcHồiDữLiệuToolStripMenuItem;
        private ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private ToolStripMenuItem thôngTinPhầnMềmToolStripMenuItem;

        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem orderToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem dangXuatToolStripMenuItem;
        private ToolStripMenuItem thoatToolStripMenuItem;
    }
}