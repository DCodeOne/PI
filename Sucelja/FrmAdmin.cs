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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
            userName.Text = PI_projekt.Sucelja.FrmPocetna.SpremnikPodataka.Zaposlenik;
            userRole.Text = PI_projekt.Sucelja.FrmPocetna.SpremnikPodataka.Uloga;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Opcije_Enter(object sender, EventArgs e)
        {

        }

        private void Dvorane_Click(object sender, EventArgs e)
        {

        }

        private void Artikli_Click(object sender, EventArgs e)
        {
            FrmAdminArtikli adminArtikli = new FrmAdminArtikli();
            adminArtikli.Show();
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
    }
}
    

