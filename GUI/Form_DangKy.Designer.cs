namespace QuanLyQuanCaPhe.GUI
{
    partial class Form_DangKy
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
            btnDangKy = new Button();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            lblTitle = new Label();
            txtHoTen = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(482, 355);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(173, 55);
            btnDangKy.TabIndex = 7;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.ForeColor = Color.Gray;
            txtMatKhau.Location = new Point(451, 295);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(251, 27);
            txtMatKhau.TabIndex = 6;
            txtMatKhau.TextChanged += txtMatKhau_TextChanged;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.ForeColor = Color.Gray;
            txtTenDangNhap.Location = new Point(451, 229);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(251, 27);
            txtTenDangNhap.TabIndex = 5;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(502, 93);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(153, 20);
            lblTitle.TabIndex = 4;
            lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // txtHoTen
            // 
            txtHoTen.ForeColor = Color.Gray;
            txtHoTen.Location = new Point(451, 166);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(251, 27);
            txtHoTen.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(451, 134);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 9;
            label1.Text = "Họ tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 206);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 10;
            label2.Text = "Tên đăng ký";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(451, 272);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 11;
            label3.Text = "Mật khẩu";
            // 
            // Form_DangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 553);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHoTen);
            Controls.Add(btnDangKy);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblTitle);
            Name = "Form_DangKy";
            Text = "Form_DangKy";
            Load += Form_DangKy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDangKy;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label lblTitle;
        private TextBox txtHoTen;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}