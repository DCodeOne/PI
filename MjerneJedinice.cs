using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    class MjernaJedinica
    {
        #region Constructors

        /// <summary>
        /// Konstruktor za kreiranje mjerne jedinice
        /// </summary>
        public MjernaJedinica()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za Artikl.</param>
        public MjernaJedinica(DbDataReader dr)
        {
            if (dr != null)
            {
                IdMjerneJedinice = int.Parse(dr["id_mjerne_jedinice"].ToString());
                Naziv = dr["naziv"].ToString();
                
            }

        }

        #endregion

        #region Private Fields

        private int id_mjerne_jedinice;
        private string naziv;
     

        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator mjerne jedinice.
        /// </summary>
        public int IdMjerneJedinice
        {
            get
            {
                return id_mjerne_jedinice;
            }
            private set
            {
                if (id_mjerne_jedinice != value)
                {
                    id_mjerne_jedinice = value;
                }
            }
        }

        /// <summary>
        /// Naziv mjerne jedinice
        /// </summary>
        public string Naziv
        {
            get
            {
                return naziv;
            }
            set
            {
                if (naziv != value)
                {
                    naziv = value;
                }
            }
        }

      
        #endregion

        #region Methods

        /// <summary>
        /// Dohvaća sve mjerne jedinice iz baze i vraća ih u obliku generičke liste.
        /// </summary>
        /// <returns>Lista mjernih jedinica</returns>
        public static List<MjernaJedinica> DohvatiMjerneJedinice()
        {
            List<MjernaJedinica> lista = new List<MjernaJedinica>();
            string sqlUpit = "SELECT * FROM Mjerna_jedinica";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                MjernaJedinica mjernaJedinica = new MjernaJedinica(dr);
                lista.Add(mjernaJedinica);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }

        

        #endregion
    }
}