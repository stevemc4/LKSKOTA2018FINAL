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
    public partial class Form1 : Form
    {
        Master m = new Master();
        Cashier cash = new Cashier();
        Chef chef = new Chef();
        bool safe = false;
        public Form1(int code)
        {
            InitializeComponent();
            if (code == 0) {
                SetupForm(m).Show();
                Program.MainForm = m;
            }
            else
            {
                employee.Visible = false;
                member.Visible = false;
                menu.Visible = false;
                package.Visible = false;
                report.Visible = false;
                if (code == 1)
                {
                    SetupForm(chef).Show();
                    Program.MainForm = chef;
                }
                else if (code == 2)
                {
                    Program.MainForm = cash;
                    SetupForm(cash).Show();
                }
            }
            greeter.Text += Program.currentEmployee.name;
            FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!safe) Application.Exit();
        }

        private Form SetupForm(Form form)
        {
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            return form;
        }

        private void employee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m.state = State.Employee;
            m.SetupList(new string[] { "ID Karyawan", "Nama", "Email", "Nomor Telepon", "Posisi" });
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m.state = State.Menu;
            m.SetupList(new string[] { "Nama", "Harga" });
        }

        private void member_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m.state = State.Member;
            m.SetupList(new string[] { "ID Member", "Nama", "Email", "Tanggal Bergabung" });
        }

        private void package_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            m.state = State.Package;
            m.SetupList(new string[] { "Nama", "Harga", "Isi" });
        }

        private void logout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            safe = true;
            Close();
            Program.currentEmployee = null;
            Program.StartingForm.Show();
        }
    }
}
