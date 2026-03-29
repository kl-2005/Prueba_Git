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
          

            try
            {
                if (!ValidarCampos())
                    return;

                if (!ValidarCedula10Digitos(textBox_CedulaTutor.Text))
                    return;

                if (!ValidarCedulaUnica())
                    return;
                if (!CoincidenciasCedulaEstudianteTutor(textBox_CedulaTutor.Text))
                    return;
                AgregarTutor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error:  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AgregarTutor()
        {
            try
            {
                DatosGlobales.Tutores.Add(new Tutor(textBox_CedulaTutor.Text, textBox_NombreTutor.Text,textBox_Apellido.Text, Convert.ToInt32(numericUpDown_CapacidadMaxima.Value), Convert.ToInt32(numericUpDown_CapacidadMaxima.Value)));
                MessageBox.Show("Tutor registrado correctamente");
                textBox_CedulaTutor.Text = "";
                textBox_NombreTutor.Text = "";
                numericUpDown_CapacidadMaxima.Value = 0;
                textBox_CedulaTutor.Focus();
                MostrarTutor();
            }
            catch(Exception e) 
            {
                
                    MessageBox.Show("Error al agregar el tutor: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


             }
        }

        private void MostrarTutor()
        {
            dataGridView_Tutor.DataSource = null;
            dataGridView_Tutor.DataSource = DatosGlobales.Tutores;
        }

        public bool ValidarCampos()
        {
            if (textBox_CedulaTutor.Text.Trim() == ""|| textBox_Apellido.Text.Trim() == "" || textBox_NombreTutor.Text.Trim() == "" || numericUpDown_CapacidadMaxima.Value==0)
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
                    MessageBox.Show("Ya existe un tutor con esa cédula", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_CedulaTutor.Clear();
                    textBox_NombreTutor.Clear();
                    textBox_Apellido.Clear();
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

        private bool ValidarCedula10Digitos(string cedula)
        {
            if (cedula.Trim()=="")
            {
                MessageBox.Show("El campo de la cedula no puede estar vacio", "validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (textBox_CedulaTutor.Text.Length != 10)
            {
                MessageBox.Show("Ingrese 10 dígitos en la cedula", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            foreach (char item in textBox_CedulaTutor.Text)
            {
                if (!char.IsDigit(item))
                {
                    MessageBox.Show("la cedula debe tener solo numeros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;

                }
            }
            return true;
        }

        private void button_Buscar_Click(object sender, EventArgs e)  
        {

            try
            {
                string cedula = textBox_CedulaTutor.Text.Trim();

                if (cedula == "" && !ValidarCedula10Digitos(cedula))
                {
                    MessageBox.Show("Ingrese la cédula del Tutor a buscar", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    textBox_CedulaTutor.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBox_NombreTutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        public bool CoincidenciasCedulaEstudianteTutor(string cedula)
        {
            try
            {
                foreach (var est in DatosGlobales.Estudiantes)
                {
                    if (cedula == est.Cedula)
                    {
                        MessageBox.Show("La cédula del tutor coincide con la del estudiante", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dataGridView_Tutor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_Tutor_Load(object sender, EventArgs e)
        {

        }

        private void textBox_Buscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string filtro = textBox_Buscar.Text.Trim().ToLower();
                List<Tutor> listaFiltrada = new List<Tutor>();

                foreach (var tutor in DatosGlobales.Tutores)
                {
                    string cedula = tutor.Cedula.ToLower();
                    string nombre = tutor.Nombre.ToLower();

                    if (cedula.Contains(filtro) || nombre.Contains(filtro))
                    {
                        listaFiltrada.Add(tutor);
                    }
                }

                dataGridView_Tutor.DataSource = null;
                dataGridView_Tutor.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
