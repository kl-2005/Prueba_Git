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

       
        private void dataGridView_Estudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_ApellidosEstudiantes_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_Estudiantes_Enter(object sender, EventArgs e)
        {

        }

    

        private void pictureBox1_Click(object sender, EventArgs e)
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
                if (!DatosSistema.CoincidenciaCedula(textBox_CedulaEstudiantes.Text))
                {
                    MessageBox.Show("La cédula ya existe en el sistema", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AgregarEstudiante();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el estudiante: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AgregarEstudiante()
        {
            try
            {
                DatosSistema.Estudiantes.Add(new Estudiante(textBox_CedulaEstudiantes.Text, textBox_NombreEstudiantes.Text, textBox_ApellidosEstudiantes.Text));
                MessageBox.Show("Estudiante registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_CedulaEstudiantes.Clear();
                textBox_NombreEstudiantes.Clear();
                textBox_ApellidosEstudiantes.Clear();
                textBox_CedulaEstudiantes.Focus();
                MostrarEstudiantes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar al estudiante : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            foreach (var item in DatosSistema.Estudiantes)
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
            dataGridView_Estudiantes.DataSource = DatosSistema.Estudiantes;
        }

        private bool ValidarCedula10Digitos(string cedula)
        {
            if (cedula.Trim() == "")
            {
                MessageBox.Show("El campo de la cedula no puede estar vacia", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cedula.Length != 10)
            {

                MessageBox.Show("La cedula debe tener 10 digitos", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (char item in cedula)
            {
                if (!char.IsDigit(item))
                {
                    MessageBox.Show("la cedula debe tener solo numeros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;

                }
            }
            return true;
        }



        private void textBox_Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string buscar = textBox_Buscar.Text.Trim().ToLower();
                List<Estudiante> listaFiltrada = new List<Estudiante>();

                foreach (var estudiantes in DatosSistema.Estudiantes)
                {
                    string cedula = estudiantes.Cedula.ToLower();
                    string nombre = estudiantes.Nombre.ToLower();

                    if (cedula.Contains(buscar) || nombre.Contains(buscar))
                    {
                        listaFiltrada.Add(estudiantes);
                    }
                }

                dataGridView_Estudiantes.DataSource = null;
                dataGridView_Estudiantes.DataSource = listaFiltrada;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar los datos del estudiante : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
