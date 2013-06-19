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
            userName.Text = FrmPocetna.SpremnikPodataka.Zaposlenik;
            userRole.Text = FrmPocetna.SpremnikPodataka.Uloga;
        }

        private bool pomOdjava = false;

        private void FrmAdminArtikli_Load(object sender, EventArgs e)
        {
            OsvjeziArtikle();
        }


        private void btnOsvjeziArtikle_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            OsvjeziArtikle();
        }

       
        /// <summary>
        /// Prilikom klika na određenu ćeliju dohvaća se id pojedinog artikla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSviArtikli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pomOdjava = true;
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
            pomOdjava = true;
            FrmAdminArtikliDodaj formaDodaj = new FrmAdminArtikliDodaj();
            formaDodaj.Show();
            this.Close();
        }

        /// <summary>
        /// Na klik ažuriraj provjerava je li odabran artikl u cbSviArtikli i ako je odabran poziva formu za dodavanje/ažuriranje artikla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAzurirajArtikl_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            //ako je odabran artikl u dgvSviArtikli
            if (IdArtikla>-1)
            {
                detaljiArtikl = Artikl.DohvatiArtikl(IdArtikla);
                FrmAdminArtikliDodaj formaAzuriraj = new FrmAdminArtikliDodaj(detaljiArtikl);
                formaAzuriraj.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Molimo vas odaberite artikl!");
            }
        }
        
        private void btnArtikliPovratak_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            FrmAdmin admin = new FrmAdmin();
            admin.Show();
            this.Close();
        }

        /// <summary>
        /// funkcija za odjavu iz sustava, klikom na odjava se postavlja parametar na 1
        /// i prosljeđuje funkciji koja će ispisati poruku i pitati želi li se korisnik odjaviti
        /// u slučaju klika na yes, korisnik se odjavljuje i vraća na početnu stranicu (login)
        /// </summary>
        int odjavljivanje = 0;
        private void Odjava_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            odjavljivanje = 1;
            odjava();
        }
        private void odjava()
        {
            if (odjavljivanje == 1)
            {
                string message = "Želite li se odjaviti iz sustava?";
                string caption = "Odjava iz sustava";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(this, message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                    pomOdjava = true;
                    PI_projekt.Sucelja.FrmPocetna pocetna = new PI_projekt.Sucelja.FrmPocetna();
                    pocetna.Show();
                    this.Close();
                }
            }
        }

        private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!pomOdjava)
            {
                FrmAdmin admin = new FrmAdmin();
                admin.Show();
            }
        }   
    }
}
