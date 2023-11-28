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
    public partial class Banhang : UserControl
    {
        SanPhamBLL lspbll = new SanPhamBLL();
        List<SanPhamDTO> lsp;

        BanHangBLL lhdbbll = new BanHangBLL();
        BanHangDTO HDB = new BanHangDTO();
        List<BanHangDTO> lhdb, found;
        
        public Banhang()
        {
            InitializeComponent();
            loadcbb();
        }
        void loadcbb()
        {
            
            lsp = lspbll.readDB();
            cbTensanpham.DisplayMember = "Tensanpham";
            cbTensanpham.ValueMember = "Id";
            cbTensanpham.DataSource = lsp;
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BanHangBLL lhdbbll = new BanHangBLL();
            List<BanHangDTO> lhdb;
            lhdb = lhdbbll.readDB();

           
            HDB.MaHD = tbMaHD.Text;
           
            HDB.Tensanpham = cbTensanpham.Selected.ToString();
            HDB.Tenkhachhang = tbHoten.Text;
            HDB.Gia = Convert.ToDecimal(tbDongia.ToString());
            HDB.Soluong = Convert.ToInt32(tbSoluong.ToString());

            DateTime selectedDateTime = dtNgaylap.Value;
            HDB.Ngaylap = selectedDateTime.ToString("yyyy-MM-dd");
            HDB.Khuyenmai = Convert.ToInt32(tbGiakhuyenmai.ToString());

            if (lhdbbll.InsertHD(HDB.Id,HDB.MaHD, HDB.Tennhanvien, HDB.Tenkhachhang, HDB.Ngaylap, HDB.Tongtien, HDB.Tensanpham, HDB.Soluong, HDB.Gia, HDB.Thanhtien,HDB.Khuyenmai))
            {
                MessageBox.Show("thêm thành công!");
            }
           
           
        }
    }
}
