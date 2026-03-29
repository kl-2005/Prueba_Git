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
    public partial class Form_Tutor : Form
    {
        public Form_Tutor()
        {
            InitializeComponent();
            MostrarTutor();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_RegistrarTutor_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            if (!ValidarCedulaUnica()) return;
            ValidarCedula10Digitos();
            AgregarEstudiante();

        }

        private void AgregarEstudiante()
        {
            DatosGlobales.Tutores.Add(new Tutor(textBox_CedulaTutor.Text, textBox_NombreTutor.Text, Convert.ToInt32(numericUpDown_CapacidadMaxima.Value),Convert.ToInt32(numericUpDown_CapacidadMaxima.Value)));
            MessageBox.Show("Tutor registrado correctamente");
            textBox_CedulaTutor.Text = "";
            textBox_NombreTutor.Text = "";
            numericUpDown_CapacidadMaxima.Value = 0;
            textBox_CedulaTutor.Focus();
            MostrarTutor();
        }

        private void MostrarTutor()
        {
            dataGridView_Tutor.DataSource = null;
            dataGridView_Tutor.DataSource = DatosGlobales.Tutores;
        }

        public bool ValidarCampos()
        {
            if (textBox_CedulaTutor.Text.Trim() == "" || textBox_NombreTutor.Text.Trim() == "")
            {
                MessageBox.Show("Valide que todos los campos esten llenos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool ValidarCedulaUnica()
        {
            foreach (var item in DatosGlobales.Tutores)
            {
                if (item.Cedula == textBox_CedulaTutor.Text)
                {
                    MessageBox.Show("Ya existe un estudiante con esa cédula", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_CedulaTutor.Clear();
                    textBox_NombreTutor.Clear();
                    numericUpDown_CapacidadMaxima.Value = 0;
                    textBox_CedulaTutor.Focus();
                    return false;
                }
            }
            return true;
        }

        private void textBox_CedulaTutor_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidarCedula10Digitos()
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("La cédula no puede estar vacía", "corriga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (textBox_CedulaTutor.Text.Length != 10)
            {
                MessageBox.Show("Ponga 10 dígitos", "corriga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (char item in textBox_CedulaTutor.Text)
            {
                if (!char.IsDigit(item))
                {
                    MessageBox.Show("la cedu debe ser solo numeros", "corrige", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;

                }
            }
            return true;
        }

        private void button_Buscar_Click(object sender, EventArgs e)  /// cambiar de estudiante a tutor
        {
            
            string cedula = textBox_CedulaEstudiantes.Text.Trim();

            if (cedula.Trim() == "" && !ValidarCedula10Digitos(cedula))
            {
                MessageBox.Show("InIngrese la cédula del estudiante a buscar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            bool encontrado = false;
            foreach (var item in DatosGlobales.Estudiantes)
            {
                if (item.Cedula == cedula)
                {
                    textBox_NombreEstudiantes.Text = item.Nombre;
                    textBox_ApellidosEstudiantes.Text = item.Apellido;

                    encontrado = true;
                    break;

                }
            }


            if (!encontrado)
            {
                MessageBox.Show("No se encontró ningún estudiante con esa cédula", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_NombreEstudiantes.Clear();
                textBox_ApellidosEstudiantes.Clear();
                textBox_CedulaEstudiantes.Focus();
            }
        }
    }
    
}
