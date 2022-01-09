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
    public partial class FormOrdersDetail : Form
    {
        public FormOrdersDetail()
        {
            InitializeComponent();
        }
        decimal totalCiro = 0;
        decimal ordersQuantity = 0;
        decimal totalMaterialsPrice = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (var order in FormCreateOrders.OrderList)
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
            lblTotalOrderCount.Text = FormCreateOrders.OrderList.Count.ToString();
            lblTotalCiro.Text = totalCiro.ToString("C2");
        }
    }
}
