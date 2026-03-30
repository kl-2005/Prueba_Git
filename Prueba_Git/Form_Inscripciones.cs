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
            CargarTablas();
        }

       
        private void RegistrarInscripcion()
        {
            if (!ValidarCampos()) return;

            Estudiante estudiante = (Estudiante)comboBox1.SelectedItem;
            Tutor tutor = (Tutor)comboBox2.SelectedItem;
            Horario horario = (Horario)comboBox3.SelectedItem;

            string horarioSeleccionado = horario.Dia + " " + horario.Hora;

            bool yaInscrito = DatosSistema.Inscripciones.Any(i => i.Estudiante == estudiante.NombreCompleto);

            if (yaInscrito)
            {
                MessageBox.Show("Este estudiante ya está inscrito.");
                return;
            }

            int inscritos = DatosSistema.Inscripciones.Count(i => i.Tutor == tutor.Nombre);

            if (inscritos >= tutor.Cupo_Disponible)
            {
                MessageBox.Show("El tutor ya no tiene cupos disponibles.");
                return;
            }

            DatosSistema.Inscripciones.Add(new Inscripcion(
                estudiante.NombreCompleto,
                tutor.Nombre,
                horarioSeleccionado
            ));

            CargarTablas();
        }

        private void CargarTablas()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DatosSistema.Inscripciones;

            var datos = from t in DatosSistema.Tutores
                        select new
                        {
                            Tutor = t.Nombre,
                            CuposTotales = t.Cupo_Maximo,
                            CuposDisponibles = t.Cupo_Maximo -
                                DatosSistema.Inscripciones.Count(i => i.Tutor == t.Nombre)
                        };

            dataGridView_Inscripciones.DataSource = null;
            dataGridView_Inscripciones.DataSource = datos.ToList();
        }

        private bool ValidarCampos()
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null ||comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar todos los campos.");
                return false;
            }

            if (comboBox1.Text.Trim() == "" || comboBox2.Text.Trim() == "" ||comboBox3.Text.Trim() == "")
            {
                MessageBox.Show("Los campos no pueden estar vacíos.");
                return false;
            }

            return true;
        }

        private void CargarHorariosComboBox()
        {
            comboBox3.DataSource = null;
            comboBox3.DataSource = DatosSistema.Horarios;
            comboBox3.DisplayMember = "HorarioCompleto";
        }



        private void CargarTutoresComboBox()
        {
            comboBox2.DataSource = null;
            comboBox2.DataSource = DatosSistema.Tutores;
            comboBox2.DisplayMember = "NombresCompletosT";
        }

        private void CargarEstudiantesComboBox()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = DatosSistema.Estudiantes;
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
            RegistrarInscripcion();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Inscripciones_Load(object sender, EventArgs e)
        {

        }
    }
}
