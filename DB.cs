using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using System.Data.Common;
using System.Data;

namespace PI_projekt
{
    /// <summary>
    /// Klasa za pristup bazi podataka.
    /// </summary>
    public class DB
    {
        #region Constructors

        /// <summary>
        /// Konstruktor klase.
        /// </summary>
        private DB()
        {
            ConnectionString = @"Data Source= ..\..\Baza\KinoDB.db3";
            Connection = new SQLiteConnection(ConnectionString);
            Connection.Open();
        }

        /// <summary>
        /// Destruktor klase.
        /// </summary>
        /*~DB()
        {
            Connection.Close();
            Connection = null;
        }*/

        #endregion

        #region Private Fields

        private static DB instance;          //Singleton objekt
        private string connectionString;     //Putanja i ostali podaci za spajanje na bazu
        private SQLiteConnection connection; //Konekcija prema bazi

        #endregion

        #region Properties

        /// <summary>
        /// Singleton instanca klase za rad za bazom.
        /// </summary>
        public static DB Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DB();
                }
                return instance;
            }
        }

        /// <summary>
        /// Tekstualna reprezentacija konekcije na bazu.
        /// </summary>
        public string ConnectionString
        {
            get
            {
                return connectionString;
            }
            private set
            {
                if (connectionString != value)
                {
                    connectionString = value;
                }
            }
        }

        /// <summary>
        /// Konekcija na bazu podataka.
        /// </summary>
        public SQLiteConnection Connection
        {
            get
            {
                return connection;
            }
            private set
            {
                if (connection != value)
                {
                    connection = value;
                }
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Dohvaća podatke u obliku DataReader objekta na temelju proslijeđenog upita.
        /// </summary>
        /// <param name="sqlUpit">SQL upit.</param>
        /// <returns>Rezultati upita.</returns>
        public DbDataReader DohvatiDataReader(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteReader();
        }

        /// <summary>
        /// Dohvaća skalarnu vrijednost kao rezultat proslijeđenog upita.
        /// </summary>
        /// <param name="sqlUpit">SQL upit.</param>
        /// <returns>Skalarna vrijednost kao rezultat upita.</returns>
        public object DohvatiVrijednost(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteScalar();
        }

        /// <summary>
        /// Izvršava INSERT, UPDATE, DELETE SQL izraz.
        /// </summary>
        /// <param name="sqlUpit">INSERT, UPDATE, DELETE SQL izraz.</param>
        /// <returns>Broj redaka u tablici koji su dodani, promijenjeni ili obrisani.</returns>
        public int IzvrsiUpit(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            return command.ExecuteNonQuery();
        }

         /// <summary>
        /// Izvršava INSERT sql izraz i vraća ID autoincrement primarnog ključa 
        /// </summary>
        /// <param name="sqlUpit">INSERT izraz</param>
        /// <returns>ID posljednje unešenog primarnog ključa</returns>
        public int IzvrsiUpitID(string sqlUpit)
        {
            SQLiteCommand command = new SQLiteCommand(sqlUpit, Connection);
            command.ExecuteNonQuery();
            return (int)Connection.LastInsertRowId;
        }
        
        #endregion
    }
}
