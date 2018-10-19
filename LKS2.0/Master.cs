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
    public enum State {Employee, Menu, Member, Package};
    public partial class Master : Form
    {
        public State state = State.Employee;
        public Master()
        {
            InitializeComponent();
            SetupList(new string[] { "ID Karyawan", "Nama", "Email", "Nomor Telepon", "Posisi" });
            FormClosing += Master_FormClosing;
        }

        private void Master_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        public void SetupList(string[] headers)
        {
            mainlist.Columns.Clear();
            foreach(string s in headers)
            {
                ColumnHeader h = new ColumnHeader();
                h.Text = s;
                h.Width = 120;
                mainlist.Columns.Add(h);
            }
            Refresh();
        }
        public new void Refresh()
        {
            mainlist.Items.Clear();
            switch (state){
                case State.Employee: 
                    foreach(DataSet1.EmployeeRow row in Database.Data.Employee)
                    {
                        ListViewItem item = new ListViewItem(row.employeeid);
                        item.SubItems.Add(row.name);
                        item.SubItems.Add(row.email);
                        item.SubItems.Add(row.handphone);
                        item.SubItems.Add(row.position);
                        mainlist.Items.Add(item);
                    }
                    break;
                case State.Member:
                    foreach(DataSet1.MemberRow row in Database.Data.Member)
                    {
                        ListViewItem item = new ListViewItem(row.memberid);
                        item.SubItems.Add(row.name);
                        item.SubItems.Add(row.email);
                        item.SubItems.Add(row.joindate.ToString("dd MMM yyyy"));
                        mainlist.Items.Add(item);
                    }
                    break;
                case State.Menu:
                    foreach(DataSet1.MenuRow row in Database.Data.Menu)
                    {
                        ListViewItem item = new ListViewItem(row.name);
                        item.SubItems.Add($"Rp. {row.price:0,0}");
                        mainlist.Items.Add(item);
                    }
                    break;
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            switch(state)
            {
                case State.Menu: new Menu().Show(); break;
                case State.Employee: new Employee().Show(); break;
                case State.Member: new Member().Show(); break;
                case State.Package: new Package().Show(); break;
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if(mainlist.SelectedIndices.Count > 0)
            {
                int index = mainlist.SelectedIndices[0];
                switch (state)
                {
                    case State.Menu: new Menu(Database.Data.Menu[index]).Show(); break;
                    case State.Employee: new Employee(Database.Data.Employee[index]).Show(); break;
                    case State.Member: new Member(Database.Data.Member[index]).Show(); break;
                    case State.Package: new Package().Show(); break;
                }
            }
        }
    }
}
