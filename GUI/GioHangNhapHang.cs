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
    public partial class GioHangNhapHang : UserControl
    {
        NhapHangBLL nhBLL= new NhapHangBLL();
        public GioHangNhapHang()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbId.Text.Trim().Length == 0)
                {
                    DialogResult result = MessageBox.Show("Vui lòng chọn sản phẩm!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //click thêm thay đổi số lượng giỏ hàng
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

                int quantityCart = 0;
                int quantityNew = spDTO.Soluong;
                foreach (var item in Nhaphang.listCart)
                {
                    if (item.Id == spDTO.Id)
                    {
                        int quantityOld = item.Soluong;
                        //ví dụ ban đầu có sl=5 chỉnh lại sl=3 -> quantityCart= 5-3= 2 ngược lại quantityCart= 3-5= -2
                        quantityCart = quantityOld - quantityNew;
                        item.Soluong = quantityNew;
                        break;
                    }
                }
                dgv_giohang_nhaphang.DataSource = null;
                dgv_giohang_nhaphang.DataSource = Nhaphang.listCart;
                int sumMoney = 0;
                foreach (var item in Nhaphang.listCart)
                {
                    sumMoney += item.Gia * item.Soluong;
                }
                label11.Text = sumMoney+"đ";
                foreach (var item in Nhaphang.listProduct)
                {
                    if (item.Id == spDTO.Id)
                    {
                        item.Soluong = item.Soluong + quantityCart;
                        break;
                    }
                }
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
            catch (Exception ex) {
                MessageBox.Show("Sai định dạng số lượng!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Kiểm tra chỉ mục ô có hợp lệ
            {
                DataGridViewRow row = dgv_giohang_nhaphang.Rows[e.RowIndex];
                // Sử dụng row để truy cập các giá trị của hàng theo nhu cầu của bạn
                // Ví dụ: string cellValue = row.Cells["TênCột"].Value.ToString();

                tbId.Text = row.Cells[0].Value.ToString();
                tbtensanpham.Text = row.Cells[1].Value.ToString();
                tbidloaisanpham.Text = row.Cells[2].Value.ToString();
                tbtenloai.Text = row.Cells[3].Value.ToString();
                tbhangsanxuat.Text = row.Cells[4].Value.ToString();
                tbgia.Text = row.Cells[5].Value.ToString();
                tbsoluong.Text = row.Cells[6].Value.ToString();
                tbdonvitinh.Text = row.Cells[7].Value.ToString();
                tbkhuyenmai.Text = row.Cells[8].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbId.Text.Trim().Length == 0)
                {
                    DialogResult result = MessageBox.Show("Vui lòng chọn sản phẩm!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //click thêm thay đổi số lượng giỏ hàng
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

                int quantityCart = 0;
                int quantityNew = spDTO.Soluong;
                foreach (var item in Nhaphang.listCart)
                {
                    if (item.Id == spDTO.Id)
                    {
                        int quantityOld = item.Soluong;
                        quantityCart = quantityOld;
                        break;
                    }
                }
                Nhaphang.listCart.RemoveAll(item => item.Id == spDTO.Id);
                dgv_giohang_nhaphang.DataSource = null;
                dgv_giohang_nhaphang.DataSource = Nhaphang.listCart;
                int sumMoney = 0;
                foreach (var item in Nhaphang.listCart)
                {
                    sumMoney += item.Gia * item.Soluong;
                }
                label11.Text = sumMoney + "đ";
                foreach (var item in Nhaphang.listProduct)
                {
                    if (item.Id == spDTO.Id)
                    {
                        item.Soluong = item.Soluong + quantityCart;
                        break;
                    }
                }
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
                MessageBox.Show("Sai định dạng số lượng!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Boolean result= nhBLL.InsertSP(Nhaphang.listCart);
            if (result)
            {
                MessageBox.Show("Thêm thành công!!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
