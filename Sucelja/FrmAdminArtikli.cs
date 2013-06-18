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
    public partial class FrmAdminArtikli : Form
    {
        //objekt klase artikl u kojeg se sprema artikl za uređivanje
        Artikl detaljiArtikl = null;
        int IdArtikla = -1;

        /// <summary>
        /// Metoda koja osvježava popis artikala u dgvSviArtikli objektu
        /// </summary>
        private void OsvjeziArtikle()
        {
            List<Artikl> listaArtikala = Artikl.DohvatiArtikle();
            dgvSviArtikli.DataSource = listaArtikala;
        }


        public FrmAdminArtikli()
        {
            InitializeComponent();
        }


        private void FrmAdminArtikli_Load(object sender, EventArgs e)
        {
            OsvjeziArtikle();
        }


        private void btnOsvjeziArtikle_Click(object sender, EventArgs e)
        {
            OsvjeziArtikle();
        }

       

        /// <summary>
        /// Prilikom klika na određenu ćeliju dohvaća se id pojedinog artikla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSviArtikli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow red = this.dgvSviArtikli.Rows[e.RowIndex];
                //postavljamo id artikla u varijablu IdArtikl
                IdArtikla = int.Parse(red.Cells["IdArtikla"].Value.ToString());
            
            }
        }

        /// <summary>
        /// Klikom na gumb dodaj otvara se forma za dodavanje novog artikla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            FrmAdminArtikliDodaj formaDodaj = new FrmAdminArtikliDodaj();
            formaDodaj.Show();
        }

        /// <summary>
        /// Na klik ažuriraj provjerava je li odabran artikl u cbSviArtikli i ako je odabran poziva formu za dodavanje/ažuriranje artikla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAzurirajArtikl_Click(object sender, EventArgs e)
        {
            //ako je odabran artikl u dgvSviArtikli
            if (IdArtikla>-1)
            {
                detaljiArtikl = Artikl.DohvatiArtikl(IdArtikla);
                FrmAdminArtikliDodaj formaAzuriraj = new FrmAdminArtikliDodaj(detaljiArtikl);
                formaAzuriraj.Show();
            }
            else
            {
                MessageBox.Show("Molimo vas odaberite artikl!");
            }
        }

        private void dgvSviArtikli_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
