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

            string Strconn = @"Data Source=LAPTOP-IJDHL0GE\SQLEXPRESS;Initial Catalog=PhoneManage;Integrated Security=True";

            SqlConnection conn = new SqlConnection(Strconn);
            return conn;
        }
    }

    public class DatabaseAccess
    {

        private string connectionSTR = @"Data Source=LAPTOP-IJDHL0GE\SQLEXPRESS;Initial Catalog=PhoneManage;Integrated Security=True";

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                
                adapter.Fill(data);
                connection.Close();
            }
            return data;
        }
    }
}