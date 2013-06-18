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
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
        }

        private void Prijava_Click(object sender, EventArgs e)
        {
            List<Zaposlenici> listaKorisnika = Zaposlenici.DohvatiZaposlenike();
            for (int i = 0; i < 4; i++)
            {
                if (KorIme.Text == listaKorisnika[i].KorIme)
                {
                    SpremnikPodataka.Zaposlenik = KorIme.Text;
                    if (Pass.Text == listaKorisnika[i].Lozinka)
                    {
                        if (listaKorisnika[i].Uloga == 2)
                        {
                            SpremnikPodataka.Uloga = "administrator";
                            FrmAdmin admin = new FrmAdmin();
                            admin.Show();
                            this.Hide();
                        }
                        else if (listaKorisnika[i].Uloga == 1)
                        {
                            SpremnikPodataka.Uloga = "prodavač";
                            FrmProdavac prodavac = new FrmProdavac();
                            prodavac.Show();
                            this.Hide();
                        }
                    }
                }
            }
        }

        public static class SpremnikPodataka
        {
            public static String Zaposlenik;
            public static String Uloga;
        }



        private void Ponisti_Click(object sender, EventArgs e)
        {
            KorIme.Clear();
            Pass.Clear();
        }

        //funkcija za izlaz iz aplikacije
        int izlaz = 0;
        private void btnIzlaz_Click(object sender, EventArgs e)
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
