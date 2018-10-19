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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet1.EmployeeRow[] data = Database.Data.Employee.Select($@"email='{email.Text}'") as DataSet1.EmployeeRow[];
            if (data.Count() > 0)
            {
                if (password.Text == data[0].password)
                {
                    Program.currentEmployee = data[0];
                    switch (data[0].position)
                    {
                        case "Admin":
                            new Form1(0).Show();
                            break;
                        case "Koki":
                            new Form1(1).Show();
                            break;
                        case "Kasir":
                            new Form1(2).Show();
                            break;
                    }
                    password.Text = "";
                    Hide();
                }
                else MessageBox.Show("Password Salah!");
            }
            else MessageBox.Show("Email tidak ditemukan!");
        }
    }
}
