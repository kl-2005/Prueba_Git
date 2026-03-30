using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Git
{
    public class Tutor
    {
        
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public String Apellido { get; set; }
        public int Cupo_Maximo {get; set; }
        public int Cupo_Disponible { get; set; }

        public Tutor()
        {

        }
        public Tutor(string cedula, string nombre, string apellido, int cupo_Maximo, int cupo_Disponible)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Cupo_Maximo = cupo_Maximo;
            Cupo_Disponible = cupo_Disponible;
        }
    }
}
