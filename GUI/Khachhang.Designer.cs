﻿namespace GUI
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
            this.tbMaKH = new System.Windows.Forms.TextBox();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbDanhsach = new System.Windows.Forms.Label();
            this.dtaGVKhachang = new System.Windows.Forms.DataGridView();
            this.pnThemSuaXoa = new System.Windows.Forms.Panel();
            this.tbTimkiem = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGVKhachang)).BeginInit();
            this.pnThemSuaXoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbQuanly
            // 
            this.lbQuanly.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbQuanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanly.Location = new System.Drawing.Point(0, 0);
            this.lbQuanly.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbQuanly.Name = "lbQuanly";
            this.lbQuanly.Padding = new System.Windows.Forms.Padding(4, 8, 0, 0);
            this.lbQuanly.Size = new System.Drawing.Size(1233, 38);
            this.lbQuanly.TabIndex = 5;
            this.lbQuanly.Text = "Quản lý khách hàng";
            // 
            // lbThongtin
            // 
            this.lbThongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongtin.Location = new System.Drawing.Point(14, 48);
            this.lbThongtin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbThongtin.Name = "lbThongtin";
            this.lbThongtin.Size = new System.Drawing.Size(167, 20);
            this.lbThongtin.TabIndex = 6;
            this.lbThongtin.Text = "Thông tin khách hàng";
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoten.Location = new System.Drawing.Point(37, 123);
            this.lbHoten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(46, 15);
            this.lbHoten.TabIndex = 9;
            this.lbHoten.Text = "Họ tên ";
            // 
            // tbHoten
            // 
            this.tbHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoten.Location = new System.Drawing.Point(39, 155);
            this.tbHoten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(160, 21);
            this.tbHoten.TabIndex = 10;
            // 
            // lbSđt
            // 
            this.lbSđt.AutoSize = true;
            this.lbSđt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSđt.Location = new System.Drawing.Point(37, 222);
            this.lbSđt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSđt.Name = "lbSđt";
            this.lbSđt.Size = new System.Drawing.Size(79, 15);
            this.lbSđt.TabIndex = 12;
            this.lbSđt.Text = "Số điện thoại";
            // 
            // tbSđt
            // 
            this.tbSđt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSđt.Location = new System.Drawing.Point(39, 252);
            this.tbSđt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSđt.Name = "tbSđt";
            this.tbSđt.Size = new System.Drawing.Size(160, 21);
            this.tbSđt.TabIndex = 15;
            // 
            // lbGioitinh
            // 
            this.lbGioitinh.AutoSize = true;
            this.lbGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioitinh.Location = new System.Drawing.Point(37, 318);
            this.lbGioitinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGioitinh.Name = "lbGioitinh";
            this.lbGioitinh.Size = new System.Drawing.Size(52, 15);
            this.lbGioitinh.TabIndex = 19;
            this.lbGioitinh.Text = "Giới tính";
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Location = new System.Drawing.Point(39, 350);
            this.rb1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(47, 17);
            this.rb1.TabIndex = 20;
            this.rb1.TabStop = true;
            this.rb1.Text = "Nam";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Location = new System.Drawing.Point(103, 350);
            this.rb2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(39, 17);
            this.rb2.TabIndex = 21;
            this.rb2.TabStop = true;
            this.rb2.Text = "Nữ";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // lbGhichu
            // 
            this.lbGhichu.AutoSize = true;
            this.lbGhichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGhichu.Location = new System.Drawing.Point(37, 410);
            this.lbGhichu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGhichu.Name = "lbGhichu";
            this.lbGhichu.Size = new System.Drawing.Size(49, 15);
            this.lbGhichu.TabIndex = 24;
            this.lbGhichu.Text = "Ghi chú";
            // 
            // tbGhichu
            // 
            this.tbGhichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGhichu.Location = new System.Drawing.Point(39, 448);
            this.tbGhichu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGhichu.Multiline = true;
            this.tbGhichu.Name = "tbGhichu";
            this.tbGhichu.Size = new System.Drawing.Size(160, 92);
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
            this.panel1.Location = new System.Drawing.Point(16, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 571);
            this.panel1.TabIndex = 26;
            // 
            // tbMaKH
            // 
            this.tbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaKH.Location = new System.Drawing.Point(39, 57);
            this.tbMaKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMaKH.Name = "tbMaKH";
            this.tbMaKH.Size = new System.Drawing.Size(160, 21);
            this.tbMaKH.TabIndex = 27;
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.Location = new System.Drawing.Point(37, 22);
            this.lbMaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(92, 15);
            this.lbMaKH.TabIndex = 8;
            this.lbMaKH.Text = "Mã khách hàng";
            // 
            // lbDanhsach
            // 
            this.lbDanhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhsach.Location = new System.Drawing.Point(326, 48);
            this.lbDanhsach.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDanhsach.Name = "lbDanhsach";
            this.lbDanhsach.Size = new System.Drawing.Size(167, 20);
            this.lbDanhsach.TabIndex = 28;
            this.lbDanhsach.Text = "Danh sách khách hàng";
            // 
            // dtaGVKhachang
            // 
            this.dtaGVKhachang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtaGVKhachang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaGVKhachang.Location = new System.Drawing.Point(300, 71);
            this.dtaGVKhachang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtaGVKhachang.Name = "dtaGVKhachang";
            this.dtaGVKhachang.RowHeadersWidth = 51;
            this.dtaGVKhachang.RowTemplate.Height = 24;
            this.dtaGVKhachang.Size = new System.Drawing.Size(933, 570);
            this.dtaGVKhachang.TabIndex = 29;
            // 
            // pnThemSuaXoa
            // 
            this.pnThemSuaXoa.BackColor = System.Drawing.Color.White;
            this.pnThemSuaXoa.Controls.Add(this.tbTimkiem);
            this.pnThemSuaXoa.Controls.Add(this.btnExport);
            this.pnThemSuaXoa.Controls.Add(this.btnDelete);
            this.pnThemSuaXoa.Controls.Add(this.btnEdit);
            this.pnThemSuaXoa.Controls.Add(this.btnAdd);
            this.pnThemSuaXoa.Location = new System.Drawing.Point(2, 656);
            this.pnThemSuaXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnThemSuaXoa.Name = "pnThemSuaXoa";
            this.pnThemSuaXoa.Size = new System.Drawing.Size(1231, 89);
            this.pnThemSuaXoa.TabIndex = 30;
            // 
            // tbTimkiem
            // 
            this.tbTimkiem.BackColor = System.Drawing.Color.White;
            this.tbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimkiem.HideSelection = false;
            this.tbTimkiem.Location = new System.Drawing.Point(656, 28);
            this.tbTimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTimkiem.Multiline = true;
            this.tbTimkiem.Name = "tbTimkiem";
            this.tbTimkiem.Size = new System.Drawing.Size(340, 39);
            this.tbTimkiem.TabIndex = 8;
            this.tbTimkiem.Text = "Tìm kiếm\r\n\r\n";
            this.tbTimkiem.Enter += new System.EventHandler(this.tbTimkiem_Enter);
            this.tbTimkiem.Leave += new System.EventHandler(this.tbTimkiem_Leave);
            // 
            // btnExport
            // 
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(472, 12);
            this.btnExport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(56, 61);
            this.btnExport.TabIndex = 7;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(337, 12);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(56, 61);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(196, 12);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 61);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(62, 12);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 61);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // Khachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnThemSuaXoa);
            this.Controls.Add(this.dtaGVKhachang);
            this.Controls.Add(this.lbDanhsach);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbThongtin);
            this.Controls.Add(this.lbQuanly);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Khachhang";
            this.Size = new System.Drawing.Size(1233, 748);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtaGVKhachang)).EndInit();
            this.pnThemSuaXoa.ResumeLayout(false);
            this.pnThemSuaXoa.PerformLayout();
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
        private System.Windows.Forms.Label lbDanhsach;
        private System.Windows.Forms.DataGridView dtaGVKhachang;
        private System.Windows.Forms.Panel pnThemSuaXoa;
        private System.Windows.Forms.TextBox tbTimkiem;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}
