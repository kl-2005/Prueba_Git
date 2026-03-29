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
        
        public static List<Estudiante> Estudiantes = new List<Estudiante>()
        {
        new Estudiante("0100000001","Juan","Pérez"),
        new Estudiante("0100000002","María","Gómez"),
        new Estudiante("0100000003","Carlos","López"),
        new Estudiante("0100000004","Ana","Martínez"),
        new Estudiante("0100000005","Luis","Torres"),
        new Estudiante("0100000006","Sofía","Ramírez"),
        new Estudiante("0100000007","Pedro","Castro"),
        new Estudiante("0100000008","Lucía","Vargas"),
        new Estudiante("0100000009","Diego","Morales"),
        new Estudiante("0100000010","Valentina","Rojas"),

       
        };

        public static List<Tutor> Tutores = new List<Tutor>()
        {
        new Tutor("0200000001","Miguel","Andrade",10,10),
        new Tutor("0200000002","Patricia","Vega",10,10),
        new Tutor("0200000003","Roberto","Molina",10,10),
        new Tutor("0200000004","Verónica","Cedeño",10,10),
        new Tutor("0200000005","Luis","Jaramillo",10,10),

        new Tutor("0200000006","Silvia","Carrasco",10,10),
        new Tutor("0200000007","Fernando","Guerrero",10,10),
        new Tutor("0200000008","Andrea","Pazmiño",10,10),
        new Tutor("0200000009","Javier","Borja",10,10),
        new Tutor("0200000010","Mónica","Santacruz",10,10)
        };

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
