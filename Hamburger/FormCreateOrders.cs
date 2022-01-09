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
    public partial class FormCreateOrders : Form
    {
        public FormCreateOrders()
        {
            InitializeComponent();
        }
        public static List<Menus> menus = new List<Menus>() {
            new Menus()
            {
                MenuName = "Steakhouse",
            MenuPrice = 10.0m
            },
            new Menus()
            {
                MenuName = "King Chicken",
            MenuPrice = 20.0m
            }
         };
        public static List<Orders> OrderList = new List<Orders>();
        public static List<Materials> materials = new List<Materials>()
        {
            new Materials()
            {
                MaterialName = "Ketçap",
                MaterialPrice = 1.5m
            },
            new Materials()
            {
                MaterialName = "Mayonez",
                MaterialPrice = 1.6m
            },
            new Materials()
            {
                MaterialName = "Sos",
                MaterialPrice = 1.2m
            }
        };
        public static List<Orders> currentOrders = new List<Orders>();
        decimal totalPrice = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (var item in currentOrders)
            {
                listBox1.Items.Add(item.ToString());
                totalPrice += item.TotalPrice;
            }
            lblTotalPrice.Text = totalPrice.ToString("C2");
            #region Menu

            cmbMenu.DisplayMember = "MenuName";
            cmbMenu.ValueMember = "MenuPrice";
            foreach (var item in menus)
            {
                cmbMenu.Items.Add(item);
            }
            cmbMenu.SelectedIndex = 0;
            #endregion

            #region MenuSize
            foreach (var item in Enum.GetValues(typeof(MenuSize)))
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Text = item.ToString();
                radioButton.Tag = item;
                if (item.ToString() == "Kucuk")
                {
                    radioButton.Checked = true;
                }
                flowLayoutPanel2.Controls.Add(radioButton);
            }
            #endregion

            #region Material


            foreach (var item in materials)
            {
                CheckBox cb = new CheckBox();
                cb.Text = item.MaterialName;
                cb.Name = item.MaterialPrice.ToString();
                cb.Tag = item;
                flowLayoutPanel1.Controls.Add(cb);
            }

            #endregion
            if (listBox1.Items.Count == 0)
            {
                btnOrderComplete.Visible = false;
            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            btnOrderComplete.Visible = true;
            Orders orders = new Orders();
            orders.Menus = (Menus)cmbMenu.SelectedItem;

            foreach (RadioButton item in flowLayoutPanel2.Controls)
            {
                if (item.Checked)
                {
                    orders.Size = (MenuSize)item.Tag;
                }
            }

            orders.Materials = new List<Materials>();
            foreach (CheckBox item in flowLayoutPanel1.Controls)
            {
                if (item.Checked)
                {
                    orders.Materials.Add((Materials)item.Tag);
                }
            }

            orders.Quantity = (int)numericUpDown1.Value;
            orders.Calculate();
            totalPrice += orders.TotalPrice;
            listBox1.Items.Add(orders.ToString());
            lblTotalPrice.Text = totalPrice.ToString("C2");
            currentOrders.Add(orders);
            //Orders.Add(orders);
            FormClear();
        }
        private void btnOrderComplete_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                var result = MessageBox.Show(@"Siparişi Onaylıyor musunuz?", @"Sipariş Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result.Equals(DialogResult.Yes))
                {
                    foreach (var order in currentOrders)
                    {
                        OrderList.Add(order);
                    }
                    totalPrice = 0;
                    lblTotalPrice.Text = totalPrice.ToString("C2");
                    currentOrders.Clear();
                    listBox1.Items.Clear();
                    FormClear();
                    MessageBox.Show("Siparişiniz oluşturuldu.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Sipariş Seçimi yapınız!");
            }
        }
        void FormClear()
        {
            cmbMenu.SelectedIndex = 0;
            foreach (RadioButton item in flowLayoutPanel2.Controls)
            {
                if (item.Text == "Kucuk")
                {
                    item.Checked = true;
                }
            }
            foreach (CheckBox item in flowLayoutPanel1.Controls)
            {
                if (item.Checked)
                {
                    item.Checked = false;
                }
            }
            numericUpDown1.Value = 1;
        }
    }
}
