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
    public partial class Chef : Form
    {
        public Chef()
        {
            InitializeComponent();
            foreach(DataSet1.OrderRow row in Database.Data.Order)
            {
                if(row.payment != "!" && row.date.ToString("yyyyMMdd") == DateTime.Now.ToString("yyyyMMdd"))
                {
                    orders.Items.Add(row.orderid);
                }
            }
            Shown += Chef_Shown;
        }

        private void Chef_Shown(object sender, EventArgs e)
        {
        }

        private void orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDetail();
        }

        void LoadDetail()
        {
            if (orders.SelectedIndices.Count > 0)
            {
                detail.Items.Clear();
                DataSet1.OrderDetailRow[] details = Database.Data.OrderDetail.Select($"orderid='{orders.SelectedItem.ToString()}'") as DataSet1.OrderDetailRow[];
                foreach (DataSet1.OrderDetailRow row in details)
                {
                    ListViewItem item = new ListViewItem(row.MenuRow.name);
                    item.Tag = row.detailid;
                    item.SubItems.Add(row.qty.ToString());
                    item.SubItems.Add(row.message);
                    detail.Items.Add(item);
                }
            }
        }

        private void detail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (detail.SelectedIndices.Count > 0)
            {
                status.Enabled = true;
                status.Text = detail.SelectedItems[0].SubItems[2].Text;
            }
            else status.Enabled = false;
        }

        private void apply_Click(object sender, EventArgs e)
        {
            DataSet1.OrderDetailRow current = Database.Data.OrderDetail.FindBydetailid(int.Parse(detail.SelectedItems[0].Tag.ToString()));
            current.message = status.Text;
            Database.Transact(Database.Data.OrderDetail);
            Database.Commit();
            LoadDetail();
        }
    }
}
