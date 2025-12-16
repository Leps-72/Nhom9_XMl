namespace QuanLyQuanCaPhe.GUI
{
    partial class Form_TinhLuong
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
            lblNhanVien = new Label();
            cboNhanVien = new ComboBox();
            lblLuongGio = new Label();
            txtLuongGio = new TextBox();
            lblSoNgay = new Label();
            txtSoNgay = new TextBox();
            btnTinhLuong = new Button();
            dgvLuong = new DataGridView();
            btnDong = new Button();
            cboThang = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLuong).BeginInit();
            SuspendLayout();
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.BackColor = Color.Transparent;
            lblNhanVien.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblNhanVien.Location = new Point(71, 90);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(136, 23);
            lblNhanVien.TabIndex = 0;
            lblNhanVien.Text = "Chọn nhân viên:";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(213, 89);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(151, 28);
            cboNhanVien.TabIndex = 1;
            // 
            // lblLuongGio
            // 
            lblLuongGio.AutoSize = true;
            lblLuongGio.BackColor = Color.Transparent;
            lblLuongGio.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblLuongGio.Location = new Point(71, 147);
            lblLuongGio.Name = "lblLuongGio";
            lblLuongGio.Size = new Size(147, 23);
            lblLuongGio.TabIndex = 2;
            lblLuongGio.Text = "Lương/giờ (VND):";
            // 
            // txtLuongGio
            // 
            txtLuongGio.Location = new Point(224, 146);
            txtLuongGio.Name = "txtLuongGio";
            txtLuongGio.Size = new Size(125, 27);
            txtLuongGio.TabIndex = 3;
            txtLuongGio.TextChanged += txtLuongGio_TextChanged;
            // 
            // lblSoNgay
            // 
            lblSoNgay.AutoSize = true;
            lblSoNgay.BackColor = Color.Transparent;
            lblSoNgay.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            lblSoNgay.Location = new Point(71, 194);
            lblSoNgay.Name = "lblSoNgay";
            lblSoNgay.Size = new Size(109, 23);
            lblSoNgay.TabIndex = 4;
            lblSoNgay.Text = "Số ngày làm:";
            // 
            // txtSoNgay
            // 
            txtSoNgay.Location = new Point(203, 193);
            txtSoNgay.Name = "txtSoNgay";
            txtSoNgay.Size = new Size(125, 27);
            txtSoNgay.TabIndex = 5;
            // 
            // btnTinhLuong
            // 
            btnTinhLuong.BackColor = Color.AliceBlue;
            btnTinhLuong.FlatStyle = FlatStyle.Popup;
            btnTinhLuong.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTinhLuong.Location = new Point(414, 162);
            btnTinhLuong.Name = "btnTinhLuong";
            btnTinhLuong.Size = new Size(109, 58);
            btnTinhLuong.TabIndex = 6;
            btnTinhLuong.Text = "Tính lương";
            btnTinhLuong.UseVisualStyleBackColor = false;
            btnTinhLuong.Click += btnTinhLuong_Click;
            // 
            // dgvLuong
            // 
            dgvLuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLuong.Location = new Point(75, 238);
            dgvLuong.Name = "dgvLuong";
            dgvLuong.RowHeadersWidth = 51;
            dgvLuong.Size = new Size(1016, 269);
            dgvLuong.TabIndex = 7;
            // 
            // btnDong
            // 
            btnDong.BackColor = Color.CornflowerBlue;
            btnDong.FlatStyle = FlatStyle.Popup;
            btnDong.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnDong.Location = new Point(898, 90);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(109, 58);
            btnDong.TabIndex = 9;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // cboThang
            // 
            cboThang.FormattingEnabled = true;
            cboThang.Location = new Point(638, 93);
            cboThang.Name = "cboThang";
            cboThang.Size = new Size(151, 28);
            cboThang.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(426, 94);
            label1.Name = "label1";
            label1.Size = new Size(190, 23);
            label1.TabIndex = 11;
            label1.Text = "Chọn tháng tính lương:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(335, 21);
            label4.Name = "label4";
            label4.Size = new Size(520, 46);
            label4.TabIndex = 12;
            label4.Text = "TÍNH TIỀN LƯƠNG NHÂN VIÊN";
            // 
            // Form_TinhLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(cboThang);
            Controls.Add(btnDong);
            Controls.Add(dgvLuong);
            Controls.Add(btnTinhLuong);
            Controls.Add(txtSoNgay);
            Controls.Add(lblSoNgay);
            Controls.Add(txtLuongGio);
            Controls.Add(lblLuongGio);
            Controls.Add(cboNhanVien);
            Controls.Add(lblNhanVien);
            Name = "Form_TinhLuong";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_TinhLuong";
            Load += Form_TinhLuong_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLuong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNhanVien;
        private ComboBox cboNhanVien;
        private Label lblLuongGio;
        private TextBox txtLuongGio;
        private Label lblSoNgay;
        private TextBox txtSoNgay;
        private Button btnTinhLuong;
        private DataGridView dgvLuong;
        private Button btnDong;
        private ComboBox cboThang;
        private Label label1;
        private Label label4;
    }
}