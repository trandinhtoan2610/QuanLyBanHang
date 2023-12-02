using BLL;
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
    public partial class fTimkiem : UserControl
    {
        public event EventHandler DiDenBanhang;
        public fTimkiem()
        {
            InitializeComponent();
            
        }


        KhachHangBLL khachhangbll = new KhachHangBLL();
        private void button1_Click(object sender, EventArgs e)
        {
            string getkhachhang = khachhangbll.CheckTimKiemKH(tbSđt.Text);
            switch (getkhachhang)
            {
                case "requeid_sodienthoai":
                    MessageBox.Show("Không được để trống số điện thoại");
                    return;
                case "sai so dien thoai":
                    MessageBox.Show("Không tìm thấy khách hàng");
                    return;
                case "timthaykhachhang":
                    DiDenBanhang?.Invoke(this, EventArgs.Empty);
                    return;
            }
            
        }
    }
}
