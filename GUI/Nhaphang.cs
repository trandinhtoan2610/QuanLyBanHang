using BLL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class Nhaphang : UserControl
    {
        public static List<SanPhamDTO> listCart= new List<SanPhamDTO>();
        NhapHangBLL nhBLL= new NhapHangBLL();
        public static List<SanPhamDTO> listProduct = new List<SanPhamDTO>();
        public event EventHandler DiDenGioHangNhaphang;
        public static int nhaCungCapId = 0;
        SanPhamBLL sp = new SanPhamBLL();
        public Nhaphang()
        {
            InitializeComponent();
            cbb_nhacungcap.DisplayMember = "tennhacungcap";
            cbb_nhacungcap.ValueMember = "Id";
            cbb_nhacungcap.DataSource = nhBLL.getAllNhaCungCap();
        }
        public void loadData()
        {
            dgv_nhaphang.DataSource = null;
            dgv_nhaphang.DataSource = listProduct;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbId.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Vui lòng chọn sản phẩm để thêm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                foreach (var item in listCart)
                {
                    if (item.Hangsanxuat != nhaCungCapId.ToString())
                    {
                        MessageBox.Show("Xóa hết sản phẩm trong giỏ để mua sản phẩm của nhà cung cấp khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                //click thêm vào giỏ hàng
                SanPhamDTO spDTO = new SanPhamDTO();
                spDTO.Id = Convert.ToInt32(tbId.Text);
                spDTO.Tensanpham = tbtensanpham.Text;
                spDTO.Donvitinh = tbdonvitinh.Text;
                spDTO.Gia = Convert.ToInt32(tbgia.Text);
                spDTO.Soluong = Convert.ToInt32(tbsoluong.Text);
                spDTO.Hangsanxuat = tbhangsanxuat.Text;
                spDTO.Khuyenmai = Convert.ToInt32(tbkhuyenmai.Text);
                spDTO.IdLoaiSanPham = Convert.ToInt32(tbidloaisanpham.Text);
                spDTO.Tenloai = tbtenloai.Text;
                Boolean isExist = false;
                foreach (var item in listCart)
                {
                    if (item.Id == spDTO.Id)
                    {
                        isExist = true;
                        item.Soluong = item.Soluong + spDTO.Soluong;
                        break;
                    }
                }
                if (!isExist)
                {
                    listCart.Add(spDTO);
                }

                foreach (var item in listProduct)
                {
                    if (item.Id == spDTO.Id)
                    {
                        item.Soluong = item.Soluong - spDTO.Soluong;
                        break;
                    }
                }
                dgv_nhaphang.DataSource = null;
                dgv_nhaphang.DataSource = listProduct;
                tbId.Text = "";
                tbtensanpham.Text = "";
                tbdonvitinh.Text = "";
                tbgia.Text = "";
                tbsoluong.Text = "";
                tbhangsanxuat.Text = "";
                tbkhuyenmai.Text = "";
                tbidloaisanpham.Text = "";
                tbtenloai.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sai định dạng số lượng!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiDenGioHangNhaphang?.Invoke(this, EventArgs.Empty);
            GioHangNhapHang.dgv_giohang_nhaphang.DataSource = null;
            GioHangNhapHang.dgv_giohang_nhaphang.DataSource = listCart;
            int sumMoney = 0;
            foreach (var item in listCart)
            {
                sumMoney += item.Gia * item.Soluong;
            }
            GioHangNhapHang.label11.Text = sumMoney + "đ";
        }

        private void dgv_nhaphang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Kiểm tra chỉ mục ô có hợp lệ
            {               
                DataGridViewRow row = dgv_nhaphang.Rows[e.RowIndex];
                if (row.Cells[5].Value.ToString() == "0")
                {
                    MessageBox.Show("Sản phẩm đã hết!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                // Sử dụng row để truy cập các giá trị của hàng theo nhu cầu của bạn
                // Ví dụ: string cellValue = row.Cells["TênCột"].Value.ToString();

                tbId.Text = row.Cells[0].Value.ToString();
                tbtensanpham.Text = row.Cells[1].Value.ToString();
                tbidloaisanpham.Text = row.Cells[2].Value.ToString();
                tbtenloai.Text = row.Cells[3].Value.ToString();
                tbhangsanxuat.Text = row.Cells[4].Value.ToString();
                tbgia.Text = row.Cells[5].Value.ToString();
                tbsoluong.Text = "1";
                tbdonvitinh.Text = row.Cells[7].Value.ToString();
                tbkhuyenmai.Text = row.Cells[8].Value.ToString();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (cbb_nhacungcap.SelectedItem != null)
            {
                var firstValue = ((dynamic)cbb_nhacungcap.SelectedItem).Id;
                // Sử dụng giá trị đầu tiên
                nhaCungCapId = (int)firstValue;
                listProduct.Clear();
                listProduct = nhBLL.getAllProduct(nhaCungCapId, txt_search.Text);
            }
            loadData();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_nhacungcap.SelectedItem != null)
            {
                var firstValue = ((dynamic)cbb_nhacungcap.SelectedItem).Id;
                // Sử dụng giá trị đầu tiên
                nhaCungCapId = (int)firstValue;
                listProduct.Clear();
                listProduct = nhBLL.getAllProduct(nhaCungCapId, txt_search.Text);
            }
            loadData();
        }
    }
}
