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
        //varijabla koja se koristi kod odjave i zatvaranja aplikacije
        private bool pom = false; 

        public FrmAdmin()
        {    
            InitializeComponent();

            //varijabla koja prikazuje korisničko ime trenutno prijavljenog korisnika
            ssUsername.Text = Sucelja.FrmPocetna.SpremnikPodataka.Zaposlenik;
        }

        /// <summary>
        /// Event koji poziva formu FrmAdminZaposlenici kada korisnik u glavnom izborniku pod mogućnosti Šifarnici odabere Zaposlenici
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miSifarniciZaposlenici_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminZaposlenici Odabir = new Sucelja.FrmAdminZaposlenici();
            Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.Show();
            
        }

        /// <summary>
        /// Event koji poziva formu FrmAdminArtikli kada korisnik u glavnom izborniku pod mogućnosti Šifarnici odabere Artikli
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miSifarniciArtikli_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminArtikli Odabir = new Sucelja.FrmAdminArtikli();
            Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.Show();

        }

        /// <summary>
        /// Event koji poziva formu FrmAdminFilmovi kada korisnik u glavnom izborniku pod mogućnosti Šifarnici odabere Filmovi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miSifarniciFilmovi_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminFilmovi Odabir = new Sucelja.FrmAdminFilmovi();
            Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.Show();

        }

        /// <summary>
        /// Event koji poziva formu FrmAdminProjekcije kada korisnik u glavnom izborniku pod mogućnosti Šifarnici odabere Projekcije
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miSifarniciProjekcije_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminProjekcije Odabir = new Sucelja.FrmAdminProjekcije();
            Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.Show();

        }

        /// <summary>
        /// Event koji poziva formu FrmAdminDvorane kada korisnik u glavnom izborniku pod mogućnosti Šifarnici odabere Dvorane
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miSifarniciDvorane_MouseUp(object sender, MouseEventArgs e)
        {
            Sucelja.FrmAdminDvorane Odabir = new Sucelja.FrmAdminDvorane();
            Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.Show();

        }

        /// <summary>
        /// Event koji poziva formu StatistikaProjekcije kada korisnik u glavnom izborniku pod mogućnosti Statistika odabere Statistika projekcija
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void statistikaProjekcijaToolStripMenuItem_MouseUp(object sender, MouseEventArgs e)
        {
            Izvjestaj.StatistikaProjekcije Odabir = new Izvjestaj.StatistikaProjekcije();
            Odabir.MdiParent = this;
            Odabir.WindowState = FormWindowState.Normal;
            Odabir.Show();
        }  

        
        int odjavljivanje = 0;
        /// <summary>
        /// Event koji poziva formu FrmPocetna kada korisnik u glavnom izborniku pod mogućnosti Opcije odabere Odjava
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miOpcijeOdjava_MouseUp(object sender, MouseEventArgs e)
        {         
            odjavljivanje = 1;
            pom = true;
            odjava();
        }

        /// <summary>
        /// Metoda koja služi za odjavu iz aplikacije
        /// </summary>
        private void odjava()
        {
            if (odjavljivanje == 1)
            {
                string message = "Želite li se odjaviti iz sustava?";
                string caption = "Odjava iz sustava";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                //Prikaz poruke o odjavi (Message Box)
                result = MessageBox.Show(this, message, caption, buttons);
                if (result == DialogResult.Yes)
                {
                    FrmPocetna pocetna = new FrmPocetna();
                    this.Close();
                    pocetna.Show();                    
                }
            }
        }
        
        int izlaz = 0;
        /// <summary>
        /// Event koji zatvara otvorenu formu kada korisnik u glavnom izborniku pod mogućnosti Opcije odabere Izlaz
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miOpcijeIzlaz_MouseUp(object sender, MouseEventArgs e)
        {
            izlaz = 1;
            pom = true;
            izlazak();
        }

        /// <summary>
        /// Metoda koja služi za izlaz iz aplikacije
        /// </summary>
        private void izlazak()
        {
            if (izlaz == 1)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Metoda za zatvaranje trenutno otvorene forme
        /// </summary>
        /// <param name="sender"></param>+
        /// <param name="e"></param>
        private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
           izlaz = 1;
           if (!pom)
           {
                izlazak();
           } 
        }  
    }
}
    

