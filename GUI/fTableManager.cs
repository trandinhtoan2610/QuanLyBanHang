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

    }
}
