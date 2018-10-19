using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS2._0
{
    public class CommonDialog : Form
    {
        Master referrer;
        protected bool safe = false;
        public CommonDialog(Master _ref)
        {
            referrer = _ref;
        }

        protected new void Close()
        {
            if(safe)
            {
                referrer.Refresh();
                base.Close();
            }
            else
            {
                if(MessageBox.Show("Apakah Anda ingin membatalkan perubahan?", "Peringatan", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    base.Close();
                    referrer.Refresh();
                }
            }
        }
    }
}
