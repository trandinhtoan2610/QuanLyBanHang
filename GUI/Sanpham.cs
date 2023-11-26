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
        BindingSource splist = new BindingSource();
        SanPhamBLL qlspBLL = new SanPhamBLL();
        SanPhamDTO sp = new SanPhamDTO();
        List<SanPhamDTO> spv;

        
        public Sanpham()
        {
            InitializeComponent();
            load();
            
        }
        
        void load()
        {
            dataGridView1.DataSource = splist;

            loadData();
            loadcbb();
            addSanPhamBinding();           
        }

        public void loadData()
        {
            spv = qlspBLL.readDB();
            splist.DataSource = spv;
        }
        void loadcbb()
        {
            LoaiSanPhamBLL lspbll = new LoaiSanPhamBLL();
            List<LoaiSanPhamDTO> llsp;
            llsp = lspbll.readDB();
            cbTenloaisanpham.DisplayMember = "TenLoai";
            cbTenloaisanpham.ValueMember = "Id";
            cbTenloaisanpham.DataSource = llsp;
        }
        public void addSanPhamBinding()
        {
            tbMaSP.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "id"));
            tbTenSP.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "tensanpham"));
            cbTenloaisanpham.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "IdLoaiSanPham"));
            cbHangSX.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "HangSanXuat"));
            tbGia.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Gia"));
            tbSoluong.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Soluong"));
            tbDonvitinh.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Donvitinh"));
        }

        public void Clear()
        {
            tbMaSP.Text = tbTenSP.Text = cbTenloaisanpham.Text = tbGia.Text = tbSoluong.Text = tbDonvitinh.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            sp.Id = Convert.ToInt32(tbMaSP.Text);
            sp.Tensanpham = tbTenSP.Text;
            sp.IdLoaiSanPham = Convert.ToInt32(cbTenloaisanpham.SelectedValue);
            sp.Hangsanxuat = cbHangSX.Text;
            sp.Gia = Convert.ToInt32(tbGia.Text);
            sp.Soluong = Convert.ToInt32(tbSoluong.Text);
            sp.Donvitinh = tbDonvitinh.Text;
            if(qlspBLL.InsertSP(sp.Id ,sp.Tensanpham, sp.IdLoaiSanPham, sp.Hangsanxuat, sp.Gia, sp.Soluong, sp.Donvitinh))
            {
               MessageBox.Show("thêm thành công!");
            }
            loadData();
            Clear();
      
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
