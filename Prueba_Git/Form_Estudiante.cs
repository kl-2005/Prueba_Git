using System;
using System.Collections;
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
    public partial class Form_Estudiante : Form
    {
        public Form_Estudiante()
        {
            InitializeComponent();
            MostrarEstudiantes();
        }

        private void Form_Estudiantes_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_CedulaEstudiantes_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_ResgistrarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                if (!ValidarCedula10Digitos(textBox_CedulaEstudiantes.Text))
                    return;

                if (!ValidarCedulaUnica(textBox_CedulaEstudiantes.Text))
                    return;

                AgregarEstudiante();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un error : " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarEstudiante()
        {
            try
            {
                DatosGlobales.Estudiantes.Add(new Estudiante(textBox_CedulaEstudiantes.Text, textBox_NombreEstudiantes.Text, textBox_ApellidosEstudiantes.Text));
                MessageBox.Show("Estudiante registrado correctamente");
                textBox_CedulaEstudiantes.Clear();
                textBox_NombreEstudiantes.Clear();
                textBox_ApellidosEstudiantes.Clear();
                textBox_CedulaEstudiantes.Focus();
                MostrarEstudiantes();
            }
            catch (Exception e) 
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public bool ValidarCampos()
        {
            if (textBox_CedulaEstudiantes.Text.Trim() == "" || textBox_NombreEstudiantes.Text.Trim() == "" || textBox_ApellidosEstudiantes.Text.Trim() == "")
            {
                MessageBox.Show("Valide que todos los campos esten llenos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool ValidarCedulaUnica(string cedula)
        {
            foreach (var item in DatosGlobales.Estudiantes)
            {
                if (item.Cedula == cedula)
                {
                    MessageBox.Show("Ya existe un estudiante con esa cédula", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_CedulaEstudiantes.Clear();
                    textBox_NombreEstudiantes.Clear();
                    textBox_ApellidosEstudiantes.Clear();
                    textBox_CedulaEstudiantes.Focus();
                    return false;
                }
            }
            return true;
        }

        public void MostrarEstudiantes()
        {
            dataGridView_Estudiantes.DataSource = null;
            dataGridView_Estudiantes.DataSource = DatosGlobales.Estudiantes;
        }

        private bool ValidarCedula10Digitos(string cedula) 
        {
            if (cedula.Trim()=="") 
            {
                MessageBox.Show("La cédula no puede estar vacía", "corriga",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cedula.Length!=10)
            {

                MessageBox.Show("Ponga 10 dígitos","corriga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (char item in cedula)
            {
                if (!char.IsDigit(item))
                {
                    MessageBox.Show("la cedu debe ser solo numeros","corrige",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return false;

                }
            }
            return true;
        }



        private void dataGridView_Estudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_ApellidosEstudiantes_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string cedula = textBox_CedulaTutor.Text.Trim();

                if (cedula == "" || !ValidarCedula10Digitos(cedula))
                {
                    MessageBox.Show("Ingrese una cédula válida del Tutor a buscar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool encontrado = false;

                foreach (var item in DatosGlobales.Tutores)
                {
                    if (item.Cedula == cedula)
                    {
                        textBox_NombreTutor.Text = item.Nombre;
                        numericUpDown_CapacidadMaxima.Value = item.Cupo_Maximo;

                        encontrado = true;
                        break;
                    }
                }

                if (!encontrado)
                {
                    MessageBox.Show("No se encontró ningún Tutor con esa cédula", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_NombreTutor.Clear();
                    textBox_CedulaTutor.Clear();
                    numericUpDown_CapacidadMaxima.Value = 0;
                    textBox_CedulaTutor.Focus();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un error al buscar el tutor: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox_Estudiantes_Enter(object sender, EventArgs e)
        {

        }
    }
}
