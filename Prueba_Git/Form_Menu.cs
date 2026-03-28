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
    public partial class Form_Principal : Form
    {
        public Form_Principal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_Horario venta_horario= new Form_Horario();
            venta_horario.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_Estudiante venta_estudiante=new Form_Estudiante();
            venta_estudiante.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_Tutor venta_Tutor = new Form_Tutor();
            venta_Tutor.ShowDialog();
        }
    }
}
