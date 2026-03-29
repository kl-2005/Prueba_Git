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
            if (!ValidarCampos())
                return;

            if (!ValidarCedulaUnica(textBox_CedulaEstudiantes.Text))
                return;

            AgregarEstudiante();
        }

        private void AgregarEstudiante()
        {
            DatosGlobales.Estudiantes.Add(new Estudiante(textBox_CedulaEstudiantes.Text, textBox_NombreEstudiantes.Text, textBox_ApellidosEstudiantes.Text));
            MessageBox.Show("Estudiante registrado correctamente");
            textBox_CedulaEstudiantes.Text = "";
            textBox_NombreEstudiantes.Text = "";
            textBox_ApellidosEstudiantes.Text = "";
            textBox_CedulaEstudiantes.Focus();
            MostrarEstudiantes();
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
            if (!ValidarCampos(cedula)) 
            {
                MessageBox.Show("La cédula no puede estar vacía", "corriga",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cedula.Length!=10)
            {

                MessageBox.Show("Ponga 10 dígitos","corriga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false
            }

            foreach (char item in cedula)
            {
                if (!char.IsDigit(item))
                {
                    MessageBox.Show("la cedu debe ser solo numeros","corrige",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
        }


        private void dataGridView_Estudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_ApellidosEstudiantes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
