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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.tbtaikhoan = new System.Windows.Forms.TextBox();
            this.tbmatkhau = new System.Windows.Forms.TextBox();
            this.pnBackground = new System.Windows.Forms.Panel();
            this.pBUser = new System.Windows.Forms.PictureBox();
            this.btnDangnhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBUser)).BeginInit();
            this.SuspendLayout();
            // 
            // tbtaikhoan
            // 
            this.tbtaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtaikhoan.Location = new System.Drawing.Point(574, 170);
            this.tbtaikhoan.Name = "tbtaikhoan";
            this.tbtaikhoan.Size = new System.Drawing.Size(260, 34);
            this.tbtaikhoan.TabIndex = 3;
            // 
            // tbmatkhau
            // 
            this.tbmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmatkhau.Location = new System.Drawing.Point(574, 235);
            this.tbmatkhau.Name = "tbmatkhau";
            this.tbmatkhau.Size = new System.Drawing.Size(260, 34);
            this.tbmatkhau.TabIndex = 4;
            // 
            // pnBackground
            // 
            this.pnBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnBackground.BackgroundImage")));
            this.pnBackground.CausesValidation = false;
            this.pnBackground.Location = new System.Drawing.Point(0, -1);
            this.pnBackground.Name = "pnBackground";
            this.pnBackground.Size = new System.Drawing.Size(430, 459);
            this.pnBackground.TabIndex = 5;
            // 
            // pBUser
            // 
            this.pBUser.BackgroundImage = global::GUI.Properties.Resources.pngtree_user_login_or_authenticate_icon_on_gray_background_flat_icon_ve_png_image_1742031__2__removebg_preview;
            this.pBUser.Location = new System.Drawing.Point(661, 44);
            this.pBUser.Name = "pBUser";
            this.pBUser.Size = new System.Drawing.Size(80, 80);
            this.pBUser.TabIndex = 6;
            this.pBUser.TabStop = false;
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangnhap.Location = new System.Drawing.Point(512, 315);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(161, 50);
            this.btnDangnhap.TabIndex = 9;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(709, 315);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(161, 52);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // lbUser
            // 
            this.lbUser.Image = ((System.Drawing.Image)(resources.GetObject("lbUser.Image")));
            this.lbUser.Location = new System.Drawing.Point(509, 154);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(50, 50);
            this.lbUser.TabIndex = 11;
            this.lbUser.Click += new System.EventHandler(this.lbUser_Click);
            // 
            // lbPass
            // 
            this.lbPass.Image = ((System.Drawing.Image)(resources.GetObject("lbPass.Image")));
            this.lbPass.Location = new System.Drawing.Point(509, 219);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(50, 50);
            this.lbPass.TabIndex = 12;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.pBUser);
            this.Controls.Add(this.pnBackground);
            this.Controls.Add(this.tbmatkhau);
            this.Controls.Add(this.tbtaikhoan);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.pBUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbtaikhoan;
        private System.Windows.Forms.TextBox tbmatkhau;
        private System.Windows.Forms.Panel pnBackground;
        private System.Windows.Forms.PictureBox pBUser;
        private System.Windows.Forms.Button btnDangnhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbPass;
    }
}