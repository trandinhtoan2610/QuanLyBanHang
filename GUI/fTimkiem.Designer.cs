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
            this.gbThongtinKH.Location = new System.Drawing.Point(16, 89);
            this.gbThongtinKH.Name = "gbThongtinKH";
            this.gbThongtinKH.Size = new System.Drawing.Size(657, 172);
            this.gbThongtinKH.TabIndex = 1;
            this.gbThongtinKH.TabStop = false;
            this.gbThongtinKH.Text = "Thông tin khách hàng";
            // 
            // tbSđt
            // 
            this.tbSđt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSđt.Location = new System.Drawing.Point(409, 86);
            this.tbSđt.Name = "tbSđt";
            this.tbSđt.Size = new System.Drawing.Size(212, 24);
            this.tbSđt.TabIndex = 16;
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
            // tbHoten
            // 
            this.tbHoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHoten.Location = new System.Drawing.Point(57, 86);
            this.tbHoten.Name = "tbHoten";
            this.tbHoten.Size = new System.Drawing.Size(212, 24);
            this.tbHoten.TabIndex = 11;
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
            // lbTimkiem
            // 
            this.lbTimkiem.BackColor = System.Drawing.Color.Cyan;
            this.lbTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimkiem.Location = new System.Drawing.Point(0, 0);
            this.lbTimkiem.Name = "lbTimkiem";
            this.lbTimkiem.Size = new System.Drawing.Size(735, 40);
            this.lbTimkiem.TabIndex = 2;
            this.lbTimkiem.Text = "Tìm kiếm khách hàng";
            this.lbTimkiem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // fTimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTimkiem);
            this.Controls.Add(this.gbThongtinKH);
            this.Name = "fTimkiem";
            this.Size = new System.Drawing.Size(735, 312);
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
