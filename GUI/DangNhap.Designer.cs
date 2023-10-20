namespace GUI
{
    partial class DangNhap
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
            this.lbdangnhap = new System.Windows.Forms.Label();
            this.lbtaikhoan = new System.Windows.Forms.Label();
            this.lbmatkhau = new System.Windows.Forms.Label();
            this.tbtaikhoan = new System.Windows.Forms.TextBox();
            this.tbmatkhau = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbdangnhap
            // 
            this.lbdangnhap.AutoSize = true;
            this.lbdangnhap.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbdangnhap.Location = new System.Drawing.Point(320, 60);
            this.lbdangnhap.Name = "lbdangnhap";
            this.lbdangnhap.Size = new System.Drawing.Size(142, 31);
            this.lbdangnhap.TabIndex = 0;
            this.lbdangnhap.Text = "Đăng nhập";
            // 
            // lbtaikhoan
            // 
            this.lbtaikhoan.AutoSize = true;
            this.lbtaikhoan.Location = new System.Drawing.Point(139, 151);
            this.lbtaikhoan.Name = "lbtaikhoan";
            this.lbtaikhoan.Size = new System.Drawing.Size(67, 16);
            this.lbtaikhoan.TabIndex = 1;
            this.lbtaikhoan.Text = "Tài khoản";
            // 
            // lbmatkhau
            // 
            this.lbmatkhau.AutoSize = true;
            this.lbmatkhau.Location = new System.Drawing.Point(139, 220);
            this.lbmatkhau.Name = "lbmatkhau";
            this.lbmatkhau.Size = new System.Drawing.Size(61, 16);
            this.lbmatkhau.TabIndex = 2;
            this.lbmatkhau.Text = "Mật khẩu";
            // 
            // tbtaikhoan
            // 
            this.tbtaikhoan.Location = new System.Drawing.Point(289, 148);
            this.tbtaikhoan.Name = "tbtaikhoan";
            this.tbtaikhoan.Size = new System.Drawing.Size(266, 22);
            this.tbtaikhoan.TabIndex = 3;
            // 
            // tbmatkhau
            // 
            this.tbmatkhau.Location = new System.Drawing.Point(289, 217);
            this.tbmatkhau.Name = "tbmatkhau";
            this.tbmatkhau.Size = new System.Drawing.Size(266, 22);
            this.tbmatkhau.TabIndex = 4;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbmatkhau);
            this.Controls.Add(this.tbtaikhoan);
            this.Controls.Add(this.lbmatkhau);
            this.Controls.Add(this.lbtaikhoan);
            this.Controls.Add(this.lbdangnhap);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbdangnhap;
        private System.Windows.Forms.Label lbtaikhoan;
        private System.Windows.Forms.Label lbmatkhau;
        private System.Windows.Forms.TextBox tbtaikhoan;
        private System.Windows.Forms.TextBox tbmatkhau;
    }
}