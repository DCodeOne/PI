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
    public partial class CustomMessageBox : Form
    {
        static CustomMessageBox newMessageBox;
        int disposeFormTimer;
        
        /// <summary>
        /// Inicijalizacija
        /// </summary>
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event koji se pokreće prilikom pokretanja MB-a
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            PlaceLowerRight();
            base.OnLoad(e);
            disposeFormTimer = 20;
            Timer msgTimer = new Timer();
            msgTimer.Interval = 1000;
            msgTimer.Enabled = true;
            msgTimer.Start();
            msgTimer.Tick += new System.EventHandler(this.timer_tick);
        }

        /// <summary>
        /// Tajmer koji zatvara MB ukoliko ga prodavač ne zatvori manualno u periodu od 20 sekundi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_tick(object sender, EventArgs e)
        {
            disposeFormTimer--;
            if (disposeFormTimer >= 0)
            {
                newMessageBox.lblTimer.Text = "00:" + disposeFormTimer.ToString() + " s";
            }
            else
            {
                newMessageBox.Dispose();
            }
        }

        /// <summary>
        /// Metoda za pozicioniranje MB-a
        /// </summary>
        private void PlaceLowerRight()
        {
            //Determine "rightmost" screen
            Screen rightmost = Screen.AllScreens[0];
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen.WorkingArea.Right > rightmost.WorkingArea.Right)
                    rightmost = screen;
            }

            this.Left = rightmost.WorkingArea.Right - this.Width;
            this.Top = rightmost.WorkingArea.Bottom - this.Height;
        }

        /// <summary>
        /// Metoda za prikaz MB-a
        /// </summary>
        /// <param name="txtMessage"></param>
        public static void ShowBox(string txtMessage)
        {
            newMessageBox = new CustomMessageBox();
            newMessageBox.lblPoruka.Text = txtMessage;
            newMessageBox.Text = "Projekcija skoro popunjena!";
            newMessageBox.ShowDialog();
        }

        /// <summary>
        /// Klik na gumb Uredu zatvara MB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUredu_Click_1(object sender, EventArgs e)
        {
            newMessageBox.Dispose();
        }
    }
}
