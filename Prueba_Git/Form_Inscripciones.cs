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
        }

        private void MostrarTutorEstudiante()
        {
            if (!ValidarCampos()) return;
            dataGridView1.DataSource = null;
            List<Inscripcion> listaInscripciones = new List<Inscripcion>();
            listaInscripciones.Add(new Inscripcion(comboBox1.SelectedItem.ToString(),comboBox2.SelectedItem.ToString()));
            dataGridView1.DataSource = listaInscripciones;
        }

        private bool ValidarCampos()
        {
            if (comboBox2.SelectedItem.ToString() == "" || comboBox1.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Debe seleccionar un tutor y un estudiante para mostrar la información.");
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

        private void button_Agregar_Click(object sender, EventArgs e)
        {
            MostrarTutorEstudiante();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
