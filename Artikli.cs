using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_projekt
{
    public class Artikl
    {
        #region Constructors

        /// <summary>
        /// Konstruktor za kreiranje artikla.
        /// </summary>
        public Artikl()
        {
            
        }

        /// <summary>
        /// Puni objekt sa podacima iz DataReader objekta.
        /// </summary>
        /// <param name="dr">DataReader objekt sa podacima za Artikl.</param>
        public Artikl(DbDataReader dr)
        {
            if (dr != null)
            {
                IdArtikla = int.Parse(dr["id_artikla"].ToString());
                Naziv = dr["naziv"].ToString();
                Cijena = float.Parse(dr["cijena"].ToString());
                IdMjerneJedinice = int.Parse(dr["id_mjerne_jedinice"].ToString());
            }

        }

        #endregion

        #region Private Fields

        private int id_artikla;
        private string naziv;
        private float cijena;
        private int id_mjerne_jedinice;

        #endregion

        #region Properties

        /// <summary>
        /// Jedinstveni identifikator artikla.
        /// </summary>
        public int IdArtikla
        {
            get
            {
                return id_artikla;
            }
            private set
            {
                if (id_artikla != value)
                {
                    id_artikla = value;
                }
            }
        }

        /// <summary>
        /// Naziv artikla.
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

        /// <summary>
        /// Cijena artikla.
        /// </summary>
        public float Cijena
        {
            get
            {
                return cijena;
            }
            set
            {
                if (cijena != value)
                {
                    cijena = value;
                }
            }
        }

        /// <summary>
        /// Mjerna jedinica artikla (vanjski ključ).
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

        #endregion

        #region Methods

        /// <summary>
        /// Dohvaća sve artikle iz baze i vraća ih u obliku generičke liste.
        /// </summary>
        /// <returns>Lista artikala.</returns>
        public static List<Artikl> DohvatiArtikle()
        {
            List<Artikl> lista = new List<Artikl>();
            string sqlUpit = "SELECT * FROM Artikl";
            DbDataReader dr = DB.Instance.DohvatiDataReader(sqlUpit);
            while (dr.Read())
            {
                Artikl artikl = new Artikl(dr);
                lista.Add(artikl);
            }
            dr.Close();     //Zatvaranje DataReader objekta.
            return lista;
        }

        #endregion
    }
}
