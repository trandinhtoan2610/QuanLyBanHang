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
    public class LoaiSanPhamDAL
    {
        SqlConnection conn = SqlConnectionData.Connect();
        private List<LoaiSanPhamDTO> dslsp, found;
        public List<LoaiSanPhamDTO> readDB()
        {
            try
            {
                conn.Open();
                String query = "Select * from LoaiSanPham";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader read = cmd.ExecuteReader();
                dslsp = new List<LoaiSanPhamDTO>();
                while (read.Read())
                {
                    LoaiSanPhamDTO lsp = new LoaiSanPhamDTO();
                    lsp.Id = read.GetInt32(0);
                    lsp.TenLoai = read.GetString(1);
                    dslsp.Add(lsp);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally { conn.Close(); }
            return dslsp;
        }

        public bool InsertLSP(LoaiSanPhamDTO lsp)
        {
            conn.Open();
            try
            {
                string query = $"Insert into LoaiSanPham (id,tenloai) values ({lsp.Id},'{lsp.TenLoai}')";
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



        public bool UpdateLSP(int id, string tensanpham)
        {
            conn.Open();
            try
            {
                string query = "UPDATE SanPham SET "
                    + "tensanpham = '" + tensanpham
                    + "' where id='" + id ;
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
        //Xoá theo số điện thoại
        public bool DeleteLSP(string index)
        {
            conn.Open();
            try
            {
                foreach (LoaiSanPhamDTO lsp in dslsp)
                {
                    if (lsp.TenLoai.Equals(index))
                    {
                        string query = "Delete From LoaiSanPham  WHERE tenloai = '" + index + "' or id = '" + index + "'";
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

        public List<LoaiSanPhamDTO> Search(string text)
        {
            try
            {
                foreach (LoaiSanPhamDTO lsp in dslsp)
                {
                    conn.Open();
                    string query = "SELECT * FROM LoaiSanPham WHERE tenloai LIKE '" + text + "' OR hangsanxuat LIKE '" + text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader read = cmd.ExecuteReader();
                    found = new List<LoaiSanPhamDTO>();
                    while (read.Read())
                    {
                        lsp.Id = read.GetInt32(0);
                        lsp.TenLoai = read.GetString(1);                 
                        found.Add(lsp);   //Thêm đối tượng vừa đọc vào List
                    }
                    conn.Close(); //Sau mỗi lần đọc lần đóng kết nối lại
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);    //Hiển thị lỗi nếu có
            }
            finally
            {
                conn.Close();   //Đóng kết nối
            }
            return found;
        }

        //Hiển thị + Reload dữ liệu vào DataGridView
        public DataTable Display(List<LoaiSanPhamDTO> ds)
        {
            ds = readDB();
            return Show(ds);
        }

        public DataTable Show(List<LoaiSanPhamDTO> ds)
        {
            DataTable dtb = new DataTable();    //Khởi tạo bảng, sau đó thêm các cột và gán kiểu dữ liệu
            dtb.Columns.Add("ID", typeof(int));
            dtb.Columns.Add("Tên sản phẩm", typeof(string));
            

            foreach (LoaiSanPhamDTO lsp in ds)
            {
                DataRow data = dtb.NewRow();
                data["id"] = lsp.Id;
                data["Tên loại sản phẩm"] = lsp.TenLoai;
                dtb.Rows.Add(data); 
                for (int i = 0; i < dtb.Rows.Count; i++)
                {
                    data["STT"] = i + 1;   
                }

            }
            return dtb;
        }
    }
}
