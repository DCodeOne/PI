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
    public partial class FrmAdminFilmovi : Form
    {
        public FrmAdminFilmovi()
        {
            InitializeComponent();
        }
  
        /// <summary>
        /// Metoda koja osvježava popis filmova u dgvSviFilmovi objektu
        /// </summary>
        private void OsvjeziFilmove()
        {
            List<Film> listaFilmova = Film.DohvatiFilmove();
            dgvSviFilmovi.DataSource = listaFilmova;
        }

        /// <summary>
        /// Pri učitavanju forme poziva se metoda osvježi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdminFilmovi_Load(object sender, EventArgs e)
        {
             OsvjeziFilmove();
        }

        private void btnFilmoviOsvjezi_Click_1(object sender, EventArgs e)
        {
            OsvjeziFilmove();
        }      

        //objekt klase film ukog se sprema film za uređivanje
        Film detaljiFilm = new Film();
        int IdFilma = -1;
        /// <summary>
        /// Klikom na pojedinu ćeliju u dgvSviFilmovi odabiremo pojedini element
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSviFilmovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow red = this.dgvSviFilmovi.Rows[e.RowIndex];
                //postavljamo id filma u varijablu IdFilma
                IdFilma = int.Parse(red.Cells["IdFilma"].Value.ToString());
            }

        }

        /// <summary>
        /// Gumb osvježi osvježava spisak filmova koji se nalaze u dgvSviFilmovi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilmoviOsvjezi_Click(object sender, EventArgs e)
        {
            OsvjeziFilmove();
        }

        /// <summary>
        /// Gumb dodaj otvara formu za unos novih filmova
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilmoviDodaj_Click(object sender, EventArgs e)
        {
            FrmAdminFilmoviDodaj formaDodaj = new FrmAdminFilmoviDodaj();
            formaDodaj.ShowDialog(this);
        }

        /// <summary>
        /// Gumb dodaj otvara formu za ažuriranje postojećih
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFilmoviAzuriraj_Click(object sender, EventArgs e)
        {
            //ako je odabran artikl u dgvSviArtikli
            if (IdFilma > -1)
            {
                FrmAdminFilmoviDodaj formaAzuriraj = new FrmAdminFilmoviDodaj(IdFilma);
                formaAzuriraj.ShowDialog(this);
            }
        }
                       
    }
}
