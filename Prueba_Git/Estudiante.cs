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
        public string Apellido { get; set; }
        public Tutor Tutor { get; set; }
        public Horario Horario { get; set; }

        public Estudiante()
        {

        }

        public Estudiante(string cedula, string nombre, string apellido, string correo, Tutor tutor, Horario horario)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Tutor = tutor;
            Horario = horario;
        }
    }
}
