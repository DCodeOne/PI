using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_projekt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sucelja.FrmPocetna());
            Application.Run(new Sucelja.FrmAdmin());
            Application.Run(new Sucelja.FrmProdavac());
            Application.Run(new Artikli.FrmArtikli());
            Application.Run(new Ulaznica.FrmUlaznica());
        }
    }
}
