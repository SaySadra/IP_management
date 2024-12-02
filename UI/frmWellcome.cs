using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmWellcome : Form
    {
        public frmWellcome()
        {
            InitializeComponent();
        }


        private void timerWellcome_Tick(object sender, EventArgs e)
        {
            prgbWellcome.Value++;
            if (prgbWellcome.Value == 100)
            {
                timerWellcome.Enabled = false;
                this.Hide();
                frmLogin frm = new frmLogin();
                frm.ShowDialog();
            }
        }
    }
}
