﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnMenuAdd_Click(object sender, EventArgs e)
        {
            Menus menus = new Menus();
            menus.MenuName = txtMenuName.Text;
            menus.MenuPrice = (decimal)numericUpDown1.Value;
            Form2.menus.Add(menus);
            this.Hide();
        }
    }
}