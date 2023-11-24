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
    public class SanPhamDAL
    {
        SqlConnection conn = SqlConnectionData.Connect();
        private List<SanPhamDTO> dssp, found;


        public List<SanPhamDTO> readDB() 
        {
            try
            {
                conn.Open();
                String query = "Select * From SanPham";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader read = cmd.ExecuteReader();
                dssp = new List<SanPhamDTO>();
                while (read.Read())
                {
                    SanPhamDTO sp = new SanPhamDTO();
                    sp.Id = read.GetInt32(0);
                    sp.Tensanpham = read.GetString(1);
                    sp.IdLoaiSanPham = read.GetInt32(2);
                    sp.Hangsanxuat = read.GetString(3);
                    sp.Gia = read.GetInt32(4);
                    sp.Soluong = read.GetInt32(5);
                    sp.Donvitinh = read.GetString(6);
                    dssp.Add(sp);
                }
                conn.Close();
            }
            catch (SqlException ex)
            { 
                MessageBox.Show("Error: " + ex);
            }
            finally { conn.Close(); }
            return dssp;
        }

        public bool InsertSP(SanPhamDTO sp)
        {
            conn.Open();
            try
            {
                string query = $"Insert into SanPham (id,tensanpham, idLoaiSanPham, hangsanxuat, gia, soluong, donvitinh) values ({sp.Id},'{sp.Tensanpham}', {sp.IdLoaiSanPham}, '{sp.Hangsanxuat}',{sp.Gia},{sp.Soluong},'{sp.Donvitinh}')";
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



        public bool UpdateSP(int id, string tensanpham, int idLoaiSanPham, string hangsanxuat, float gia, int soluong, string donvitinh)
        {
            conn.Open();
            try
            {           
                string query = "UPDATE SanPham SET "
                    + "tensanpham = '" + tensanpham
                    + "',idLoaiSanPham = '" + idLoaiSanPham
                    + "',hangsanxuat = '" + hangsanxuat
                    + "',gia = '" + gia
                    + "',soluong = '" + soluong
                    + "',donvitinh = '" + donvitinh
                    + "' where tensanpham='" + tensanpham + "'";
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
        public bool DeleteSP(string index)
        {
            conn.Open();
            try
            {
                foreach (SanPhamDTO sp in dssp)
                {
                    if (sp.Tensanpham.Equals(index)) //Nếu số điện thoại bằng giá trị ô được chọn của cột "Số điện thoại" thì mới cập nhật lại status
                    {
                        string query = "Delete From SanPham  WHERE tensanpham = '" + index + "' or id = '" + index + "'";
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

        public List<SanPhamDTO> Search(string text)
        {
            try
            {
                foreach (SanPhamDTO sp in dssp)
                {
                    conn.Open();
                    string query = "SELECT * FROM SanPham WHERE tensanpham LIKE '" + text + "' OR hangsanxuat LIKE '" + text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader read = cmd.ExecuteReader();
                    found = new List<SanPhamDTO>();
                    while (read.Read())
                    {
                        sp.Id = read.GetInt32(0);
                        sp.Tensanpham = read.GetString(1);
                        sp.IdLoaiSanPham = read.GetInt32(3);
                        sp.Hangsanxuat = read.GetString(4);
                        sp.Gia = read.GetInt32(5);
                        sp.Soluong = read.GetInt32(6);
                        sp.Donvitinh = read.GetString(7);
                        found.Add(sp);   //Thêm đối tượng vừa đọc vào List
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
        public DataTable Display(List<SanPhamDTO> ds)
        {
            ds = readDB();
            return Show(ds);
        }

        public DataTable Show(List<SanPhamDTO> ds)
        {
            DataTable dtb = new DataTable();    //Khởi tạo bảng, sau đó thêm các cột và gán kiểu dữ liệu
            dtb.Columns.Add("ID", typeof(int));
            dtb.Columns.Add("Tên sản phẩm", typeof(string));
            dtb.Columns.Add("Loại sản phẩm", typeof(string));
            dtb.Columns.Add("Hãng sản xuất", typeof(string));
            dtb.Columns.Add("Giá", typeof(int));
            dtb.Columns.Add("Số lương", typeof(int));
            dtb.Columns.Add("Đơn vị tính", typeof(string));

            foreach (SanPhamDTO sp in ds)
            {
                DataRow data = dtb.NewRow();
                data["id"] = sp.Tensanpham;
                data["Tên sản phâmr"] = sp.Tensanpham;
                data["Loại sản phẩm"] = sp.IdLoaiSanPham;
                data["Hãng sản xuất"] = sp.Hangsanxuat;
                data["Giá"] = sp.Gia;
                data["Số lương"] = sp.Soluong;
                data["Đơn vị tính"] = sp.Donvitinh;

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
