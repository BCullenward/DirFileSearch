using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieSearch
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var dbPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MovieSearch\";
            if (!System.IO.Directory.Exists(dbPath))
            {
                System.IO.Directory.CreateDirectory(dbPath);
            }

            MediaContext db = new MediaContext();
            db.Database.EnsureCreated();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
