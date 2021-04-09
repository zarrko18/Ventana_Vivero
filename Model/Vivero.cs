using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Model
{
    public class Vivero
    {
        public Vivero()
        {
        }

        public Vivero(string nombre, string iD, string tipo)
        {
            Nombre = nombre;
            ID = iD;
            Tipo = tipo;
        }

        public string Nombre { get; set; }
        public string ID { get; set; }
        public string Tipo { get; set; }
    }
}
