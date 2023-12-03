using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class ChiTietHoaDonBanBLL
    {
        ChiTietHoaDonBanDAL qlcthd = new ChiTietHoaDonBanDAL();

        

        public List<ChiTietHoaDonBanDTO> ShowBill(int id)
        {
            return qlcthd.ShowBill(id);
        }

        public bool InsertCTHDB(ChiTietHoaDonBanDTO cthdb)
        { 
            return qlcthd.InsertCTHDB(cthdb);
        }

        public bool InsertCTHDB(int id, int idhoadon, int idsanpham, int thanhtien, int count)
        {
            ChiTietHoaDonBanDTO cthddto = new ChiTietHoaDonBanDTO(id, idhoadon, idsanpham, thanhtien, count);
            return InsertCTHDB(cthddto);
        }
    }
}
