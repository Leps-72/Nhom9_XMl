namespace QuanLyQuanCaPhe.GUI
{
    partial class Form_ThongKeMon
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label5 = new Label();
            cboThang = new ComboBox();
            cboNam = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(330, 55);
            label4.Name = "label4";
            label4.Size = new Size(602, 46);
            label4.TabIndex = 5;
            label4.Text = "THỐNG KÊ DOANH THU THEO MÓN";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(370, 134);
            label5.Name = "label5";
            label5.Size = new Size(58, 23);
            label5.TabIndex = 9;
            label5.Text = "Tháng";
            // 
            // cboThang
            // 
            cboThang.FormattingEnabled = true;
            cboThang.Location = new Point(464, 133);
            cboThang.Name = "cboThang";
            cboThang.Size = new Size(99, 28);
            cboThang.TabIndex = 10;
            // 
            // cboNam
            // 
            cboNam.FormattingEnabled = true;
            cboNam.Location = new Point(767, 133);
            cboNam.Name = "cboNam";
            cboNam.Size = new Size(99, 28);
            cboNam.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(673, 134);
            label1.Name = "label1";
            label1.Size = new Size(47, 23);
            label1.TabIndex = 11;
            label1.Text = "Năm";
            // 
            // Form_ThongKeMon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 589);
            Controls.Add(cboNam);
            Controls.Add(label1);
            Controls.Add(cboThang);
            Controls.Add(label5);
            Controls.Add(label4);
            Name = "Form_ThongKeMon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_ThongKeMon";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label5;
        private ComboBox cboThang;
        private ComboBox cboNam;
        private Label label1;
    }
}