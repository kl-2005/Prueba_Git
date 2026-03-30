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
                
                if (!DatosSistema.CoincidenciaCedula(textBox_CedulaTutor.Text))
                {
                    MessageBox.Show("La cédula ya existe en el sistema", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                AgregarTutor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar un tutor :  " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void AgregarTutor()
        {
            try
            {
                DatosSistema.Tutores.Add(new Tutor(textBox_CedulaTutor.Text, textBox_NombreTutor.Text,textBox_Apellido.Text, Convert.ToInt32(numericUpDown_CapacidadMaxima.Value), Convert.ToInt32(numericUpDown_CapacidadMaxima.Value)));
                MessageBox.Show("Tutor registrado correctamente","Exito",MessageBoxButtons.OK,MessageBoxIcon.Information);
                textBox_CedulaTutor.Text = "";
                textBox_NombreTutor.Text = "";
                numericUpDown_CapacidadMaxima.Value = 0;
                textBox_CedulaTutor.Focus();
                MostrarTutor();
            }
            catch(Exception e) 
            {
                    MessageBox.Show("Error al agregar el tutor: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarTutor()
        {
            dataGridView_Tutor.DataSource = null;
            dataGridView_Tutor.DataSource = DatosSistema.Tutores;
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
            foreach (var item in DatosSistema.Tutores)
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
                    MessageBox.Show("La cedula debe tener solo numeros", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;

                }
            }
            return true;
        }

        


        private void textBox_NombreTutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
                string buscar = textBox_Buscar.Text.Trim().ToLower();
                List<Tutor> listaFiltrada = new List<Tutor>();

                foreach (var tutor in DatosSistema.Tutores)
                {
                    string cedula = tutor.Cedula.ToLower();
                    string nombre = tutor.Nombre.ToLower();

                    if (cedula.Contains(buscar) || nombre.Contains(buscar))
                    {
                        listaFiltrada.Add(tutor);
                    }
                }

                dataGridView_Tutor.DataSource = null;
                dataGridView_Tutor.DataSource = listaFiltrada;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar el tutor: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
