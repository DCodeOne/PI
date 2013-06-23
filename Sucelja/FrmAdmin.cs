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
            ssUsername.Text = Sucelja.FrmPocetna.SpremnikPodataka.Zaposlenik;
        }
        private void miSifarniciZaposlenici_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminZaposlenici Odabir = new Sucelja.FrmAdminZaposlenici();
            //Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.ShowDialog(this);
            
        }

        private void miSifarniciArtikli_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminArtikli Odabir = new Sucelja.FrmAdminArtikli();
            //Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.ShowDialog(this);

        }

        private void miSifarniciFilmovi_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminFilmovi Odabir = new Sucelja.FrmAdminFilmovi();
            //Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.ShowDialog(this);

        }

        private void miSifarniciProjekcije_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminProjekcije Odabir = new Sucelja.FrmAdminProjekcije();
            //Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.ShowDialog(this);

        }

        private void miSifarniciDvorane_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminDvorane Odabir = new Sucelja.FrmAdminDvorane();
            //Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.ShowDialog(this);

        }

         /// <summary>
        /// funkcija za odjavu iz sustava, klikom na odjava se postavlja parametar na 1
        /// i prosljeđuje funkciji koja će ispisati poruku i pitati želi li se korisnik odjaviti
        /// u slučaju klika na yes, korisnik se odjavljuje i vraća na početnu stranicu (login)
        /// </summary>
        int odjavljivanje = 0;
        private void miOpcijeOdjava_MouseUp(object sender, MouseEventArgs e)
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
                    FrmPocetna pocetna = new FrmPocetna();
                    this.Close();
                    pocetna.Show();
                    
                }
            }
        }

        /// <summary>
        ///funkcija za izlaz iz aplikacije 
        /// </summary>
        int izlaz = 0;
        private void miOpcijeIzlaz_MouseUp(object sender, MouseEventArgs e)
        {
            izlaz = 1;
            izlazak(); 
        }

        private void izlazak()
        {
            if (izlaz == 1)
            {
                string message = "Želite li ugasiti aplikaciju?";
                string caption = "Gašenje aplikacije";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.
                result = MessageBox.Show(this, message, caption, buttons);

                if (result == DialogResult.Yes)
                {
                  Application.Exit();
                }
            }
        }  
      
            
    }
}
    

