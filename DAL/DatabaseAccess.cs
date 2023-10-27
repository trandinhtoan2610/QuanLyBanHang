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
        
    }
} 
