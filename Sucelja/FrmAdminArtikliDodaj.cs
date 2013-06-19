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
    public partial class FrmAdminArtikliDodaj : Form
    {
        private bool pomOdjava = false;
        private Artikl artiklAzuriraj = null;

        List<MjernaJedinica> listaMjernihJedinica = MjernaJedinica.DohvatiMjerneJedinice();

        /// <summary>
        /// Konstruktor koji se poziva u slučaju dodavanja novog artikla
        /// </summary>
        public FrmAdminArtikliDodaj()
        {
            InitializeComponent(); 
            userName.Text = FrmPocetna.SpremnikPodataka.Zaposlenik;
            userRole.Text = FrmPocetna.SpremnikPodataka.Uloga;
            
           
            foreach (MjernaJedinica mJedinica in listaMjernihJedinica)
            {
                cbMjerneJedinice.Items.Add(mJedinica.Naziv);
            }

        }
        /// <summary>
        /// Konstruktor koji se poziva prilikom ažuriranja postojeeg artikla
        /// </summary>
        /// <param name="odabraniArtikl"></param>
        public FrmAdminArtikliDodaj(Artikl odabraniArtikl)
        {
            InitializeComponent();
            artiklAzuriraj = odabraniArtikl;

            foreach (MjernaJedinica mJedinica in listaMjernihJedinica)
            {
                cbMjerneJedinice.Items.Add(mJedinica.Naziv);
            }

        }

        /// <summary>
        /// Rukuje događajem pokretanja forme, ukoliko se radi o ažuriranju tima tada formulu popunjava sa postojećim podacima
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAdminArtikliDodaj_Load(object sender, EventArgs e)
        {
            if (artiklAzuriraj != null)
            {
                txtNazivDodajArtikl.Text = artiklAzuriraj.Naziv.ToString();
                txtCijenaDodajArtikl.Text = artiklAzuriraj.Cijena.ToString();
                //pod hitno popravit!!!  ovaj način hvatanja combo boxa nije dobar
                cbMjerneJedinice.SelectedIndex = artiklAzuriraj.IdMjerneJedinice-1;

            }
        }



        private void cbMjerneJedinice_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            FrmAdminArtikli adminArtikli = new FrmAdminArtikli();
            adminArtikli.Show();
            this.Close();
        }

        /// <summary>
        /// Dodavanje novog artikla prilikom klika na tipku dodaj!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
            pomOdjava = true;
            Artikl noviArtikl = new Artikl();
            noviArtikl.Naziv = txtNazivDodajArtikl.Text.ToString();
            //MessageBox.Show(txtCijenaDodajArtikl.Text.ToString());
           try
           {
                noviArtikl.Cijena = float.Parse(txtCijenaDodajArtikl.Text.ToString());

                //pod hitno popravit!!!  ovaj način hvatanja combo boxa nije dobar
                noviArtikl.IdMjerneJedinice = int.Parse(listaMjernihJedinica[cbMjerneJedinice.SelectedIndex].IdMjerneJedinice.ToString());

                if (artiklAzuriraj != null)
                {   
                    noviArtikl.IdArtikla=artiklAzuriraj.IdArtikla;
                    Artikl.AzurirajArtikl(noviArtikl);
                
                }
                else
                {
                    Artikl.DodajArtikl(noviArtikl);
                    
                }
                FrmAdminArtikli adminArtikli = new FrmAdminArtikli();
                adminArtikli.Show();
                this.Close();
            }
            catch
            {
                
                MessageBox.Show("Pogrešan unos podataka!");
            }


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
        private void FrmAdminArtikliDodaj_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!pomOdjava)
            {
                FrmAdminArtikli adminArtikli = new FrmAdminArtikli();
                adminArtikli.Show();
            }
        }  
    }
}
