using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKS2._0
{
    static class Program
    {
        public static Form MainForm;
        public static Login StartingForm;
        public static DataSet1.EmployeeRow currentEmployee;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Database.Init();
            Server.Init();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartingForm = new Login();
            Application.Run(StartingForm);
        }

        public static Image LoadImage(string path)
        {
            Image i;
            using (StreamReader reader = new StreamReader(path))
            {
                i = new Bitmap(reader.BaseStream);
                reader.Close();
                reader.Dispose();
            }
            return i;
        }
        public static int GenerateCode(string previousCode, int offset)
        {
            int i = int.Parse(previousCode.Substring(offset));
            return ++i;
        }
    }
}
