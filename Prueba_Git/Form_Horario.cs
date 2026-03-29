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

        private void CargarDiasInscripcion()
        {
            string[] diasTutorias = new System.String[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            comboBox_Dia.Items.AddRange(diasTutorias);
        }

        private void CargarHorasTutorias()
        {
            string[] horasTutorias = new System.String[] { "8:00 - 9:00", "9:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "12:00 - 13:00" };
            comboBox_Hora.Items.AddRange(horasTutorias);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_RegistrarHorario_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidarCampos())
                    return;

                GuardarHorario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Error al validar los campos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void GuardarHorario()
        {
            try
            {
                string Dia = comboBox_Dia.SelectedItem.ToString();
                string hora = comboBox_Hora.SelectedItem.ToString();

                foreach (var item in DatosGlobales.Horarios)
                {
                    if (item.Dia == Dia && item.Hora == hora)
                    {
                        MessageBox.Show("Ya existe un horario registrado ", "Corriga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                DatosGlobales.Horarios.Add(new Horario(Dia, hora, textBox_Aula.Text));
                MostrarHorario();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarHorario()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DatosGlobales.Horarios;
        }

        private void comboBox_Dia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
