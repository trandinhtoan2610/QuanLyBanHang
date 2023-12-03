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
    public class HoaDonNhapDAL
    {
        SqlConnection conn = SqlConnectionData.Connect();
        public List<HoaDonNhapDTO> getAllHoaDonNhap(DateTime dateStart, DateTime dateEnd)
        {
            List<HoaDonNhapDTO> list = new List<HoaDonNhapDTO>();
            try
            {
                conn.Open();
                String query = $"SELECT * FROM hoadonnhaphang where ngaylap BETWEEN '{dateStart}' AND '{dateEnd}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader read = cmd.ExecuteReader();
                if (read.HasRows) {
                    while (read.Read())
                    {
                        HoaDonNhapDTO hd = new HoaDonNhapDTO();
                        hd.id = read.GetInt32(0);
                        hd.ngaylap = read.GetDateTime(1);
                        hd.idNhanvien = read.GetInt32(2);
                        hd.idNhacungcap = read.GetInt32(3);
                        hd.status = read.GetInt32(4);
                        list.Add(hd);
                    }
                }
                
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally { conn.Close(); }
            return list;
        }
        public List<CTHDNhapDTO> getAllCTHoaDonNhap(int idHoaDon)
        {
            List<CTHDNhapDTO> listCTHD = new List<CTHDNhapDTO>();
            try
            {
                conn.Open();
                String query = $"SELECT * FROM ct_hoadonnhaphang where idHoadonnhaphang= {idHoaDon}";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    CTHDNhapDTO hd = new CTHDNhapDTO();
                    hd.id = read.GetInt32(0);
                    hd.idHoadonnhaphang = read.GetInt32(1);
                    hd.idSanpham = read.GetInt32(2);
                    hd.count = read.GetInt32(3);
                    hd.thanhtien = read.GetDouble(4);
                    listCTHD.Add(hd);
                }
                conn.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            finally { conn.Close(); }
            return listCTHD;
        }
    }
}
