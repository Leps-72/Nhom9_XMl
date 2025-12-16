namespace QuanLyQuanCaPhe.GUI
{
    partial class Form_Ban
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
            pnlDanhSach = new Panel();
            dgvBan = new DataGridView();
            lblTieuDeDanhSach = new Label();
            pnlChiTiet = new Panel();
            flpNut = new FlowLayoutPanel();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            txtGhiChu = new TextBox();
            lblGhiChu = new Label();
            cboTrangThai = new ComboBox();
            lblTrangThai = new Label();
            txtKhuVuc = new TextBox();
            lblKhuVuc = new Label();
            txtTenBan = new TextBox();
            lblTenBan = new Label();
            txtMaBan = new TextBox();
            lblMaBan = new Label();
            tlpInput = new TableLayoutPanel();
            lblTieuDeChiTiet = new Label();
            pnlDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBan).BeginInit();
            pnlChiTiet.SuspendLayout();
            flpNut.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDanhSach
            // 
            pnlDanhSach.Controls.Add(dgvBan);
            pnlDanhSach.Controls.Add(lblTieuDeDanhSach);
            pnlDanhSach.Dock = DockStyle.Left;
            pnlDanhSach.Location = new Point(0, 0);
            pnlDanhSach.Name = "pnlDanhSach";
            pnlDanhSach.Size = new Size(720, 553);
            pnlDanhSach.TabIndex = 0;
            // 
            // dgvBan
            // 
            dgvBan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBan.Dock = DockStyle.Fill;
            dgvBan.Location = new Point(0, 25);
            dgvBan.Name = "dgvBan";
            dgvBan.RowHeadersWidth = 51;
            dgvBan.Size = new Size(720, 528);
            dgvBan.TabIndex = 1;
            dgvBan.CellContentClick += dgvBan_CellContentClick;
            // 
            // lblTieuDeDanhSach
            // 
            lblTieuDeDanhSach.AutoSize = true;
            lblTieuDeDanhSach.Dock = DockStyle.Top;
            lblTieuDeDanhSach.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTieuDeDanhSach.Location = new Point(0, 0);
            lblTieuDeDanhSach.Name = "lblTieuDeDanhSach";
            lblTieuDeDanhSach.Size = new Size(164, 25);
            lblTieuDeDanhSach.TabIndex = 0;
            lblTieuDeDanhSach.Text = "DANH SÁCH BÀN";
            // 
            // pnlChiTiet
            // 
            pnlChiTiet.Controls.Add(flpNut);
            pnlChiTiet.Controls.Add(txtGhiChu);
            pnlChiTiet.Controls.Add(lblGhiChu);
            pnlChiTiet.Controls.Add(cboTrangThai);
            pnlChiTiet.Controls.Add(lblTrangThai);
            pnlChiTiet.Controls.Add(txtKhuVuc);
            pnlChiTiet.Controls.Add(lblKhuVuc);
            pnlChiTiet.Controls.Add(txtTenBan);
            pnlChiTiet.Controls.Add(lblTenBan);
            pnlChiTiet.Controls.Add(txtMaBan);
            pnlChiTiet.Controls.Add(lblMaBan);
            pnlChiTiet.Controls.Add(tlpInput);
            pnlChiTiet.Controls.Add(lblTieuDeChiTiet);
            pnlChiTiet.Dock = DockStyle.Fill;
            pnlChiTiet.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            pnlChiTiet.Location = new Point(720, 0);
            pnlChiTiet.Name = "pnlChiTiet";
            pnlChiTiet.Size = new Size(462, 553);
            pnlChiTiet.TabIndex = 1;
            pnlChiTiet.Paint += pnlChiTiet_Paint;
            // 
            // flpNut
            // 
            flpNut.Controls.Add(btnThem);
            flpNut.Controls.Add(btnSua);
            flpNut.Controls.Add(btnXoa);
            flpNut.Controls.Add(btnLamMoi);
            flpNut.Dock = DockStyle.Bottom;
            flpNut.ForeColor = SystemColors.ControlLightLight;
            flpNut.Location = new Point(0, 364);
            flpNut.Name = "flpNut";
            flpNut.Size = new Size(462, 80);
            flpNut.TabIndex = 12;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.MenuHighlight;
            btnThem.FlatStyle = FlatStyle.Popup;
            btnThem.ForeColor = SystemColors.ControlLightLight;
            btnThem.Location = new Point(3, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.MenuHighlight;
            btnSua.FlatStyle = FlatStyle.Popup;
            btnSua.ForeColor = SystemColors.ControlLightLight;
            btnSua.Location = new Point(103, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.FlatStyle = FlatStyle.Popup;
            btnXoa.ForeColor = SystemColors.ControlLightLight;
            btnXoa.Location = new Point(203, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.OliveDrab;
            btnLamMoi.FlatStyle = FlatStyle.Popup;
            btnLamMoi.ForeColor = SystemColors.ControlLightLight;
            btnLamMoi.Location = new Point(303, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 3;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(117, 269);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(259, 80);
            txtGhiChu.TabIndex = 11;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblGhiChu.Location = new Point(28, 269);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(69, 23);
            lblGhiChu.TabIndex = 10;
            lblGhiChu.Text = "Ghi chú";
            // 
            // cboTrangThai
            // 
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Trống", "Đang phục vụ", "Đã đặt trước,", "Hỏng" });
            cboTrangThai.Location = new Point(117, 227);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(151, 31);
            cboTrangThai.TabIndex = 9;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblTrangThai.Location = new Point(28, 230);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(87, 23);
            lblTrangThai.TabIndex = 8;
            lblTrangThai.Text = "Trạng thái";
            // 
            // txtKhuVuc
            // 
            txtKhuVuc.Location = new Point(117, 179);
            txtKhuVuc.Name = "txtKhuVuc";
            txtKhuVuc.Size = new Size(151, 30);
            txtKhuVuc.TabIndex = 7;
            // 
            // lblKhuVuc
            // 
            lblKhuVuc.AutoSize = true;
            lblKhuVuc.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblKhuVuc.Location = new Point(28, 182);
            lblKhuVuc.Name = "lblKhuVuc";
            lblKhuVuc.Size = new Size(73, 23);
            lblKhuVuc.TabIndex = 6;
            lblKhuVuc.Text = "Khu vực";
            // 
            // txtTenBan
            // 
            txtTenBan.Location = new Point(117, 137);
            txtTenBan.Name = "txtTenBan";
            txtTenBan.Size = new Size(151, 30);
            txtTenBan.TabIndex = 5;
            // 
            // lblTenBan
            // 
            lblTenBan.AutoSize = true;
            lblTenBan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblTenBan.Location = new Point(28, 140);
            lblTenBan.Name = "lblTenBan";
            lblTenBan.Size = new Size(70, 23);
            lblTenBan.TabIndex = 4;
            lblTenBan.Text = "Tên bàn";
            // 
            // txtMaBan
            // 
            txtMaBan.Location = new Point(117, 90);
            txtMaBan.Name = "txtMaBan";
            txtMaBan.Size = new Size(125, 30);
            txtMaBan.TabIndex = 3;
            // 
            // lblMaBan
            // 
            lblMaBan.AutoSize = true;
            lblMaBan.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblMaBan.Location = new Point(28, 90);
            lblMaBan.Name = "lblMaBan";
            lblMaBan.Size = new Size(69, 23);
            lblMaBan.TabIndex = 2;
            lblMaBan.Text = "Mã bàn";
            // 
            // tlpInput
            // 
            tlpInput.ColumnCount = 2;
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpInput.Dock = DockStyle.Bottom;
            tlpInput.Location = new Point(0, 444);
            tlpInput.Name = "tlpInput";
            tlpInput.RowCount = 6;
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpInput.Size = new Size(462, 109);
            tlpInput.TabIndex = 1;
            // 
            // lblTieuDeChiTiet
            // 
            lblTieuDeChiTiet.AutoSize = true;
            lblTieuDeChiTiet.Dock = DockStyle.Fill;
            lblTieuDeChiTiet.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTieuDeChiTiet.Location = new Point(0, 0);
            lblTieuDeChiTiet.Name = "lblTieuDeChiTiet";
            lblTieuDeChiTiet.Size = new Size(158, 25);
            lblTieuDeChiTiet.TabIndex = 0;
            lblTieuDeChiTiet.Text = "THÔNG TIN BÀN";
            // 
            // Form_Ban
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(pnlChiTiet);
            Controls.Add(pnlDanhSach);
            Name = "Form_Ban";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_Ban";
            pnlDanhSach.ResumeLayout(false);
            pnlDanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBan).EndInit();
            pnlChiTiet.ResumeLayout(false);
            pnlChiTiet.PerformLayout();
            flpNut.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDanhSach;
        private DataGridView dgvBan;
        private Label lblTieuDeDanhSach;
        private Panel pnlChiTiet;
        private TextBox txtKhuVuc;
        private Label lblKhuVuc;
        private TextBox txtTenBan;
        private Label lblTenBan;
        private TextBox txtMaBan;
        private Label lblMaBan;
        private TableLayoutPanel tlpInput;
        private Label lblTieuDeChiTiet;
        private Label lblTrangThai;
        private TextBox txtGhiChu;
        private Label lblGhiChu;
        private ComboBox cboTrangThai;
        private FlowLayoutPanel flpNut;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
    }
}