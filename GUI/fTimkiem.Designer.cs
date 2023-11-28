namespace GUI
{
    partial class fTimkiem
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
            this.gbThongtinKH = new System.Windows.Forms.GroupBox();
            this.tbSđt = new System.Windows.Forms.TextBox();
            this.lbSđt = new System.Windows.Forms.Label();
            this.tbHoten = new System.Windows.Forms.TextBox();
            this.lbHoten = new System.Windows.Forms.Label();
            this.lbTimkiem = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbThongtinKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbThongtinKH
            // 
            this.gbThongtinKH.Controls.Add(this.tbSđt);
            this.gbThongtinKH.Controls.Add(this.lbSđt);
            this.gbThongtinKH.Controls.Add(this.tbHoten);
            this.gbThongtinKH.Controls.Add(this.lbHoten);
            this.gbThongtinKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbThongtinKH.Location = new System.Drawing.Point(353, 289);
            this.gbThongtinKH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbThongtinKH.Name = "gbThongtinKH";
            this.gbThongtinKH.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbThongtinKH.Size = new System.Drawing.Size(493, 140);
            this.gbThongtinKH.TabIndex = 1;
            this.gbThongtinKH.TabStop = false;
            this.gbThongtinKH.Text = "Thông tin khách hàng";
            // 
            // tbSđt
            // 
            this.tbSđt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSđt.Location = new System.Drawing.Point(307, 70);
            this.tbSđt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSđt.Name = "tbSđt";
            this.tbSđt.Size = new System.Drawing.Size(160, 21);
            this.tbSđt.TabIndex = 16;
            // 
            // lbSđt
            // 
            this.lbSđt.AutoSize = true;
            this.lbSđt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSđt.Location = new System.Drawing.Point(304, 37);
            this.lbSđt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSđt.Name = "lbSđt";
            this.lbSđt.Size = new System.Drawing.Size(79, 15);
            this.lbSđt.TabIndex = 13;
            this.lbSđt.Text = "Số điện thoại";
            // 
            // tbHoten
            // 
            this.tbHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoten.Location = new System.Drawing.Point(43, 70);
            this.tbHoten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(160, 21);
            this.tbHoten.TabIndex = 11;
            // 
            // lbHoten
            // 
            this.lbHoten.AutoSize = true;
            this.lbHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHoten.Location = new System.Drawing.Point(40, 37);
            this.lbHoten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHoten.Name = "lbHoten";
            this.lbHoten.Size = new System.Drawing.Size(46, 15);
            this.lbHoten.TabIndex = 10;
            this.lbHoten.Text = "Họ tên ";
            // 
            // lbTimkiem
            // 
            this.lbTimkiem.BackColor = System.Drawing.Color.Cyan;
            this.lbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimkiem.Location = new System.Drawing.Point(341, 217);
            this.lbTimkiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTimkiem.Name = "lbTimkiem";
            this.lbTimkiem.Size = new System.Drawing.Size(551, 32);
            this.lbTimkiem.TabIndex = 2;
            this.lbTimkiem.Text = "Tìm kiếm khách hàng";
            this.lbTimkiem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fTimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTimkiem);
            this.Controls.Add(this.gbThongtinKH);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "fTimkiem";
            this.Size = new System.Drawing.Size(1233, 748);
            this.gbThongtinKH.ResumeLayout(false);
            this.gbThongtinKH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbThongtinKH;
        private System.Windows.Forms.TextBox tbSđt;
        private System.Windows.Forms.Label lbSđt;
        private System.Windows.Forms.TextBox tbHoten;
        private System.Windows.Forms.Label lbHoten;
        private System.Windows.Forms.Label lbTimkiem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
