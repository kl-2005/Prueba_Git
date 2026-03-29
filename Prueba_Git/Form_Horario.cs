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
            string[] diasTutorias = new String[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" };
            comboBox_Dia.Items.AddRange(diasTutorias);
        }

        private void CargarHorasTutorias()
        {
            string[] horasTutorias = new String[] { "8:00 - 9:00", "9:00 - 10:00", "10:00 - 11:00", "11:00 - 12:00", "12:00 - 13:00" };
            comboBox_Hora.Items.AddRange(horasTutorias);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_RegistrarHorario_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;
            GuardarHorario();
        }

        private bool ValidarCampos()
        {
            string Dia = comboBox_Dia.SelectedItem.ToString();
            string hora = comboBox_Hora.SelectedItem.ToString();
            if (Dia.Trim()=="" || hora.Trim()=="" || textBox_Aula.Text.Trim() == "")
            {
                MessageBox.Show("Valide que todos los campos esten llenos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void GuardarHorario()
        {
            string Dia = comboBox_Dia.SelectedItem.ToString();
            string hora = comboBox_Hora.SelectedItem.ToString();
            foreach (var item in DatosGlobales.Horarios)
            {
                if (item.Dia == Dia && item.Hora == hora){
                    MessageBox.Show("Ya existe un horario registrado para ese día y hora", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            DatosGlobales.Horarios.Add(new Horario(comboBox_Dia.SelectedItem.ToString(), comboBox_Hora.SelectedItem.ToString(), textBox_Aula.Text));
            MostrarHorario();
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
