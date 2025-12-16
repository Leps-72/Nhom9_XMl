namespace QuanLyQuanCaPhe.GUI
{
    partial class Form_HoaDon
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
            dgvChiTietHD = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtTongTien = new TextBox();
            txtGiamGia = new TextBox();
            txtThanhTien = new TextBox();
            cboHinhThuc = new ComboBox();
            btnXacNhan = new Button();
            btnDong = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHD).BeginInit();
            SuspendLayout();
            // 
            // dgvChiTietHD
            // 
            dgvChiTietHD.AllowUserToAddRows = false;
            dgvChiTietHD.AllowUserToDeleteRows = false;
            dgvChiTietHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTietHD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietHD.Location = new Point(58, 153);
            dgvChiTietHD.MultiSelect = false;
            dgvChiTietHD.Name = "dgvChiTietHD";
            dgvChiTietHD.ReadOnly = true;
            dgvChiTietHD.RowHeadersWidth = 51;
            dgvChiTietHD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvChiTietHD.Size = new Size(637, 360);
            dgvChiTietHD.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(400, 22);
            label2.Name = "label2";
            label2.Size = new Size(381, 46);
            label2.TabIndex = 3;
            label2.Text = "THÔNG TIN HÓA ĐƠN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 108);
            label3.Name = "label3";
            label3.Size = new Size(185, 31);
            label3.TabIndex = 5;
            label3.Text = "Chi tiết hóa đơn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(751, 108);
            label4.Name = "label4";
            label4.Size = new Size(162, 31);
            label4.TabIndex = 6;
            label4.Text = "THANH TOÁN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(776, 181);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 7;
            label5.Text = "Tổng tiền :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(776, 231);
            label6.Name = "label6";
            label6.Size = new Size(106, 23);
            label6.TabIndex = 8;
            label6.Text = "Giảm giá % :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(776, 285);
            label7.Name = "label7";
            label7.Size = new Size(101, 23);
            label7.TabIndex = 9;
            label7.Text = "Thành tiền :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(776, 337);
            label8.Name = "label8";
            label8.Size = new Size(96, 23);
            label8.TabIndex = 10;
            label8.Text = "Hình thức :";
            // 
            // txtTongTien
            // 
            txtTongTien.Location = new Point(900, 170);
            txtTongTien.Multiline = true;
            txtTongTien.Name = "txtTongTien";
            txtTongTien.Size = new Size(200, 35);
            txtTongTien.TabIndex = 11;
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(900, 220);
            txtGiamGia.Multiline = true;
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(200, 35);
            txtGiamGia.TabIndex = 12;
            // 
            // txtThanhTien
            // 
            txtThanhTien.Location = new Point(900, 274);
            txtThanhTien.Multiline = true;
            txtThanhTien.Name = "txtThanhTien";
            txtThanhTien.Size = new Size(200, 35);
            txtThanhTien.TabIndex = 13;
            // 
            // cboHinhThuc
            // 
            cboHinhThuc.FormattingEnabled = true;
            cboHinhThuc.Location = new Point(900, 332);
            cboHinhThuc.Name = "cboHinhThuc";
            cboHinhThuc.Size = new Size(200, 28);
            cboHinhThuc.TabIndex = 14;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = SystemColors.MenuHighlight;
            btnXacNhan.FlatStyle = FlatStyle.Popup;
            btnXacNhan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXacNhan.ForeColor = SystemColors.ControlLightLight;
            btnXacNhan.Location = new Point(900, 418);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(100, 35);
            btnXacNhan.TabIndex = 17;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            // 
            // btnDong
            // 
            btnDong.BackColor = SystemColors.ControlLightLight;
            btnDong.FlatStyle = FlatStyle.Popup;
            btnDong.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDong.ForeColor = Color.Red;
            btnDong.Location = new Point(1031, 418);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(100, 35);
            btnDong.TabIndex = 18;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = false;
            // 
            // Form_HoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1182, 553);
            Controls.Add(btnDong);
            Controls.Add(btnXacNhan);
            Controls.Add(cboHinhThuc);
            Controls.Add(txtThanhTien);
            Controls.Add(txtGiamGia);
            Controls.Add(txtTongTien);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvChiTietHD);
            Name = "Form_HoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_HoaDon";
            Load += Form_HoaDon_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvChiTietHD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvChiTietHD;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtTongTien;
        private TextBox txtGiamGia;
        private TextBox txtThanhTien;
        private ComboBox cboHinhThuc;
        private Button btnXacNhan;
        private Button btnDong;
    }
}