using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Git
{
    public class Horario
    {
        public System.String Dia{ get; set; }
        public System.String Hora{ get; set; }
        public System.String Aula{ get; set; }

        public Horario()
        {
            
        }
        public Horario(string dia, string hora, string aula)
        {
            Dia = dia;
            Hora = hora;
            Aula = aula;
        }
    }
}
