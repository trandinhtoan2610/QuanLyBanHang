using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
namespace DAL
{
    public class SqlConnectionData
    {
        // Tạo kết nối cơ sở dữ liệu
        public static SqlConnection Connect()
        {
            string Strconn = @"Data Source=Toàn;Initial Catalog=PhoneManage;Integrated Security=True";
            SqlConnection conn = new SqlConnection(Strconn);
            return conn;
        }
    }

    public class DatabaseAccess
    {
        public static string CheckLoginDTO(TaiKhoanDTO taikhoan)
        {
            string user = null;
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_login", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@user", taikhoan.UserName);
            command.Parameters.AddWithValue("@pass", taikhoan.Password);

            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                    return user;
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản mật khẩu không chính xác";
            }
            return user;
        }
    }
} 
