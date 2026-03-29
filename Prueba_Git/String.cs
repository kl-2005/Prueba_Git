using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Git
{
    public class String
    {
        public String()
        {
            
        }

        public String(string cedula, string nombre, int cupo_Maximo, int cupo_Disponible)
        {
            Cedula = cedula;
            Nombre = nombre;
            Cupo_Maximo = cupo_Maximo;
            Cupo_Disponible = cupo_Disponible;
        }

        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public int Cupo_Maximo {get; set; }
        public int Cupo_Disponible { get; set; }
        public List<String> ListaEstudiantes { get; set; }
    }
}
