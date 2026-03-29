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
        
        public static List<Estudiante> Estudiantes = new List<Estudiante>(){
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

    new Estudiante("0100000011","Andrés","Herrera"),
    new Estudiante("0100000012","Camila","Ortega"),
    new Estudiante("0100000013","Jorge","Silva"),
    new Estudiante("0100000014","Daniela","Mendoza"),
    new Estudiante("0100000015","Fernando","Paredes"),
    new Estudiante("0100000016","Gabriela","Cruz"),
    new Estudiante("0100000017","Ricardo","Flores"),
    new Estudiante("0100000018","Paula","Reyes"),
    new Estudiante("0100000019","Kevin","Navarro"),
    new Estudiante("0100000020","Diana","Peña"),

    new Estudiante("0100000021","Mateo","Guerrero"),
    new Estudiante("0100000022","Elena","Suárez"),
    new Estudiante("0100000023","Sebastián","Acosta"),
    new Estudiante("0100000024","Natalia","Benítez"),
    new Estudiante("0100000025","José","Salazar"),
    new Estudiante("0100000026","Andrea","Espinoza"),
    new Estudiante("0100000027","Cristian","Valencia"),
    new Estudiante("0100000028","Karla","Aguirre"),
    new Estudiante("0100000029","Brayan","Cordero"),
    new Estudiante("0100000030","Michelle","Tapia"),

    new Estudiante("0100000031","Esteban","Núñez"),
    new Estudiante("0100000032","Tatiana","Lara"),
    new Estudiante("0100000033","Adrián","Ibarra"),
    new Estudiante("0100000034","Carolina","Quintero"),
    new Estudiante("0100000035","Hugo","Santana"),
    new Estudiante("0100000036","Melanie","Mora"),
    new Estudiante("0100000037","Iván","Zambrano"),
    new Estudiante("0100000038","Alejandra","Cabrera"),
    new Estudiante("0100000039","Oscar","Bravo"),
    new Estudiante("0100000040","Dayana","Soto"),

    new Estudiante("0100000041","Alex","Ponce"),
    new Estudiante("0100000042","Fernanda","León"),
    new Estudiante("0100000043","Marco","Campos"),
    new Estudiante("0100000044","Isabella","Rivas"),
    new Estudiante("0100000045","Raúl","Delgado"),
    new Estudiante("0100000046","Cynthia","Palacios"),
    new Estudiante("0100000047","David","Mejía"),
    new Estudiante("0100000048","Lorena","Vélez"),
    new Estudiante("0100000049","Gustavo","Chávez"),
    new Estudiante("0100000050","Patricia","Romero")
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
