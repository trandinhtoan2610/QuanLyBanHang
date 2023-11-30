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
        
        TaiKhoanBLL taiKhoanbll = new TaiKhoanBLL();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string getuser = taiKhoanbll.CheckLogin(tbtaikhoan.Text, tbmatkhau.Text);

            switch (getuser)
            {
                case "requeid_taikhoan":
                    MessageBox.Show("Không được để trống tài khoản");
                    return;
                case "requeid_matkhau":
                    MessageBox.Show("Không được để trống mật khẩu");
                    return;
                case "sai tai khoan mat khau":
                    MessageBox.Show("Tài khoản mật khẩu không chính xác");
                    return;
                case "login success":
                    fTableManager f = new fTableManager();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                    return;
            }
            
        }
    }
}
