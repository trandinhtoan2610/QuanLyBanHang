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
    public class LoaiNhanVienDAL
    {
        SqlConnection conn = SqlConnectionData.Connect();
        private List<LoaiNhanVienDTO> dslnv, found;
        public List<LoaiNhanVienDTO> readDB()
        {
            try
            {
                conn.Open();
                String query = "Select * from LoaiNhanVien";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader read = cmd.ExecuteReader();
                dslnv = new List<LoaiNhanVienDTO>();
                while (read.Read())
                {
                    LoaiNhanVienDTO lnv = new LoaiNhanVienDTO();
                    lnv.ID = read.GetInt32(0);
                    lnv.Tenloai = read.GetString(1);
                    dslnv.Add(lnv);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally { conn.Close(); }
            return dslnv;
        }

        public bool InsertLNV(LoaiNhanVienDTO lnv)
        {
            conn.Open();
            try
            {
                string query = $"Insert into LoaiNhanVien (id,tenloai) values ({lnv.ID},'{lnv.Tenloai}')";
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



        public bool UpdateLNV(int id, string tenloai)
        {
            conn.Open();
            try
            {
                string query = "UPDATE LoaiNhanVien SET "
                    + "tenloai = '" + tenloai
                    + "' where id='" + id;
                SqlCommand cmd = new SqlCommand(query, conn);
                //Thực hiện câu lệnh cập nhật khách hàng trong CSDL
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);    //Hiển thị lỗi nếu có
                return false;
            }
            finally
            {
                conn.Close();   //Đóng kết nối
            }

        }

        public bool DeleteLNV(string index)
        {
            conn.Open();
            try
            {
                foreach (LoaiNhanVienDTO lsp in dslnv)
                {
                    if (lsp.Tenloai.Equals(index))
                    {
                        string query = "Delete From LoaiNhanVien  WHERE tenloai = '" + index + "' or id = '" + index + "'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);    //Hiển thị lỗi nếu có
                return false;
            }
            finally
            {
                conn.Close();   //Đóng kết nối
            }
        }
    }
}
