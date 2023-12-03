using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class KhachHangBLL
    {
        private KhachHangDTO kh;
        private List<KhachHangDTO> dskh;
        KhachHangDAL qlkhDAL = new KhachHangDAL();

        public List<KhachHangDTO> readDB()
        {
            return qlkhDAL.readDB();
        }
        public bool InsertKH(KhachHangDTO kh)
        {
            dskh = readDB();
            dskh.Add(kh);
            return qlkhDAL.InsertKH(kh);
        }
        public bool DeleteKH(int id)
        {
            dskh = readDB();

            foreach (KhachHangDTO kh in dskh)
            {
                if (kh.Id.Equals(id))
                {
                    kh.Id = id;
                }
            }
            return qlkhDAL.DeleteKH(id);
        }
        public bool UpdateKH(KhachHangDTO k)
        {
            dskh = readDB();

            
            return qlkhDAL.UpdateKH(k);
        }
        public List<KhachHangDTO> Search(string text)
        {

            return qlkhDAL.Search(text);
        }

        public static KhachHangDTO khachdto = new KhachHangDTO();
        
        public string CheckTimKiemKH(string sodienthoai)
        {
            KhachHangDAL khachdal = new KhachHangDAL();
            if (sodienthoai == "")
            {
                return "requeid_sodienthoai";
            }
            KhachHangDTO info = khachdal.TimKiemKH(sodienthoai);
            if (info != null)
            {
                khachdto = info;
                return "timthaykhachhang";
            }
            return "sai so dien thoai";
        }
    }
}
