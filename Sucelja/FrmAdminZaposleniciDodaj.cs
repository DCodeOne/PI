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
    public partial class FrmAdminZaposleniciDodaj : Form
    {

        private Zaposlenici zaposlenikAzuriraj = null;
        long kontrolnaSuma = 10000000000;
        List<Uloga> listaUloga = new List<Uloga>();

        /// <summary>
        /// Inicijalizacija
        /// Konstruktor koji se poziva u slucaju dodavanja novog zaposlenika
        /// </summary> 
        public FrmAdminZaposleniciDodaj()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktor koji se poziva prilikom ažuriranja postojećeg zaposlenika
        /// </summary>
        /// <param name="odabraniArtikl"></param>
        public FrmAdminZaposleniciDodaj (long odabraniZaposlenik)
        {
            InitializeComponent();
            zaposlenikAzuriraj = Zaposlenici.DohvatiZaposlenika(odabraniZaposlenik);
            txtZaposleniciDodajOIB.Text = zaposlenikAzuriraj.OIB.ToString();
            txtZaposleniciDodajIme.Text = zaposlenikAzuriraj.Ime.ToString();
            txtZaposleniciDodajPrezime.Text = zaposlenikAzuriraj.Prezime.ToString();
            txtZaposleniciDodajAdresa.Text = zaposlenikAzuriraj.Adresa.ToString();
            txtZaposleniciDodajKontakt.Text = zaposlenikAzuriraj.Kontakt.ToString();
            txtZaposleniciDodajEmail.Text = zaposlenikAzuriraj.Email.ToString();
            txtZaposleniciDodajKorime.Text = zaposlenikAzuriraj.KorIme.ToString();
            txtZaposleniciDodajLozinka.Text = zaposlenikAzuriraj.Lozinka.ToString();
            foreach (Uloga uloga in listaUloga)
            {
                if (uloga.IdUloge == zaposlenikAzuriraj.Uloga)
                {
                    cbUloga.SelectedIndex = cbUloga.FindStringExact(uloga.Naziv.ToString());
                }
            }

        }

        /// <summary>
        /// Rukuje dogadajem pokretanja forme, ukoliko se radi o ažuriranju zaposlenika tada formu popunjava sa postojećim podacima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdminZaposleniciDodaj_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtZaposleniciDodajOIB;
            listaUloga = Uloga.DohvatiSveUloge();
            foreach (Uloga uloga in listaUloga) 
            {
                cbUloga.Items.Add(uloga.Naziv);
         
            }

            //Ako je otvoren obrazac za ažuriranje
            if (zaposlenikAzuriraj != null)
            {
                txtZaposleniciDodajOIB.Text = zaposlenikAzuriraj.OIB.ToString();
                txtZaposleniciDodajIme.Text = zaposlenikAzuriraj.Ime.ToString();
                txtZaposleniciDodajPrezime.Text = zaposlenikAzuriraj.Prezime.ToString();
                txtZaposleniciDodajAdresa.Text = zaposlenikAzuriraj.Adresa.ToString();
                txtZaposleniciDodajKontakt.Text = zaposlenikAzuriraj.Kontakt.ToString();
                txtZaposleniciDodajEmail.Text = zaposlenikAzuriraj.Email.ToString();
                txtZaposleniciDodajKorime.Text = zaposlenikAzuriraj.KorIme.ToString();
                txtZaposleniciDodajLozinka.Text = zaposlenikAzuriraj.Lozinka.ToString();
                foreach (Uloga uloga in listaUloga)
                {
                    if (uloga.IdUloge == zaposlenikAzuriraj.Uloga)
                    {
                        cbUloga.SelectedIndex = cbUloga.FindStringExact(uloga.Naziv.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// Dodavanje novog zaposlenika prilikom klika na tipku dodaj!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZaposleniciDodaj_Click(object sender, EventArgs e)
        {
            Zaposlenici noviZaposlenik = new Zaposlenici();
            noviZaposlenik.Ime = txtZaposleniciDodajIme.Text.ToString();
            noviZaposlenik.Prezime = txtZaposleniciDodajPrezime.Text.ToString();
            noviZaposlenik.Adresa = txtZaposleniciDodajAdresa.Text.ToString();
            noviZaposlenik.Kontakt = txtZaposleniciDodajKontakt.Text.ToString();
            noviZaposlenik.Email = txtZaposleniciDodajEmail.Text.ToString();
            noviZaposlenik.KorIme = txtZaposleniciDodajKorime.Text.ToString();
            noviZaposlenik.Lozinka = txtZaposleniciDodajLozinka.Text.ToString();
            try
            {
                noviZaposlenik.Uloga = listaUloga[cbUloga.SelectedIndex].IdUloge;
                if (noviZaposlenik.Ime == "" || noviZaposlenik.Prezime == "" || noviZaposlenik.Adresa == "" ||
                    noviZaposlenik.Kontakt == "" || noviZaposlenik.Email == "" || noviZaposlenik.KorIme == "" ||
                    noviZaposlenik.Lozinka == "")
                {
                    MessageBox.Show("Greška! Podaci neispravno uneseni.");
                }
                else
                {
                    if (zaposlenikAzuriraj != null)
                    {
                        string oibTest = txtZaposleniciDodajOIB.Text.ToString();
                        noviZaposlenik.OIB = long.Parse(txtZaposleniciDodajOIB.Text.ToString());
                        if (noviZaposlenik.OIB > kontrolnaSuma && oibTest.Length == 11)
                        {
                            noviZaposlenik.OIB = zaposlenikAzuriraj.OIB;
                            Zaposlenici.AzurirajZaposlenika(noviZaposlenik);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Greška! Unijeli ste neispravan OIB.");
                        }
                    }
                    else
                    {
                        string oibTest = txtZaposleniciDodajOIB.Text.ToString();
                        noviZaposlenik.OIB = long.Parse(txtZaposleniciDodajOIB.Text.ToString());
                        if (noviZaposlenik.OIB > kontrolnaSuma && oibTest.Length == 11)
                        {
                            Zaposlenici.DodajZaposlenika(noviZaposlenik);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Greška! Unijeli ste neispravan OIB.");
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Greška! Podaci neispravno uneseni.");
            }
        }

        /// <summary>
        /// Odustajanje od dodavanja novog zaposlenika prilikom klika na tipku odustani
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZaposleniciDodajOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
