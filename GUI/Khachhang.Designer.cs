namespace GUI
{
    partial class Khachhang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khachhang));
            this.lbQuanly = new System.Windows.Forms.Label();
            this.lbThongtin = new System.Windows.Forms.Label();
            this.lbHoten = new System.Windows.Forms.Label();
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.lbSđt = new System.Windows.Forms.Label();
            this.tbSđt = new System.Windows.Forms.TextBox();
            this.lbGioitinh = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.lbGhichu = new System.Windows.Forms.Label();
            this.tbGhichu = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.pnThemSuaXoa = new System.Windows.Forms.Panel();
            this.tbTimkiem = new System.Windows.Forms.TextBox();
            this.btnExxport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbDanhsach = new System.Windows.Forms.Label();
            this.dtaGVKhachang = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.pnThemSuaXoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGVKhachang)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQuanly
            // 
            this.lbQuanly.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbQuanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanly.Location = new System.Drawing.Point(0, 0);
            this.lbQuanly.Name = "lbQuanly";
            this.lbQuanly.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.lbQuanly.Size = new System.Drawing.Size(1639, 47);
            this.lbQuanly.TabIndex = 5;
            this.lbQuanly.Text = "Quản lý khách hàng";
            // 
            // lbThongtin
            // 
            this.lbThongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongtin.Location = new System.Drawing.Point(18, 59);
            this.lbThongtin.Name = "lbThongtin";
            this.lbThongtin.Size = new System.Drawing.Size(223, 25);
            this.lbThongtin.TabIndex = 6;
            this.lbThongtin.Text = "Thông tin khách hàng";
            this.lbThongtin.Click += new System.EventHandler(this.lbThongtin_Click);
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoten.Location = new System.Drawing.Point(49, 151);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(56, 18);
            this.lbHoten.TabIndex = 9;
            this.lbHoten.Text = "Họ tên ";
            // 
            // tbHoten
            // 
            this.tbHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoten.Location = new System.Drawing.Point(52, 191);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(212, 24);
            this.tbHoten.TabIndex = 10;
            // 
            // lbSđt
            // 
            this.lbSđt.AutoSize = true;
            this.lbSđt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSđt.Location = new System.Drawing.Point(49, 273);
            this.lbSđt.Name = "lbSđt";
            this.lbSđt.Size = new System.Drawing.Size(94, 18);
            this.lbSđt.TabIndex = 12;
            this.lbSđt.Text = "Số điện thoại";
            // 
            // tbSđt
            // 
            this.tbSđt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSđt.Location = new System.Drawing.Point(52, 310);
            this.tbSđt.Name = "tbSđt";
            this.tbSđt.Size = new System.Drawing.Size(212, 24);
            this.tbSđt.TabIndex = 15;
            // 
            // lbGioitinh
            // 
            this.lbGioitinh.AutoSize = true;
            this.lbGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioitinh.Location = new System.Drawing.Point(49, 391);
            this.lbGioitinh.Name = "lbGioitinh";
            this.lbGioitinh.Size = new System.Drawing.Size(62, 18);
            this.lbGioitinh.TabIndex = 19;
            this.lbGioitinh.Text = "Giới tính";
            this.lbGioitinh.Click += new System.EventHandler(this.lbGioitinh_Click);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(52, 431);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(57, 20);
            this.rb1.TabIndex = 20;
            this.rb1.TabStop = true;
            this.rb1.Text = "Nam";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(137, 431);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(45, 20);
            this.rb2.TabIndex = 21;
            this.rb2.TabStop = true;
            this.rb2.Text = "Nữ";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // lbGhichu
            // 
            this.lbGhichu.AutoSize = true;
            this.lbGhichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGhichu.Location = new System.Drawing.Point(49, 504);
            this.lbGhichu.Name = "lbGhichu";
            this.lbGhichu.Size = new System.Drawing.Size(59, 18);
            this.lbGhichu.TabIndex = 24;
            this.lbGhichu.Text = "Ghi chú";
            // 
            // tbGhichu
            // 
            this.tbGhichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGhichu.Location = new System.Drawing.Point(52, 551);
            this.tbGhichu.Multiline = true;
            this.tbGhichu.Name = "tbGhichu";
            this.tbGhichu.Size = new System.Drawing.Size(212, 112);
            this.tbGhichu.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbMaKH);
            this.panel1.Controls.Add(this.tbGhichu);
            this.panel1.Controls.Add(this.lbMaKH);
            this.panel1.Controls.Add(this.lbGhichu);
            this.panel1.Controls.Add(this.lbHoten);
            this.panel1.Controls.Add(this.rb2);
            this.panel1.Controls.Add(this.tbHoten);
            this.panel1.Controls.Add(this.rb1);
            this.panel1.Controls.Add(this.lbSđt);
            this.panel1.Controls.Add(this.lbGioitinh);
            this.panel1.Controls.Add(this.tbSđt);
            this.panel1.Location = new System.Drawing.Point(22, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 702);
            this.panel1.TabIndex = 26;
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.Location = new System.Drawing.Point(49, 27);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(109, 18);
            this.lbMaKH.TabIndex = 8;
            this.lbMaKH.Text = "Mã khách hàng";
            // 
            // tbMaKH
            // 
            this.tbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaKH.Location = new System.Drawing.Point(52, 70);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(212, 24);
            this.tbMaKH.TabIndex = 27;
            // 
            // pnThemSuaXoa
            // 
            this.pnThemSuaXoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnThemSuaXoa.Controls.Add(this.tbTimkiem);
            this.pnThemSuaXoa.Controls.Add(this.btnExxport);
            this.pnThemSuaXoa.Controls.Add(this.btnDelete);
            this.pnThemSuaXoa.Controls.Add(this.btnEdit);
            this.pnThemSuaXoa.Controls.Add(this.btnAdd);
            this.pnThemSuaXoa.Location = new System.Drawing.Point(0, 814);
            this.pnThemSuaXoa.Name = "pnThemSuaXoa";
            this.pnThemSuaXoa.Size = new System.Drawing.Size(1639, 103);
            this.pnThemSuaXoa.TabIndex = 27;
            // 
            // tbTimkiem
            // 
            this.tbTimkiem.BackColor = System.Drawing.Color.White;
            this.tbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimkiem.Location = new System.Drawing.Point(896, 22);
            this.tbTimkiem.Multiline = true;
            this.tbTimkiem.Name = "tbTimkiem";
            this.tbTimkiem.Size = new System.Drawing.Size(452, 65);
            this.tbTimkiem.TabIndex = 8;
            this.tbTimkiem.Text = "Tìm kiếm theo số điện thoại";
            // 
            // btnExxport
            // 
            this.btnExxport.Image = ((System.Drawing.Image)(resources.GetObject("btnExxport.Image")));
            this.btnExxport.Location = new System.Drawing.Point(629, 22);
            this.btnExxport.Name = "btnExxport";
            this.btnExxport.Size = new System.Drawing.Size(69, 60);
            this.btnExxport.TabIndex = 7;
            this.btnExxport.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(438, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 60);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(261, 22);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 60);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(83, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 60);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // lbDanhsach
            // 
            this.lbDanhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhsach.Location = new System.Drawing.Point(434, 59);
            this.lbDanhsach.Name = "lbDanhsach";
            this.lbDanhsach.Size = new System.Drawing.Size(223, 25);
            this.lbDanhsach.TabIndex = 28;
            this.lbDanhsach.Text = "Danh sách khách hàng";
            // 
            // dtaGVKhachang
            // 
            this.dtaGVKhachang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtaGVKhachang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGVKhachang.Location = new System.Drawing.Point(400, 87);
            this.dtaGVKhachang.Name = "dtaGVKhachang";
            this.dtaGVKhachang.RowHeadersWidth = 51;
            this.dtaGVKhachang.RowTemplate.Height = 24;
            this.dtaGVKhachang.Size = new System.Drawing.Size(1236, 702);
            this.dtaGVKhachang.TabIndex = 29;
            // 
            // Khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtaGVKhachang);
            this.Controls.Add(this.lbDanhsach);
            this.Controls.Add(this.pnThemSuaXoa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbThongtin);
            this.Controls.Add(this.lbQuanly);
            this.Name = "Khachhang";
            this.Size = new System.Drawing.Size(1639, 920);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnThemSuaXoa.ResumeLayout(false);
            this.pnThemSuaXoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGVKhachang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbQuanly;
        private System.Windows.Forms.Label lbThongtin;
        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.TextBox tbHoten;
        private System.Windows.Forms.Label lbSđt;
        private System.Windows.Forms.TextBox tbSđt;
        private System.Windows.Forms.Label lbGioitinh;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.Label lbGhichu;
        private System.Windows.Forms.TextBox tbGhichu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbMaKH;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Panel pnThemSuaXoa;
        private System.Windows.Forms.TextBox tbTimkiem;
        private System.Windows.Forms.Button btnExxport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbDanhsach;
        private System.Windows.Forms.DataGridView dtaGVKhachang;
    }
}
