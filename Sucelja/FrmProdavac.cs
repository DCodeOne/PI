using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI_projekt.Artikli;
using PI_projekt.Ulaznica;

namespace PI_projekt.Sucelja
{
    public partial class FrmProdavac : Form
    {
        public FrmProdavac()
        {
            InitializeComponent();
            userName.Text = PI_projekt.Sucelja.FrmPocetna.SpremnikPodataka.Zaposlenik;
            userRole.Text = PI_projekt.Sucelja.FrmPocetna.SpremnikPodataka.Uloga;
        }
        //funkcija za odjavu iz sustava, klikom na odjava se postavlja parametar na 1
        // i prosljeđuje funkciji koja će ispisati poruku i pitati želi li se korisnik odjaviti
        // u slučaju klika na yes, korisnik se odjavljuje i vraća na početnu stranicu (login)
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
                    PI_projekt.Sucelja.FrmPocetna pocetna = new PI_projekt.Sucelja.FrmPocetna();
                    pocetna.Show();
                    this.Close();
                }
            }
        }

        private void Artikli_Click(object sender, EventArgs e)
        {
            FrmArtikli prodavacArtikli = new FrmArtikli();
            prodavacArtikli.Show();
        }

        private void Ulaznica_Click(object sender, EventArgs e)
        {
            FrmUlaznica prodavacUlaznica = new FrmUlaznica();
            prodavacUlaznica.Show();
        } 
    }
}
