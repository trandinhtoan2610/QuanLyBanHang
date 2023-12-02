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
    public class NhapHangDAL
    {
        SqlConnection conn = SqlConnectionData.Connect();
        private List<SanPhamDTO> listProduct = new List<SanPhamDTO>();
        private List<NCCDTO> listNCC = new List<NCCDTO>();

        public List<NCCDTO> getAllNhaCungCap()
        {
            try
            {
                conn.Open();
                String query = "Select * from NhaCungCap";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    NCCDTO ncc = new NCCDTO();
                    ncc.Id = read.GetInt32(0);
                    ncc.Tennhacungcap = read.GetString(1);
                    ncc.Sodienthoai= read.GetString(2);
                    ncc.Diachi = read.GetString(3);
                    ncc.Email = read.GetString(4);
                   
                    listNCC.Add(ncc);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally { conn.Close(); }
            return listNCC;
        }
        public List<SanPhamDTO> getAllProduct(int nhaCungCapId)
        {
            try
            {
                conn.Open();
                String query = $"Select SanPham.id,tensanpham,idLoaiSanPham,tenloai,hangsanxuat,gia,soluong,donvitinh,khuyenmai from SanPham Join LoaiSanPham on SanPham.idLoaiSanPham = LoaiSanPham.id where SanPham.hangsanxuat = {nhaCungCapId}";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    SanPhamDTO sp = new SanPhamDTO();
                    sp.Id = read.GetInt32(0);
                    sp.Tensanpham = read.GetString(1);
                    sp.IdLoaiSanPham = read.GetInt32(2);
                    sp.Tenloai = read.GetString(3);
                    sp.Hangsanxuat = read.GetString(4);
                    sp.Gia = read.GetInt32(5);
                    sp.Soluong = read.GetInt32(6);
                    sp.Donvitinh = read.GetString(7);
                    sp.Khuyenmai = read.GetInt32(8);
                    listProduct.Add(sp);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally { conn.Close(); }
            return listProduct;
        }
        public bool InsertSP(List<SanPhamDTO> listsp, NhanVienDTO nv, int nhaCungCapId)
        {
            conn.Open();
            try
            {
                DateTime currentTime = DateTime.Now;
                string queryHoaDonNhap = $"INSERT INTO hoadonnhaphang (ngaylap , idNhanvien, idNhacungcap , status ) VALUES ('{currentTime}',{nv.Id} ,{nhaCungCapId},1);";
                SqlCommand cmdHoaDonNhap = new SqlCommand(queryHoaDonNhap, conn);
                cmdHoaDonNhap.ExecuteNonQuery();

                string queryGetInsertedId = "SELECT SCOPE_IDENTITY()";
                SqlCommand cmdGetInsertedId = new SqlCommand(queryGetInsertedId, conn);
                int insertedId = Convert.ToInt32(cmdGetInsertedId.ExecuteScalar());

                string queryGetAllSPKho = $"SELECT * FROM SanPham_Kho";
                SqlCommand cmdAllSPKho = new SqlCommand(queryGetAllSPKho, conn);
                SqlDataReader readAllSPKho = cmdAllSPKho.ExecuteReader();
                List<SanPhamKhoDTO> listSPKho = new List<SanPhamKhoDTO>();

                while (readAllSPKho.Read())
                {
                    SanPhamKhoDTO sp = new SanPhamKhoDTO();
                    sp.id = readAllSPKho.GetInt32(0);
                    sp.soluong = readAllSPKho.GetInt32(1);
                    sp.gia = readAllSPKho.GetInt32(2);
                    listSPKho.Add(sp);
                }
                readAllSPKho.Close();

                string queryGetAllSP = $"SELECT * FROM SanPham";
                SqlCommand cmdAllSP = new SqlCommand(queryGetAllSP, conn);
                SqlDataReader readAllSP = cmdAllSP.ExecuteReader();
                List<SanPhamDTO> listSP = new List<SanPhamDTO>();
                while (readAllSP.Read())
                {
                    SanPhamDTO sp = new SanPhamDTO();
                    sp.Id = readAllSP.GetInt32(0);
                    sp.Soluong = readAllSP.GetInt32(5);
                    listSP.Add(sp);
                }
                readAllSP.Close();

                int soluongSPKho = -1;
                int soluongSP = -1;
                foreach (var sp in listsp)
                {
                    int moneySum = sp.Soluong * sp.Gia + ((sp.Gia * 10) / 100);
                    string queryCTHDNhap = $"INSERT INTO ct_hoadonnhaphang (idHoadonnhaphang , idSanpham, count , thanhtien ) VALUES ({insertedId},{sp.Id} ,{sp.Soluong},{moneySum});";
                    SqlCommand cmdCTHDNhap = new SqlCommand(queryCTHDNhap, conn);
                    cmdCTHDNhap.ExecuteNonQuery();

                    foreach (var spKho in listSPKho)
                    {
                        if (spKho.id == sp.Id)
                        {
                            soluongSPKho = spKho.soluong;
                            break;
                        }
                    }

                    string query = "";
                    if (soluongSPKho != -1)
                    {
                        query = $"UPDATE SanPham_Kho SET soluong = {soluongSPKho + sp.Soluong} WHERE id = {sp.Id};";
                    }
                    else
                    {
                        query = $"INSERT INTO SanPham_Kho (id , soluong, gia ) VALUES ({sp.Id} ,{sp.Soluong},{Convert.ToDouble(sp.Gia + Convert.ToDouble((Convert.ToDouble((sp.Gia * 10)) / 100)))});";
                    }
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    foreach (var spncc in listSP)
                    {
                        if (spncc.Id == sp.Id)
                        {
                            soluongSP = spncc.Soluong;
                            break;
                        }
                    }

                    string queryUpdateSanPham = $"UPDATE SanPham SET soluong = {soluongSP - sp.Soluong} WHERE id = {sp.Id};";
                    SqlCommand cmdUpdateSanPham = new SqlCommand(queryUpdateSanPham, conn);
                    cmdUpdateSanPham.ExecuteNonQuery();
                    soluongSP = -1;
                    soluongSPKho = -1;
                }

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
