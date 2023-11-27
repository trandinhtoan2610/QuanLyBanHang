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
    public class LoaiSanPhamDAL
    {
        SqlConnection conn = SqlConnectionData.Connect();
        private List<LoaiSanPhamDTO> dslsp, found;
        public List<LoaiSanPhamDTO> readDB()
        {
            try
            {
                conn.Open();
                String query = "Select * from LoaiSanPham";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader read = cmd.ExecuteReader();
                dslsp = new List<LoaiSanPhamDTO>();
                while (read.Read())
                {
                    LoaiSanPhamDTO lsp = new LoaiSanPhamDTO();
                    lsp.Id = read.GetInt32(0);
                    lsp.TenLoai = read.GetString(1);
                    dslsp.Add(lsp);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally { conn.Close(); }
            return dslsp;
        }

        public bool InsertLSP(LoaiSanPhamDTO lsp)
        {
            conn.Open();
            try
            {
                string query = $"Insert into LoaiSanPham (tenloai) values ('{lsp.TenLoai}')";
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



        public bool UpdateLSP(int id, string tenloaisanpham)
        {
            conn.Open();
            try
            {
                string query = "UPDATE LoaiSanPham SET "
                    + "tenloai = '" + tenloaisanpham
                    + "' where id = " + id ;
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
        public bool DeleteLSP(int id)
        {
            conn.Open();
            try
            {
                foreach (LoaiSanPhamDTO lsp in dslsp)
                {
                    if (lsp.Id.Equals(id))
                    {
                        string query = "Delete From LoaiSanPham  WHERE  id = " + id;
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

        public List<LoaiSanPhamDTO> Search(string text)
        {
            try
            {
                foreach (LoaiSanPhamDTO lsp in dslsp)
                {
                    conn.Open();
                    string query = "SELECT * FROM LoaiSanPham WHERE tenloai LIKE '%" + text + "%'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader read = cmd.ExecuteReader();
                    found = new List<LoaiSanPhamDTO>();
                    while (read.Read())
                    {
                        lsp.Id = read.GetInt32(0);
                        lsp.TenLoai = read.GetString(1);                 
                        found.Add(lsp);   //Thêm đối tượng vừa đọc vào List
                    }
                    conn.Close(); //Sau mỗi lần đọc lần đóng kết nối lại
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);    //Hiển thị lỗi nếu có
            }
            finally
            {
                conn.Close();   //Đóng kết nối
            }
            return found;
        }
    }
}
