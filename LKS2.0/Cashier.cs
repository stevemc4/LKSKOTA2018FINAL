using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS2._0
{
    public partial class Cashier : Form
    {
        long total = 0;
        public Cashier()
        {
            InitializeComponent();
            LoadOrders();
        }

        public void LoadOrders()
        {
            orders.Items.Clear();
            foreach (DataSet1.OrderRow row in Database.Data.Order)
            {
                Console.WriteLine(row.orderid);
                if (row.payment == "!")
                {
                    orders.Items.Add(row.orderid);
                }
            }
        }

        private void newOrder_Click(object sender, EventArgs e)
        {
            new CreateOrder().Show();
        }

        private void orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            total = 0;
            if (orders.SelectedIndex != -1)
            {
                cart.Items.Clear();
                DataSet1.OrderDetailRow[] items = Database.Data.OrderDetail.Select($@"orderid='{orders.SelectedItems[0].ToString()}'") as DataSet1.OrderDetailRow[];
                foreach(DataSet1.OrderDetailRow row in items)
                {
                    ListViewItem item = new ListViewItem(row.MenuRow.name);
                    item.SubItems.Add(row.qty.ToString());
                    item.SubItems.Add($"Rp. {row.price:0,0}");
                    item.SubItems.Add(row.message);
                    total += row.price;
                    cart.Items.Add(item);
                }
                totalText.Text = $"Rp. {total:0,0}";
                name.Text = "Nama Pemesan: " + Database.Data.Order.FindByorderid(orders.SelectedItem.ToString()).MemberRow.name;
            }
            else
            {
                cart.Items.Clear();
                name.Text = "Nama Pemesan: -";
                totalText.Text = "Rp. 0";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadOrders();
        }

        private void pay_Click(object sender, EventArgs e)
        {
            if(orders.SelectedIndices.Count > 0)
            {
                new Payment(Database.Data.Order.FindByorderid(orders.SelectedItem.ToString()), total).Show();
            }
        }
    }
}
