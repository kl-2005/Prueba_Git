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
            dataGridView1.DataSource = null;
            if (!ValidarCampos()) return;
            List<Inscripcion> listaInscripciones = new List<Inscripcion>();
            listaInscripciones.Add(new Inscripcion(combo, comboBox2);//me quede aqui, no se como agregar el estudiante y el tutor a la lista de inscripciones
                                                                     //, ya que no se como se llaman las propiedades del estudiante y del tutor, ni como se
                                                                     //relacionan con la clase inscripcion
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
    }
}
