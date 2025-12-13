namespace QuanLyQuanCaPhe
{
    partial class Form_ThongKeNgay
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
            label5 = new Label();
            label1 = new Label();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            dgvDoanhThu = new DataGridView();
            label2 = new Label();
            txtTongDoanhThu = new Label();
            btnThongKe = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(366, 55);
            label4.Name = "label4";
            label4.Size = new Size(510, 46);
            label4.TabIndex = 4;
            label4.Text = "THỐNG KÊ DOANH THU NGÀY";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(254, 157);
            label5.Name = "label5";
            label5.Size = new Size(73, 23);
            label5.TabIndex = 8;
            label5.Text = "Từ ngày";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(535, 157);
            label1.Name = "label1";
            label1.Size = new Size(84, 23);
            label1.TabIndex = 9;
            label1.Text = "Đến ngày";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Format = DateTimePickerFormat.Custom;
            dtpTuNgay.Location = new Point(350, 157);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(123, 27);
            dtpTuNgay.TabIndex = 18;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Format = DateTimePickerFormat.Custom;
            dtpDenNgay.Location = new Point(645, 157);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(123, 27);
            dtpDenNgay.TabIndex = 19;
            // 
            // dgvDoanhThu
            // 
            dgvDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoanhThu.Location = new Point(141, 209);
            dgvDoanhThu.Name = "dgvDoanhThu";
            dgvDoanhThu.RowHeadersWidth = 51;
            dgvDoanhThu.Size = new Size(937, 255);
            dgvDoanhThu.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(871, 499);
            label2.Name = "label2";
            label2.Size = new Size(134, 23);
            label2.TabIndex = 21;
            label2.Text = "Tổng doanh thu";
            // 
            // txtTongDoanhThu
            // 
            txtTongDoanhThu.AutoSize = true;
            txtTongDoanhThu.Location = new Point(1028, 499);
            txtTongDoanhThu.Name = "txtTongDoanhThu";
            txtTongDoanhThu.Size = new Size(17, 20);
            txtTongDoanhThu.TabIndex = 22;
            txtTongDoanhThu.Text = "a";
            // 
            // btnThongKe
            // 
            btnThongKe.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnThongKe.Location = new Point(859, 154);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(134, 34);
            btnThongKe.TabIndex = 23;
            btnThongKe.Text = "Thống kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // Form_ThongKeNgay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 589);
            Controls.Add(btnThongKe);
            Controls.Add(txtTongDoanhThu);
            Controls.Add(label2);
            Controls.Add(dgvDoanhThu);
            Controls.Add(dtpDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label4);
            Name = "Form_ThongKeNgay";
            Text = "Form_ThongKeNgay";
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Label label5;
        private Label label1;
        private DateTimePicker dtpTuNgay;
        private DateTimePicker dtpDenNgay;
        private DataGridView dgvDoanhThu;
        private Label label2;
        private Label txtTongDoanhThu;
        private Button btnThongKe;
    }
}