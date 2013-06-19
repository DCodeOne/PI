using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    class Ulaznice
    {
           
        #region Constructors

        /// <summary>
        /// Konstruktor za kreiranje  vrste projekcije
        /// </summary>
        public Ulaznice()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za film-Zanr.</param>
        public Ulaznice(DbDataReader dr)
        {
            if (dr != null)
            {
                IdUlaznice = int.Parse(dr["id_karte"].ToString());
                Sjedalo = int.Parse(dr["sjedalo"].ToString());
                IdProjekcije = int.Parse(dr["id_projekcije"].ToString()); 
            }

        }

        #endregion

        #region Private Fields

        private int id_ulaznice;
        private int sjedalo;
        private int id_projekcije;
     
        #endregion

        #region Properties


        
        /// <summary>
        /// Jedinstveni identifikator ulaznice
        /// </summary>
        public int IdUlaznice
        {
            get
            {
                return id_ulaznice;
            }
            private set
            {
                if (id_ulaznice != value)
                {
                    id_ulaznice = value;
                }
            }
        }

        /// <summary>
        /// Jedinstveni identifikator projekcije
        /// </summary>
        public int IdProjekcije
        {
            get
            {
                return id_projekcije;
            }
            private set
            {
                if (id_projekcije != value)
                {
                    id_projekcije = value;
                }
            }
        }
        /// <summary>
        /// broj sjedala
        /// </summary>
        public int Sjedalo
        {
            get
            {
                return sjedalo;
            }
            private set
            {
                if (sjedalo != value)
                {
                    sjedalo = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Dohvaća sve ulaznice
        /// </summary>
        /// <returns>Lista svih ulaznica</returns>
        public static List<Ulaznice>  DohvatiSveUlaznice()
        {
            List<Ulaznice> lista = new List<Ulaznice>();
            string sqlUpit = "SELECT * from Karta ;";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Ulaznice ulaznica = new Ulaznice(dr);
                lista.Add(ulaznica);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }

       /// <summary>
        /// Dohvaća sve ulaznice za određenu projekciju
       /// </summary>
       /// <param name="idProjekcije">Id projekcije za koju se dohvaćaju sve ulaznice</param>
       /// <returns>int vraća listu sjedala</returns>
        public static List<int> DohvatiUlazniceProjekciju(int idProjekcije)
        {
            List<int> lista = new List<int>();
            string sqlUpit = "SELECT Karta.* FROM Karta LEFT JOIN Projekcija ON Karta.id_projekcije=Projekcija.id_projekcije WHERE Projekcija.id_projekcije=" 
                + idProjekcije + ";";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Ulaznice ulaznica = new Ulaznice(dr);
                lista.Add(ulaznica.Sjedalo);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }

        public static int UnesiUlaznicu(int sjedalo, int idProjekcije)
        {
            
            string sqlUpit = "INSERT INTO Karta ('sjedalo','id_projekcije') VALUES ('"+ sjedalo + "','" + idProjekcije + "');";
            int idUlaznice = DB.Instance.IzvrsiUpitID(sqlUpit);

            return idUlaznice;
        }
        
        #endregion
    }
}
