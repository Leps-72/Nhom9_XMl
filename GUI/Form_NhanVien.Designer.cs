namespace QuanLyQuanCaPhe.GUI
{
    partial class Form_NhanVien
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
            txtMaNV = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dgvChamCong = new DataGridView();
            cboLoaiNV = new ComboBox();
            label5 = new Label();
            cboNhanVien = new ComboBox();
            label6 = new Label();
            dtpNgayLam = new DateTimePicker();
            lblSoGio = new Label();
            txtGioVao = new TextBox();
            txtGioRa = new TextBox();
            lblTongGio = new Label();
            btnLamMoi = new Button();
            lblThangHienTai = new Label();
            label7 = new Label();
            btnChamCong = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).BeginInit();
            SuspendLayout();
            // 
            // txtMaNV
            // 
            txtMaNV.BackColor = SystemColors.ButtonFace;
            txtMaNV.ImeMode = ImeMode.NoControl;
            txtMaNV.Location = new Point(210, 64);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(195, 27);
            txtMaNV.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 64);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 115);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 5;
            label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 164);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 6;
            label3.Text = "Giờ làm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 218);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 7;
            label4.Text = "Giờ kết thúc";
            // 
            // dgvChamCong
            // 
            dgvChamCong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChamCong.Location = new Point(106, 306);
            dgvChamCong.Name = "dgvChamCong";
            dgvChamCong.RowHeadersWidth = 51;
            dgvChamCong.Size = new Size(875, 188);
            dgvChamCong.TabIndex = 8;
            dgvChamCong.CellContentClick += dgvChamCong_CellContentClick;
            // 
            // cboLoaiNV
            // 
            cboLoaiNV.FormattingEnabled = true;
            cboLoaiNV.Location = new Point(592, 64);
            cboLoaiNV.Name = "cboLoaiNV";
            cboLoaiNV.Size = new Size(151, 28);
            cboLoaiNV.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(460, 67);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 13;
            label5.Text = "Loại nhân viên";
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(210, 115);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(195, 28);
            cboNhanVien.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(460, 134);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 15;
            label6.Text = "Ngày làm";
            // 
            // dtpNgayLam
            // 
            dtpNgayLam.Location = new Point(592, 134);
            dtpNgayLam.Name = "dtpNgayLam";
            dtpNgayLam.Size = new Size(250, 27);
            dtpNgayLam.TabIndex = 17;
            // 
            // lblSoGio
            // 
            lblSoGio.AutoSize = true;
            lblSoGio.Location = new Point(483, 220);
            lblSoGio.Name = "lblSoGio";
            lblSoGio.Size = new Size(0, 20);
            lblSoGio.TabIndex = 18;
            // 
            // txtGioVao
            // 
            txtGioVao.ImeMode = ImeMode.NoControl;
            txtGioVao.Location = new Point(210, 164);
            txtGioVao.Name = "txtGioVao";
            txtGioVao.Size = new Size(195, 27);
            txtGioVao.TabIndex = 19;
            // 
            // txtGioRa
            // 
            txtGioRa.ImeMode = ImeMode.NoControl;
            txtGioRa.Location = new Point(210, 211);
            txtGioRa.Name = "txtGioRa";
            txtGioRa.Size = new Size(195, 27);
            txtGioRa.TabIndex = 20;
            // 
            // lblTongGio
            // 
            lblTongGio.AutoSize = true;
            lblTongGio.Location = new Point(469, 211);
            lblTongGio.Name = "lblTongGio";
            lblTongGio.Size = new Size(0, 20);
            lblTongGio.TabIndex = 21;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(298, 253);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(153, 34);
            btnLamMoi.TabIndex = 22;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // lblThangHienTai
            // 
            lblThangHienTai.AutoSize = true;
            lblThangHienTai.Location = new Point(1000, 33);
            lblThangHienTai.Name = "lblThangHienTai";
            lblThangHienTai.Size = new Size(103, 20);
            lblThangHienTai.TabIndex = 23;
            lblThangHienTai.Text = "Tháng hiện tại";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(69, 7);
            label7.Name = "label7";
            label7.Size = new Size(126, 20);
            label7.TabIndex = 24;
            label7.Text = "Quản lý nhân viên";
            // 
            // btnChamCong
            // 
            btnChamCong.Location = new Point(604, 253);
            btnChamCong.Name = "btnChamCong";
            btnChamCong.Size = new Size(153, 34);
            btnChamCong.TabIndex = 25;
            btnChamCong.Text = "Chấm công";
            btnChamCong.UseVisualStyleBackColor = true;
            btnChamCong.Click += btnChamCong_Click;
            // 
            // Form_NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(btnChamCong);
            Controls.Add(label7);
            Controls.Add(lblThangHienTai);
            Controls.Add(btnLamMoi);
            Controls.Add(lblTongGio);
            Controls.Add(txtGioRa);
            Controls.Add(txtGioVao);
            Controls.Add(lblSoGio);
            Controls.Add(dtpNgayLam);
            Controls.Add(label6);
            Controls.Add(cboNhanVien);
            Controls.Add(label5);
            Controls.Add(cboLoaiNV);
            Controls.Add(dgvChamCong);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMaNV);
            Name = "Form_NhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_NhanVien";
            Load += Form_NhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMaNV;
        private TextBox txtHoTen;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dgvChamCong;
        private ComboBox cboLoaiNV;
        private Label label5;
        private ComboBox cboNhanVien;
        private Label label6;
        private DateTimePicker dtpNgayLam;
        private Label lblSoGio;
        private TextBox txtGioVao;
        private TextBox txtGioRa;
        private Label lblTongGio;
        private Button btnLamMoi;
        private Label lblThangHienTai;
        private Label label7;
        private Button btnChamCong;
    }
}