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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnMaterialsAdd_Click(object sender, EventArgs e)
        {
            Materials materials = new Materials();
            materials.MaterialName = txtMaterialsName.Text;
            materials.MaterialPrice = (decimal)numericUpDown1.Value;
            Form2.materials.Add(materials);
            this.Hide();
        }
    }
}
