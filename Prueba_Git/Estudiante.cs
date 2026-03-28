using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Git
{
    public class Estudiante
    {
        public Estudiante()
        {

        }
        public Estudiante(string cedula, string nombre, string apellido, string correo)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
        }

        public String Cedula{ get; set; }
        public String Nombre{ get; set; }
        public String Apellido { get; set; }
        public string Correo{ get; set; }

        
    }
}
