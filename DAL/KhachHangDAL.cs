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
        public KhachHangDTO findbyPhone(string phone) 
            {
            KhachHangDTO kh = new KhachHangDTO();
            try
                {
                    conn.Open();
                    
                    string sql = "SELECT * FROM KhachHang WHERE sodienthoai like '" + phone + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    SqlDataReader read = cmd.ExecuteReader();
                    while (read.Read())
                {
                    
                    kh.Id = read.GetInt32(0);
                    kh.TenKhachHang = read.GetString(1);
                    kh.SoDienThoai = read.GetString(2);
                    kh.GioiTinh = read.GetString(3);
                    kh.Ghichu = read.GetString(4);
                }
                    conn.Close();
                return kh;


            }
                catch (SqlException ex) {
                    MessageBox.Show("Error : " + ex);

                }
                finally { conn.Close(); }

            return null;
            } 
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
                    kh.Id = read.GetInt32(0);
                    kh.TenKhachHang = read.GetString(1);
                    kh.SoDienThoai = read.GetString(2);
                    kh.GioiTinh = read.GetString(3);
                    kh.Ghichu = read.GetString(4);
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
                cmd.Parameters.AddWithValue("@ghichu", kh.Ghichu);
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
                        k.Id = read.GetInt32(0);
                        k.TenKhachHang = read.GetString(1);
                        k.SoDienThoai = read.GetString(2);
                        k.GioiTinh = read.GetString(3);
                        k.Ghichu = read.GetString(4);
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
                string query = "UPDATE KhachHang SET tenkhachhang =  @TenKhachHang ,sodienthoai = @SoDienThoai ,gioitinh = @GioiTinh ,ghichu = @ghichu where id = " + k.Id;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TenKhachHang", k.TenKhachHang);
                cmd.Parameters.AddWithValue("@SoDienThoai", k.SoDienThoai);
                cmd.Parameters.AddWithValue("@GioiTinh", k.GioiTinh);
                cmd.Parameters.AddWithValue("@ghichu", k.Ghichu);
                cmd.ExecuteNonQuery();
                conn.Close();
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

        public KhachHangDTO TimKiemKH(string sodienthoai)
        {

            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            string query = $"Select * from KhachHang where sodienthoai = '{sodienthoai}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader read = cmd.ExecuteReader();

            if (read.HasRows)
            {
                while (read.Read())
                {
                    KhachHangDTO khachhang = new KhachHangDTO();
                    khachhang.Id = read.GetInt32(0);
                    khachhang.TenKhachHang = read.GetString(1);
                    khachhang.SoDienThoai = read.GetString(2);
                    khachhang.GioiTinh = read.GetString(2);
                    khachhang.Ghichu = read.GetString(3);
                    return khachhang;
                }
                read.Close();
                conn.Close();
            }

            return null;

        }


    }

    }

