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
            ValidarcedulaUnica();
        }

        private bool ValidarcedulaUnica(string cedula) 
        { 
            foreach (var item in DatosGlobales.Estudiantes)
            { if (item.Cedula == cedula) 
                { 
                    MessageBox.Show("Ya existe un estudiante con esa cédula", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox_CedulaEstudiantes.Clear(); 
                    textBox_Nombre.Clear();
                    textBox_Apellidos.Clear();
                    textBox_CedulaEstudiantes.Focus(); 
                    return false; 
                }
            } return true;
        }

    }
}
