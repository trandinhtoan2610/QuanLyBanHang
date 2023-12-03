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
                    nv.Matkhau = read.GetString(9);
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
                string query = $"Insert into NhanVien (tennhanvien, ngaysinh, IdLoainhanvien, sodienthoai, cmnd, email, gioitinh, diachi, matkhau) values (@TenNhanVien, '{nv.Ngaysinh}', {nv.IdLoainhanvien}, @SoDienThoai,'{nv.Cmnd}','{nv.Email}', @GioiTinh , @DiaChi, '{nv.Matkhau}')"; ;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenNhanVien", nv.Tennhanvien);
                cmd.Parameters.AddWithValue("@SoDienThoai", nv.Sodienthoai);
                cmd.Parameters.AddWithValue("@GioiTinh", nv.Gioitinh);
                cmd.Parameters.AddWithValue("@DiaChi", nv.Diachi);
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

        public NhanVienDTO findbyPhone(string phone)
        {
            NhanVienDTO nv = new NhanVienDTO();
            try
            {
                conn.Open();

                string sql = "SELECT * FROM NhanVien WHERE sodienthoai like '" + phone + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {

                    
                    nv.Sodienthoai = read.GetString(2);
                    
                }
                conn.Close();
                return nv;


            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error : " + ex);

            }
            finally { conn.Close(); }

            return null;
        }

        public bool UpdateNV(int id, string tennhanvien, string ngaysinh, int IdLoainhanvien, string sodienthoai, string cmnd, string email, string gioitinh, string diachi, string matkhau)
        {
            conn.Open();
            try
            {
                string query = "UPDATE NhanVien SET "
                    + "tennhanvien = @TenNhanVien"
                    + ",ngaysinh = '" + ngaysinh
                    + "',IdLoainhanvien = '" + IdLoainhanvien
                    + "',sodienthoai = @SoDienThoai"
                    + ",cmnd = '" + cmnd
                    + "',email = '" + email
                    + "',gioitinh = @GioiTinh"
                    + ",diachi = @DiaChi"
                    + ",matkhau = '" + matkhau
                    + "' where id = " + id;
                SqlCommand cmd = new SqlCommand(query, conn);
                //Thực hiện câu lệnh cập nhật nhân viên trong CSDL
                cmd.Parameters.AddWithValue("@TenNhanVien", tennhanvien);
                cmd.Parameters.AddWithValue("@SoDienThoai", sodienthoai);
                cmd.Parameters.AddWithValue("@GioiTinh", gioitinh);
                cmd.Parameters.AddWithValue("@DiaChi", diachi);
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
                string query = "Delete From NhanVien  WHERE  id = " + id;
                SqlCommand cmd = new SqlCommand(query, conn);
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

    }
}