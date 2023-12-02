using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HoaDonBLL
    {
        private HoaDonDTO hd;
        private List<HoaDonDTO> dshd;
        private HoaDonDAL qlhdDAL = new HoaDonDAL();

        public List<HoaDonDTO> readDB()
        {
            return qlhdDAL.readDB();
        }

        public bool InsertHDB(HoaDonDTO hoadon)
        {
            dshd = readDB();
            dshd.Add(hoadon);
            return qlhdDAL.InsertHDB(hoadon);
        }
        
        public bool InsertHDB(int id,DateTime ngaylap, int idkhachhang, int idnhanvien, int status)
        {
            hd = new HoaDonDTO(id,ngaylap, idkhachhang, idnhanvien, status);
            return InsertHDB(hd);
        }
        public bool CheckoutBill(int id)
        {   
            return qlhdDAL.CheckoutBill(id);
        }
        
        public int GetIdHDB(int idKhachHang)
        {
            return qlhdDAL.GetIdHDB(idKhachHang);
        }
    }
}
