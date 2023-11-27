using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    
    public class NCCDAL
    {
        SqlConnection conn = SqlConnectionData.Connect();
        private List<NCCDTO> dsNCC, found;
        public List<NCCDTO> readDB()
        {
            try
            {
                conn.Open();
                String query = "Select * From NhaCungCap";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader read = cmd.ExecuteReader();
                dsNCC = new List<NCCDTO>();
                while (read.Read())
                {
                    NCCDTO ncc = new NCCDTO();
                    ncc.Id = read.GetInt32(0);
                    ncc.Tennhacungcap = read.GetString(1);
                    ncc.Sodienthoai = read.GetString(2);
                    ncc.Diachi = read.GetString(3);
                    ncc.Email = read.GetString(4);
                    
                    dsNCC.Add(ncc);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally { conn.Close(); }
            return dsNCC;
        }

        public bool InsertNCC(NCCDTO ncc)
        {
            conn.Open();
            try
            {
                string query = $"Insert into NhaCungCap (tennhacungcap,sodienthoai,diachi,email) values ('{ncc.Tennhacungcap}', '{ncc.Sodienthoai}', '{ncc.Diachi}','{ncc.Email}')";
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
