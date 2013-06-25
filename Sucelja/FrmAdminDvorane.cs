using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_projekt.Sucelja
{
    public partial class FrmAdminDvorane : Form
    {
        //objekt klase dvorana u kojeg se sprema dvorana za uređivanje
        Dvorana detaljiDvorana = null;
        int BrojDvorane = -1;

        /// <summary>
        /// Metoda koja osvježava popis dvorana u dgvSveDvorane objektu
        /// </summary>
        private void OsvjeziDvorane()
        {
            List<Dvorana> listaDvorana = Dvorana.DohvatiDvorane();
            dgvSveDvorane.DataSource = listaDvorana;
        }

        /// <summary>
        /// Inicijalizacija
        /// </summary>
        public FrmAdminDvorane()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Prilikom pokretanja forme poziva se metoda koja osvježava spisak svih dvorana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdminDvorane_Load(object sender, EventArgs e)
        {
            OsvjeziDvorane();
        }

        /// <summary>
        /// Gumb OSvježi osvježava spisak svih dvorana u dgvSveDvorane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDvoraneOsvjezi_Click(object sender, EventArgs e)
        {
            OsvjeziDvorane();
        }

        /// <summary>
        /// Prilikom klika na odredenu ćeliju dohvaća se id pojedine dvorane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSveDvorane_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow red = this.dgvSveDvorane.Rows[e.RowIndex];
                //postavljamo broj dvorane artikla u varijablu BrojDvorane
                BrojDvorane = int.Parse(red.Cells["BrojDvorane"].Value.ToString());
            }
        }
              
        /// <summary>
        /// Klikom na gumb dodaj otvara se forma za dodavanje nove dvorane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDvoraneDodaj_Click(object sender, EventArgs e)
        {
            FrmAdminDvoraneDodaj formaDodaj = new FrmAdminDvoraneDodaj();
            formaDodaj.ShowDialog(this);
        }

        /// <summary>
        /// Na klik ažuriraj provjerava je li odabrana dvorana u cbSveDvorane i ako je odabrana poziva formu za dodavanje/ažuriranje dvorana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDvoraneAzuriraj_Click(object sender, EventArgs e)
        {
            //ako je odabrana dvorana u dgvSveDvorane
            if (BrojDvorane > -1)
            {
                detaljiDvorana = Dvorana.DohvatiDvoranu(BrojDvorane);
                FrmAdminDvoraneDodaj formaAzuriraj = new FrmAdminDvoraneDodaj(detaljiDvorana);
                formaAzuriraj.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Molimo vas odaberite dvoranu!");
            }
        }
    }
}
