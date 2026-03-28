using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Git
{
    public class Estudiante
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public Tutor Tutor { get; set; }
        public Horario Horario { get; set; }

        public Estudiante()
        {

        }

        public Estudiante(string cedula, string nombre, Tutor tutor, Horario horario)
        {
            Cedula = cedula;
            Nombre = nombre;
            Tutor = tutor;
            Horario = horario;
        }
    }
}
