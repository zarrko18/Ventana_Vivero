using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Model
{
    public class DaoVivero
    {
        OracleConnection con;
        Conexion con1 = new Conexion();
        public DaoVivero()
        {
            this.con = con1.Connect();
        }
        public int Agregar_Viviero(Vivero vivero) {
            
            OracleCommand command = con.CreateCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "inser_Vivero";
            
            command.BindByName = true;
            command.Parameters.Add(new OracleParameter("P_Nombre", vivero.Nombre));
            command.Parameters.Add(new OracleParameter("P_ID", vivero.ID));
            command.Parameters.Add(new OracleParameter("P_Tipo", vivero.Tipo));

           
             return command.ExecuteNonQuery();
            

        }


        public List<Vivero> Listar_Vivero()
        {
            List<Vivero> list = new List<Vivero>();
            OracleCommand command = con.CreateCommand();
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = "list_Vivero";
            command.BindByName = true;



            OracleDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Vivero viv = new Vivero();
                viv.Nombre = reader.GetString(0);
                viv.ID = reader.GetString(1);
                viv.Tipo = reader.GetString(2);
                list.Add(viv);

            }
            return list;
          

        }
    }
}
