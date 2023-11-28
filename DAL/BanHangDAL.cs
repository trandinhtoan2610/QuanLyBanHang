using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;

namespace DAL
{

   
    public class BanHangDAL
    {

        SqlConnection conn = SqlConnectionData.Connect();
        private List<BanHangDTO> dshdb, found;

        public List<BanHangDTO> readDB()
        {
            try
            {
                conn.Open();
                String query = "Select * from ct_hoadonbanhang";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader read = cmd.ExecuteReader();
                dshdb = new List<BanHangDTO>();
                while (read.Read())
                {
                    BanHangDTO HDB = new BanHangDTO();
                    HDB.Id = read.GetInt32(0);
                    HDB.MaHD = read.GetString(1);
                    HDB.Tennhanvien = read.GetString(2);
                    HDB.Tenkhachhang = read.GetString(3);
                    HDB.Ngaylap = read.GetString(4);
                    HDB.Tongtien = read.GetDecimal(5);
                    HDB.Tensanpham = read.GetString(6);
                    HDB.Soluong = read.GetInt32(7);
                    HDB.Gia = read.GetDecimal(8);
                    HDB.Thanhtien = read.GetDecimal(9);
                    HDB.Khuyenmai = read.GetInt32(10);
                    dshdb.Add(HDB);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally { conn.Close(); }
            return dshdb;
        }

        public bool InsertHD(BanHangDTO HDB)
        {
            conn.Open();
            try
            {
                string query = $"Insert into ct_hoadonbanhang (id,maHD, tennhanvien, tenkhachhang, ngaylap, tongtien, tensanpham, soluong, gia, thanhtien , khuyenmai) values ({HDB.Id},'{HDB.MaHD}', '{HDB.Tennhanvien}', '{HDB.Tenkhachhang}',{HDB.Ngaylap},{HDB.Tongtien},'{HDB.Tensanpham}',{HDB.Soluong},{HDB.Gia},{HDB.Thanhtien},{HDB.Khuyenmai})";
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
    }
}
