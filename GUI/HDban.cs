using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class HDban : UserControl
    {
        HoaDonBLL qlhdBLL = new HoaDonBLL();
        HoaDonDTO hd = new HoaDonDTO();
        List<HoaDonDTO> dshd, found;
        public HDban()
        {
            InitializeComponent();
            load();
        }

        void load()
        {
            loadData();
            dtaGVdanhsachHD.Columns["IdKhachhang"].Visible = false;
            dtaGVdanhsachHD.Columns["IdNhanvien"].Visible = false;
        }
        public void loadData()
        {
            dshd = qlhdBLL.readDB();
            dtaGVdanhsachHD.DataSource = dshd;
        }
    }
}
