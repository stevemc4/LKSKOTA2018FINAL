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
    public partial class Package : Form
    {
        bool safe = false;
        DataSet1.PackageRow currentRow;
        public Package(DataSet1.PackageRow row = null)
        {
            InitializeComponent();
            foreach(DataSet1.MenuRow menu in Database.Data.Menu)
            {
                ListViewItem item = new ListViewItem(menu.name);
                item.SubItems.Add($"Rp. {menu.price:0,0}");
                item.Tag = menu.menuid;
                menuList.Items.Add(item);
            }
            if(row != null)
            {
                currentRow = row;
                name.Text = currentRow.type;
                price.Value = currentRow.price;
            }
            else
            {
                currentRow = Database.Data.Package.NewPackageRow();
                currentRow.type = "temp";
                currentRow.price = 0;
                Database.Data.Package.AddPackageRow(currentRow);
            }
        }

        void LoadItems()
        {
            item.Items.Clear();
            foreach (DataSet1.PackageItemRow item in currentRow.GetPackageItemRows())
            {
                ListViewItem i = new ListViewItem(item.MenuRow.name);
                i.SubItems.Add(item.qty.ToString());
                this.item.Items.Add(i);
            }
        }

        private void addItem_Click(object sender, EventArgs e)
        {
            if(menuList.SelectedIndices.Count > 0)
            {
                DataSet1.MenuRow menu = Database.Data.Menu.FindBymenuid((int)menuList.SelectedItems[0].Tag);
                DataSet1.PackageItemRow[] items = Database.Data.PackageItem.Select($@"packageId = '{currentRow.packageid}' and menuId = '{menu.menuid}'") as DataSet1.PackageItemRow[];
                if (items.Count() > 0)
                {
                    items[0].qty++;
                }
                else Database.Data.PackageItem.AddPackageItemRow(currentRow, Database.Data.Menu.FindBymenuid((int)menuList.SelectedItems[0].Tag), 1);
                LoadItems();
            }
        }
    }
}
