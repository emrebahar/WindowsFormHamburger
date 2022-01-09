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
    public partial class FormCreateMenu : Form
    {
        public FormCreateMenu()
        {
            InitializeComponent();
        }

        private void btnMenuAdd_Click(object sender, EventArgs e)
        {
            if (txtMenuName.Text != string.Empty)
            {
                var result = MessageBox.Show(@"Yeni Menü Eklensin mi?", @"İşlem Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result.Equals(DialogResult.Yes))
                {
                    Menus menus = new Menus();
                    menus.MenuName = txtMenuName.Text;
                    menus.MenuPrice = (decimal)numericUpDown1.Value;
                    FormCreateOrders.menus.Add(menus);
                    this.Hide();
                    MessageBox.Show("Menüye '" + menus.MenuName + "' Eklendi");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Menü Adı Yazınız!");
            }
        }
    }
}
