namespace Prueba_Git
{
    partial class Form_Estudiante
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_ResgistrarEstudiante = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_CedulaEstudiantes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_Estudiantes = new System.Windows.Forms.GroupBox();
            this.textBox_Apellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.dataGridView_Estudiantes = new System.Windows.Forms.DataGridView();
            this.groupBox_Estudiantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Estudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ResgistrarEstudiante
            // 
            this.button_ResgistrarEstudiante.Location = new System.Drawing.Point(26, 226);
            this.button_ResgistrarEstudiante.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_ResgistrarEstudiante.Name = "button_ResgistrarEstudiante";
            this.button_ResgistrarEstudiante.Size = new System.Drawing.Size(65, 25);
            this.button_ResgistrarEstudiante.TabIndex = 0;
            this.button_ResgistrarEstudiante.Text = "Registrar";
            this.button_ResgistrarEstudiante.UseVisualStyleBackColor = true;
            this.button_ResgistrarEstudiante.Click += new System.EventHandler(this.button_ResgistrarEstudiante_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cedula";
            // 
            // textBox_CedulaEstudiantes
            // 
            this.textBox_CedulaEstudiantes.Location = new System.Drawing.Point(26, 57);
            this.textBox_CedulaEstudiantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_CedulaEstudiantes.Name = "textBox_CedulaEstudiantes";
            this.textBox_CedulaEstudiantes.Size = new System.Drawing.Size(68, 20);
            this.textBox_CedulaEstudiantes.TabIndex = 2;
            this.textBox_CedulaEstudiantes.TextChanged += new System.EventHandler(this.textBox_CedulaEstudiantes_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox_Estudiantes
            // 
            this.groupBox_Estudiantes.Controls.Add(this.textBox_Apellidos);
            this.groupBox_Estudiantes.Controls.Add(this.label3);
            this.groupBox_Estudiantes.Controls.Add(this.textBox_Nombre);
            this.groupBox_Estudiantes.Controls.Add(this.dataGridView_Estudiantes);
            this.groupBox_Estudiantes.Controls.Add(this.button_ResgistrarEstudiante);
            this.groupBox_Estudiantes.Controls.Add(this.label1);
            this.groupBox_Estudiantes.Controls.Add(this.label2);
            this.groupBox_Estudiantes.Controls.Add(this.textBox_CedulaEstudiantes);
            this.groupBox_Estudiantes.Location = new System.Drawing.Point(16, 18);
            this.groupBox_Estudiantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Estudiantes.Name = "groupBox_Estudiantes";
            this.groupBox_Estudiantes.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox_Estudiantes.Size = new System.Drawing.Size(509, 267);
            this.groupBox_Estudiantes.TabIndex = 5;
            this.groupBox_Estudiantes.TabStop = false;
            this.groupBox_Estudiantes.Text = "Estudiantes";
            // 
            // textBox_Apellidos
            // 
            this.textBox_Apellidos.Location = new System.Drawing.Point(27, 191);
            this.textBox_Apellidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Apellidos.Name = "textBox_Apellidos";
            this.textBox_Apellidos.Size = new System.Drawing.Size(68, 20);
            this.textBox_Apellidos.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellidos";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(27, 136);
            this.textBox_Nombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(68, 20);
            this.textBox_Nombre.TabIndex = 6;
            // 
            // dataGridView_Estudiantes
            // 
            this.dataGridView_Estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Estudiantes.Location = new System.Drawing.Point(202, 16);
            this.dataGridView_Estudiantes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_Estudiantes.Name = "dataGridView_Estudiantes";
            this.dataGridView_Estudiantes.RowHeadersWidth = 62;
            this.dataGridView_Estudiantes.RowTemplate.Height = 28;
            this.dataGridView_Estudiantes.Size = new System.Drawing.Size(263, 218);
            this.dataGridView_Estudiantes.TabIndex = 5;
            // 
            // Form_Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.groupBox_Estudiantes);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Estudiante";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form_Estudiantes_Load);
            this.groupBox_Estudiantes.ResumeLayout(false);
            this.groupBox_Estudiantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Estudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_ResgistrarEstudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_CedulaEstudiantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox_Estudiantes;
        private System.Windows.Forms.DataGridView dataGridView_Estudiantes;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Apellidos;
        private System.Windows.Forms.Label label3;
    }
}