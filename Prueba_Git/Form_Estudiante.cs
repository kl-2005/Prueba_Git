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
            ValidarCamposEstudiantes();
        }

        private void textBox_NombresEstudiantes_TextChanged(object sender, EventArgs e)
        {

        }


        bool ValidarCamposEstudiantes() 
        {

            if (textBox_CedulaEstudiantes.Text.Trim() == "" || textBox_NombresEstudiantes.Trim() == "")
            {
                MessageBox.Show("Llene los campos del estudiantes a registrar",
                               "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Cantidad.Focus();
                return true;
            }
            return false;
        }
    }
}
