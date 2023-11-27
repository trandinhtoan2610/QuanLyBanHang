using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class SanPhamDAL
    {
        SqlConnection conn = SqlConnectionData.Connect();
        private List<SanPhamDTO> dssp, found;


        public List<SanPhamDTO> readDB()
        {
            try
            {
                conn.Open();
                String query = "Select SanPham.id,tensanpham,idLoaiSanPham,tenloai,hangsanxuat,gia,soluong,donvitinh from SanPham Join LoaiSanPham on SanPham.idLoaiSanPham = LoaiSanPham.id";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader read = cmd.ExecuteReader();
                dssp = new List<SanPhamDTO>();
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
                    dssp.Add(sp);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally { conn.Close(); }
            return dssp;
        }

        public bool InsertSP(SanPhamDTO sp)
        {
            conn.Open();
            try
            {
                string query = $"Insert into SanPham (id,tensanpham, idLoaiSanPham, hangsanxuat, gia, soluong, donvitinh) values ({sp.Id},'{sp.Tensanpham}', {sp.IdLoaiSanPham}, '{sp.Hangsanxuat}',{sp.Gia},{sp.Soluong},'{sp.Donvitinh}')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
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



        public bool UpdateSP(int id, string tensanpham, int idLoaiSanPham, string hangsanxuat, float gia, int soluong, string donvitinh)
        {
            conn.Open();
            try
            {
                string query = "UPDATE SanPham SET "
                    + "tensanpham = '" + tensanpham
                    + "',idLoaiSanPham = '" + idLoaiSanPham
                    + "',hangsanxuat = '" + hangsanxuat
                    + "',gia = '" + gia
                    + "',soluong = '" + soluong
                    + "',donvitinh = '" + donvitinh
                    + "' where id =" + id;
                SqlCommand cmd = new SqlCommand(query, conn);
                //Thực hiện câu lệnh cập nhật khách hàng trong CSDL
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);    //Hiển thị lỗi nếu có
                return false;
            }
            finally
            {
                conn.Close();   //Đóng kết nối
            }

        }
        //Xoá theo số điện thoại
        public bool DeleteSP(int id)
        {
            conn.Open();
            try
            {
                foreach (SanPhamDTO sp in dssp)
                {
                    if (sp.Id.Equals(id))
                    {
                        string query = "Delete From SanPham  WHERE id = " + id;
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);    //Hiển thị lỗi nếu có
                return false;
            }
            finally
            {
                conn.Close();   //Đóng kết nối
            }
        }

        public List<SanPhamDTO> Search(string text)
        {
            try
            {
                foreach (SanPhamDTO sp in dssp)
                {
                    conn.Open();
                    string query = "select SanPham.id,tensanpham,idLoaiSanPham,tenloai,hangsanxuat,gia,soluong,donvitinh from SanPham Join LoaiSanPham on SanPham.idLoaiSanPham = LoaiSanPham.id where tensanpham like '%" + text + "%'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader read = cmd.ExecuteReader();
                    found = new List<SanPhamDTO>();
                    while (read.Read())
                    {
                        sp.Id = read.GetInt32(0);
                        sp.Tensanpham = read.GetString(1);
                        sp.IdLoaiSanPham = read.GetInt32(2);
                        sp.Tenloai = read.GetString(3);
                        sp.Hangsanxuat = read.GetString(4);
                        sp.Gia = read.GetInt32(5);
                        sp.Soluong = read.GetInt32(6);
                        sp.Donvitinh = read.GetString(7);
                        found.Add(sp);
                    }
                    conn.Close(); 
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);    
            }
            finally
            {
                conn.Close();   
            }
            return found;
        }

    }
}