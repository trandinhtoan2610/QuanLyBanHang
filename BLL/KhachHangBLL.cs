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
                if (kh.id.Equals(id))
                {
                    kh.id = id;
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
    }
}
