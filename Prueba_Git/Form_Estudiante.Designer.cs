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
            this.button_Buscar = new System.Windows.Forms.Button();
            this.textBox_ApellidosEstudiantes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_NombreEstudiantes = new System.Windows.Forms.TextBox();
            this.dataGridView_Estudiantes = new System.Windows.Forms.DataGridView();
            this.groupBox_Estudiantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Estudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // button_ResgistrarEstudiante
            // 
            this.button_ResgistrarEstudiante.Location = new System.Drawing.Point(39, 348);
            this.button_ResgistrarEstudiante.Name = "button_ResgistrarEstudiante";
            this.button_ResgistrarEstudiante.Size = new System.Drawing.Size(98, 38);
            this.button_ResgistrarEstudiante.TabIndex = 0;
            this.button_ResgistrarEstudiante.Text = "Registrar";
            this.button_ResgistrarEstudiante.UseVisualStyleBackColor = true;
            this.button_ResgistrarEstudiante.Click += new System.EventHandler(this.button_ResgistrarEstudiante_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cedula";
            // 
            // textBox_CedulaEstudiantes
            // 
            this.textBox_CedulaEstudiantes.Location = new System.Drawing.Point(39, 88);
            this.textBox_CedulaEstudiantes.Name = "textBox_CedulaEstudiantes";
            this.textBox_CedulaEstudiantes.Size = new System.Drawing.Size(100, 26);
            this.textBox_CedulaEstudiantes.TabIndex = 2;
            this.textBox_CedulaEstudiantes.TextChanged += new System.EventHandler(this.textBox_CedulaEstudiantes_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombres ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox_Estudiantes
            // 
            this.groupBox_Estudiantes.Controls.Add(this.button_Buscar);
            this.groupBox_Estudiantes.Controls.Add(this.textBox_ApellidosEstudiantes);
            this.groupBox_Estudiantes.Controls.Add(this.label3);
            this.groupBox_Estudiantes.Controls.Add(this.textBox_NombreEstudiantes);
            this.groupBox_Estudiantes.Controls.Add(this.dataGridView_Estudiantes);
            this.groupBox_Estudiantes.Controls.Add(this.button_ResgistrarEstudiante);
            this.groupBox_Estudiantes.Controls.Add(this.label1);
            this.groupBox_Estudiantes.Controls.Add(this.label2);
            this.groupBox_Estudiantes.Controls.Add(this.textBox_CedulaEstudiantes);
            this.groupBox_Estudiantes.Location = new System.Drawing.Point(24, 28);
            this.groupBox_Estudiantes.Name = "groupBox_Estudiantes";
            this.groupBox_Estudiantes.Size = new System.Drawing.Size(939, 603);
            this.groupBox_Estudiantes.TabIndex = 5;
            this.groupBox_Estudiantes.TabStop = false;
            this.groupBox_Estudiantes.Text = "Estudiantes";
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(161, 352);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(97, 34);
            this.button_Buscar.TabIndex = 9;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // textBox_ApellidosEstudiantes
            // 
            this.textBox_ApellidosEstudiantes.Location = new System.Drawing.Point(39, 279);
            this.textBox_ApellidosEstudiantes.Name = "textBox_ApellidosEstudiantes";
            this.textBox_ApellidosEstudiantes.Size = new System.Drawing.Size(100, 26);
            this.textBox_ApellidosEstudiantes.TabIndex = 8;
            this.textBox_ApellidosEstudiantes.TextChanged += new System.EventHandler(this.textBox_ApellidosEstudiantes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellidos";
            // 
            // textBox_NombreEstudiantes
            // 
            this.textBox_NombreEstudiantes.Location = new System.Drawing.Point(39, 184);
            this.textBox_NombreEstudiantes.Name = "textBox_NombreEstudiantes";
            this.textBox_NombreEstudiantes.Size = new System.Drawing.Size(100, 26);
            this.textBox_NombreEstudiantes.TabIndex = 6;
            // 
            // dataGridView_Estudiantes
            // 
            this.dataGridView_Estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Estudiantes.Location = new System.Drawing.Point(277, 61);
            this.dataGridView_Estudiantes.Name = "dataGridView_Estudiantes";
            this.dataGridView_Estudiantes.RowHeadersWidth = 62;
            this.dataGridView_Estudiantes.RowTemplate.Height = 28;
            this.dataGridView_Estudiantes.Size = new System.Drawing.Size(615, 397);
            this.dataGridView_Estudiantes.TabIndex = 5;
            this.dataGridView_Estudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Estudiantes_CellContentClick);
            // 
            // Form_Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 662);
            this.Controls.Add(this.groupBox_Estudiantes);
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
        private System.Windows.Forms.TextBox textBox_NombreEstudiantes;
        private System.Windows.Forms.TextBox textBox_ApellidosEstudiantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_Buscar;
    }
}