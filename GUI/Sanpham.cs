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
    public partial class Sanpham : UserControl
    {
        List<SanPhamDTO> sp;
        SanPhamBLL bus = new SanPhamBLL();
        public Sanpham()
        {
            InitializeComponent();
            loadData();
        }

        public void loadData()
        {
            sp = bus.readDB();
            dataGridView1.DataSource = sp;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SanPhamDTO sp = new SanPhamDTO(tbTenSP.Text,int.Parse(tbMaLoaiSP.Text), cbHangSX.Text, int.Parse(tbGia.Text), int.Parse(tbSoluong.Text) , tbDonvitinh.Text);
            SanPhamBLL spbll = new SanPhamBLL();
            spbll.InsertSP(sp);
            loadData();
        }
    }
}
