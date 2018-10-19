using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS2._0
{
    public partial class Payment : Form
    {
        DataSet1.OrderRow order;
        public Payment(DataSet1.OrderRow order, long _bill)
        {
            InitializeComponent();
            this.order = order;
            name.Text = order.MemberRow.name;
            bill.Text = $"Rp. {_bill:0,0}";
        }

        private void method_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(method.Text == "Tunai")
            {
                bank.Enabled = false;
                cardNo.Enabled = false;
            }
            else if (method.Text == "Debit")
            {
                bank.Enabled = true;
                cardNo.Enabled = false;
            }
            else if (method.Text == "Kredit")
            {
                bank.Enabled = true;
                cardNo.Enabled = true;
            }
        }

        private void pay_Click(object sender, EventArgs e)
        {
            if(method.Text == "Tunai")
            {
                order.payment = "Tunai";
                Database.Transact(Database.Data.Order);
                Database.Commit();
                MessageBox.Show("Pembayaran Berhasil!");
                Close();
            }
            else if (method.Text == "Debit")
            {
                if (bank.Text != "")
                {
                    order.payment = "Debit";
                    order.bank = bank.Text;
                    Database.Transact(Database.Data.Order);
                    Database.Commit();
                    MessageBox.Show("Pembayaran Berhasil!");
                    Close();
                }
                else MessageBox.Show("Bank tidak boleh kosong!");
            }
            else if (method.Text == "Kredit")
            {
                if (bank.Text != "" && cardNo.Text != "")
                {
                    if (cardNo.Text.Length == 16)
                    {
                        if (new Regex("\\d").IsMatch(cardNo.Text))
                        {
                            order.payment = "Kredit";
                            order.bank = bank.Text;
                            order.cardNumber = cardNo.Text;
                            Database.Transact(Database.Data.Order);
                            Database.Commit();
                            MessageBox.Show("Pembayaran Berhasil!");
                            Close();
                        }
                        else MessageBox.Show("Nomor kartu tidak valid!");
                    }
                    else MessageBox.Show("Nomor Kartu harus 16 digit!");
                }
                else MessageBox.Show("Harap Isi Semua Kolom!");
            }
            ((Cashier)Program.MainForm).LoadOrders();
        }
    }
}
