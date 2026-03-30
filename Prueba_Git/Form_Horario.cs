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
    public partial class Form_Horario : Form
    {
        public Form_Horario()
        {
            InitializeComponent();
            CargarDiasInscripcion();
            CargarHorasTutorias();
            MostrarHorario();
        }

     
        private void label1_Click(object sender, EventArgs e)
        {

        }
      

        private void comboBox_Dia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_Hora_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CargarDiasInscripcion()
        {
            string[] diasTutorias = new System.String[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            comboBox_Dia.Items.AddRange(diasTutorias);
        }

        private void CargarHorasTutorias()
        {
            string[] horasTutorias = { "8:00 - 9:00", "9:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "12:00 - 13:00", "14:00 - 15:00", "15:00 - 16:00", "16:00 - 17:00", "17:00 - 18:00", "18:00 - 19:00", "19:00 - 20:00" };
            comboBox_Hora.Items.AddRange(horasTutorias);
        }
        private void button_RegistrarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                GuardarHorario();
                MessageBox.Show("Horario registrado correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al registrar el horario : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidarCampos()
        {
            try
            {
                if (comboBox_Dia.SelectedItem == null || comboBox_Hora.SelectedItem == null || string.IsNullOrWhiteSpace(textBox_Aula.Text))
                {
                    MessageBox.Show("Valide que todos los campos estén llenos", "Corriga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al validar los campos del horario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void GuardarHorario()
        {
            try
            {
                string Dia = comboBox_Dia.SelectedItem.ToString();
                string hora = comboBox_Hora.SelectedItem.ToString();

                foreach (var item in DatosSistema.Horarios)
                {
                    if (item.Dia == Dia && item.Hora == hora)
                    {
                        MessageBox.Show("Ya existe un horario registrado ", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                DatosSistema.Horarios.Add(new Horario(Dia, hora, textBox_Aula.Text));
                MostrarHorario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar horario : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MostrarHorario()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DatosSistema.Horarios;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Horario_Load(object sender, EventArgs e)
        {

        }
    }
}
