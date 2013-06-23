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
 
        private Artikl artiklAzuriraj = null;

        List<MjernaJedinica> listaMjernihJedinica = MjernaJedinica.DohvatiMjerneJedinice();

        /// <summary>
        /// Konstruktor koji se poziva u slučaju dodavanja novog artikla
        /// </summary>
        public FrmAdminArtikliDodaj()
        {
            InitializeComponent(); 
            
            foreach (MjernaJedinica mJedinica in listaMjernihJedinica)
            {
                cbMjerneJedinice.Items.Add(mJedinica.Naziv);
            }

        }
        /// <summary>
        /// Konstruktor koji se poziva prilikom ažuriranja postojćeg artikla
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

        /// <summary>
        /// Odustajanje od dodavanja novog artikla prilikom klika na tipku odustani
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOdustani_Click(object sender, EventArgs e)
        {

            this.Close(); 
        }

        /// <summary>
        /// Dodavanje novog artikla prilikom klika na tipku dodaj!
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDodaj_Click(object sender, EventArgs e)
        {
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
                
                this.Close();
            }
            catch
            {
                
                MessageBox.Show("Pogrešan unos podataka!");
            }
            
        }
        
       
    }
}
