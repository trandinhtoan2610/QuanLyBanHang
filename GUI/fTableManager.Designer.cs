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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerDropDown = new System.Windows.Forms.Timer(this.components);
            this.timerDropDown2 = new System.Windows.Forms.Timer(this.components);
            this.nhanvien1 = new GUI.Nhanvien();
            this.lbLogo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbQLCH = new System.Windows.Forms.Label();
            this.pnDanhmuc.SuspendLayout();
            this.pnQuanlyhoadon.SuspendLayout();
            this.pnDropDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.pnUserControl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDanhmuc
            // 
            this.pnDanhmuc.BackColor = System.Drawing.Color.Silver;
            this.pnDanhmuc.Controls.Add(this.button2);
            this.pnDanhmuc.Controls.Add(this.button1);
            this.pnDanhmuc.Controls.Add(this.pnQuanlyhoadon);
            this.pnDanhmuc.Controls.Add(this.pnDropDown);
            this.pnDanhmuc.Location = new System.Drawing.Point(1, 206);
            this.pnDanhmuc.Margin = new System.Windows.Forms.Padding(0);
            this.pnDanhmuc.Name = "pnDanhmuc";
            this.pnDanhmuc.Size = new System.Drawing.Size(279, 782);
            this.pnDanhmuc.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 425);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(279, 55);
            this.button2.TabIndex = 9;
            this.button2.Text = "Phân quyền";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 370);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(279, 55);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thống kê";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pnQuanlyhoadon
            // 
            this.pnQuanlyhoadon.Controls.Add(this.btnHoadonnhap);
            this.pnQuanlyhoadon.Controls.Add(this.btnNhaphang);
            this.pnQuanlyhoadon.Controls.Add(this.btnHoadonban);
            this.pnQuanlyhoadon.Controls.Add(this.btnBanhang);
            this.pnQuanlyhoadon.Controls.Add(this.btnQuanlyhoadon);
            this.pnQuanlyhoadon.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnQuanlyhoadon.Location = new System.Drawing.Point(0, 315);
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
            this.btnHoadonnhap.Location = new System.Drawing.Point(0, 220);
            this.btnHoadonnhap.Name = "btnHoadonnhap";
            this.btnHoadonnhap.Size = new System.Drawing.Size(279, 56);
            this.btnHoadonnhap.TabIndex = 9;
            this.btnHoadonnhap.Text = "Hóa đơn nhập";
            this.btnHoadonnhap.UseVisualStyleBackColor = false;
            // 
            // btnNhaphang
            // 
            this.btnNhaphang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNhaphang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhaphang.FlatAppearance.BorderSize = 0;
            this.btnNhaphang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhaphang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhaphang.Location = new System.Drawing.Point(0, 165);
            this.btnNhaphang.Name = "btnNhaphang";
            this.btnNhaphang.Size = new System.Drawing.Size(279, 55);
            this.btnNhaphang.TabIndex = 8;
            this.btnNhaphang.Text = "Nhập hàng";
            this.btnNhaphang.UseVisualStyleBackColor = false;
            // 
            // btnHoadonban
            // 
            this.btnHoadonban.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnHoadonban.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoadonban.FlatAppearance.BorderSize = 0;
            this.btnHoadonban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoadonban.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoadonban.Location = new System.Drawing.Point(0, 110);
            this.btnHoadonban.Name = "btnHoadonban";
            this.btnHoadonban.Size = new System.Drawing.Size(279, 55);
            this.btnHoadonban.TabIndex = 10;
            this.btnHoadonban.Text = "Hóa đơn bán";
            this.btnHoadonban.UseVisualStyleBackColor = false;
            // 
            // btnBanhang
            // 
            this.btnBanhang.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBanhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBanhang.FlatAppearance.BorderSize = 0;
            this.btnBanhang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanhang.Location = new System.Drawing.Point(0, 55);
            this.btnBanhang.Name = "btnBanhang";
            this.btnBanhang.Size = new System.Drawing.Size(279, 55);
            this.btnBanhang.TabIndex = 7;
            this.btnBanhang.Text = "Bán hàng";
            this.btnBanhang.UseVisualStyleBackColor = false;
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
            this.pnDropDown.MaximumSize = new System.Drawing.Size(279, 315);
            this.pnDropDown.MinimumSize = new System.Drawing.Size(279, 55);
            this.pnDropDown.Name = "pnDropDown";
            this.pnDropDown.Size = new System.Drawing.Size(279, 315);
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
            this.btnSp.Location = new System.Drawing.Point(0, 55);
            this.btnSp.Name = "btnSp";
            this.btnSp.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
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
            this.btnLoaisp.Image = ((System.Drawing.Image)(resources.GetObject("btnLoaisp.Image")));
            this.btnLoaisp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoaisp.Location = new System.Drawing.Point(0, 105);
            this.btnLoaisp.Name = "btnLoaisp";
            this.btnLoaisp.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
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
            this.btnNhanvien.Image = ((System.Drawing.Image)(resources.GetObject("btnNhanvien.Image")));
            this.btnNhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.Location = new System.Drawing.Point(0, 155);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
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
            this.btnNCC.Image = ((System.Drawing.Image)(resources.GetObject("btnNCC.Image")));
            this.btnNCC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNCC.Location = new System.Drawing.Point(0, 210);
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
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
            this.btnKhachhang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachhang.Image")));
            this.btnKhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachhang.Location = new System.Drawing.Point(0, 260);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnKhachhang.Size = new System.Drawing.Size(279, 55);
            this.btnKhachhang.TabIndex = 2;
            this.btnKhachhang.Text = "Khách hàng";
            this.btnKhachhang.UseVisualStyleBackColor = false;
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
            this.pnUserControl.Location = new System.Drawing.Point(280, 65);
            this.pnUserControl.Margin = new System.Windows.Forms.Padding(0);
            this.pnUserControl.Name = "pnUserControl";
            this.pnUserControl.Size = new System.Drawing.Size(1644, 920);
            this.pnUserControl.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbLogo);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 209);
            this.panel1.TabIndex = 1;
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
            // nhanvien1
            // 
            this.nhanvien1.Location = new System.Drawing.Point(0, 3);
            this.nhanvien1.Margin = new System.Windows.Forms.Padding(0);
            this.nhanvien1.Name = "nhanvien1";
            this.nhanvien1.Size = new System.Drawing.Size(1644, 920);
            this.nhanvien1.TabIndex = 0;
            // 
            // lbLogo
            // 
            this.lbLogo.Image = ((System.Drawing.Image)(resources.GetObject("lbLogo.Image")));
            this.lbLogo.Location = new System.Drawing.Point(3, 7);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(180, 200);
            this.lbLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(160, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 123);
            this.label1.TabIndex = 9;
            // 
            // lbQLCH
            // 
            this.lbQLCH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbQLCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQLCH.Location = new System.Drawing.Point(280, -1);
            this.lbQLCH.Name = "lbQLCH";
            this.lbQLCH.Padding = new System.Windows.Forms.Padding(500, 20, 0, 0);
            this.lbQLCH.Size = new System.Drawing.Size(1644, 66);
            this.lbQLCH.TabIndex = 7;
            this.lbQLCH.Text = "Quản lý cửa hàng bán điện thoại";
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fTableManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.pnDanhmuc.ResumeLayout(false);
            this.pnQuanlyhoadon.ResumeLayout(false);
            this.pnDropDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.pnUserControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDanhmuc;

        private System.Windows.Forms.Panel pnDropDown;
        private System.Windows.Forms.Timer timerDropDown;

        private System.Windows.Forms.Panel pnQuanlyhoadon;
        private System.Windows.Forms.Button btnHoadonnhap;
        private System.Windows.Forms.Button btnNhaphang;
        private System.Windows.Forms.Button btnHoadonban;
        private System.Windows.Forms.Button btnBanhang;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerDropDown2;
        private Nhanvien nhanvien1;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbQLCH;
    }
}