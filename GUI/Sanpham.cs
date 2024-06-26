﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using BLL;
using DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Sanpham : UserControl
    {
        BindingSource splist = new BindingSource();
        SanPhamBLL qlspBLL = new SanPhamBLL();
        List<SanPhamDTO> spv, found;


        public Sanpham()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            dataGridView1.DataSource = splist;
            loadData();
            loadcbb();
             
            addSanPhamBinding();
            loadHeaderText();
            dataGridView1.Columns["idLoaiSanPham"].Visible = false;
        }

        public void loadData()
        {
            spv = qlspBLL.readDB();
            splist.DataSource = spv;
        }
        public void loadcbb()
        {
            LoaiSanPhamBLL lspbll = new LoaiSanPhamBLL();
            List<LoaiSanPhamDTO> llsp;
            llsp = lspbll.readDB();
            cbTenloaisanpham.DisplayMember = "TenLoai";
            cbTenloaisanpham.ValueMember = "Id";
            cbTenloaisanpham.DataSource = llsp;

            NCCBLL nccbll = new NCCBLL();
            List<NCCDTO> lncc = nccbll.readDB();
            cbHangSX.DataSource = lncc;
            cbHangSX.DisplayMember = "tennhacungcap";
            cbHangSX.ValueMember= "Id";
        }

        public void loadHeaderText()
        {
            dataGridView1.Columns["id"].HeaderText = "Mã sản phẩm";
            dataGridView1.Columns["tensanpham"].HeaderText = "Tên sản phẩm";
            dataGridView1.Columns["tenloai"].HeaderText = "Tên loại";
            dataGridView1.Columns["hangsanxuat"].HeaderText = "Hãng sản xuất";
            dataGridView1.Columns["soluong"].HeaderText = "số lượng";
            dataGridView1.Columns["gia"].HeaderText = "Giá";
            dataGridView1.Columns["donvitinh"].HeaderText = "Đơn vị tính";
            dataGridView1.Columns["khuyenmai"].HeaderText = "Khuyến mãi";
        }
        public void addSanPhamBinding()
        {
            tbMaSP.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "id", true, DataSourceUpdateMode.Never));
            tbTenSP.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "tensanpham", true, DataSourceUpdateMode.Never));
            cbTenloaisanpham.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Tenloai", true, DataSourceUpdateMode.Never));
            cbHangSX.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "HangSanXuat", true, DataSourceUpdateMode.Never));
            tbGia.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Gia", true, DataSourceUpdateMode.Never));
            tbSoluong.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Soluong", true, DataSourceUpdateMode.Never));
            tbDonvitinh.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Donvitinh", true, DataSourceUpdateMode.Never));
            tbKhuyenmai.DataBindings.Add(new Binding("Text", dataGridView1.DataSource, "Khuyenmai", true, DataSourceUpdateMode.Never));
        }

        public void Clear()
        {
            tbMaSP.Text = tbTenSP.Text = cbTenloaisanpham.Text = tbGia.Text = tbSoluong.Text = tbDonvitinh.Text = tbKhuyenmai.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            SanPhamDTO sp = new SanPhamDTO();
            sp.Tensanpham = tbTenSP.Text;
            sp.IdLoaiSanPham = Convert.ToInt32(cbTenloaisanpham.SelectedValue);
            sp.Hangsanxuat = cbHangSX.SelectedValue.ToString();
            sp.Gia = Convert.ToInt32(tbGia.Text);
            sp.Soluong = Convert.ToInt32(tbSoluong.Text);
            sp.Donvitinh = tbDonvitinh.Text;
            sp.Khuyenmai = Convert.ToInt32(tbKhuyenmai.Text);
            if (qlspBLL.InsertSP(sp.Tensanpham, sp.IdLoaiSanPham, sp.Hangsanxuat, sp.Gia, sp.Soluong, sp.Donvitinh, sp.Khuyenmai))
            {
                MessageBox.Show("thêm thành công!");
            }
            loadData();
            Clear();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SanPhamDTO sp = new SanPhamDTO();
            sp.Id = Convert.ToInt32(tbMaSP.Text);
            sp.Tensanpham = tbTenSP.Text;
            sp.IdLoaiSanPham = Convert.ToInt32(cbTenloaisanpham.SelectedValue);
            sp.Hangsanxuat = cbHangSX.Text;
            sp.Gia = Convert.ToInt32(tbGia.Text);
            sp.Soluong = Convert.ToInt32(tbSoluong.Text);
            sp.Donvitinh = tbDonvitinh.Text;
            sp.Khuyenmai = Convert.ToInt32(tbKhuyenmai.Text);

            if (qlspBLL.UpdateSP(sp))
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            loadData();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SanPhamDTO sp = new SanPhamDTO();
            sp.Id = Convert.ToInt32(tbMaSP.Text);
            if (qlspBLL.DeleteSP(sp.Id))
            {
                MessageBox.Show("Xóa thành công!");
            }
            loadData();
        }

        public void SearchSP()
        {
            string searchValue = tbTimkiem.Text;
            found = qlspBLL.Search(searchValue);
            splist.DataSource = found;
        }


        private void cbHangSX_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void tbTimkiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(tbTimkiem.Text))
                {
                    loadData();
                }
                else
                {
                    SearchSP();
                }
                e.SuppressKeyPress = true;
            }
        }
    }
}