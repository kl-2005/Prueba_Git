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
            RegistrarEstudiante();
        }

        private List<Estudiante> RegistrarEstudiante()
        {
            List<Estudiante> ListaEstudiantes = new List<Estudiante>();
            if(textBox_CedulaEstudiantes.Text.Trim() == "" || textBox_NombresEstudiantes.Text.Trim() == "")
                MessageBox.Show("Debe llenar los campos","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            Estudiante estudiante = new Estudiante(textBox_CedulaEstudiantes.Text,textBox_NombresEstudiantes.Text);
            ListaEstudiantes.Add(estudiante);

            return ListaEstudiantes;
        }
    }
}
