namespace QuanLyQuanCaPhe.GUI
{
    partial class Form_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DangNhap));
            lblTitle = new Label();
            txtTenDangNhap = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            lnkDangKy = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(99, 71);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(173, 20);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "ĐĂNG NHẬP HỆ THỐNG";
            lblTitle.Click += lblTitle_Click;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.ForeColor = Color.Gray;
            txtTenDangNhap.Location = new Point(78, 157);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.Size = new Size(251, 27);
            txtTenDangNhap.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            txtMatKhau.ForeColor = Color.Gray;
            txtMatKhau.Location = new Point(78, 231);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(251, 27);
            txtMatKhau.TabIndex = 2;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(114, 282);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(173, 55);
            btnDangNhap.TabIndex = 3;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // lnkDangKy
            // 
            lnkDangKy.AutoSize = true;
            lnkDangKy.Location = new Point(114, 390);
            lnkDangKy.Name = "lnkDangKy";
            lnkDangKy.Size = new Size(184, 20);
            lnkDangKy.TabIndex = 4;
            lnkDangKy.TabStop = true;
            lnkDangKy.Text = "Chưa có tài khoản đăng ký";
            lnkDangKy.LinkClicked += lnkDangKy_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 123);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 5;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 199);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "Mật khẩu";
            label2.Click += label2_Click;
            // 
            // Form_DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(412, 483);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lnkDangKy);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTenDangNhap);
            Controls.Add(lblTitle);
            Name = "Form_DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_DangNhap";
            Load += Form_DangNhap_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtTenDangNhap;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private LinkLabel lnkDangKy;
        private Label label1;
        private Label label2;
    }
}