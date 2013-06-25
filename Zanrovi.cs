using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    //Klasa za rad s podacima o žanrovima
    class Zanrovi
    {
     
        #region Constructors

        /// <summary>
        /// Konstruktor za kreiranje žanrova
        /// </summary>
        public Zanrovi()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za Zanr.</param>
        public Zanrovi(DbDataReader dr)
        {
            if (dr != null)
            {
                IdZanra = int.Parse(dr["id_zanra"].ToString());
                Naziv = dr["naziv"].ToString();
                
            }

        }

        #endregion

        #region Private Fields

        private int id_zanra;
        private string naziv;
     

        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator žanra
        /// </summary>
        public int IdZanra
        {
            get
            {
                return id_zanra;
            }
            private set
            {
                if (id_zanra != value)
                {
                    id_zanra = value;
                }
            }
        }

        /// <summary>
        /// Naziv Žanra
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
        /// Metoda koja dohvaća sve žanrove iz baze i vraća ih u obliku generičke liste.
        /// </summary>
        /// <returns>Lista žanrova</returns>
        public static List<Zanrovi> DohvatiZanrove()
        {
            List<Zanrovi> lista = new List<Zanrovi>();
            string sqlUpit = "SELECT * FROM Zanr";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Zanrovi zanr = new Zanrovi(dr);
                lista.Add(zanr);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }

       /// <summary>
        /// Metoda koja dohvaća sve žanrove za određeni film
       /// </summary>
       /// <param name="idFilma">Int id filma</param>
       /// <returns>Lista žanrova</returns>
        public static List<Zanrovi> DohvatiZanrove(int idFilma)
        {
            List<Zanrovi> lista = new List<Zanrovi>();
            string sqlUpit = "SELECT zanr.* FROM Zanr LEFT JOIN film_zanr ON Zanr.id_zanra=film_zanr.id_zanra WHERE film_zanr.id_filma=" + idFilma + ";";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Zanrovi zanr = new Zanrovi(dr);
                lista.Add(zanr);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }
        

        #endregion
    }

    
}
