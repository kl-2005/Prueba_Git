using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Git
{
    public static class DatosGlobales
    {
        public static List<Estudiante> Estudiantes = new List<Estudiante>();
        public static List<Tutor> Tutores = new List<Tutor>();
        public static List<Horario> Horarios = new List<Horario>();
        public static List<Inscripcion> Inscripciones = new List<Inscripcion>();

        public static bool CoincidenciasCedulaEstudianteTutor(string cedula)
        {
            try
            {
                foreach (var tutor in DatosGlobales.Tutores)
                {
                    if (cedula == tutor.Cedula)
                    {
                        MessageBox.Show("La cédula del estudiante coincide con la del tutor", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
