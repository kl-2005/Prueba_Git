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
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox_CedulaTutor_TextChanged(object sender, EventArgs e)
        {

        }

        public bool ValidarCampos()
        {
            if (textBox_CedulaTutor.Text.Trim() == "" || textBox_NombreTutor.Text.Trim() == "")
            {
                MessageBox.Show("Valide que todos los campos esten llenos", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
