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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void siparişOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frmShow(frm);
        }

        private void siparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frmShow(frm);
        }

        private void menuBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frmShow(frm);
        }

        private void extraMalzemeBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
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
