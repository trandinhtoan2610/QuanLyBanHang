using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class NhapHangDAL
    {
        SqlConnection conn = SqlConnectionData.Connect();
        private List<SanPhamDTO> listProduct = new List<SanPhamDTO>();
        public List<SanPhamDTO> getAllProduct()
        {
            try
            {
                conn.Open();
                String query = "Select SanPham.id,tensanpham,idLoaiSanPham,tenloai,hangsanxuat,gia,soluong,donvitinh,khuyenmai from SanPham Join LoaiSanPham on SanPham.idLoaiSanPham = LoaiSanPham.id";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader read = cmd.ExecuteReader();
                listProduct = new List<SanPhamDTO>();
                while (read.Read())
                {
                    SanPhamDTO sp = new SanPhamDTO();
                    sp.Id = read.GetInt32(0);
                    sp.Tensanpham = read.GetString(1);
                    sp.IdLoaiSanPham = read.GetInt32(2);
                    sp.Tenloai = read.GetString(3);
                    sp.Hangsanxuat = read.GetString(4);
                    sp.Gia = read.GetInt32(5);
                    sp.Soluong = read.GetInt32(6);
                    sp.Donvitinh = read.GetString(7);
                    sp.Khuyenmai = read.GetInt32(8);
                    listProduct.Add(sp);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally { conn.Close(); }
            return listProduct;
        }
        public bool InsertSP(List<SanPhamDTO> listsp)
        {
            conn.Open();
            try
            {
                foreach(var sp in listsp)
                {
                    string query = $"Insert into SanPham (id,tensanpham, idLoaiSanPham, hangsanxuat, gia, soluong, donvitinh,khuyenmai) values ({sp.Id},'{sp.Tensanpham}', {sp.IdLoaiSanPham}, '{sp.Hangsanxuat}',{sp.Gia},{sp.Soluong},'{sp.Donvitinh}',{sp.Khuyenmai})";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }        
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
