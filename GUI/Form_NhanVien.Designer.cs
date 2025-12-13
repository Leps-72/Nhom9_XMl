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
            label7 = new Label();
            btnChamCong = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChamCong).BeginInit();
            SuspendLayout();
            // 
            // txtMaNV
            // 
            txtMaNV.BackColor = SystemColors.ButtonFace;
            txtMaNV.ImeMode = ImeMode.NoControl;
            txtMaNV.Location = new Point(239, 106);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.ReadOnly = true;
            txtMaNV.Size = new Size(195, 27);
            txtMaNV.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 106);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.Location = new Point(106, 157);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 5;
            label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label3.Location = new Point(106, 206);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 6;
            label3.Text = "Giờ làm";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label4.Location = new Point(489, 213);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 7;
            label4.Text = "Giờ kết thúc";
            // 
            // dgvChamCong
            // 
            dgvChamCong.BackgroundColor = SystemColors.MenuHighlight;
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
            cboLoaiNV.Location = new Point(621, 106);
            cboLoaiNV.Name = "cboLoaiNV";
            cboLoaiNV.Size = new Size(151, 28);
            cboLoaiNV.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label5.Location = new Point(489, 109);
            label5.Name = "label5";
            label5.Size = new Size(109, 20);
            label5.TabIndex = 13;
            label5.Text = "Loại nhân viên";
            // 
            // cboNhanVien
            // 
            cboNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(239, 157);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(195, 28);
            cboNhanVien.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label6.Location = new Point(489, 160);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 15;
            label6.Text = "Ngày làm";
            // 
            // dtpNgayLam
            // 
            dtpNgayLam.CustomFormat = "dd/MM/yyyy";
            dtpNgayLam.Format = DateTimePickerFormat.Custom;
            dtpNgayLam.Location = new Point(621, 160);
            dtpNgayLam.Name = "dtpNgayLam";
            dtpNgayLam.Size = new Size(123, 27);
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
            txtGioVao.Location = new Point(239, 206);
            txtGioVao.Name = "txtGioVao";
            txtGioVao.Size = new Size(195, 27);
            txtGioVao.TabIndex = 19;
            // 
            // txtGioRa
            // 
            txtGioRa.ImeMode = ImeMode.NoControl;
            txtGioRa.Location = new Point(622, 206);
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
            btnLamMoi.FlatStyle = FlatStyle.Popup;
            btnLamMoi.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnLamMoi.Location = new Point(298, 253);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(153, 34);
            btnLamMoi.TabIndex = 22;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(66, 24);
            label7.Name = "label7";
            label7.Size = new Size(368, 46);
            label7.TabIndex = 24;
            label7.Text = "QUẢN LÝ NHÂN VIÊN";
            label7.Click += label7_Click;
            // 
            // btnChamCong
            // 
            btnChamCong.FlatStyle = FlatStyle.Popup;
            btnChamCong.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
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
        private Label label7;
        private Button btnChamCong;
    }
}