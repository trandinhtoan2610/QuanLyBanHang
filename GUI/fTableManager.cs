using BLL;
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
    public partial class fTableManager : Form
    {
        
        private bool isCollapsed = true;
        private bool isCollapsed2 = true ;

        public fTableManager()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void InitializeControls()
        {
            nhaphang1.DiDenGioHangNhaphang += Nhaphang1_DiDenGioHangNhaphang;
            fTimkiem1.DiDenBanhang += sukiennuttimkiem;
            banhang1.DiDenGioHang += sukiennutgiohang;
        }

        private void Nhaphang1_DiDenGioHangNhaphang(object sender, EventArgs e)
        {
            giohangnhaphang.BringToFront();
            GioHangNhapHang.dgv_giohang_nhaphang.DataSource = null;
            GioHangNhapHang.dgv_giohang_nhaphang.DataSource = Nhaphang.listCart;
        }

        private void sukiennutgiohang(object sender, EventArgs e)

        {
            giohang.BringToFront();
            giohang.dataGridView2.DataSource = null;
            giohang.dataGridView2.DataSource = Banhang.listCart;
                
        }
        
        private void sukiennuttimkiem(object sender, EventArgs e)
        {
            banhang1.BringToFront();
        }

        private void btnDanhmuc_Click(object sender, EventArgs e)
        {
            timerDropDown.Start();
        }

        private void timerDropDown_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pnDropDown.Height += 20;
                if(pnDropDown.Size == pnDropDown.MaximumSize)
                {
                    timerDropDown.Stop();
                    isCollapsed = false;  
                }
            }
            else
            {
                pnDropDown.Height -= 20;
                if (pnDropDown.Size == pnDropDown.MinimumSize)
                {
                    timerDropDown.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnQuanlyhoadon_Click(object sender, EventArgs e)
        {
            timerDropDown2.Start();
        }
        private void timerDropDown2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed2)
            {
                pnQuanlyhoadon.Height += 20;
                if (pnQuanlyhoadon.Size == pnQuanlyhoadon.MaximumSize)
                {
                    timerDropDown2.Stop();
                    isCollapsed2 = false;
                }
            }
            else
            {
                pnQuanlyhoadon.Height -= 20;
                if (pnQuanlyhoadon.Size == pnQuanlyhoadon.MinimumSize)
                {
                    timerDropDown2.Stop();
                    isCollapsed2 = true;
                }
            }
        }

       


        private void btnLoaisp_Click(object sender, EventArgs e)
        {
            loaiSP1.BringToFront();
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            ncc1.BringToFront();
        }

        private void btnKhachhang_Click(object sender, EventArgs e)
        {
            khachhang1.BringToFront();
        }

        private void btnSp_Click(object sender, EventArgs e)
        {
            sanpham1.BringToFront();
            sanpham1.loadcbb();
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            nhanvien1.BringToFront();
        }


        private void fTableManager_Load(object sender, EventArgs e)
        {

        }

        private void btnNhaphang_Click(object sender, EventArgs e)
        {
            nhaphang1.BringToFront();
            nhaphang1.loadData();
        }

        private void btnBanhang_Click(object sender, EventArgs e)
        {
            fTimkiem1.BringToFront();
        }

        private void btnHoadonban_Click(object sender, EventArgs e)
        {
            hDban1.BringToFront();
        }

        private void btnHoadonnhap_Click(object sender, EventArgs e)
        {
            hDnhap1.BringToFront();
            hDnhap1.loadData();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            thongke1.BringToFront();
        }

        private void btnPhanquyen_Click(object sender, EventArgs e)
        {
            phanquyen1.BringToFront();
        }

        
    }
}
