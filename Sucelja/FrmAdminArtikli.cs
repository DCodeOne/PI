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
        public FrmAdminArtikli()
        {
            InitializeComponent();
            
        }
                
        //objekt klase artikl u kojeg se sprema artikl za uređivanje
        Artikl detaljiArtikl = null;
        int IdArtikla = -1;

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
        /// Metoda koja osvježava popis artikala u dgvSviArtikli objektu
        /// </summary>
        private void OsvjeziArtikle()
        {
            List<Artikl> listaArtikala = Artikl.DohvatiArtikle();
            dgvSviArtikli.DataSource = listaArtikala;
        }
           
        /// <summary>
        /// Učitavanjem forme osvježava se spisak artikala koji se nalaze u dgvSviArtikli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param        
        private void FrmAdminArtikli_Load(object sender, EventArgs e)
        {
            OsvjeziArtikle();
        }

        /// <summary>
        /// Gumb osvježava spisak artikala koji se nalaze u dgvSviArtikli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param 
        private void btnOsvjeziArtikle_Click(object sender, EventArgs e)
        {
           OsvjeziArtikle();
        }

        /// <summary>
        /// Klikom na gumb dodaj otvara se forma za dodavanje novog artikla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodajArtikl_Click(object sender, EventArgs e)
        {
            FrmAdminArtikliDodaj formaDodaj = new FrmAdminArtikliDodaj();
            formaDodaj.ShowDialog(this);
        }

        /// <summary>
        /// Na klik ažuriraj provjerava je li odabran artikl u dgvSviArtikli i ako je odabran poziva formu za dodavanje/ažuriranje artikla
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
                formaAzuriraj.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Molimo vas odaberite artikl!");
            }
        }        
    }
}
