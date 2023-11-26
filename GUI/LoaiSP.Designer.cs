namespace GUI
{
    partial class LoaiSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoaiSP));
            this.lbQuanly = new System.Windows.Forms.Label();
            this.lbThongtin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbTenLoaiSP = new System.Windows.Forms.TextBox();
            this.lbTenLoaiSP = new System.Windows.Forms.Label();
            this.tbMaLoaiSP = new System.Windows.Forms.TextBox();
            this.lbMaLoaiSP = new System.Windows.Forms.Label();
            this.lbDanhsach = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnThemSuaXoa = new System.Windows.Forms.Panel();
            this.tbTimkiem = new System.Windows.Forms.TextBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnThemSuaXoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbQuanly
            // 
            this.lbQuanly.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbQuanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanly.Location = new System.Drawing.Point(0, 0);
            this.lbQuanly.Name = "lbQuanly";
            this.lbQuanly.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.lbQuanly.Size = new System.Drawing.Size(1642, 47);
            this.lbQuanly.TabIndex = 5;
            this.lbQuanly.Text = "Quản lý loại sản phẩm";
            // 
            // lbThongtin
            // 
            this.lbThongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongtin.Location = new System.Drawing.Point(18, 13);
            this.lbThongtin.Name = "lbThongtin";
            this.lbThongtin.Size = new System.Drawing.Size(223, 25);
            this.lbThongtin.TabIndex = 6;
            this.lbThongtin.Text = "Thông tin loại sản phẩm";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbTenLoaiSP);
            this.panel1.Controls.Add(this.lbTenLoaiSP);
            this.panel1.Controls.Add(this.tbMaLoaiSP);
            this.panel1.Controls.Add(this.lbMaLoaiSP);
            this.panel1.Controls.Add(this.lbThongtin);
            this.panel1.Location = new System.Drawing.Point(24, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 312);
            this.panel1.TabIndex = 7;
            // 
            // tbTenLoaiSP
            // 
            this.tbTenLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenLoaiSP.Location = new System.Drawing.Point(53, 210);
            this.tbTenLoaiSP.Name = "tbTenLoaiSP";
            this.tbTenLoaiSP.Size = new System.Drawing.Size(212, 24);
            this.tbTenLoaiSP.TabIndex = 10;
            // 
            // lbTenLoaiSP
            // 
            this.lbTenLoaiSP.AutoSize = true;
            this.lbTenLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenLoaiSP.Location = new System.Drawing.Point(50, 172);
            this.lbTenLoaiSP.Name = "lbTenLoaiSP";
            this.lbTenLoaiSP.Size = new System.Drawing.Size(129, 18);
            this.lbTenLoaiSP.TabIndex = 8;
            this.lbTenLoaiSP.Text = "Tên loại sản phẩm";
            // 
            // tbMaLoaiSP
            // 
            this.tbMaLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaLoaiSP.Location = new System.Drawing.Point(53, 111);
            this.tbMaLoaiSP.Name = "tbMaLoaiSP";
            this.tbMaLoaiSP.Size = new System.Drawing.Size(212, 24);
            this.tbMaLoaiSP.TabIndex = 9;
            // 
            // lbMaLoaiSP
            // 
            this.lbMaLoaiSP.AutoSize = true;
            this.lbMaLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaLoaiSP.Location = new System.Drawing.Point(50, 74);
            this.lbMaLoaiSP.Name = "lbMaLoaiSP";
            this.lbMaLoaiSP.Size = new System.Drawing.Size(125, 18);
            this.lbMaLoaiSP.TabIndex = 8;
            this.lbMaLoaiSP.Text = "Mã loại sản phẩm";
            // 
            // lbDanhsach
            // 
            this.lbDanhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhsach.Location = new System.Drawing.Point(427, 76);
            this.lbDanhsach.Name = "lbDanhsach";
            this.lbDanhsach.Size = new System.Drawing.Size(223, 25);
            this.lbDanhsach.TabIndex = 29;
            this.lbDanhsach.Text = "Danh sách loại sản phẩm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(431, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1205, 269);
            this.dataGridView1.TabIndex = 30;
            // 
            // pnThemSuaXoa
            // 
            this.pnThemSuaXoa.BackColor = System.Drawing.Color.White;
            this.pnThemSuaXoa.Controls.Add(this.tbTimkiem);
            this.pnThemSuaXoa.Controls.Add(this.btnExport);
            this.pnThemSuaXoa.Controls.Add(this.btnDelete);
            this.pnThemSuaXoa.Controls.Add(this.btnEdit);
            this.pnThemSuaXoa.Controls.Add(this.btnAdd);
            this.pnThemSuaXoa.Location = new System.Drawing.Point(0, 407);
            this.pnThemSuaXoa.Name = "pnThemSuaXoa";
            this.pnThemSuaXoa.Size = new System.Drawing.Size(1639, 106);
            this.pnThemSuaXoa.TabIndex = 31;
            // 
            // tbTimkiem
            // 
            this.tbTimkiem.BackColor = System.Drawing.Color.White;
            this.tbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimkiem.HideSelection = false;
            this.tbTimkiem.Location = new System.Drawing.Point(875, 35);
            this.tbTimkiem.Multiline = true;
            this.tbTimkiem.Name = "tbTimkiem";
            this.tbTimkiem.Size = new System.Drawing.Size(452, 47);
            this.tbTimkiem.TabIndex = 8;
            this.tbTimkiem.Text = "Tìm kiếm\r\n\r\n";
            // 
            // btnExport
            // 
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(629, 15);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 75);
            this.btnExport.TabIndex = 7;
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(449, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 75);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.Location = new System.Drawing.Point(261, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 75);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(83, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 75);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // LoaiSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnThemSuaXoa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbDanhsach);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbQuanly);
            this.Name = "LoaiSP";
            this.Size = new System.Drawing.Size(1639, 920);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnThemSuaXoa.ResumeLayout(false);
            this.pnThemSuaXoa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbQuanly;
        private System.Windows.Forms.Label lbThongtin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbMaLoaiSP;
        private System.Windows.Forms.TextBox tbMaLoaiSP;
        private System.Windows.Forms.Label lbTenLoaiSP;
        private System.Windows.Forms.TextBox tbTenLoaiSP;
        private System.Windows.Forms.Label lbDanhsach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pnThemSuaXoa;
        private System.Windows.Forms.TextBox tbTimkiem;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}
