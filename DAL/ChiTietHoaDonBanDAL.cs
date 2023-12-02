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
    public class ChiTietHoaDonBanDAL
    {
        SqlConnection conn = SqlConnectionData.Connect();
        private List<ChiTietHoaDonBanDTO> dsctsp, found;


        public List<ChiTietHoaDonBanDTO> readDB()
        {
                try
                {
                    conn.Open();
                    String query = "select * from ct_hoadonbanhang";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader read = cmd.ExecuteReader();
                    dsctsp = new List<ChiTietHoaDonBanDTO>();
                    while (read.Read())
                    {
                        ChiTietHoaDonBanDTO ctsp = new ChiTietHoaDonBanDTO();
                        ctsp.Id = read.GetInt32(0);
                        ctsp.IdHoadonban = read.GetInt32(1);
                        ctsp.IdSanpham = read.GetInt32(2);
                        ctsp.Thanhtien = Convert.ToInt32(read.GetDouble(3));
                        ctsp.Count = read.GetInt32(4);
                        dsctsp.Add(ctsp);
                    }
                    conn.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex);
                }
                finally { conn.Close(); }
                return dsctsp;
        }

        public bool InsertCTHDB(ChiTietHoaDonBanDTO ctsp)
        {
            conn.Open();
            try
            {
                string query = $"insert into ct_hoadonbanhang (idHoadonbanhang,idSanpham,thanhtien,count) values ({ctsp.Id},{ctsp.IdHoadonban},{ctsp.IdSanpham},{ctsp.Thanhtien},{ctsp.Count})";
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

        public List<ChiTietHoaDonBanDTO> ShowBill(int id)
        {
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            string query = $"select * from ct_hoadonbanhang where idHoadonbanhang = " + id;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader read = cmd.ExecuteReader();
            List<ChiTietHoaDonBanDTO> show = new List<ChiTietHoaDonBanDTO>(); 
            while (read.Read())
            {
                ChiTietHoaDonBanDTO cthd = new ChiTietHoaDonBanDTO(
                read.GetInt32(0),
                read.GetInt32(1),
                read.GetInt32(2),
                Convert.ToInt32(read.GetDouble(3)),
                read.GetInt32(4));
                show.Add(cthd);    
                return show;
                }
            read.Close();
            conn.Close(); 
            return null;
        }
    }
}
