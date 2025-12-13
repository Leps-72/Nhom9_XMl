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
            ((System.ComponentModel.ISupportInitialize)dgvLuong).BeginInit();
            SuspendLayout();
            // 
            // lblNhanVien
            // 
            lblNhanVien.AutoSize = true;
            lblNhanVien.Location = new Point(72, 60);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(113, 20);
            lblNhanVien.TabIndex = 0;
            lblNhanVien.Text = "Chọn nhân viên:";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(200, 61);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(151, 28);
            cboNhanVien.TabIndex = 1;
            // 
            // lblLuongGio
            // 
            lblLuongGio.AutoSize = true;
            lblLuongGio.Location = new Point(72, 117);
            lblLuongGio.Name = "lblLuongGio";
            lblLuongGio.Size = new Size(127, 20);
            lblLuongGio.TabIndex = 2;
            lblLuongGio.Text = "Lương/giờ (VND):";
            // 
            // txtLuongGio
            // 
            txtLuongGio.Location = new Point(200, 110);
            txtLuongGio.Name = "txtLuongGio";
            txtLuongGio.Size = new Size(125, 27);
            txtLuongGio.TabIndex = 3;
            // 
            // lblSoNgay
            // 
            lblSoNgay.AutoSize = true;
            lblSoNgay.Location = new Point(72, 164);
            lblSoNgay.Name = "lblSoNgay";
            lblSoNgay.Size = new Size(94, 20);
            lblSoNgay.TabIndex = 4;
            lblSoNgay.Text = "Số ngày làm:";
            // 
            // txtSoNgay
            // 
            txtSoNgay.Location = new Point(200, 161);
            txtSoNgay.Name = "txtSoNgay";
            txtSoNgay.Size = new Size(125, 27);
            txtSoNgay.TabIndex = 5;
            // 
            // btnTinhLuong
            // 
            btnTinhLuong.Location = new Point(384, 130);
            btnTinhLuong.Name = "btnTinhLuong";
            btnTinhLuong.Size = new Size(109, 58);
            btnTinhLuong.TabIndex = 6;
            btnTinhLuong.Text = "Tính lương";
            btnTinhLuong.UseVisualStyleBackColor = true;
            btnTinhLuong.Click += btnTinhLuong_Click;
            // 
            // dgvLuong
            // 
            dgvLuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLuong.Location = new Point(75, 238);
            dgvLuong.Name = "dgvLuong";
            dgvLuong.RowHeadersWidth = 51;
            dgvLuong.Size = new Size(903, 269);
            dgvLuong.TabIndex = 7;
            // 
            // btnDong
            // 
            btnDong.Location = new Point(899, 60);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(109, 58);
            btnDong.TabIndex = 9;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btnDong_Click;
            // 
            // cboThang
            // 
            cboThang.FormattingEnabled = true;
            cboThang.Location = new Point(615, 60);
            cboThang.Name = "cboThang";
            cboThang.Size = new Size(151, 28);
            cboThang.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(427, 64);
            label1.Name = "label1";
            label1.Size = new Size(160, 20);
            label1.TabIndex = 11;
            label1.Text = "Chọn tháng tính lương:";
            // 
            // Form_TinhLuong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
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
            Text = "Form_TinhLuong";
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
    }
}