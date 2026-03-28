using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Git
{
    public class Tutorias
    {
        public int Id{ get; set; }
        public int Cupos{ get; set; }
        public List<Estudiante> ListaEstudiantes{ get; set; }
        public Tutor Tutor{ get; set; }
        public Tutorias()
        {

        }
        public Tutorias(int id, int cupos, List<Estudiante> listaEstudiantes, Tutor tutor)
        {
            Id = id;
            Cupos = cupos;
            ListaEstudiantes = listaEstudiantes;
            Tutor = tutor;
        }
    }
}
