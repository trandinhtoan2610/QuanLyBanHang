using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class TaikhoanDAL
    {
        public NhanVienDTO CheckLogin(string sodienthoai, string matkhau)
        {
            
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            string query = $"Select * from NhanVien where sodienthoai = '{sodienthoai}' and matkhau = '{matkhau}'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader read = cmd.ExecuteReader();
           
            if (read.HasRows)
            {
                while (read.Read())
                {
                    NhanVienDTO user = new NhanVienDTO(
                        read.GetInt32(0),
                        read.GetString(1),
                        read.GetString(2),
                        read.GetInt32(3),
                        read.GetString(4),
                        read.GetString(5),
                        read.GetString(6),
                        read.GetString(7),
                        read.GetString(8),
                        read.GetString(9));
                    
                    return user;
                }
                read.Close();
                conn.Close();
            }
            
                return null ;

        }
       
        public List<int> GetQuyen()
        {
            List<int> quyen = new List<int> ();
            return quyen; 
        }
    }
}
