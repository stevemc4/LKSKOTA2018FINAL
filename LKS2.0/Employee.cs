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
    public partial class Employee : Form
    {
        bool safe = false;
        DataSet1.EmployeeRow currentRow;
        public Employee(DataSet1.EmployeeRow row = null)
        {
            InitializeComponent();
            if (row != null)
            {
                name.Text = row.name;
                email.Text = row.email;
                phone.Text = row.handphone;
                position.Text = row.position;
                currentRow = row;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if(currentRow != null)
            {
                currentRow.name = name.Text;
                currentRow.handphone = phone.Text;
                currentRow.email = email.Text;
                currentRow.position = position.Text;
            }
            else
            {
                string code = "E00001";
                if (Database.Data.Employee.Count > 0)
                    code = Database.Data.Employee.Last().employeeid;
                code = $"E{Program.GenerateCode(code, 1):00000}";
                Database.Data.Employee.AddEmployeeRow(code, name.Text, email.Text, "newpass", phone.Text, position.Text);
            }
            Database.Transact(Database.Data.Employee);
            Database.Commit();
            ((Master)Program.MainForm).Refresh();
            Close();
        }
    }
}
