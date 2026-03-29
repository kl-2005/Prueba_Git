using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Git
{
    public class Inscripcion
    {
        public Estudiante Estudiante { get; set; }
        public Tutor Tutor { get; set; }
        public Horario Horario { get; set; }
        public Inscripcion()
        {

        }
        public Inscripcion(Estudiante estudiante, Tutor tutor, Horario horario)
        {
            Estudiante = estudiante;
            Tutor = tutor;
            Horario = horario;
        }
        public Inscripcion(Estudiante estudiante, Tutor tutor)
        {
            Estudiante = estudiante;
            Tutor = tutor;
        }
    }
}
