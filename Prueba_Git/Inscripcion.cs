using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Git
{
    public class Inscripcion
    {
        public String Estudiante { get; set; }
        public String Tutor { get; set; }
        public String Horario { get; set; }
        public Inscripcion()
        {

        }
        public Inscripcion(String estudiante, String tutor, String horario)
        {
            Estudiante = estudiante;
            Tutor = tutor;
            Horario = horario;
        }
        public Inscripcion(String estudiante, String tutor)
        {
            Estudiante = estudiante;
            Tutor = tutor;
        }
    }
}
