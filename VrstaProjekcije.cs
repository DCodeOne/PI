using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    class VrstaProjekcije
    {
        
        #region Constructors

        /// <summary>
        /// Konstruktor za kreiranje  vrste projekcije
        /// </summary>
        public VrstaProjekcije()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za film-Zanr.</param>
        public VrstaProjekcije(DbDataReader dr)
        {
            if (dr != null)
            {
                IdVrste = int.Parse(dr["id_vrste"].ToString());
                Naziv= dr["naziv"].ToString();
                 
            }

        }

        #endregion

        #region Private Fields

        private int id_vrste;
        private string naziv;
     
        #endregion

        #region Properties


        
        /// <summary>
        /// Jedinstveni identifikator vrste projekcije
        /// </summary>
        public int IdVrste
        {
            get
            {
                return id_vrste;
            }
            private set
            {
                if (id_vrste != value)
                {
                    id_vrste = value;
                }
            }
        }

        /// <summary>
        /// Naziv vrste projekcije
        /// </summary>
        public string Naziv
        {
            get
            {
                return naziv;
            }
            private set
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
        /// Dohvaca vrste projekcije za određenu projekciju
        /// </summary>
        /// <param name="idProjekcije">int id projekcije</param>
        /// <returns>lista vrsti projekcije</returns>
        public static List<VrstaProjekcije> DohvatiVrste(int idProjekcije)
        {
            List<VrstaProjekcije> lista = new List<VrstaProjekcije>();
            string sqlUpit = "SELECT Vrsta_projekcije.* FROM Vrsta_projekcije LEFT JOIN projekcija_vrsta ON Vrsta_projekcije.id_vrste=projekcija_vrsta.id_vrste WHERE projekcija_vrsta.id_projekcije="
                + idProjekcije + ";";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                VrstaProjekcije vrstaProjekcije = new VrstaProjekcije(dr);
                lista.Add(vrstaProjekcije);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }


        
        #endregion
    }
}
