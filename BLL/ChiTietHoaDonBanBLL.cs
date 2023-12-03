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

        private List<ChiTietHoaDonBanDTO> dscthd;
        private ChiTietHoaDonBanDTO cthddto;

        public List<ChiTietHoaDonBanDTO> readDB()
        {
            return qlcthd.readDB();
        }

        public List<ChiTietHoaDonBanDTO> ShowBill(int id)
        {
            return qlcthd.ShowBill(id);
        }
        public bool InsertCTHDB(ChiTietHoaDonBanDTO cthdb)
        {
            dscthd = readDB();
            dscthd.Add(cthdb);
            return qlcthd.InsertCTHDB(cthdb);
        }

        public bool InsertCTHDB(int id, int idhoadon, int idsanpham, int thanhtien, int count)
        {
            cthddto = new ChiTietHoaDonBanDTO(id, idhoadon, idsanpham, thanhtien, count);
            return InsertCTHDB(cthddto);
        }
        public bool deletect_HoaDon(int hoaDonID)
        {
            return qlcthd.deletectHoaDon(hoaDonID);
        }
    }
}
