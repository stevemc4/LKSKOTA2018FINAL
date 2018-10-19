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
    public partial class ChangePass : Form
    {
        public ChangePass()
        {
            InitializeComponent();
        }

        private void newPass_TextChanged(object sender, EventArgs e)
        {
            Regex tester = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.{8,})");
        }
    }
}
