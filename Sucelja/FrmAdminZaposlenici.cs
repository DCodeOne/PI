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
    public partial class FrmAdminZaposlenici : Form
    {
        public FrmAdminZaposlenici()
        {
            InitializeComponent();
        }

        //objekt klase zaposlenik u kojeg se sprema zaposlenik za uređivanje
        //Zaposlenici detaljiZaposlenik = null;
        long oib = -1;

        /// <summary>
        /// Prilikom klika na odredenu celiju dohvaca se OIB pojedinog zaposlenika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void dgvSviZaposlenici_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow red = this.dgvSviZaposlenici.Rows[e.RowIndex];
                //postavljamo OIB zaposlenika u varijablu OIB
                oib = long.Parse(red.Cells["oib"].Value.ToString());
            }
        }


        /// <summary>
        /// Metoda koja osvježava popis zaposlenika u dgvSviZaposlenici objektu
        /// </summary>
        /// 
        private void OsvjeziZaposlenike()
        {
            List<Zaposlenici> listaZaposlenika = Zaposlenici.DohvatiZaposlenike();
            dgvSviZaposlenici.DataSource = listaZaposlenika;
        }


        /// <summary>
        /// Pri učitavanju forme poziva se metoda osvježi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdminZaposlenici_Load(object sender, EventArgs e)
        {
            OsvjeziZaposlenike();
        }

        /// <summary>
        /// Gumb osvježava spisak zaposlenika koji se nalaze u dgvSviZaposlenici
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param
        private void btnZaposleniciOsvjezi_Click(object sender, EventArgs e)
        {
            OsvjeziZaposlenike();
        }

       
        /// <summary>
        /// Klikom na gumb dodaj otvara se forma za dodavanje novog artikla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZaposleniciDodaj_Click(object sender, EventArgs e)
        {
            FrmAdminZaposleniciDodaj formaDodaj = new FrmAdminZaposleniciDodaj();
            formaDodaj.ShowDialog(this);
        }

        /// <summary>
        /// Na klik ažuriraj provjerava je li odabran zaposlenik u dgvSviZaposlenici i ako je odabran poziva formu za dodavanje/ažuriranje zaposlenika
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZaposleniciAzuriraj_Click(object sender, EventArgs e)
        {
            //ako je odabran zaposlenik u dgvSviZaposlenici

            //MessageBox.Show(oib.ToString());
            if (oib > -1)
            {
                FrmAdminZaposleniciDodaj formaAzuriraj = new FrmAdminZaposleniciDodaj(oib);
                formaAzuriraj.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Molimo vas odaberite zaposlenika!");
            }
        } 
    }
}
