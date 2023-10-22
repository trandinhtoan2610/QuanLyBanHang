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
        private bool isCollapsed;
        private bool isCollapsed2;
        public fTableManager()
        {
            InitializeComponent();
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

        private void btnSp_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            nhanvien1.BringToFront();
        }
    }
}
