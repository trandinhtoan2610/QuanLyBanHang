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
    public class KhachHangDAL
    {
        SqlConnection conn = SqlConnectionData.Connect();
        private List<KhachHangDTO> dskh, found;

        public List<KhachHangDTO> readDB()
        {
            try
            {
                conn.Open();
                String query = "select * From KhachHang";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader read = cmd.ExecuteReader();
                dskh = new List<KhachHangDTO>();
                while (read.Read())
                {
                    KhachHangDTO kh = new KhachHangDTO();
                    kh.id = read.GetInt32(0);
                    kh.TenKhachHang = read.GetString(1);
                    kh.SoDienThoai = read.GetInt32(2);
                    kh.GioiTinh = read.GetString(3);
                    kh.ghichu = read.GetString(4);
                    dskh.Add(kh);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally { conn.Close(); }
            return dskh;
        }
        public bool InsertKH(KhachHangDTO kh)
        {
            conn.Open();
            try
            {
                
                string query = $"Insert into KhachHang (tenkhachhang, sodienthoai, gioitinh, ghichu) values (@TenKhachHang, @SoDienThoai , @GioiTinh , @ghichu)"; 
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenKhachHang", kh.TenKhachHang);
                cmd.Parameters.AddWithValue("@SoDienThoai", kh.SoDienThoai);
                cmd.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh);
                cmd.Parameters.AddWithValue("@ghichu", kh.ghichu);
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
        public bool DeleteKH(int id)
        {
            conn.Open();
            try
            {
                string query = "Delete From KhachHang WHERE  id = " + id;
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
        public List<KhachHangDTO> Search(string text)
        {
            try
            {
                /*foreach (KhachHangDTO sp in dskh)
                {*/
                    conn.Open();
                    string query = "select * from KhachHang where tenkhachhang like '%" + text + "%'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader read = cmd.ExecuteReader();
                    found = new List<KhachHangDTO>();
                    while (read.Read())
                    {
                        KhachHangDTO k = new KhachHangDTO();
                        k.id = read.GetInt32(0);
                        k.TenKhachHang = read.GetString(1);
                        k.SoDienThoai = read.GetInt32(2);
                        k.GioiTinh = read.GetString(3);
                        k.ghichu = read.GetString(4);
                        found.Add(k);
                    }
                    conn.Close(); //Sau mỗi lần đọc lần đóng kết nối lại
                /*}*/
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
        public bool UpdateKH(KhachHangDTO k)
        {
            conn.Open();
            try
            {
                string query = "UPDATE KhachHang SET "
                    + "tenkhachhang =  @TenKhachHang ,sodienthoai = @SoDienThoai ,gioitinh = @GioiTinh , ghichu = @ghichu where id = " + k.id;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenKhachHang", k.TenKhachHang);
                cmd.Parameters.AddWithValue("@SoDienThoai", k.SoDienThoai);
                cmd.Parameters.AddWithValue("@GioiTinh", k.GioiTinh);
                cmd.Parameters.AddWithValue("@ghichu", k.ghichu);
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

