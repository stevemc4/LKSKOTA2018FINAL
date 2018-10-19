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
    public partial class CreateOrder : Form
    {
        long total = 0;
        bool isExist = false;
        public CreateOrder()
        {
            InitializeComponent();
            foreach(DataSet1.MenuRow row in Database.Data.Menu)
            {
                ListViewItem item = new ListViewItem(row.name);
                item.SubItems.Add($"Rp. {row.price:0,0}");
                menu.Items.Add(item);
            }
            AutoCompleteStringCollection kancolle = new AutoCompleteStringCollection();
            foreach (DataSet1.MemberRow row in Database.Data.Member)
            {
                kancolle.Add(row.email);
            }
            members.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            members.AutoCompleteSource = AutoCompleteSource.CustomSource;
            members.AutoCompleteCustomSource = kancolle;
        }

        void ReloadCart()
        {
            cart.Items.Clear();
            total = 0;
            foreach(DataSet1.CartRow row in Database.Data.Cart)
            {
                ListViewItem item = new ListViewItem(row.MenuRow.name);
                item.SubItems.Add(row.qty.ToString());
                item.SubItems.Add($@"Rp. {row.price:0,0}");
                total += row.price;
                cart.Items.Add(item);
            }
            if (total > 0) totalText.Text = $"Rp. {total:0,0}";
            else totalText.Text = "Rp. 0";
        }

        private void add_Click(object sender, EventArgs e)
        {
            if(menu.SelectedIndices.Count > 0)
            {
                DataSet1.MenuRow menuRow = Database.Data.Menu[menu.SelectedIndices[0]];
                DataSet1.CartRow[] carts = Database.Data.Cart.Select($@"menuid={menuRow.menuid}") as DataSet1.CartRow[];
                if (carts.Count() == 0)
                    Database.Data.Cart.AddCartRow(menuRow, 1, menuRow.price);
                else
                {
                    carts[0].qty++;
                    carts[0].price += menuRow.price;
                }
                //Database.Commit();
                ReloadCart();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(cart.SelectedIndices.Count > 0)
            {
                DataSet1.CartRow item = Database.Data.Cart[cart.SelectedIndices[0]];
                if(item.qty > 1)
                {
                    item.qty--;
                    item.price -= item.MenuRow.price;
                }
                else
                {
                    item.Delete();
                }
                ReloadCart();
            }
        }

        private void deleteRow_Click(object sender, EventArgs e)
        {
            if (cart.SelectedIndices.Count > 0)
            {
                DataSet1.CartRow item = Database.Data.Cart[cart.SelectedIndices[0]];
                item.Delete();
                ReloadCart();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Database.Data.Cart.Clear();
            ReloadCart();
        }

        private void create_Click(object sender, EventArgs e)
        {
            if(Database.Data.Cart.Count > 0)
            {
                DateTime now = DateTime.Now;
                string id = $"{now.ToString("yyyyMMdd")}00";
                if(Database.Data.Order.Count > 0)
                {
                    DataSet1.OrderRow lastOrder = Database.Data.Order.Last();
                    if (lastOrder.orderid.Substring(0, 8) == id.Substring(0, 8))
                        id = lastOrder.orderid;
                }
                id = $"{now.ToString("yyyyMMdd")}{Program.GenerateCode(id, 8):00}";
                DataSet1.MemberRow[] check = Database.Data.Member.Select($@"email='{members.Text}'") as DataSet1.MemberRow[];
                if (check.Count() > 0 && isExist)
                {
                    Database.Data.Order.AddOrderRow(id, Program.currentEmployee, check[0], now, "!", "!", "!");
                    Database.Transact(Database.Data.Order);
                    Database.Commit();
                    foreach (DataSet1.CartRow row in Database.Data.Cart)
                    {
                        Database.Data.OrderDetail.AddOrderDetailRow(Database.Data.Order.FindByorderid(id), row.MenuRow, row.qty, (int)row.price, "Queued");
                    }
                    Database.Transact(Database.Data.OrderDetail);
                    Database.Commit();
                    MessageBox.Show("Pesanan berhasil dibuat!");
                    ((Cashier)Program.MainForm).LoadOrders();
                    Database.Data.Cart.Clear();
                    Database.Commit();
                    Close();
                }
                else MessageBox.Show("Terjadi Kesalahan!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void members_TextChanged(object sender, EventArgs e)
        {
            if(members.Text.Length > 0)
            {
                memberChecker.Visible = true;
                DataSet1.MemberRow[] check = Database.Data.Member.Select($@"email='{members.Text}'") as DataSet1.MemberRow[];
                if (check.Count() > 0)
                {
                    memberChecker.Text = check[0].name;
                    isExist = true;
                }
                else
                {
                    memberChecker.Text = "Member Tidak Ditemukan";
                    isExist = false;
                }
            }
            else
            {
                memberChecker.Visible = false;
                isExist = false;
            }
        }
    }
}
