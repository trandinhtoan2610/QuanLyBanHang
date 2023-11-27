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

        public DataTable Display(List<NCCDTO> ds)
        {
            ds = readDB();
            return Show(ds);
        }

        public DataTable Show(List<NCCDTO> ds)
        {
            DataTable dtb = new DataTable();    //Khởi tạo bảng, sau đó thêm các cột và gán kiểu dữ liệu
            dtb.Columns.Add("ID", typeof(int));
            dtb.Columns.Add("Tên nhà cung cấp", typeof(string));
            dtb.Columns.Add("Số điện thoại", typeof(string));
            dtb.Columns.Add("Địa chỉ", typeof(string));
            dtb.Columns.Add("Email", typeof(int));
            


            foreach (NCCDTO ncc in dsNCC)
            {
                DataRow data = dtb.NewRow();
                data["ID"] = ncc.Id;
                data["Tên nhà cung cấp"] = ncc.Tennhacungcap;
                data["Số điện thoại"] = ncc.Sodienthoai;
                data["Địa chỉ"] = ncc.Diachi;
                data["Email"] = ncc.Email;
                

                dtb.Rows.Add(data); //Thêm đối tượng vào bảng

                for (int i = 0; i < dtb.Rows.Count; i++)
                {
                    data["STT"] = i + 1;    //set số thứ tự tăng dần cho bảng
                }

            }
            return dtb;
        }

    }
}
