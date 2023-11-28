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
    public partial class LoaiSP : UserControl
    {
        BindingSource lsplist = new BindingSource();
        LoaiSanPhamBLL lspBLL = new LoaiSanPhamBLL();
        LoaiSanPhamDTO lsp = new LoaiSanPhamDTO();
        List<LoaiSanPhamDTO> lspv, found;
        

        public LoaiSP()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            dgvlsp.DataSource = lsplist;
            loadData();
            addLoaiSanPhamBinding();  
            loadHeaderText();
        }

        public void loadData()
        {
            lspv = lspBLL.readDB();
            lsplist.DataSource = lspv;
        }
        

        public void loadHeaderText()
        {
            dgvlsp.Columns["id"].HeaderText = "Mã sản phẩm";
            dgvlsp.Columns["tenloai"].HeaderText = "Tên loại"; 
        }
        public void addLoaiSanPhamBinding()
        {
            tbMaLoaiSP.DataBindings.Add(new Binding("Text", dgvlsp.DataSource, "id", true, DataSourceUpdateMode.Never));
            tbTenLoaiSP.DataBindings.Add(new Binding("Text", dgvlsp.DataSource, "tenloai", true, DataSourceUpdateMode.Never));  
        }

        public void Clear()
        {
            tbMaLoaiSP.Text = tbMaLoaiSP.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            LoaiSanPhamBLL lspbll = new LoaiSanPhamBLL();
            List<LoaiSanPhamDTO> llsp;
            llsp = lspbll.readDB();
            lsp.Id = Convert.ToInt32(tbMaLoaiSP.Text);
            lsp.TenLoai = tbTenLoaiSP.Text;
            
            if (lspBLL.InsertLSP(lsp.Id, lsp.TenLoai))
            {
                MessageBox.Show("thêm thành công!");
            }
            loadData();
            Clear();
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            lsp.Id = Convert.ToInt32(tbMaLoaiSP.Text);
            lsp.TenLoai = tbTenLoaiSP.Text;

            if (lspBLL.UpdateLSP(lsp.Id, lsp.TenLoai))
            {
                MessageBox.Show("Cập nhật thành công!");
            }
            
            loadData();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lsp.Id = Convert.ToInt32(tbMaLoaiSP.Text);
            if (lspBLL.DeleteLSP(lsp.Id))
            {
                MessageBox.Show("Xóa thành công!");
            }
            loadData();
        }

        public void SearchLSP()
        {
            string searchValue = tbTimkiem.Text;
            found = lspBLL.Search(searchValue);
            lsplist.DataSource = found;
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
                    SearchLSP();
                }
                e.SuppressKeyPress = true;
            }
        }
    }
}
