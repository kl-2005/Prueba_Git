using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Git
{
    public class Tutor
    {
        public Tutor()
        {
            
        }

        public Tutor(string cedula, string nombre, string asignatura)
        {
            Cedula = cedula;
            Nombre = nombre;
            Asignatura = asignatura;
        }

        public string Cedula{ get; set; }
        public string Nombre{ get; set; }
        public string Asignatura{ get; set; }   //olaaa
    }
}
