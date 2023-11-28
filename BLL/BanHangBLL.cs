using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BanHangBLL
    {
        private BanHangDTO HDB;
        private List<BanHangDTO> dshdb;
        BanHangDAL qlhdbDAL = new BanHangDAL();

        public List<BanHangDTO> readDB()
        {
            return qlhdbDAL.readDB();
        }

        public bool InsertHD(BanHangDTO HDB)
        {
            dshdb = readDB();
            dshdb.Add(HDB);
            return qlhdbDAL.InsertHD(HDB);
        }

        public bool InsertHD(int id, string maHD, string tennhanvien, string tenkhachhang, string ngaylap, decimal tongtien, string tensanpham, int soluong, decimal gia, decimal thanhtien, int khuyenmai)
        {
            HDB = new BanHangDTO(id, maHD, tennhanvien, tenkhachhang, ngaylap, tongtien, tensanpham, soluong, gia, thanhtien, khuyenmai);
            return InsertHD(HDB);
        }

    }
}
