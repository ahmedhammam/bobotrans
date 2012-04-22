using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    partial class DAL
    {
        public class DAOFactory
        {
            private static DAOFactory instanca = null;

            public static DAOFactory Instanca
            {
                get { return (instanca==null)? instanca = new DAOFactory() : instanca; }
            }

            private DAOFactory() { }

            public AutobusDAO getAutobusDAO()
            {
                return new AutobusDAO();
            }
        }
    }
}
