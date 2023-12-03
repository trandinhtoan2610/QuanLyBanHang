using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections;
namespace DAL
{
    public class ThongKeDAL
    {
        SqlConnection conn = SqlConnectionData.Connect();
        int n = 0;
        public double ThongKeTienNhapHang(string thang, string nam)
        {
            double tongthanhtien = 0;

            try
            {
                conn.Open();
                String sql = "SELECT SUM(cthdnh.thanhtien) AS TongThanhTien FROM ct_hoadonnhaphang cthdnh JOIN hoadonnhaphang hdnh ON cthdnh.idHoadonnhaphang= hdnh.id WHERE MONTH(hdnh.ngaylap) = "+thang+" AND YEAR(hdnh.ngaylap) = "+nam+"";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    if (!sqlDataReader.IsDBNull(0))
                    {
                        tongthanhtien = sqlDataReader.GetDouble(0);
                    }
                    else
                    {
                        tongthanhtien = 0;
                    }


                }
                
                conn.Close();
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            finally { conn.Close(); }
            return tongthanhtien;
        }
        public double ThongKeDoanhThuTrongThang(string thang, string nam)
        {
            double tongthanhtien = 0;

            try
            {
                conn.Open();
                String sql = "SELECT SUM(cthdbh.thanhtien) AS TongThanhTien FROM ct_hoadonbanhang cthdbh JOIN hoadonbanhang hdbh ON cthdbh.idHoadonbanhang= hdbh.id WHERE MONTH(hdbh.ngaylap) = " + thang + " AND YEAR(hdbh.ngaylap) = " + nam + "";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    if (!sqlDataReader.IsDBNull(0))
                    {
                        tongthanhtien = sqlDataReader.GetDouble(0);
                    }
                    else
                    {
                        tongthanhtien = 0;
                    }


                }

                conn.Close();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            finally { conn.Close(); }
            return tongthanhtien;
        }
        public List<NhanVienDTO> listNVBHTT(string thang, string nam)
        {
            List<NhanVienDTO> list = new List<NhanVienDTO>();
            try
            {
                conn.Open();
                String sql = "SELECT nv.id , nv.tennhanvien , nv.ngaysinh , nv.idLoaiNhanVien , nv.sodienthoai , nv.email FROM NhanVien nv JOIN hoadonbanhang hdbh ON nv.id = hdbh.idNhanvien JOIN ct_hoadonbanhang cthdbh ON cthdbh.idHoadonbanhang = hdbh.id WHERE MONTH(hdbh.ngaylap) = '"+thang+"' AND YEAR(hdbh.ngaylap) = '"+nam+"' GROUP BY nv.id , nv.tennhanvien , nv.ngaysinh , nv.idLoaiNhanVien , nv.sodienthoai , nv.email ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    n++;
                    NhanVienDTO nv = new NhanVienDTO();
                   nv.Id = sqlDataReader.GetInt32(0);
                    nv.Tennhanvien = sqlDataReader.GetString(1);
                    nv.Ngaysinh = sqlDataReader.GetString(2);
                    nv.IdLoainhanvien = sqlDataReader.GetInt32(3);
                    nv.Sodienthoai = sqlDataReader.GetString(4);
                    nv.Email= sqlDataReader.GetString(5);
                    list.Add(nv);

                }
                conn.Close();
                return list;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            finally { conn.Close(); }
            return null;
        }
        public double[] listTienNV(string thang, string nam)
        {
            double[] ArrayTongTien = new double[n];
            int i = 0;
            try
            {
                conn.Open();
                String sql = "SELECT  nv.id , SUM(cthdbh.thanhtien) AS TT FROM NhanVien nv JOIN hoadonbanhang hdbh ON nv.id = hdbh.idNhanvien JOIN ct_hoadonbanhang cthdbh ON cthdbh.idHoadonbanhang = hdbh.id WHERE MONTH(hdbh.ngaylap) = '"+thang+"' AND YEAR(hdbh.ngaylap) = '"+nam+"' GROUP BY nv.id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    ArrayTongTien[i]   = sqlDataReader.GetDouble(1);
                    i++;
                }
                conn.Close();
                return ArrayTongTien;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            finally { conn.Close(); }
            return null;
        }
        public List<SanPhamDTO> listSanPhamBTT(string thang , string nam)
        {
            List<SanPhamDTO> list = new List<SanPhamDTO>();
            try
            {
                conn.Open();
                String sql = "SELECT sp.* FROM SanPham sp JOIN ct_hoadonbanhang cthd ON sp.id= cthd.idSanpham JOIN hoadonbanhang hd ON cthd.idHoadonbanhang = hd.id WHERE MONTH(hd.ngaylap) = " + thang + " AND YEAR(hd.ngaylap) = "+nam+"";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while(sqlDataReader.Read()) {
                    SanPhamDTO sp = new SanPhamDTO();
                    sp.Id = sqlDataReader.GetInt32(0);
                    sp.Tensanpham = sqlDataReader.GetString(1);
                    sp.IdLoaiSanPham = sqlDataReader.GetInt32(2);
                    sp.Hangsanxuat = sqlDataReader.GetString(3);
                    sp.Gia = sqlDataReader.GetInt32(4);
                    sp.Donvitinh = sqlDataReader.GetString(6);
                    sp.Khuyenmai = sqlDataReader.GetInt32(7);
                    list.Add(sp);
                    
                }
                conn.Close();
                return list;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error : "+ex);
            }
            finally { conn.Close(); }
            return null;
        }
        public List<ChiTietHoaDonBanDTO> listCount(string thang , string nam)
        {
            List<ChiTietHoaDonBanDTO> list = new List<ChiTietHoaDonBanDTO>();

            try
            {
                conn.Open();
                String sql = "SELECT cthd.count FROM SanPham sp JOIN ct_hoadonbanhang cthd ON sp.id = cthd.idSanpham JOIN hoadonbanhang hd ON cthd.idHoadonbanhang = hd.id WHERE MONTH(hd.ngaylap) = "+thang+ " AND YEAR(hd.ngaylap) = "+nam+"";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    ChiTietHoaDonBanDTO ct = new ChiTietHoaDonBanDTO();
                    ct.Count = sqlDataReader.GetInt32(0);
                    list.Add(ct);
                }
                conn.Close();
                return list;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            finally { conn.Close(); }
            return null;
        }
        public List<SanPhamDTO> listSanPhamNhapHangTT(string thang , string nam)
        {
            List<SanPhamDTO> sanPhams = new List<SanPhamDTO>();
            
            
            try
            {
                conn.Open();
                string sql = "SELECT sp.id , sp.tensanpham , sp.idLoaiSanPham , sp.gia , sp.donvitinh , chthdnh.count , sp.gia*chthdnh.count AS thanhtien FROM SanPham sp JOIN ct_hoadonnhaphang chthdnh ON sp.id = chthdnh.idSanpham JOIN hoadonnhaphang hdnh ON hdnh.id = chthdnh.idHoadonnhaphang WHERE MONTH(hdnh.ngaylap)= '" + thang + "' AND YEAR(hdnh.ngaylap) = '" + nam + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while(sqlDataReader.Read())
                {
                    SanPhamDTO sp = new SanPhamDTO();
                    sp.Id = sqlDataReader.GetInt32(0);
                    sp.Tensanpham = sqlDataReader.GetString(1);
                    sp.IdLoaiSanPham = sqlDataReader.GetInt32(2);
                    sp.Gia = sqlDataReader.GetInt32(3);
                    sanPhams.Add(sp);
                }
                return sanPhams;

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error : " + ex);
            }
            finally { conn.Close(); }
            return null;
        }

        public List<CTHDNhapDTO> soluongvathanhtien(string thang, string nam)
        {
            List<CTHDNhapDTO> cTHDNhapDTOs = new List<CTHDNhapDTO>();
            try
            {
                conn.Open();
                string sql = "SELECT  chthdnh.count ,sp.gia*chthdnh.count AS thanhtien FROM SanPham sp JOIN ct_hoadonnhaphang chthdnh ON sp.id = chthdnh.idSanpham JOIN hoadonnhaphang hdnh ON hdnh.id = chthdnh.idHoadonnhaphang WHERE MONTH(hdnh.ngaylap)= '" + thang + "' AND YEAR(hdnh.ngaylap) = '" + nam + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while(sqlDataReader.Read())
                {
                    CTHDNhapDTO ct = new CTHDNhapDTO();
                    ct.count = sqlDataReader.GetInt32(0);
                    ct.thanhtien = sqlDataReader.GetInt32(1); 
                    cTHDNhapDTOs.Add(ct);
                }
                conn.Close();
                return cTHDNhapDTOs;
                
            }
            catch (SqlException ex)
            {
                MessageBox.Show("error : " + ex);
            }
            finally { conn.Close(); }
            return null;
        }
        public List<SanPhamDTO> listHangTonKho()
        {
            List<SanPhamDTO> dssp = new List<SanPhamDTO>();
            try
            {
                conn.Open();
                String query = "Select SanPham.id,tensanpham,idLoaiSanPham,tenloai,hangsanxuat,gia,soluong,donvitinh,khuyenmai from SanPham Join LoaiSanPham on SanPham.idLoaiSanPham = LoaiSanPham.id WHERE soluong >0";
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
    }
}
