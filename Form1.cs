using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; //Para função Process.Start

namespace MudaIP
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMudaip_Load(object sender, EventArgs e)
        {

        }

        private void CbGM_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGM.Checked)
            {
                RbGEM.Visible = true;
                RbOnix.Visible = true;
            }
            else
            {
                RbGEM.Visible = false;
                RbOnix.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVW.Checked)
            {
                RbMQB.Visible = true;
                RbUP.Visible = true;
            }
            else
            {
                RbMQB.Visible = false;
                RbUP.Visible = false;
            }
        }

        private void chkNissan_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNissan.Checked)
            {
                RbVersa.Visible = true;
                RbFrontier.Visible = true;
            }
            else
            {
                RbVersa.Visible = false;
                RbFrontier.Visible = false;
            }
        }

        private void RbGEM_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
