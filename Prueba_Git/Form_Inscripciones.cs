using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba_Git
{
    public partial class Form_Inscripciones : Form
    {

        public Form_Inscripciones()
        {
            InitializeComponent();
            CargarEstudiantesComboBox();
            CargarTutoresComboBox();
            CargarHorariosComboBox();
        }

        private void CargarHorariosComboBox()
        {
            comboBox3.DataSource = null;
            comboBox3.DataSource = DatosGlobales.Horarios;
            comboBox3.DisplayMember = "HorarioCompleto";
        }

        private void MostrarTutorEstudiante()
        {
            if (!ValidarCampos()) return;

            dataGridView1.DataSource = null;

            Estudiante estudiante = (Estudiante)comboBox1.SelectedItem;
            Tutor tutor = (Tutor)comboBox2.SelectedItem;
            Horario horario = (Horario)comboBox3.SelectedItem;

            DatosGlobales.Inscripciones.Add(new Inscripcion(
                estudiante.NombreCompleto,
                tutor.Nombre,
                horario.Dia + " " + horario.Hora
            ));
            dataGridView1.DataSource = DatosGlobales.Inscripciones;

            var datos = from Tutor in DatosGlobales.Tutores
                        select new
                        {
                            Tutor = tutor.Nombre,
                            CuposTotales = tutor.Cupo_Disponible,
                            CuposDisponibles = tutor.Cupo_Disponible -
                                DatosGlobales.Inscripciones.Count(i => i.Tutor == tutor.Nombre)
                        };

            dataGridView_Inscripciones.DataSource = null;
            dataGridView_Inscripciones.DataSource = datos.ToList();
        }

        private bool ValidarCampos()
        {
            if (comboBox1.SelectedItem == null ||
                comboBox2.SelectedItem == null ||
                comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar todos los campos.");
                return false;
            }

            if (comboBox1.Text.Trim() == "" ||
                comboBox2.Text.Trim() == "" ||
                comboBox3.Text.Trim() == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos.");
                return false;
            }

            return true;
        }

        private void CargarTutoresComboBox()
        {
            comboBox2.DataSource = null;
            comboBox2.DataSource = DatosGlobales.Tutores;
            comboBox2.DisplayMember = "Nombre";
        }

        private void CargarEstudiantesComboBox()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = DatosGlobales.Estudiantes;
            comboBox1.DisplayMember = "NombreCompleto";
        }

       
      

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Incribir_Click(object sender, EventArgs e)
        {

        }

        private void button_Inscribir_Click(object sender, EventArgs e)
        {
            MostrarTutorEstudiante();
        }
    }
}
