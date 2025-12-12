namespace QuanLyQuanCaPhe
{
    partial class Form_QuanLySanPhamDanhMuc
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
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            label5 = new Label();
            grbThongTinDM = new GroupBox();
            btnLuuDM = new Button();
            btnLamMoiDM = new Button();
            btnXoaDM = new Button();
            btnSuaDM = new Button();
            btnThemDM = new Button();
            txtMoTaDM = new TextBox();
            txtTenDM = new TextBox();
            txtMaDM = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            grbDanhSachDM = new GroupBox();
            dgvDanhMuc = new DataGridView();
            tabPage1 = new TabPage();
            label1 = new Label();
            grbThongTinSP = new GroupBox();
            btnTimSP = new Button();
            txtTimSP = new TextBox();
            label10 = new Label();
            cboDanhMucSP = new ComboBox();
            label9 = new Label();
            btnLuuSP = new Button();
            btnLamMoiSP = new Button();
            btnXoaSP = new Button();
            btnSuaSP = new Button();
            btnThemSP = new Button();
            txtDonGia = new TextBox();
            txtTenMon = new TextBox();
            txtMaMon = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            grbDanhSachSP = new GroupBox();
            dgvSanPham = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            grbThongTinDM.SuspendLayout();
            grbDanhSachDM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).BeginInit();
            tabPage1.SuspendLayout();
            grbThongTinSP.SuspendLayout();
            grbDanhSachSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1181, 557);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(grbThongTinDM);
            tabPage2.Controls.Add(grbDanhSachDM);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1173, 524);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Danh mục";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(407, 24);
            label5.Name = "label5";
            label5.Size = new Size(365, 46);
            label5.TabIndex = 6;
            label5.Text = "QUẢN LÝ DANH MỤC";
            // 
            // grbThongTinDM
            // 
            grbThongTinDM.Controls.Add(btnLuuDM);
            grbThongTinDM.Controls.Add(btnLamMoiDM);
            grbThongTinDM.Controls.Add(btnXoaDM);
            grbThongTinDM.Controls.Add(btnSuaDM);
            grbThongTinDM.Controls.Add(btnThemDM);
            grbThongTinDM.Controls.Add(txtMoTaDM);
            grbThongTinDM.Controls.Add(txtTenDM);
            grbThongTinDM.Controls.Add(txtMaDM);
            grbThongTinDM.Controls.Add(label4);
            grbThongTinDM.Controls.Add(label3);
            grbThongTinDM.Controls.Add(label2);
            grbThongTinDM.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbThongTinDM.Location = new Point(725, 112);
            grbThongTinDM.Name = "grbThongTinDM";
            grbThongTinDM.Size = new Size(413, 352);
            grbThongTinDM.TabIndex = 1;
            grbThongTinDM.TabStop = false;
            grbThongTinDM.Text = "Thông tin danh mục:";
            // 
            // btnLuuDM
            // 
            btnLuuDM.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnLuuDM.Location = new Point(276, 304);
            btnLuuDM.Name = "btnLuuDM";
            btnLuuDM.Size = new Size(94, 29);
            btnLuuDM.TabIndex = 10;
            btnLuuDM.Text = "Lưu";
            btnLuuDM.UseVisualStyleBackColor = true;
            // 
            // btnLamMoiDM
            // 
            btnLamMoiDM.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnLamMoiDM.Location = new Point(154, 304);
            btnLamMoiDM.Name = "btnLamMoiDM";
            btnLamMoiDM.Size = new Size(94, 29);
            btnLamMoiDM.TabIndex = 9;
            btnLamMoiDM.Text = "Làm mới";
            btnLamMoiDM.UseVisualStyleBackColor = true;
            // 
            // btnXoaDM
            // 
            btnXoaDM.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnXoaDM.Location = new Point(276, 248);
            btnXoaDM.Name = "btnXoaDM";
            btnXoaDM.Size = new Size(94, 29);
            btnXoaDM.TabIndex = 8;
            btnXoaDM.Text = "Xóa";
            btnXoaDM.UseVisualStyleBackColor = true;
            // 
            // btnSuaDM
            // 
            btnSuaDM.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSuaDM.Location = new Point(154, 248);
            btnSuaDM.Name = "btnSuaDM";
            btnSuaDM.Size = new Size(94, 29);
            btnSuaDM.TabIndex = 7;
            btnSuaDM.Text = "Sửa";
            btnSuaDM.UseVisualStyleBackColor = true;
            // 
            // btnThemDM
            // 
            btnThemDM.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnThemDM.Location = new Point(31, 248);
            btnThemDM.Name = "btnThemDM";
            btnThemDM.Size = new Size(94, 29);
            btnThemDM.TabIndex = 6;
            btnThemDM.Text = "Thêm";
            btnThemDM.UseVisualStyleBackColor = true;
            // 
            // txtMoTaDM
            // 
            txtMoTaDM.Font = new Font("Segoe UI", 12F);
            txtMoTaDM.Location = new Point(190, 182);
            txtMoTaDM.Multiline = true;
            txtMoTaDM.Name = "txtMoTaDM";
            txtMoTaDM.Size = new Size(200, 43);
            txtMoTaDM.TabIndex = 5;
            // 
            // txtTenDM
            // 
            txtTenDM.Font = new Font("Segoe UI", 12F);
            txtTenDM.Location = new Point(190, 124);
            txtTenDM.Name = "txtTenDM";
            txtTenDM.Size = new Size(217, 34);
            txtTenDM.TabIndex = 4;
            // 
            // txtMaDM
            // 
            txtMaDM.Font = new Font("Segoe UI", 12F);
            txtMaDM.Location = new Point(189, 69);
            txtMaDM.Name = "txtMaDM";
            txtMaDM.Size = new Size(146, 34);
            txtMaDM.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(31, 185);
            label4.Name = "label4";
            label4.Size = new Size(73, 28);
            label4.TabIndex = 2;
            label4.Text = "Mô tả:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(31, 127);
            label3.Name = "label3";
            label3.Size = new Size(152, 28);
            label3.TabIndex = 1;
            label3.Text = "Tên Danh mục:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(31, 67);
            label2.Name = "label2";
            label2.Size = new Size(87, 28);
            label2.TabIndex = 0;
            label2.Text = "Mã DM:";
            // 
            // grbDanhSachDM
            // 
            grbDanhSachDM.Controls.Add(dgvDanhMuc);
            grbDanhSachDM.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbDanhSachDM.Location = new Point(63, 112);
            grbDanhSachDM.Name = "grbDanhSachDM";
            grbDanhSachDM.Size = new Size(566, 352);
            grbDanhSachDM.TabIndex = 0;
            grbDanhSachDM.TabStop = false;
            grbDanhSachDM.Text = "Danh mục";
            // 
            // dgvDanhMuc
            // 
            dgvDanhMuc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhMuc.Location = new Point(25, 42);
            dgvDanhMuc.Name = "dgvDanhMuc";
            dgvDanhMuc.RowHeadersWidth = 51;
            dgvDanhMuc.Size = new Size(520, 291);
            dgvDanhMuc.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(grbThongTinSP);
            tabPage1.Controls.Add(grbDanhSachSP);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1173, 524);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sản phẩm";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(401, 27);
            label1.Name = "label1";
            label1.Size = new Size(359, 46);
            label1.TabIndex = 9;
            label1.Text = "QUẢN LÝ SẢN PHẨM\r\n";
            // 
            // grbThongTinSP
            // 
            grbThongTinSP.Controls.Add(btnTimSP);
            grbThongTinSP.Controls.Add(txtTimSP);
            grbThongTinSP.Controls.Add(label10);
            grbThongTinSP.Controls.Add(cboDanhMucSP);
            grbThongTinSP.Controls.Add(label9);
            grbThongTinSP.Controls.Add(btnLuuSP);
            grbThongTinSP.Controls.Add(btnLamMoiSP);
            grbThongTinSP.Controls.Add(btnXoaSP);
            grbThongTinSP.Controls.Add(btnSuaSP);
            grbThongTinSP.Controls.Add(btnThemSP);
            grbThongTinSP.Controls.Add(txtDonGia);
            grbThongTinSP.Controls.Add(txtTenMon);
            grbThongTinSP.Controls.Add(txtMaMon);
            grbThongTinSP.Controls.Add(label6);
            grbThongTinSP.Controls.Add(label7);
            grbThongTinSP.Controls.Add(label8);
            grbThongTinSP.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbThongTinSP.Location = new Point(711, 103);
            grbThongTinSP.Name = "grbThongTinSP";
            grbThongTinSP.Size = new Size(413, 410);
            grbThongTinSP.TabIndex = 8;
            grbThongTinSP.TabStop = false;
            grbThongTinSP.Text = "Thông tin danh mục:";
            // 
            // btnTimSP
            // 
            btnTimSP.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnTimSP.Location = new Point(332, 53);
            btnTimSP.Name = "btnTimSP";
            btnTimSP.Size = new Size(72, 29);
            btnTimSP.TabIndex = 15;
            btnTimSP.Text = "Tìm";
            btnTimSP.UseVisualStyleBackColor = true;
            // 
            // txtTimSP
            // 
            txtTimSP.Font = new Font("Segoe UI", 12F);
            txtTimSP.Location = new Point(126, 48);
            txtTimSP.Name = "txtTimSP";
            txtTimSP.Size = new Size(200, 34);
            txtTimSP.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label10.Location = new Point(15, 54);
            label10.Name = "label10";
            label10.Size = new Size(105, 28);
            label10.TabIndex = 13;
            label10.Text = "Tìm kiếm:";
            // 
            // cboDanhMucSP
            // 
            cboDanhMucSP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDanhMucSP.FormattingEnabled = true;
            cboDanhMucSP.Location = new Point(187, 204);
            cboDanhMucSP.Name = "cboDanhMucSP";
            cboDanhMucSP.Size = new Size(151, 36);
            cboDanhMucSP.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(28, 212);
            label9.Name = "label9";
            label9.Size = new Size(113, 28);
            label9.TabIndex = 11;
            label9.Text = "Danh mục:";
            // 
            // btnLuuSP
            // 
            btnLuuSP.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnLuuSP.Location = new Point(283, 369);
            btnLuuSP.Name = "btnLuuSP";
            btnLuuSP.Size = new Size(94, 29);
            btnLuuSP.TabIndex = 10;
            btnLuuSP.Text = "Lưu";
            btnLuuSP.UseVisualStyleBackColor = true;
            // 
            // btnLamMoiSP
            // 
            btnLamMoiSP.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnLamMoiSP.Location = new Point(161, 369);
            btnLamMoiSP.Name = "btnLamMoiSP";
            btnLamMoiSP.Size = new Size(94, 29);
            btnLamMoiSP.TabIndex = 9;
            btnLamMoiSP.Text = "Làm mới";
            btnLamMoiSP.UseVisualStyleBackColor = true;
            // 
            // btnXoaSP
            // 
            btnXoaSP.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnXoaSP.Location = new Point(283, 313);
            btnXoaSP.Name = "btnXoaSP";
            btnXoaSP.Size = new Size(94, 29);
            btnXoaSP.TabIndex = 8;
            btnXoaSP.Text = "Xóa";
            btnXoaSP.UseVisualStyleBackColor = true;
            // 
            // btnSuaSP
            // 
            btnSuaSP.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnSuaSP.Location = new Point(161, 313);
            btnSuaSP.Name = "btnSuaSP";
            btnSuaSP.Size = new Size(94, 29);
            btnSuaSP.TabIndex = 7;
            btnSuaSP.Text = "Sửa";
            btnSuaSP.UseVisualStyleBackColor = true;
            // 
            // btnThemSP
            // 
            btnThemSP.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnThemSP.Location = new Point(38, 313);
            btnThemSP.Name = "btnThemSP";
            btnThemSP.Size = new Size(94, 29);
            btnThemSP.TabIndex = 6;
            btnThemSP.Text = "Thêm";
            btnThemSP.UseVisualStyleBackColor = true;
            // 
            // txtDonGia
            // 
            txtDonGia.Font = new Font("Segoe UI", 12F);
            txtDonGia.Location = new Point(187, 252);
            txtDonGia.Multiline = true;
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(200, 43);
            txtDonGia.TabIndex = 5;
            // 
            // txtTenMon
            // 
            txtTenMon.Font = new Font("Segoe UI", 12F);
            txtTenMon.Location = new Point(187, 159);
            txtTenMon.Name = "txtTenMon";
            txtTenMon.Size = new Size(217, 34);
            txtTenMon.TabIndex = 4;
            // 
            // txtMaMon
            // 
            txtMaMon.Font = new Font("Segoe UI", 12F);
            txtMaMon.Location = new Point(187, 108);
            txtMaMon.Name = "txtMaMon";
            txtMaMon.Size = new Size(146, 34);
            txtMaMon.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(28, 255);
            label6.Name = "label6";
            label6.Size = new Size(92, 28);
            label6.TabIndex = 2;
            label6.Text = "Đơn giá:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label7.Location = new Point(28, 165);
            label7.Name = "label7";
            label7.Size = new Size(98, 28);
            label7.TabIndex = 1;
            label7.Text = "Tên món:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label8.Location = new Point(28, 108);
            label8.Name = "label8";
            label8.Size = new Size(95, 28);
            label8.TabIndex = 0;
            label8.Text = "Mã món:";
            // 
            // grbDanhSachSP
            // 
            grbDanhSachSP.Controls.Add(dgvSanPham);
            grbDanhSachSP.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbDanhSachSP.Location = new Point(47, 103);
            grbDanhSachSP.Name = "grbDanhSachSP";
            grbDanhSachSP.Size = new Size(611, 352);
            grbDanhSachSP.TabIndex = 7;
            grbDanhSachSP.TabStop = false;
            grbDanhSachSP.Text = "Danh sách sản phẩm:";
            // 
            // dgvSanPham
            // 
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSanPham.Location = new Point(25, 42);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.Size = new Size(550, 291);
            dgvSanPham.TabIndex = 0;
            // 
            // Form_QuanLySanPhamDanhMuc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(tabControl1);
            Name = "Form_QuanLySanPhamDanhMuc";
            Text = "Form_QuanLySanPhamDanhMuc";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            grbThongTinDM.ResumeLayout(false);
            grbThongTinDM.PerformLayout();
            grbDanhSachDM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhMuc).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            grbThongTinSP.ResumeLayout(false);
            grbThongTinSP.PerformLayout();
            grbDanhSachSP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private GroupBox grbDanhSachDM;
        private TabPage tabPage1;
        private GroupBox grbThongTinDM;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dgvDanhMuc;
        private Label label5;
        private TextBox txtMoTaDM;
        private TextBox txtTenDM;
        private TextBox txtMaDM;
        private Button btnLuuDM;
        private Button btnLamMoiDM;
        private Button btnXoaDM;
        private Button btnSuaDM;
        private Button btnThemDM;
        private Label label1;
        private GroupBox grbThongTinSP;
        private Button btnLuuSP;
        private Button btnLamMoiSP;
        private Button btnXoaSP;
        private Button btnSuaSP;
        private Button btnThemSP;
        private TextBox txtDonGia;
        private TextBox txtTenMon;
        private TextBox txtMaMon;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox grbDanhSachSP;
        private DataGridView dgvSanPham;
        private Label label9;
        private ComboBox cboDanhMucSP;
        private Label label10;
        private Button btnTimSP;
        private TextBox txtTimSP;
    }
}