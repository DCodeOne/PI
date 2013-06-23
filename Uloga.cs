using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    class Uloga
    {

        #region Constructors

        /// <summary>
        /// Konstruktor za kreiranje uloga
        /// </summary>
        public Uloga()
        {

        }

        /// <summary>
        /// Puni objekt sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za Uloge.</param>
        public Uloga(DbDataReader dr)
        {
            if (dr != null)
            {
                IdUloge = int.Parse(dr["id_uloga"].ToString());
                Naziv = dr["naziv"].ToString();

            }

        }

        #endregion

        #region Private Fields

        private int id_uloge;
        private string naziv;


        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator uloge
        /// </summary>
        public int IdUloge
        {
            get
            {
                return id_uloge;
            }
            private set
            {
                if (id_uloge != value)
                {
                    id_uloge = value;
                }
            }
        }

        /// <summary>
        /// Naziv Uloge
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
        /// Dohvaća sve uloge iz baze i vraća ih u obliku generičke liste.
        /// </summary>
        /// <returns>Lista uloga</returns>
        public static List<Uloga> DohvatiSveUloge()
        {
            List<Uloga> lista = new List<Uloga>();
            string sqlUpit = "SELECT * FROM Uloga";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Uloga uloga = new Uloga(dr);
                lista.Add(uloga);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }

        /// <summary>
        /// Dohvaća  ulogu za određeni zaposlenika
        /// </summary>
        /// <param name="idZaposlenika">Int idZaposlenika</param>
        /// <returns>Lista žanrova</returns>
        public static Uloga DohvatiUlogu(int idZaposlenika)
        {
            Uloga uloga = new Uloga();
            string sqlUpit = "SELECT Uloga.* FROM Zaposlenik LEFT JOINT Uloga ON Zaposlenik.id_uloge=Uloga.id_uloge WHERE id_zaposlenika=" + idZaposlenika + ";";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                uloga = new Uloga(dr);

            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return uloga;
        }

        /// <summary>
        /// Unosi Ulogu u bazu podataka za određenog zaposlenika
        /// </summary>
        /// <param name="idZaposlenika"></param>
        /// <param name="idUloge"></param>
        /// <returns></returns>
        public static int UnesiUlogu(int idZaposlenika, int idUloge)
        {
            int zahvaceno = 0;
            string sqlUpit = "INSERT INTO Zaposlenik(id_uloge) VALUES ('" + idUloge + "')WHERE id_zaposlenika=" + idZaposlenika + ";";
            zahvaceno = DB.Instance.IzvrsiUpit(sqlUpit);

            return zahvaceno;
        }



        #endregion
    }


}