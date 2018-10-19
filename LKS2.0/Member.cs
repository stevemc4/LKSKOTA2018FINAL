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
    public partial class Member : Form
    {
        bool safe = false;
        DataSet1.MemberRow currentRow;
        public Member(DataSet1.MemberRow row = null)
        {
            InitializeComponent();
            if(row != null)
            {
                name.Text = row.name;
                phone.Text = row.handphone;
                email.Text = row.email;
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
                currentRow.email = email.Text;
                currentRow.handphone = phone.Text;
            }
            else
            {
                string id = "MEM00001";
                if (Database.Data.Member.Count > 0)
                    id = Database.Data.Member.Last().memberid;
                id = $"MEM{Program.GenerateCode(id, 3):00000}";
                Database.Data.Member.AddMemberRow(id, name.Text, email.Text, phone.Text, DateTime.Now);
            }
            Database.Transact(Database.Data.Member);
            Database.Commit();
            ((Master)Program.MainForm).Refresh();
            Close();
        }
    }
}
