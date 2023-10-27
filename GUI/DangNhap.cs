using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DangNhap : Form
    {
        TaiKhoanDTO taikhoandto = new TaiKhoanDTO();
        TaiKhoanBLL taiKhoanbll = new TaiKhoanBLL();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            taikhoandto.UserName = tbtaikhoan.Text;
            taikhoandto.Password = tbmatkhau.Text;

            string getuser = taiKhoanbll.CheckLogin(taikhoandto);

            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Không được để trống tài khoản");
                    return;
                case "requeid_matkhau":
                    MessageBox.Show("Không được để trống mật khẩu");
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
    }
}
