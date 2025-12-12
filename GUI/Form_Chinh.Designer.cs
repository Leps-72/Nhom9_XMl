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
            dangNhapToolStripMenuItem = new ToolStripMenuItem();
            dangKyToolStripMenuItem = new ToolStripMenuItem();
            thoatToolStripMenuItem = new ToolStripMenuItem();
            quanLyToolStripMenuItem = new ToolStripMenuItem();
            nhanVienToolStripMenuItem = new ToolStripMenuItem();
            banToolStripMenuItem = new ToolStripMenuItem();
            khuVucToolStripMenuItem = new ToolStripMenuItem();
            danhMụcToolStripMenuItem = new ToolStripMenuItem();
            banHangToolStripMenuItem = new ToolStripMenuItem();
            banHangFormToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            thongKeToolStripMenuItem = new ToolStripMenuItem();
            doanhThuNgayToolStripMenuItem = new ToolStripMenuItem();
            doanhThuMonToolStripMenuItem = new ToolStripMenuItem();
            doanhThuNhanVienToolStripMenuItem = new ToolStripMenuItem();
            congCuToolStripMenuItem = new ToolStripMenuItem();
            doiMatKhauToolStripMenuItem = new ToolStripMenuItem();
            saoLưuPhụcHồiDữLiệuToolStripMenuItem = new ToolStripMenuItem();
            troGiupToolStripMenuItem = new ToolStripMenuItem();
            giớiThiệuToolStripMenuItem = new ToolStripMenuItem();
            thôngTinPhầnMềmToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { heThongToolStripMenuItem, quanLyToolStripMenuItem, banHangToolStripMenuItem, thongKeToolStripMenuItem, congCuToolStripMenuItem, troGiupToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1182, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // heThongToolStripMenuItem
            // 
            heThongToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dangNhapToolStripMenuItem, dangKyToolStripMenuItem, thoatToolStripMenuItem });
            heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            heThongToolStripMenuItem.Size = new Size(85, 24);
            heThongToolStripMenuItem.Text = "Hệ thống";
            // 
            // dangNhapToolStripMenuItem
            // 
            dangNhapToolStripMenuItem.Name = "dangNhapToolStripMenuItem";
            dangNhapToolStripMenuItem.Size = new Size(224, 26);
            dangNhapToolStripMenuItem.Text = "Đăng nhập";
            dangNhapToolStripMenuItem.Click += dangNhapToolStripMenuItem_Click;
            // 
            // dangKyToolStripMenuItem
            // 
            dangKyToolStripMenuItem.Name = "dangKyToolStripMenuItem";
            dangKyToolStripMenuItem.Size = new Size(224, 26);
            dangKyToolStripMenuItem.Text = "Đăng ký";
            dangKyToolStripMenuItem.Click += dangKyToolStripMenuItem_Click;
            // 
            // thoatToolStripMenuItem
            // 
            thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            thoatToolStripMenuItem.Size = new Size(224, 26);
            thoatToolStripMenuItem.Text = "Thoát";
            thoatToolStripMenuItem.Click += thoatToolStripMenuItem_Click;
            // 
            // quanLyToolStripMenuItem
            // 
            quanLyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nhanVienToolStripMenuItem, banToolStripMenuItem, khuVucToolStripMenuItem, danhMụcToolStripMenuItem });
            quanLyToolStripMenuItem.Name = "quanLyToolStripMenuItem";
            quanLyToolStripMenuItem.Size = new Size(73, 24);
            quanLyToolStripMenuItem.Text = "Quản lý";
            // 
            // nhanVienToolStripMenuItem
            // 
            nhanVienToolStripMenuItem.Name = "nhanVienToolStripMenuItem";
            nhanVienToolStripMenuItem.Size = new Size(235, 26);
            nhanVienToolStripMenuItem.Text = "Nhân viên";
            nhanVienToolStripMenuItem.Click += nhanVienToolStripMenuItem_Click;
            // 
            // banToolStripMenuItem
            // 
            banToolStripMenuItem.Name = "banToolStripMenuItem";
            banToolStripMenuItem.Size = new Size(235, 26);
            banToolStripMenuItem.Text = "Bàn";
            // 
            // khuVucToolStripMenuItem
            // 
            khuVucToolStripMenuItem.Name = "khuVucToolStripMenuItem";
            khuVucToolStripMenuItem.Size = new Size(235, 26);
            khuVucToolStripMenuItem.Text = "Khu vực";
            // 
            // danhMụcToolStripMenuItem
            // 
            danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            danhMụcToolStripMenuItem.Size = new Size(235, 26);
            danhMụcToolStripMenuItem.Text = "Danh mục+Sản phẩm";
            danhMụcToolStripMenuItem.Click += danhMụcToolStripMenuItem_Click;
            // 
            // banHangToolStripMenuItem
            // 
            banHangToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { banHangFormToolStripMenuItem, orderToolStripMenuItem });
            banHangToolStripMenuItem.Name = "banHangToolStripMenuItem";
            banHangToolStripMenuItem.Size = new Size(85, 24);
            banHangToolStripMenuItem.Text = "Bán hàng";
            // 
            // banHangFormToolStripMenuItem
            // 
            banHangFormToolStripMenuItem.Name = "banHangFormToolStripMenuItem";
            banHangFormToolStripMenuItem.Size = new Size(224, 26);
            banHangFormToolStripMenuItem.Text = "Bàn bán hàng";
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(224, 26);
            orderToolStripMenuItem.Text = "Order";
            orderToolStripMenuItem.Click += orderToolStripMenuItem_Click;
            // 
            // thongKeToolStripMenuItem
            // 
            thongKeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doanhThuNgayToolStripMenuItem, doanhThuMonToolStripMenuItem, doanhThuNhanVienToolStripMenuItem });
            thongKeToolStripMenuItem.Name = "thongKeToolStripMenuItem";
            thongKeToolStripMenuItem.Size = new Size(84, 24);
            thongKeToolStripMenuItem.Text = "Thống kê";
            // 
            // doanhThuNgayToolStripMenuItem
            // 
            doanhThuNgayToolStripMenuItem.Name = "doanhThuNgayToolStripMenuItem";
            doanhThuNgayToolStripMenuItem.Size = new Size(259, 26);
            doanhThuNgayToolStripMenuItem.Text = "Doanh thu theo ngày";
            // 
            // doanhThuMonToolStripMenuItem
            // 
            doanhThuMonToolStripMenuItem.Name = "doanhThuMonToolStripMenuItem";
            doanhThuMonToolStripMenuItem.Size = new Size(259, 26);
            doanhThuMonToolStripMenuItem.Text = "Doanh thu theo món";
            // 
            // doanhThuNhanVienToolStripMenuItem
            // 
            doanhThuNhanVienToolStripMenuItem.Name = "doanhThuNhanVienToolStripMenuItem";
            doanhThuNhanVienToolStripMenuItem.Size = new Size(259, 26);
            doanhThuNhanVienToolStripMenuItem.Text = "Tính tiền lương nhân viên";
            doanhThuNhanVienToolStripMenuItem.Click += doanhThuNhanVienToolStripMenuItem_Click;
            // 
            // congCuToolStripMenuItem
            // 
            congCuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { doiMatKhauToolStripMenuItem, saoLưuPhụcHồiDữLiệuToolStripMenuItem });
            congCuToolStripMenuItem.Name = "congCuToolStripMenuItem";
            congCuToolStripMenuItem.Size = new Size(77, 24);
            congCuToolStripMenuItem.Text = "Công cụ";
            congCuToolStripMenuItem.Click += côngCụToolStripMenuItem_Click;
            // 
            // doiMatKhauToolStripMenuItem
            // 
            doiMatKhauToolStripMenuItem.Name = "doiMatKhauToolStripMenuItem";
            doiMatKhauToolStripMenuItem.Size = new Size(198, 26);
            doiMatKhauToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // saoLưuPhụcHồiDữLiệuToolStripMenuItem
            // 
            saoLưuPhụcHồiDữLiệuToolStripMenuItem.Name = "saoLưuPhụcHồiDữLiệuToolStripMenuItem";
            saoLưuPhụcHồiDữLiệuToolStripMenuItem.Size = new Size(198, 26);
            saoLưuPhụcHồiDữLiệuToolStripMenuItem.Text = "Phục hồi dữ liệu";
            // 
            // troGiupToolStripMenuItem
            // 
            troGiupToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { giớiThiệuToolStripMenuItem, thôngTinPhầnMềmToolStripMenuItem });
            troGiupToolStripMenuItem.Name = "troGiupToolStripMenuItem";
            troGiupToolStripMenuItem.Size = new Size(78, 24);
            troGiupToolStripMenuItem.Text = "Trợ giúp";
            // 
            // giớiThiệuToolStripMenuItem
            // 
            giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            giớiThiệuToolStripMenuItem.Size = new Size(230, 26);
            giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            // 
            // thôngTinPhầnMềmToolStripMenuItem
            // 
            thôngTinPhầnMềmToolStripMenuItem.Name = "thôngTinPhầnMềmToolStripMenuItem";
            thôngTinPhầnMềmToolStripMenuItem.Size = new Size(230, 26);
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
            // Form_Chinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1182, 553);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Form_Chinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Chinh";
            WindowState = FormWindowState.Maximized;
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
        private ToolStripMenuItem dangNhapToolStripMenuItem;
        private ToolStripMenuItem dangKyToolStripMenuItem;
        private ToolStripMenuItem thoatToolStripMenuItem;
        private ToolStripMenuItem nhanVienToolStripMenuItem;
        private ToolStripMenuItem banToolStripMenuItem;
        private ToolStripMenuItem khuVucToolStripMenuItem;
        private ToolStripMenuItem danhMụcToolStripMenuItem;
        private ToolStripMenuItem banHangToolStripMenuItem;
        private ToolStripMenuItem thongKeToolStripMenuItem;
        private ToolStripMenuItem congCuToolStripMenuItem;
        private ToolStripMenuItem troGiupToolStripMenuItem;
        private ToolStripMenuItem banHangFormToolStripMenuItem;
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
    }
}