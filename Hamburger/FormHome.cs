using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hamburger
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }
        
        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateOrders frm = new FormCreateOrders();
            frmShow(frm);
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOrdersDetail frm = new FormOrdersDetail();
            frmShow(frm);
        }

        private void menuBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateMenu frm = new FormCreateMenu();
            frmShow(frm);
        }

        private void extraMalzemeBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCreateMaterial frm = new FormCreateMaterial();
            frmShow(frm);
        }

        void frmShow(Form frm)
        {
            
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
            }
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
