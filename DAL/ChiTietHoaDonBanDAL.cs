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
        public bool InsertCTHDB(ChiTietHoaDonBanDTO ctsp)
        {
            conn.Open();
            try
            {
                string query = $"insert into ct_hoadonbanhang (idHoadonbanhang,idSanpham,thanhtien,count) values ({ctsp.IdHoadonban},{ctsp.IdSanpham},{ctsp.Thanhtien},{ctsp.Count})";
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
            string query = $"select tensanpham,thanhtien,count from ct_hoadonbanhang join SanPham on idSanpham = SanPham.id where idHoadonbanhang = " + id;
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader read = cmd.ExecuteReader();
            List<ChiTietHoaDonBanDTO> show = new List<ChiTietHoaDonBanDTO>(); 
            while (read.Read())
            {
                ChiTietHoaDonBanDTO cthd = new ChiTietHoaDonBanDTO(
                read.GetString(0),
                Convert.ToInt32(read.GetDouble(1)),
                read.GetInt32(2));
                show.Add(cthd);    
                }
            read.Close();
            conn.Close(); 
            return show;
        }
    }
}
