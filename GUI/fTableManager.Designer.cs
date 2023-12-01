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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnDanhmuc = new System.Windows.Forms.Panel();
            this.btnPhanquyen = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.pnQuanlyhoadon = new System.Windows.Forms.Panel();
            this.btnHoadonnhap = new System.Windows.Forms.Button();
            this.btnNhaphang = new System.Windows.Forms.Button();
            this.btnHoadonban = new System.Windows.Forms.Button();
            this.btnBanhang = new System.Windows.Forms.Button();
            this.btnQuanlyhoadon = new System.Windows.Forms.Button();
            this.pnDropDown = new System.Windows.Forms.Panel();
            this.btnDanhmuc = new System.Windows.Forms.Button();
            this.btnSp = new System.Windows.Forms.Button();
            this.btnLoaisp = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.btnNCC = new System.Windows.Forms.Button();
            this.btnKhachhang = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pnUserControl = new System.Windows.Forms.Panel();
            this.sanpham1 = new GUI.Sanpham();
            this.giohang = new GUI.GioHang();
            this.thongke1 = new GUI.Thongke();
            this.phanquyen1 = new GUI.Phanquyen();
            this.nhaphang1 = new GUI.Nhaphang();
            this.nhanvien1 = new GUI.Nhanvien();
            this.ncc1 = new GUI.NCC();
            this.loaiSP1 = new GUI.LoaiSP();
            this.khachhang1 = new GUI.Khachhang();
            this.hDnhap1 = new GUI.HDnhap();
            this.hDban1 = new GUI.HDban();
            this.banhang1 = new GUI.Banhang();
            this.fTimkiem1 = new GUI.fTimkiem();
            this.timerDropDown = new System.Windows.Forms.Timer(this.components);
            this.timerDropDown2 = new System.Windows.Forms.Timer(this.components);
            this.lbQLCH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLogo = new System.Windows.Forms.Label();
            this.pnDanhmuc.SuspendLayout();
            this.pnQuanlyhoadon.SuspendLayout();
            this.pnDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.pnUserControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDanhmuc
            // 
            this.pnDanhmuc.BackColor = System.Drawing.Color.Silver;
            this.pnDanhmuc.Controls.Add(this.btnPhanquyen);
            this.pnDanhmuc.Controls.Add(this.btnThongke);
            this.pnDanhmuc.Controls.Add(this.pnQuanlyhoadon);
            this.pnDanhmuc.Controls.Add(this.pnDropDown);
            this.pnDanhmuc.Location = new System.Drawing.Point(1, 204);
            this.pnDanhmuc.Margin = new System.Windows.Forms.Padding(0);
            this.pnDanhmuc.Name = "pnDanhmuc";
            this.pnDanhmuc.Size = new System.Drawing.Size(280, 609);
            this.pnDanhmuc.TabIndex = 2;
            // 
            // btnPhanquyen
            // 
            this.btnPhanquyen.BackColor = System.Drawing.Color.White;
            this.btnPhanquyen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhanquyen.FlatAppearance.BorderSize = 0;
            this.btnPhanquyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanquyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanquyen.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanquyen.Image")));
            this.btnPhanquyen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanquyen.Location = new System.Drawing.Point(0, 165);
            this.btnPhanquyen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhanquyen.Name = "btnPhanquyen";
            this.btnPhanquyen.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnPhanquyen.Size = new System.Drawing.Size(280, 55);
            this.btnPhanquyen.TabIndex = 9;
            this.btnPhanquyen.Text = "Phân quyền";
            this.btnPhanquyen.UseVisualStyleBackColor = false;
            this.btnPhanquyen.Click += new System.EventHandler(this.btnPhanquyen_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.Color.White;
            this.btnThongke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongke.FlatAppearance.BorderSize = 0;
            this.btnThongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.Image = ((System.Drawing.Image)(resources.GetObject("btnThongke.Image")));
            this.btnThongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.Location = new System.Drawing.Point(0, 110);
            this.btnThongke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnThongke.Size = new System.Drawing.Size(280, 55);
            this.btnThongke.TabIndex = 8;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // pnQuanlyhoadon
            // 
            this.pnQuanlyhoadon.Controls.Add(this.btnHoadonnhap);
            this.pnQuanlyhoadon.Controls.Add(this.btnNhaphang);
            this.pnQuanlyhoadon.Controls.Add(this.btnHoadonban);
            this.pnQuanlyhoadon.Controls.Add(this.btnBanhang);
            this.pnQuanlyhoadon.Controls.Add(this.btnQuanlyhoadon);
            this.pnQuanlyhoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnQuanlyhoadon.Location = new System.Drawing.Point(0, 55);
            this.pnQuanlyhoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnQuanlyhoadon.MaximumSize = new System.Drawing.Size(279, 276);
            this.pnQuanlyhoadon.MinimumSize = new System.Drawing.Size(279, 55);
            this.pnQuanlyhoadon.Name = "pnQuanlyhoadon";
            this.pnQuanlyhoadon.Size = new System.Drawing.Size(279, 55);
            this.pnQuanlyhoadon.TabIndex = 7;
            // 
            // btnHoadonnhap
            // 
            this.btnHoadonnhap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHoadonnhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoadonnhap.FlatAppearance.BorderSize = 0;
            this.btnHoadonnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoadonnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoadonnhap.Image = ((System.Drawing.Image)(resources.GetObject("btnHoadonnhap.Image")));
            this.btnHoadonnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoadonnhap.Location = new System.Drawing.Point(0, 220);
            this.btnHoadonnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoadonnhap.Name = "btnHoadonnhap";
            this.btnHoadonnhap.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHoadonnhap.Size = new System.Drawing.Size(279, 57);
            this.btnHoadonnhap.TabIndex = 9;
            this.btnHoadonnhap.Text = "Hóa đơn nhập";
            this.btnHoadonnhap.UseVisualStyleBackColor = false;
            this.btnHoadonnhap.Click += new System.EventHandler(this.btnHoadonnhap_Click);
            // 
            // btnNhaphang
            // 
            this.btnNhaphang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNhaphang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhaphang.FlatAppearance.BorderSize = 0;
            this.btnNhaphang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhaphang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaphang.Image = ((System.Drawing.Image)(resources.GetObject("btnNhaphang.Image")));
            this.btnNhaphang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhaphang.Location = new System.Drawing.Point(0, 165);
            this.btnNhaphang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhaphang.Name = "btnNhaphang";
            this.btnNhaphang.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNhaphang.Size = new System.Drawing.Size(279, 55);
            this.btnNhaphang.TabIndex = 8;
            this.btnNhaphang.Text = "Nhập hàng";
            this.btnNhaphang.UseVisualStyleBackColor = false;
            this.btnNhaphang.Click += new System.EventHandler(this.btnNhaphang_Click);
            // 
            // btnHoadonban
            // 
            this.btnHoadonban.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHoadonban.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoadonban.FlatAppearance.BorderSize = 0;
            this.btnHoadonban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoadonban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoadonban.Image = ((System.Drawing.Image)(resources.GetObject("btnHoadonban.Image")));
            this.btnHoadonban.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoadonban.Location = new System.Drawing.Point(0, 110);
            this.btnHoadonban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoadonban.Name = "btnHoadonban";
            this.btnHoadonban.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHoadonban.Size = new System.Drawing.Size(279, 55);
            this.btnHoadonban.TabIndex = 10;
            this.btnHoadonban.Text = "Hóa đơn bán";
            this.btnHoadonban.UseVisualStyleBackColor = false;
            this.btnHoadonban.Click += new System.EventHandler(this.btnHoadonban_Click);
            // 
            // btnBanhang
            // 
            this.btnBanhang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBanhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBanhang.FlatAppearance.BorderSize = 0;
            this.btnBanhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanhang.Image = ((System.Drawing.Image)(resources.GetObject("btnBanhang.Image")));
            this.btnBanhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanhang.Location = new System.Drawing.Point(0, 55);
            this.btnBanhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBanhang.Name = "btnBanhang";
            this.btnBanhang.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnBanhang.Size = new System.Drawing.Size(279, 55);
            this.btnBanhang.TabIndex = 7;
            this.btnBanhang.Text = "Bán hàng";
            this.btnBanhang.UseVisualStyleBackColor = false;
            this.btnBanhang.Click += new System.EventHandler(this.btnBanhang_Click);
            // 
            // btnQuanlyhoadon
            // 
            this.btnQuanlyhoadon.BackColor = System.Drawing.Color.White;
            this.btnQuanlyhoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnQuanlyhoadon.FlatAppearance.BorderSize = 0;
            this.btnQuanlyhoadon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanlyhoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuanlyhoadon.Image = ((System.Drawing.Image)(resources.GetObject("btnQuanlyhoadon.Image")));
            this.btnQuanlyhoadon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuanlyhoadon.Location = new System.Drawing.Point(0, 0);
            this.btnQuanlyhoadon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuanlyhoadon.Name = "btnQuanlyhoadon";
            this.btnQuanlyhoadon.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnQuanlyhoadon.Size = new System.Drawing.Size(279, 55);
            this.btnQuanlyhoadon.TabIndex = 6;
            this.btnQuanlyhoadon.Text = "Quản lý hóa đơn";
            this.btnQuanlyhoadon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuanlyhoadon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuanlyhoadon.UseVisualStyleBackColor = false;
            this.btnQuanlyhoadon.Click += new System.EventHandler(this.btnQuanlyhoadon_Click);
            // 
            // pnDropDown
            // 
            this.pnDropDown.Controls.Add(this.btnDanhmuc);
            this.pnDropDown.Controls.Add(this.btnSp);
            this.pnDropDown.Controls.Add(this.btnLoaisp);
            this.pnDropDown.Controls.Add(this.btnNhanvien);
            this.pnDropDown.Controls.Add(this.btnNCC);
            this.pnDropDown.Controls.Add(this.btnKhachhang);
            this.pnDropDown.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDropDown.Location = new System.Drawing.Point(0, 0);
            this.pnDropDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnDanhmuc.Image = ((System.Drawing.Image)(resources.GetObject("btnDanhmuc.Image")));
            this.btnDanhmuc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanhmuc.Location = new System.Drawing.Point(0, 0);
            this.btnDanhmuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDanhmuc.Name = "btnDanhmuc";
            this.btnDanhmuc.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
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
            this.btnSp.Image = ((System.Drawing.Image)(resources.GetObject("btnSp.Image")));
            this.btnSp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSp.Location = new System.Drawing.Point(0, -205);
            this.btnSp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSp.Name = "btnSp";
            this.btnSp.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnSp.Size = new System.Drawing.Size(279, 50);
            this.btnSp.TabIndex = 5;
            this.btnSp.Text = "Sản phẩm";
            this.btnSp.UseVisualStyleBackColor = false;
            this.btnSp.Click += new System.EventHandler(this.btnSp_Click);
            // 
            // btnLoaisp
            // 
            this.btnLoaisp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLoaisp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLoaisp.FlatAppearance.BorderSize = 0;
            this.btnLoaisp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoaisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaisp.Image = ((System.Drawing.Image)(resources.GetObject("btnLoaisp.Image")));
            this.btnLoaisp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoaisp.Location = new System.Drawing.Point(0, -155);
            this.btnLoaisp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoaisp.Name = "btnLoaisp";
            this.btnLoaisp.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnLoaisp.Size = new System.Drawing.Size(279, 50);
            this.btnLoaisp.TabIndex = 4;
            this.btnLoaisp.Text = "Loại sản phẩm";
            this.btnLoaisp.UseVisualStyleBackColor = false;
            this.btnLoaisp.Click += new System.EventHandler(this.btnLoaisp_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNhanvien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNhanvien.FlatAppearance.BorderSize = 0;
            this.btnNhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanvien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanvien.Image")));
            this.btnNhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.Location = new System.Drawing.Point(0, -105);
            this.btnNhanvien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNhanvien.Size = new System.Drawing.Size(279, 55);
            this.btnNhanvien.TabIndex = 1;
            this.btnNhanvien.Text = "Nhân viên";
            this.btnNhanvien.UseVisualStyleBackColor = false;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // btnNCC
            // 
            this.btnNCC.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNCC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnNCC.FlatAppearance.BorderSize = 0;
            this.btnNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnNCC.Image")));
            this.btnNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.Location = new System.Drawing.Point(0, -50);
            this.btnNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnNCC.Size = new System.Drawing.Size(279, 50);
            this.btnNCC.TabIndex = 3;
            this.btnNCC.Text = "Nhà cung cấp";
            this.btnNCC.UseVisualStyleBackColor = false;
            this.btnNCC.Click += new System.EventHandler(this.btnNCC_Click);
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKhachhang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnKhachhang.FlatAppearance.BorderSize = 0;
            this.btnKhachhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachhang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachhang.Image")));
            this.btnKhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachhang.Location = new System.Drawing.Point(0, 0);
            this.btnKhachhang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnKhachhang.Size = new System.Drawing.Size(279, 55);
            this.btnKhachhang.TabIndex = 2;
            this.btnKhachhang.Text = "Khách hàng";
            this.btnKhachhang.UseVisualStyleBackColor = false;
            this.btnKhachhang.Click += new System.EventHandler(this.btnKhachhang_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pnUserControl
            // 
            this.pnUserControl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnUserControl.Controls.Add(this.sanpham1);
            this.pnUserControl.Controls.Add(this.giohang);
            this.pnUserControl.Controls.Add(this.thongke1);
            this.pnUserControl.Controls.Add(this.phanquyen1);
            this.pnUserControl.Controls.Add(this.nhaphang1);
            this.pnUserControl.Controls.Add(this.nhanvien1);
            this.pnUserControl.Controls.Add(this.ncc1);
            this.pnUserControl.Controls.Add(this.loaiSP1);
            this.pnUserControl.Controls.Add(this.khachhang1);
            this.pnUserControl.Controls.Add(this.hDnhap1);
            this.pnUserControl.Controls.Add(this.hDban1);
            this.pnUserControl.Controls.Add(this.banhang1);
            this.pnUserControl.Controls.Add(this.fTimkiem1);
            this.pnUserControl.Location = new System.Drawing.Point(280, 65);
            this.pnUserControl.Margin = new System.Windows.Forms.Padding(0);
            this.pnUserControl.Name = "pnUserControl";
            this.pnUserControl.Size = new System.Drawing.Size(1233, 748);
            this.pnUserControl.TabIndex = 8;
            // 
            // sanpham1
            // 
            this.sanpham1.Location = new System.Drawing.Point(0, 4);
            this.sanpham1.Margin = new System.Windows.Forms.Padding(2);
            this.sanpham1.Name = "sanpham1";
            this.sanpham1.Size = new System.Drawing.Size(1229, 748);
            this.sanpham1.TabIndex = 10;
            // 
            // giohang
            // 
            this.giohang.Location = new System.Drawing.Point(0, 0);
            this.giohang.Margin = new System.Windows.Forms.Padding(2);
            this.giohang.Name = "giohang";
            this.giohang.Size = new System.Drawing.Size(1233, 748);
            this.giohang.TabIndex = 13;
            // 
            // thongke1
            // 
            this.thongke1.Location = new System.Drawing.Point(0, 0);
            this.thongke1.Margin = new System.Windows.Forms.Padding(2);
            this.thongke1.Name = "thongke1";
            this.thongke1.Size = new System.Drawing.Size(1233, 748);
            this.thongke1.TabIndex = 9;
            // 
            // phanquyen1
            // 
            this.phanquyen1.Location = new System.Drawing.Point(0, 0);
            this.phanquyen1.Margin = new System.Windows.Forms.Padding(2);
            this.phanquyen1.Name = "phanquyen1";
            this.phanquyen1.Size = new System.Drawing.Size(1229, 748);
            this.phanquyen1.TabIndex = 8;
            // 
            // nhaphang1
            // 
            this.nhaphang1.Location = new System.Drawing.Point(0, 0);
            this.nhaphang1.Margin = new System.Windows.Forms.Padding(2);
            this.nhaphang1.Name = "nhaphang1";
            this.nhaphang1.Size = new System.Drawing.Size(1233, 748);
            this.nhaphang1.TabIndex = 7;
            // 
            // nhanvien1
            // 
            this.nhanvien1.Location = new System.Drawing.Point(0, 0);
            this.nhanvien1.Margin = new System.Windows.Forms.Padding(0);
            this.nhanvien1.Name = "nhanvien1";
            this.nhanvien1.Size = new System.Drawing.Size(1233, 748);
            this.nhanvien1.TabIndex = 6;
            // 
            // ncc1
            // 
            this.ncc1.Location = new System.Drawing.Point(0, 0);
            this.ncc1.Margin = new System.Windows.Forms.Padding(2);
            this.ncc1.Name = "ncc1";
            this.ncc1.Size = new System.Drawing.Size(1233, 748);
            this.ncc1.TabIndex = 5;
            // 
            // loaiSP1
            // 
            this.loaiSP1.Location = new System.Drawing.Point(0, 0);
            this.loaiSP1.Margin = new System.Windows.Forms.Padding(2);
            this.loaiSP1.Name = "loaiSP1";
            this.loaiSP1.Size = new System.Drawing.Size(1229, 748);
            this.loaiSP1.TabIndex = 4;
            // 
            // khachhang1
            // 
            this.khachhang1.Location = new System.Drawing.Point(0, 0);
            this.khachhang1.Margin = new System.Windows.Forms.Padding(2);
            this.khachhang1.Name = "khachhang1";
            this.khachhang1.Size = new System.Drawing.Size(1229, 748);
            this.khachhang1.TabIndex = 3;
            // 
            // hDnhap1
            // 
            this.hDnhap1.Location = new System.Drawing.Point(0, 0);
            this.hDnhap1.Margin = new System.Windows.Forms.Padding(2);
            this.hDnhap1.Name = "hDnhap1";
            this.hDnhap1.Size = new System.Drawing.Size(1233, 748);
            this.hDnhap1.TabIndex = 2;
            // 
            // hDban1
            // 
            this.hDban1.Location = new System.Drawing.Point(0, 0);
            this.hDban1.Margin = new System.Windows.Forms.Padding(2);
            this.hDban1.Name = "hDban1";
            this.hDban1.Size = new System.Drawing.Size(1233, 748);
            this.hDban1.TabIndex = 1;
            // 
            // banhang1
            // 
            this.banhang1.Location = new System.Drawing.Point(0, 0);
            this.banhang1.Margin = new System.Windows.Forms.Padding(2);
            this.banhang1.Name = "banhang1";
            this.banhang1.Size = new System.Drawing.Size(1233, 748);
            this.banhang1.TabIndex = 0;
            // 
            // fTimkiem1
            // 
            this.fTimkiem1.Location = new System.Drawing.Point(0, 0);
            this.fTimkiem1.Margin = new System.Windows.Forms.Padding(2);
            this.fTimkiem1.Name = "fTimkiem1";
            this.fTimkiem1.Size = new System.Drawing.Size(1229, 748);
            this.fTimkiem1.TabIndex = 11;
            // 
            // timerDropDown
            // 
            this.timerDropDown.Interval = 1;
            this.timerDropDown.Tick += new System.EventHandler(this.timerDropDown_Tick);
            // 
            // timerDropDown2
            // 
            this.timerDropDown2.Interval = 15;
            this.timerDropDown2.Tick += new System.EventHandler(this.timerDropDown2_Tick);
            // 
            // lbQLCH
            // 
            this.lbQLCH.BackColor = System.Drawing.Color.Silver;
            this.lbQLCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbQLCH.Location = new System.Drawing.Point(280, 0);
            this.lbQLCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbQLCH.Name = "lbQLCH";
            this.lbQLCH.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbQLCH.Size = new System.Drawing.Size(1233, 65);
            this.lbQLCH.TabIndex = 10;
            this.lbQLCH.Text = "Quản lý cửa hàng điện thoại";
            this.lbQLCH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(161, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 120);
            this.label1.TabIndex = 11;
            // 
            // lbLogo
            // 
            this.lbLogo.Image = ((System.Drawing.Image)(resources.GetObject("lbLogo.Image")));
            this.lbLogo.Location = new System.Drawing.Point(0, 0);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(186, 204);
            this.lbLogo.TabIndex = 9;
            // 
            // fTableManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1513, 813);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbQLCH);
            this.Controls.Add(this.lbLogo);
            this.Controls.Add(this.pnUserControl);
            this.Controls.Add(this.pnDanhmuc);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTableManager";
            this.Load += new System.EventHandler(this.fTableManager_Load);
            this.pnDanhmuc.ResumeLayout(false);
            this.pnQuanlyhoadon.ResumeLayout(false);
            this.pnDropDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.pnUserControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnDanhmuc;
        private System.Windows.Forms.Button btnQuanlyhoadon;
        private System.Windows.Forms.Button btnSp;
        private System.Windows.Forms.Button btnLoaisp;
        private System.Windows.Forms.Button btnNCC;
        private System.Windows.Forms.Button btnKhachhang;
        private System.Windows.Forms.Button btnNhanvien;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel pnUserControl;
        private System.Windows.Forms.Button btnDanhmuc;

        private System.Windows.Forms.Panel pnDropDown;
        private System.Windows.Forms.Timer timerDropDown;



        private System.Windows.Forms.Panel pnQuanlyhoadon;
        private System.Windows.Forms.Button btnHoadonnhap;
        private System.Windows.Forms.Button btnNhaphang;
        private System.Windows.Forms.Button btnHoadonban;
        private System.Windows.Forms.Button btnBanhang;
        private System.Windows.Forms.Button btnPhanquyen;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Timer timerDropDown2;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Label lbQLCH;
        private System.Windows.Forms.Label label1;
        private Sanpham sanpham1;
        private Thongke thongke1;
        private Phanquyen phanquyen1;
        private Nhaphang nhaphang1;
        private Nhanvien nhanvien1;
        private NCC ncc1;
        private LoaiSP loaiSP1;
        private Khachhang khachhang1;
        private HDnhap hDnhap1;
        private HDban hDban1;
        public Banhang banhang1;
        private fTimkiem fTimkiem1;
        public GioHang giohang;
    }
}