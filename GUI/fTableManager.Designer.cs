﻿namespace GUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnDanhmuc = new System.Windows.Forms.Panel();
            this.pnDropDown = new System.Windows.Forms.Panel();
            this.btnDanhmuc = new System.Windows.Forms.Button();
            this.btnSp = new System.Windows.Forms.Button();
            this.btnLoaisp = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.btnNCC = new System.Windows.Forms.Button();
            this.btnKhachhang = new System.Windows.Forms.Button();
            this.btnPhanquyen = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnQLHĐ = new System.Windows.Forms.Button();
            this.lbQLCH = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pnUserControl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerDropDown = new System.Windows.Forms.Timer(this.components);
            this.lbLogo = new System.Windows.Forms.Label();
            this.nhanvien1 = new GUI.Nhanvien();
            this.pnDanhmuc.SuspendLayout();
            this.pnDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.pnUserControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDanhmuc
            // 
            this.pnDanhmuc.BackColor = System.Drawing.Color.Silver;
            this.pnDanhmuc.Controls.Add(this.pnDropDown);
            this.pnDanhmuc.Controls.Add(this.btnPhanquyen);
            this.pnDanhmuc.Controls.Add(this.btnThongke);
            this.pnDanhmuc.Controls.Add(this.btnQLHĐ);
            this.pnDanhmuc.Location = new System.Drawing.Point(1, 206);
            this.pnDanhmuc.Name = "pnDanhmuc";
            this.pnDanhmuc.Size = new System.Drawing.Size(279, 782);
            this.pnDanhmuc.TabIndex = 2;
            // 
            // pnDropDown
            // 
            this.pnDropDown.Controls.Add(this.btnDanhmuc);
            this.pnDropDown.Controls.Add(this.btnSp);
            this.pnDropDown.Controls.Add(this.btnLoaisp);
            this.pnDropDown.Controls.Add(this.btnNhanvien);
            this.pnDropDown.Controls.Add(this.btnNCC);
            this.pnDropDown.Controls.Add(this.btnKhachhang);
            this.pnDropDown.Location = new System.Drawing.Point(0, 3);
            this.pnDropDown.MaximumSize = new System.Drawing.Size(279, 315);
            this.pnDropDown.MinimumSize = new System.Drawing.Size(279, 55);
            this.pnDropDown.Name = "pnDropDown";
            this.pnDropDown.Size = new System.Drawing.Size(279, 55);
            this.pnDropDown.TabIndex = 0;
            // 
            // btnDanhmuc
            // 
            this.btnDanhmuc.BackColor = System.Drawing.Color.White;
            this.btnDanhmuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDanhmuc.FlatAppearance.BorderSize = 0;
            this.btnDanhmuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhmuc.Location = new System.Drawing.Point(0, 0);
            this.btnDanhmuc.Name = "btnDanhmuc";
            this.btnDanhmuc.Size = new System.Drawing.Size(279, 55);
            this.btnDanhmuc.TabIndex = 0;
            this.btnDanhmuc.Text = "Danh mục";
            this.btnDanhmuc.UseVisualStyleBackColor = false;
            this.btnDanhmuc.Click += new System.EventHandler(this.btnDanhmuc_Click);
            // 
            // btnSp
            // 
            this.btnSp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSp.FlatAppearance.BorderSize = 0;
            this.btnSp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSp.Location = new System.Drawing.Point(0, -205);
            this.btnSp.Name = "btnSp";
            this.btnSp.Size = new System.Drawing.Size(279, 50);
            this.btnSp.TabIndex = 5;
            this.btnSp.Text = "Sản phẩm";
            this.btnSp.UseVisualStyleBackColor = false;
            // 
            // btnLoaisp
            // 
            this.btnLoaisp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLoaisp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLoaisp.FlatAppearance.BorderSize = 0;
            this.btnLoaisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaisp.Location = new System.Drawing.Point(0, -155);
            this.btnLoaisp.Name = "btnLoaisp";
            this.btnLoaisp.Size = new System.Drawing.Size(279, 50);
            this.btnLoaisp.TabIndex = 4;
            this.btnLoaisp.Text = "Loại sản phẩm";
            this.btnLoaisp.UseVisualStyleBackColor = false;
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNhanvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNhanvien.FlatAppearance.BorderSize = 0;
            this.btnNhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanvien.Location = new System.Drawing.Point(0, -105);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(279, 55);
            this.btnNhanvien.TabIndex = 1;
            this.btnNhanvien.Text = "Nhân viên";
            this.btnNhanvien.UseVisualStyleBackColor = false;
            // 
            // btnNCC
            // 
            this.btnNCC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNCC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNCC.FlatAppearance.BorderSize = 0;
            this.btnNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCC.Location = new System.Drawing.Point(0, -50);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Size = new System.Drawing.Size(279, 50);
            this.btnNCC.TabIndex = 3;
            this.btnNCC.Text = "Nhà cung cấp";
            this.btnNCC.UseVisualStyleBackColor = false;
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKhachhang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKhachhang.FlatAppearance.BorderSize = 0;
            this.btnKhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachhang.Location = new System.Drawing.Point(0, 0);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(279, 55);
            this.btnKhachhang.TabIndex = 2;
            this.btnKhachhang.Text = "Khách hàng";
            this.btnKhachhang.UseVisualStyleBackColor = false;
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
            // lbQLCH
            // 
            this.lbQLCH.BackColor = System.Drawing.Color.Silver;
            this.lbQLCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLCH.Location = new System.Drawing.Point(269, -1);
            this.lbQLCH.Name = "lbQLCH";
            this.lbQLCH.Padding = new System.Windows.Forms.Padding(500, 20, 0, 0);
            this.lbQLCH.Size = new System.Drawing.Size(1653, 66);
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
            this.pnUserControl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnUserControl.Controls.Add(this.nhanvien1);
            this.pnUserControl.Location = new System.Drawing.Point(283, 68);
            this.pnUserControl.Name = "pnUserControl";
            this.pnUserControl.Size = new System.Drawing.Size(1639, 920);
            this.pnUserControl.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.lbLogo);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 209);
            this.panel1.TabIndex = 1;
            // 
            // timerDropDown
            // 
            this.timerDropDown.Interval = 1;
            this.timerDropDown.Tick += new System.EventHandler(this.timerDropDown_Tick);
            // 
            // lbLogo
            // 
            this.lbLogo.Image = ((System.Drawing.Image)(resources.GetObject("lbLogo.Image")));
            this.lbLogo.Location = new System.Drawing.Point(54, 24);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(160, 140);
            this.lbLogo.TabIndex = 0;
            // 
            // nhanvien1
            // 
            this.nhanvien1.Location = new System.Drawing.Point(3, 3);
            this.nhanvien1.Name = "nhanvien1";
            this.nhanvien1.Size = new System.Drawing.Size(1639, 920);
            this.nhanvien1.TabIndex = 0;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 983);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnUserControl);
            this.Controls.Add(this.lbQLCH);
            this.Controls.Add(this.pnDanhmuc);
            this.Name = "fTableManager";
            this.Text = "fTableManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnDanhmuc.ResumeLayout(false);
            this.pnDropDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.pnUserControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnDanhmuc;
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
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDanhmuc;

        private System.Windows.Forms.Panel pnDropDown;
        private System.Windows.Forms.Timer timerDropDown;
        private Nhanvien nhanvien1;
    }
}