using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiNhanVienBLL
    {
        private LoaiNhanVienDTO lnv;
        private List<LoaiNhanVienDTO> dslnv;
        LoaiNhanVienDAL qllnvDAL = new LoaiNhanVienDAL();

        public List<LoaiNhanVienDTO> readDB()
        {
            return qllnvDAL.readDB();
        }



        public bool InsertLNV(LoaiNhanVienDTO loainhanvien)
        {
            dslnv = readDB();
            dslnv.Add(loainhanvien);
            return qllnvDAL.InsertLNV(loainhanvien);
        }

        public bool InsertLNV(int id, string tenloai)
        {
            lnv = new LoaiNhanVienDTO(id, tenloai);
            return InsertLNV(lnv);
        }




        public bool UpdateLSP(int id, string tenloai)
        {
            dslnv = readDB();

            foreach (LoaiNhanVienDTO lnv in dslnv)
            {
                if (lnv.ID.Equals(id))
                {
                    lnv.Tenloai = tenloai;

                }
            }
            return qllnvDAL.UpdateLNV(id, tenloai);
        }


    }
}
