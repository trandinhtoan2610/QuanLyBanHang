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
    public class HoaDonDAL
    {
        SqlConnection conn = SqlConnectionData.Connect();
        private List<HoaDonDTO> dshd, found;
        

        public List<HoaDonDTO> readDB()
        {
            
            try
            {
                conn.Open();
                string querry = "select hoadonbanhang.id,KhachHang.id ,tenkhachhang,NhanVien.id, tennhanvien, ngaylap, status from hoadonbanhang join KhachHang on hoadonbanhang.idKhachang = KhachHang.id join NhanVien on hoadonbanhang.idNhanvien = NhanVien.id";
                SqlCommand cmd = new SqlCommand(querry, conn);
                SqlDataReader read = cmd.ExecuteReader();
                dshd = new List<HoaDonDTO>();
                if (read.HasRows)
                {
                    while (read.Read())
                    {
                        HoaDonDTO hd = new HoaDonDTO();
                        hd.Id = read.GetInt32(0);
                        hd.IdKhachhang = read.GetInt32(1);
                        hd.Tenkhachhang = read.GetString(2);
                        hd.IdNhanvien = read.GetInt32(3);
                        hd.Tennhanvien = read.GetString(4);
                        hd.Ngaylap = read.GetDateTime(5);
                        hd.Status = read.GetInt32(6);
                        dshd.Add(hd);
                    }
                    read.Close();
                    conn.Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally { conn.Close(); }
            return dshd;
        }

        public bool CheckoutBill (int id)
        {
            conn.Open ();
            try
            {
                string query = "Update hoadonban set status = 1 where id = " + id;
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
                return false;
            }
            finally
            {
                conn.Close();
            }

        }

        public bool InsertHDB(HoaDonDTO hd)
        {
            conn.Open();
            try
            {
                string query = $"Insert into hoadonbanhang ( idKhachang, idNhanvien, status) values ( {hd.IdKhachhang}, {hd.IdNhanvien}, {hd.Status})";
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

        public int GetIdHDB(int idKhachHang)
        {
            int id;
            conn.Open();
            string query = $"select id from hoadonbanhang where status = 0 and idKhachang = " + idKhachHang;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader read = cmd.ExecuteReader();
            if (read.HasRows)
                {
                while (read.Read())
                {
                    id = read.GetInt32(0);
                    return id;
                }
                 read.Close();
                 conn.Close();
             }
             return -1;
        }
    }
}
