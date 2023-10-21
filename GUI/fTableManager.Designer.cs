namespace GUI
{
    partial class fTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.pnDanhmuc = new System.Windows.Forms.Panel();
            this.btnPhanquyen = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnQLHĐ = new System.Windows.Forms.Button();
            this.btnSp = new System.Windows.Forms.Button();
            this.btnLoaisp = new System.Windows.Forms.Button();
            this.btnNCC = new System.Windows.Forms.Button();
            this.btnKhachhang = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.btnDanhmuc = new System.Windows.Forms.Button();
            this.lbQLCH = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pnUserControl = new System.Windows.Forms.Panel();
            this.pnDanhmuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnLogo.BackgroundImage")));
            this.pnLogo.Location = new System.Drawing.Point(-2, -1);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(279, 201);
            this.pnLogo.TabIndex = 1;
            // 
            // pnDanhmuc
            // 
            this.pnDanhmuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnDanhmuc.Controls.Add(this.btnPhanquyen);
            this.pnDanhmuc.Controls.Add(this.btnThongke);
            this.pnDanhmuc.Controls.Add(this.btnQLHĐ);
            this.pnDanhmuc.Controls.Add(this.btnSp);
            this.pnDanhmuc.Controls.Add(this.btnLoaisp);
            this.pnDanhmuc.Controls.Add(this.btnNCC);
            this.pnDanhmuc.Controls.Add(this.btnKhachhang);
            this.pnDanhmuc.Controls.Add(this.btnNhanvien);
            this.pnDanhmuc.Controls.Add(this.btnDanhmuc);
            this.pnDanhmuc.Location = new System.Drawing.Point(1, 206);
            this.pnDanhmuc.Name = "pnDanhmuc";
            this.pnDanhmuc.Size = new System.Drawing.Size(279, 782);
            this.pnDanhmuc.TabIndex = 2;
            // 
            // btnPhanquyen
            // 
            this.btnPhanquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanquyen.Location = new System.Drawing.Point(57, 694);
            this.btnPhanquyen.Name = "btnPhanquyen";
            this.btnPhanquyen.Size = new System.Drawing.Size(143, 55);
            this.btnPhanquyen.TabIndex = 8;
            this.btnPhanquyen.Text = "Phân quyền";
            this.btnPhanquyen.UseVisualStyleBackColor = true;
            // 
            // btnThongke
            // 
            this.btnThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.Location = new System.Drawing.Point(57, 612);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(143, 55);
            this.btnThongke.TabIndex = 7;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = true;
            // 
            // btnQLHĐ
            // 
            this.btnQLHĐ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLHĐ.Location = new System.Drawing.Point(57, 527);
            this.btnQLHĐ.Name = "btnQLHĐ";
            this.btnQLHĐ.Size = new System.Drawing.Size(143, 55);
            this.btnQLHĐ.TabIndex = 6;
            this.btnQLHĐ.Text = "Quản lý hóa đơn";
            this.btnQLHĐ.UseVisualStyleBackColor = true;
            // 
            // btnSp
            // 
            this.btnSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSp.Location = new System.Drawing.Point(57, 445);
            this.btnSp.Name = "btnSp";
            this.btnSp.Size = new System.Drawing.Size(143, 55);
            this.btnSp.TabIndex = 5;
            this.btnSp.Text = "Sản phẩm";
            this.btnSp.UseVisualStyleBackColor = true;
            // 
            // btnLoaisp
            // 
            this.btnLoaisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaisp.Location = new System.Drawing.Point(57, 362);
            this.btnLoaisp.Name = "btnLoaisp";
            this.btnLoaisp.Size = new System.Drawing.Size(143, 55);
            this.btnLoaisp.TabIndex = 4;
            this.btnLoaisp.Text = "Loại sản phẩm";
            this.btnLoaisp.UseVisualStyleBackColor = true;
            // 
            // btnNCC
            // 
            this.btnNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCC.Location = new System.Drawing.Point(57, 284);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(143, 55);
            this.btnNCC.TabIndex = 3;
            this.btnNCC.Text = "Nhà cung cấp";
            this.btnNCC.UseVisualStyleBackColor = true;
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachhang.Location = new System.Drawing.Point(57, 201);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(143, 55);
            this.btnKhachhang.TabIndex = 2;
            this.btnKhachhang.Text = "Khách hàng";
            this.btnKhachhang.UseVisualStyleBackColor = true;
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanvien.Location = new System.Drawing.Point(57, 121);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(143, 55);
            this.btnNhanvien.TabIndex = 1;
            this.btnNhanvien.Text = "Nhân viên";
            this.btnNhanvien.UseVisualStyleBackColor = true;
            // 
            // btnDanhmuc
            // 
            this.btnDanhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhmuc.Location = new System.Drawing.Point(57, 44);
            this.btnDanhmuc.Name = "btnDanhmuc";
            this.btnDanhmuc.Size = new System.Drawing.Size(143, 55);
            this.btnDanhmuc.TabIndex = 0;
            this.btnDanhmuc.Text = "Danh mục";
            this.btnDanhmuc.UseVisualStyleBackColor = true;
            // 
            // lbQLCH
            // 
            this.lbQLCH.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbQLCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLCH.Location = new System.Drawing.Point(283, -1);
            this.lbQLCH.Name = "lbQLCH";
            this.lbQLCH.Padding = new System.Windows.Forms.Padding(300, 20, 0, 0);
            this.lbQLCH.Size = new System.Drawing.Size(1639, 66);
            this.lbQLCH.TabIndex = 7;
            this.lbQLCH.Text = "Quản lý cửa hàng bán điện thoại";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pnUserControl
            // 
            this.pnUserControl.BackColor = System.Drawing.Color.Silver;
            this.pnUserControl.Location = new System.Drawing.Point(283, 68);
            this.pnUserControl.Name = "pnUserControl";
            this.pnUserControl.Size = new System.Drawing.Size(1639, 920);
            this.pnUserControl.TabIndex = 8;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 983);
            this.Controls.Add(this.pnUserControl);
            this.Controls.Add(this.lbQLCH);
            this.Controls.Add(this.pnDanhmuc);
            this.Controls.Add(this.pnLogo);
            this.Name = "fTableManager";
            this.Text = "fTableManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnDanhmuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Panel pnDanhmuc;
        private System.Windows.Forms.Button btnDanhmuc;
        private System.Windows.Forms.Label lbQLCH;
        private System.Windows.Forms.Button btnQLHĐ;
        private System.Windows.Forms.Button btnSp;
        private System.Windows.Forms.Button btnLoaisp;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.Button btnKhachhang;
        private System.Windows.Forms.Button btnNhanvien;
        private System.Windows.Forms.Button btnPhanquyen;
        private System.Windows.Forms.Button btnThongke;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel pnUserControl;
    }
}