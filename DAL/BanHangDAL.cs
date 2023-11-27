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
