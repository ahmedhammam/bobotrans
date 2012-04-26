using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
    public partial class DAL
    {
        //private string db, user, pass;
        const string databaseServer = "localhost";
        const string databaseName = "bobotrans";
        const string databaseUser = "root";
        const string databasePassword = "";

        private static MySqlConnection con = null;

        private static DAL instanca = null;

        public static DAL Instanca
        {
            get { return (instanca == null) ? instanca = new DAL() : instanca; }
        }

        private DAL() { }
        ~DAL() { terminirajKonekciju(); }


        public void kreirajKonekciju(string host=databaseServer, string db=databaseName, string user=databaseUser, string pass=databasePassword)
        {
            if (con != null) return;
            string connectionString = "server=" + host + ";user=" + user + ";pwd=" + pass + ";database=" + db;
            con = new MySqlConnection(connectionString);

            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public DAOFactory getDAO
        {
            get { return DAOFactory.Instanca; }
        }

        public void terminirajKonekciju()
        {
            try
            {
                if (con != null) con.Close();
                con = null;
            }
            catch (Exception e) { throw e; }

        }



    }
}
