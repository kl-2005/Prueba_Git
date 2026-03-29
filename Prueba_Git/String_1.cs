using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Git
{
    public class String
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public System.String NombreCompleto { get { return $"{Nombre} {Apellido}"; } }

        public String()
        {

        }

        public String(string cedula, string nombre, string apellido)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
        }
    }
}
