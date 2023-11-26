namespace GUI
{
    partial class Banhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banhang));
            this.gbThongtinKH = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbQuanly = new System.Windows.Forms.Label();
            this.lbHoten = new System.Windows.Forms.Label();
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.lbSđt = new System.Windows.Forms.Label();
            this.tbSđt = new System.Windows.Forms.TextBox();
            this.gbThongtinHD = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbTongtien = new System.Windows.Forms.TextBox();
            this.tbTienkhachdua = new System.Windows.Forms.TextBox();
            this.tbTienthoilai = new System.Windows.Forms.TextBox();
            this.btnThoitien = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.gbThongtinKH.SuspendLayout();
            this.gbThongtinHD.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThongtinKH
            // 
            this.gbThongtinKH.Controls.Add(this.tbSđt);
            this.gbThongtinKH.Controls.Add(this.lbSđt);
            this.gbThongtinKH.Controls.Add(this.tbHoten);
            this.gbThongtinKH.Controls.Add(this.lbHoten);
            this.gbThongtinKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongtinKH.Location = new System.Drawing.Point(28, 73);
            this.gbThongtinKH.Name = "gbThongtinKH";
            this.gbThongtinKH.Size = new System.Drawing.Size(657, 172);
            this.gbThongtinKH.TabIndex = 0;
            this.gbThongtinKH.TabStop = false;
            this.gbThongtinKH.Text = "Thông tin khách hàng";
            // 
            // lbQuanly
            // 
            this.lbQuanly.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbQuanly.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuanly.Location = new System.Drawing.Point(0, 0);
            this.lbQuanly.Margin = new System.Windows.Forms.Padding(0);
            this.lbQuanly.Name = "lbQuanly";
            this.lbQuanly.Padding = new System.Windows.Forms.Padding(5, 10, 0, 0);
            this.lbQuanly.Size = new System.Drawing.Size(1644, 47);
            this.lbQuanly.TabIndex = 5;
            this.lbQuanly.Text = "Quản lý bán hàng";
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoten.Location = new System.Drawing.Point(54, 46);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(56, 18);
            this.lbHoten.TabIndex = 10;
            this.lbHoten.Text = "Họ tên ";
            // 
            // tbHoten
            // 
            this.tbHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoten.Location = new System.Drawing.Point(57, 86);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(212, 24);
            this.tbHoten.TabIndex = 11;
            // 
            // lbSđt
            // 
            this.lbSđt.AutoSize = true;
            this.lbSđt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSđt.Location = new System.Drawing.Point(406, 46);
            this.lbSđt.Name = "lbSđt";
            this.lbSđt.Size = new System.Drawing.Size(94, 18);
            this.lbSđt.TabIndex = 13;
            this.lbSđt.Text = "Số điện thoại";
            // 
            // tbSđt
            // 
            this.tbSđt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSđt.Location = new System.Drawing.Point(409, 86);
            this.tbSđt.Name = "tbSđt";
            this.tbSđt.Size = new System.Drawing.Size(212, 24);
            this.tbSđt.TabIndex = 16;
            // 
            // gbThongtinHD
            // 
            this.gbThongtinHD.Controls.Add(this.dateTimePicker1);
            this.gbThongtinHD.Controls.Add(this.label2);
            this.gbThongtinHD.Controls.Add(this.tbMaHD);
            this.gbThongtinHD.Controls.Add(this.label1);
            this.gbThongtinHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongtinHD.Location = new System.Drawing.Point(28, 301);
            this.gbThongtinHD.Name = "gbThongtinHD";
            this.gbThongtinHD.Size = new System.Drawing.Size(657, 172);
            this.gbThongtinHD.TabIndex = 6;
            this.gbThongtinHD.TabStop = false;
            this.gbThongtinHD.Text = "Thông tin hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mã hóa đơn";
            // 
            // tbMaHD
            // 
            this.tbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaHD.Location = new System.Drawing.Point(57, 106);
            this.tbMaHD.Name = "tbMaHD";
            this.tbMaHD.Size = new System.Drawing.Size(212, 24);
            this.tbMaHD.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(369, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ngày lập";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(372, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(271, 24);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInHD);
            this.panel1.Controls.Add(this.btnThoitien);
            this.panel1.Controls.Add(this.tbTienthoilai);
            this.panel1.Controls.Add(this.tbTienkhachdua);
            this.panel1.Controls.Add(this.tbTongtien);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(748, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 390);
            this.panel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tiền khách đưa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tiền thối lại";
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(170, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 75);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // tbTongtien
            // 
            this.tbTongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTongtien.Location = new System.Drawing.Point(212, 43);
            this.tbTongtien.Name = "tbTongtien";
            this.tbTongtien.Size = new System.Drawing.Size(212, 24);
            this.tbTongtien.TabIndex = 17;
            // 
            // tbTienkhachdua
            // 
            this.tbTienkhachdua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTienkhachdua.Location = new System.Drawing.Point(212, 141);
            this.tbTienkhachdua.Name = "tbTienkhachdua";
            this.tbTienkhachdua.Size = new System.Drawing.Size(212, 24);
            this.tbTienkhachdua.TabIndex = 21;
            // 
            // tbTienthoilai
            // 
            this.tbTienthoilai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTienthoilai.Location = new System.Drawing.Point(212, 241);
            this.tbTienthoilai.Name = "tbTienthoilai";
            this.tbTienthoilai.Size = new System.Drawing.Size(212, 24);
            this.tbTienthoilai.TabIndex = 22;
            // 
            // btnThoitien
            // 
            this.btnThoitien.FlatAppearance.BorderSize = 0;
            this.btnThoitien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoitien.Image = ((System.Drawing.Image)(resources.GetObject("btnThoitien.Image")));
            this.btnThoitien.Location = new System.Drawing.Point(300, 300);
            this.btnThoitien.Name = "btnThoitien";
            this.btnThoitien.Size = new System.Drawing.Size(75, 75);
            this.btnThoitien.TabIndex = 23;
            this.btnThoitien.UseVisualStyleBackColor = true;
            // 
            // btnInHD
            // 
            this.btnInHD.FlatAppearance.BorderSize = 0;
            this.btnInHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHD.Image = ((System.Drawing.Image)(resources.GetObject("btnInHD.Image")));
            this.btnInHD.Location = new System.Drawing.Point(439, 300);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(75, 75);
            this.btnInHD.TabIndex = 24;
            this.btnInHD.UseVisualStyleBackColor = true;
            // 
            // Banhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbThongtinHD);
            this.Controls.Add(this.lbQuanly);
            this.Controls.Add(this.gbThongtinKH);
            this.Name = "Banhang";
            this.Size = new System.Drawing.Size(1644, 920);
            this.gbThongtinKH.ResumeLayout(false);
            this.gbThongtinKH.PerformLayout();
            this.gbThongtinHD.ResumeLayout(false);
            this.gbThongtinHD.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongtinKH;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbQuanly;
        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.TextBox tbHoten;
        private System.Windows.Forms.Label lbSđt;
        private System.Windows.Forms.TextBox tbSđt;
        private System.Windows.Forms.GroupBox gbThongtinHD;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbTienthoilai;
        private System.Windows.Forms.TextBox tbTienkhachdua;
        private System.Windows.Forms.TextBox tbTongtien;
        private System.Windows.Forms.Button btnThoitien;
        private System.Windows.Forms.Button btnInHD;
    }
}
