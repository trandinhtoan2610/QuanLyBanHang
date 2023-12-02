using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonNhapBLL
    {
        HoaDonNhapDAL hdnDAL= new HoaDonNhapDAL();
        public List<HoaDonNhapDTO> getAllHoaDonNhap( DateTime dateStart, DateTime dateEnd)
        {
            return hdnDAL.getAllHoaDonNhap(dateStart, dateEnd);
        }
        public List<CTHDNhapDTO> getAllCTHoaDonNhap(int idHoaDon )
        {
            return hdnDAL.getAllCTHoaDonNhap(idHoaDon);
        }
    }
}
