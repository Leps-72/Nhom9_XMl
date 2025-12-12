namespace QuanLyQuanCaPhe.GUI
{
    partial class Form_BanHang
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
            label4 = new Label();
            dgvOrder = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            btnThanhToan = new Button();
            btnHuyOrder = new Button();
            cboBan = new ComboBox();
            txtNhanVien = new TextBox();
            txtTongSoLuong = new TextBox();
            txtTongTien = new TextBox();
            btnLamMoi = new Button();
            btnDong = new Button();
            txtTimMon = new TextBox();
            groupBox2 = new GroupBox();
            dgvMon = new DataGridView();
            cboDanhMuc = new ComboBox();
            groupBox1 = new GroupBox();
            btnXoaMon = new Button();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMon).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(419, 30);
            label4.Name = "label4";
            label4.Size = new Size(304, 46);
            label4.TabIndex = 3;
            label4.Text = "ORDER ĐỒ UỐNG";
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(6, 176);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.Size = new Size(390, 249);
            dgvOrder.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 73);
            label5.Name = "label5";
            label5.Size = new Size(110, 28);
            label5.TabIndex = 7;
            label5.Text = "Danh mục:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(21, 134);
            label6.Name = "label6";
            label6.Size = new Size(99, 28);
            label6.TabIndex = 8;
            label6.Text = "Tìm món:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(29, 57);
            label7.Name = "label7";
            label7.Size = new Size(138, 28);
            label7.TabIndex = 9;
            label7.Text = "Món đã chọn:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(17, 50);
            label8.Name = "label8";
            label8.Size = new Size(51, 28);
            label8.TabIndex = 10;
            label8.Text = "Bàn:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(17, 104);
            label9.Name = "label9";
            label9.Size = new Size(45, 28);
            label9.TabIndex = 11;
            label9.Text = "NV:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(17, 171);
            label10.Name = "label10";
            label10.Size = new Size(91, 28);
            label10.TabIndex = 12;
            label10.Text = "Tổng SL:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(17, 228);
            label11.Name = "label11";
            label11.Size = new Size(105, 28);
            label11.TabIndex = 13;
            label11.Text = "Tổng tiền:";
            // 
            // btnThanhToan
            // 
            btnThanhToan.Font = new Font("Segoe UI", 12F);
            btnThanhToan.Location = new Point(17, 284);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(150, 35);
            btnThanhToan.TabIndex = 14;
            btnThanhToan.Text = "Thanh toán";
            btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // btnHuyOrder
            // 
            btnHuyOrder.Font = new Font("Segoe UI", 12F);
            btnHuyOrder.Location = new Point(17, 342);
            btnHuyOrder.Name = "btnHuyOrder";
            btnHuyOrder.Size = new Size(150, 35);
            btnHuyOrder.TabIndex = 15;
            btnHuyOrder.Text = "Hủy order";
            btnHuyOrder.UseVisualStyleBackColor = true;
            // 
            // cboBan
            // 
            cboBan.Font = new Font("Segoe UI", 12F);
            cboBan.FormattingEnabled = true;
            cboBan.Location = new Point(134, 50);
            cboBan.Name = "cboBan";
            cboBan.Size = new Size(151, 36);
            cboBan.TabIndex = 16;
            // 
            // txtNhanVien
            // 
            txtNhanVien.Font = new Font("Segoe UI", 12F);
            txtNhanVien.Location = new Point(134, 98);
            txtNhanVien.Multiline = true;
            txtNhanVien.Name = "txtNhanVien";
            txtNhanVien.Size = new Size(151, 34);
            txtNhanVien.TabIndex = 17;
            // 
            // txtTongSoLuong
            // 
            txtTongSoLuong.Font = new Font("Segoe UI", 12F);
            txtTongSoLuong.Location = new Point(134, 165);
            txtTongSoLuong.Multiline = true;
            txtTongSoLuong.Name = "txtTongSoLuong";
            txtTongSoLuong.Size = new Size(113, 34);
            txtTongSoLuong.TabIndex = 18;
            // 
            // txtTongTien
            // 
            txtTongTien.Font = new Font("Segoe UI", 12F);
            txtTongTien.Location = new Point(134, 222);
            txtTongTien.Multiline = true;
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(175, 34);
            txtTongTien.TabIndex = 19;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 12F);
            btnLamMoi.Location = new Point(29, 104);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(138, 35);
            btnLamMoi.TabIndex = 21;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            btnDong.Font = new Font("Segoe UI", 12F);
            btnDong.Location = new Point(192, 284);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(100, 35);
            btnDong.TabIndex = 22;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            // 
            // txtTimMon
            // 
            txtTimMon.Font = new Font("Segoe UI", 12F);
            txtTimMon.Location = new Point(142, 128);
            txtTimMon.Multiline = true;
            txtTimMon.Name = "txtTimMon";
            txtTimMon.Size = new Size(222, 34);
            txtTimMon.TabIndex = 23;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvMon);
            groupBox2.Controls.Add(cboDanhMuc);
            groupBox2.Controls.Add(txtTimMon);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 110);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(398, 429);
            groupBox2.TabIndex = 25;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh mục + Món";
            // 
            // dgvMon
            // 
            dgvMon.AccessibleDescription = "f";
            dgvMon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMon.Location = new Point(0, 176);
            dgvMon.Name = "dgvMon";
            dgvMon.RowHeadersWidth = 51;
            dgvMon.Size = new Size(398, 247);
            dgvMon.TabIndex = 25;
            // 
            // cboDanhMuc
            // 
            cboDanhMuc.Font = new Font("Segoe UI", 12F);
            cboDanhMuc.FormattingEnabled = true;
            cboDanhMuc.IntegralHeight = false;
            cboDanhMuc.Location = new Point(142, 70);
            cboDanhMuc.Name = "cboDanhMuc";
            cboDanhMuc.Size = new Size(177, 36);
            cboDanhMuc.TabIndex = 24;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnXoaMon);
            groupBox1.Controls.Add(btnLamMoi);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dgvOrder);
            groupBox1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(430, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(396, 431);
            groupBox1.TabIndex = 26;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết order";
            // 
            // btnXoaMon
            // 
            btnXoaMon.Font = new Font("Segoe UI", 12F);
            btnXoaMon.Location = new Point(197, 104);
            btnXoaMon.Name = "btnXoaMon";
            btnXoaMon.Size = new Size(138, 35);
            btnXoaMon.TabIndex = 22;
            btnXoaMon.Text = "Xóa món";
            btnXoaMon.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnDong);
            groupBox3.Controls.Add(txtTongTien);
            groupBox3.Controls.Add(txtTongSoLuong);
            groupBox3.Controls.Add(txtNhanVien);
            groupBox3.Controls.Add(cboBan);
            groupBox3.Controls.Add(btnHuyOrder);
            groupBox3.Controls.Add(btnThanhToan);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(844, 117);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(326, 422);
            groupBox3.TabIndex = 27;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin";
            // 
            // Form_BanHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(label4);
            Name = "Form_BanHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_BanHang";
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMon).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private DataGridView dgvOrder;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button btnThanhToan;
        private Button btnHuyOrder;
        private ComboBox cboBan;
        private TextBox txtNhanVien;
        private TextBox txtTongSoLuong;
        private TextBox txtTongTien;
        private Button btnLamMoi;
        private Button btnDong;
        private TextBox txtTimMon;
        private GroupBox groupBox2;
        private ComboBox cboDanhMuc;
        private GroupBox groupBox1;
        private Button btnXoaMon;
        private GroupBox groupBox3;
        private DataGridView dgvMon;
    }
}