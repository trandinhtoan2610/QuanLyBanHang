using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class DangNhap : Form
    {
        TaiKhoanDTO taikhoan = new TaiKhoanDTO();
        TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            taikhoan.UserName = tbtaikhoan.Text;
            taikhoan.Password = tbmatkhau.Text;
            string getuser = taiKhoanBLL.CheckLogin(taikhoan);
            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;
                case "requeid_matkhau":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;
                case "Tài khoản mật khẩu không chính xác":
                    MessageBox.Show("Tài khoản mật khẩu không chính xác");
                    return;
            }
            fTableManager f = new fTableManager();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
