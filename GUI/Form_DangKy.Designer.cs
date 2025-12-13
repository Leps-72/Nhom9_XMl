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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DangKy));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtHoTen = new TextBox();
            btnDangKy = new Button();
            txtMatKhau = new TextBox();
            txtTenDangNhap = new TextBox();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(78, 275);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 19;
            label3.Text = "Mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(78, 209);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 18;
            label2.Text = "Tên đăng ký";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label1.Location = new Point(78, 140);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 17;
            label1.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.ForeColor = Color.Gray;
            txtHoTen.Location = new Point(78, 172);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(251, 27);
            txtHoTen.TabIndex = 16;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.DeepSkyBlue;
            btnDangKy.FlatStyle = FlatStyle.Popup;
            btnDangKy.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnDangKy.ForeColor = Color.White;
            btnDangKy.Location = new Point(78, 361);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(251, 45);
            btnDangKy.TabIndex = 15;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // txtMatKhau
            // 
            txtMatKhau.ForeColor = Color.Gray;
            txtMatKhau.Location = new Point(78, 301);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(251, 27);
            txtMatKhau.TabIndex = 14;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.ForeColor = Color.Gray;
            txtTenDangNhap.Location = new Point(78, 235);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(251, 27);
            txtTenDangNhap.TabIndex = 13;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitle.Location = new Point(69, 86);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(272, 35);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // Form_DangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(412, 483);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtHoTen);
            Controls.Add(btnDangKy);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblTitle);
            Name = "Form_DangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_DangKy";
            Load += Form_DangKy_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtHoTen;
        private Button btnDangKy;
        private TextBox txtMatKhau;
        private TextBox txtTenDangNhap;
        private Label lblTitle;
    }
}