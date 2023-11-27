using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace DAL
{
    public class NhanVienDAL
    {
        SqlConnection conn = SqlConnectionData.Connect();
        private List<NhanVienDTO> dsnv, found;

        public List<NhanVienDTO> readDB()
        {
            try
            {
                conn.Open();
                String query = "select * From NhanVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader read = cmd.ExecuteReader();
                dsnv = new List<NhanVienDTO>();
                while (read.Read())
                {
                    NhanVienDTO nv = new NhanVienDTO();
                    nv.Id = read.GetInt32(0);
                    nv.Tennhanvien = read.GetString(1);
                    nv.Ngaysinh = read.GetString(2);
                    nv.IdLoainhanvien = read.GetInt32(3);
                    nv.Sodienthoai = read.GetString(4);
                    nv.Cmnd = read.GetString(5);
                    nv.Email = read.GetString(6);
                    nv.Gioitinh = read.GetString(7);
                    nv.Diachi = read.GetString(8);
                    dsnv.Add(nv);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally { conn.Close(); }
            return dsnv;
        }

       

        

        public bool InsertNV(NhanVienDTO nv)
        {
            conn.Open();
            try
            {
                string query = $"Insert into NhanVien (id,tennhanvien, ngaysinh, IdLoainhanvien, sodienthoai, cmnd, email, gioitinh, diachi) values ({nv.Id},'{nv.Tennhanvien}', '{nv.Ngaysinh}', {nv.IdLoainhanvien},'{nv.Sodienthoai}','{nv.Cmnd}','{nv.Email}','{nv.Gioitinh}','{nv.Diachi}')"; ;
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



        public bool UpdateNV(int id, string tennhanvien, string ngaysinh, int IdLoainhanvien, string sodienthoai, string cmnd, string email, string gioitinh, string diachi)
        {
            conn.Open();
            try
            {
                string query = "UPDATE NhanVien SET "
                    + "tennhanvien = '" + tennhanvien
                    + "',ngaysinh = '" + ngaysinh
                    + "',IdLoainhanvien = '" + IdLoainhanvien
                    + "',sodienthoai = '" + sodienthoai
                    + "',cmnd = '" + cmnd
                    + "',email = '" + email
                    + "',gioitinh = '" + gioitinh
                    + "',diachi = '" + diachi
                    + "' where id = " + id;
                SqlCommand cmd = new SqlCommand(query, conn);
                //Thực hiện câu lệnh cập nhật nhân viên trong CSDL
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
        public bool DeleteNV(int id)
        {
            conn.Open();
            try
            {
                foreach (NhanVienDTO nv in dsnv)
                {
                    if (nv.Id.Equals(id)) //Nếu số điện thoại bằng giá trị ô được chọn của cột "Số điện thoại" thì mới cập nhật lại status
                    {
                        string query = "Delete From NhanVien  WHERE  id = " + id;
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
    }
}