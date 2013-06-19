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
    public partial class FrmAdminDvoraneDodaj : Form
    {
        private bool pomOdjava = false;
        private Dvorana dvoranaAzuriraj = null;

        /// <summary>
        /// Konstruktor koji se poziva u slucaju dodavanja nove dvorane
        /// </summary>
        public FrmAdminDvoraneDodaj()
        {
            InitializeComponent();
            userName.Text = FrmPocetna.SpremnikPodataka.Zaposlenik;
            userRole.Text = FrmPocetna.SpremnikPodataka.Uloga;
        }

        /// <summary>
        /// Konstruktor koji se poziva prilikom ažuriranja postojeeg artikla
        /// </summary>
        /// <param name="odabraniArtikl"></param>
        public FrmAdminDvoraneDodaj(Dvorana odabranaDvorana)
        {
            InitializeComponent();
            dvoranaAzuriraj = odabranaDvorana;
        }

        /// <summary>
        /// Rukuje dogadajem pokretanja forme, ukoliko se radi o ažuriranju dvorane tada formu popunjava sa postojecim podacima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdminDvoraneDodaj_Load(object sender, EventArgs e)
        {
            if (dvoranaAzuriraj != null)
            {
                txtDodajDvoranuNaziv.Text = dvoranaAzuriraj.Naziv.ToString();
                txtDodajDvoranuBrSjedala.Text = dvoranaAzuriraj.BrojSjedala.ToString();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            FrmAdminDvorane adminDvorane = new FrmAdminDvorane();
            adminDvorane.Show();
            this.Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            Dvorana novaDvorana = new Dvorana();
            novaDvorana.Naziv = txtDodajDvoranuNaziv.Text.ToString();
            //MessageBox.Show(txtCijenaDodajArtikl.Text.ToString());
            try
            {
                novaDvorana.BrojSjedala = int.Parse(txtDodajDvoranuBrSjedala.Text.ToString());

                if (dvoranaAzuriraj != null)
                {
                    novaDvorana.BrojDvorane = dvoranaAzuriraj.BrojDvorane;
                    Dvorana.AzurirajDvoranu(novaDvorana);
                }
                else
                {
                    Dvorana.DodajDvoranu(novaDvorana);

                }
                FrmAdminDvorane adminDvorane = new FrmAdminDvorane();
                adminDvorane.Show();
                this.Close();
            }
            catch
            {
                MessageBox.Show("Pogrešan unos podataka!");
            }
        }

        /// <summary>
        /// funkcija za odjavu iz sustava, klikom na odjava se postavlja parametar na 1
        /// i prosljeduje funkciji koja ce ispisati poruku i pitati želi li se korisnik odjaviti
        /// u slucaju klika na yes, korisnik se odjavljuje i vraca na pocetnu stranicu (login)
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
        private void FrmAdminDvoraneDodaj_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!pomOdjava)
            {
                FrmAdminDvorane adminDvorane = new FrmAdminDvorane();
                adminDvorane.Show();
            }
        }
    }
}
