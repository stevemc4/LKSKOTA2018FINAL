using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS2._0
{
    public partial class Menu : Form
    {
        OpenFileDialog dlg = new OpenFileDialog();
        DataSet1.MenuRow currentRow;
        bool isImageChanged = false;
        public Menu(DataSet1.MenuRow row = null)
        {
            InitializeComponent();
            if(row != null)
            {
                name.Text = row.name;
                price.Value = row.price;
                imgUrl.Text = row.photo;
                if (row.photo != "default.png")
                {
                    viewer.Image = Program.LoadImage(Environment.CurrentDirectory + "\\Images\\" + row.photo);
                }
                currentRow = row;
            }
            dlg.Title = "Cari Gambar...";
            dlg.Filter = "Gambar|*.jpg;*.jpeg;*.png";
            dlg.FileOk += Dlg_FileOk;
        }

        private void Dlg_FileOk(object sender, CancelEventArgs e)
        {
            viewer.Image = Program.LoadImage(dlg.FileName);
            imgUrl.Text = dlg.SafeFileName;
            isImageChanged = true;
        }

        private void find_Click(object sender, EventArgs e)
        {
            dlg.ShowDialog();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if(currentRow != null)
            {
                currentRow.name = name.Text;
                currentRow.price = (int)price.Value;
                if(isImageChanged)
                {
                    currentRow.photo = dlg.SafeFileName;
                    File.Copy(dlg.FileName, Environment.CurrentDirectory + "\\Images\\" + dlg.SafeFileName, true);
                }
            }
            else
            {
                string filename = "default.png";
                if (isImageChanged)
                {
                    filename = dlg.SafeFileName;
                    File.Copy(dlg.FileName, Environment.CurrentDirectory + "\\Images\\" + dlg.SafeFileName, true);
                }
                Database.Data.Menu.AddMenuRow(name.Text, (int)price.Value, filename);
            }
            Database.Transact(Database.Data.Menu);
            Database.Commit();
            ((Master)Program.MainForm).Refresh();
            Close();
        }
    }
}
