using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;

namespace WebApplication7
{
    public class Conexion
    {
        OracleConnection con;

        public Conexion()
        {
        }

        public OracleConnection Connect()
        {
            con = new OracleConnection();
            con.ConnectionString = "  DATA SOURCE= localhost ; USER ID = PRUEBA ; PASSWORD = root ;  ";
            con.Open();

            return con;

         
        }

        void Close()
        {
            con.Close();
            con.Dispose();
        }

      
    }
}
