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
        }

        private void CargarDiasInscripcion()
        {
            comboBox_Dia.Items.Add(new String[] { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes" });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
