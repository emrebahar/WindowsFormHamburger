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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        decimal totalCiro = 0;
        decimal ordersQuantity = 0;
        decimal totalMaterialsPrice = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (var order in Form2.Orders)
            {
                listBox1.Items.Add(order);
                ordersQuantity += order.Quantity;
                totalCiro += order.TotalPrice;
                foreach (var extra in order.Materials)
                {
                    totalMaterialsPrice += extra.MaterialPrice;
                }
            }
            lblMaterial.Text = totalMaterialsPrice.ToString("C2");
            lblOrderQuantity.Text = ordersQuantity.ToString();
            lblTotalOrderCount.Text = Form2.Orders.Count.ToString();
            lblTotalCiro.Text = totalCiro.ToString("C2");
        }
    }
}
