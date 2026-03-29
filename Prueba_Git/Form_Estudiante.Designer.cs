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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Estudiante));
            this.button_ResgistrarEstudiante = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_CedulaEstudiantes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_Estudiantes = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_Buscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ApellidosEstudiantes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_NombreEstudiantes = new System.Windows.Forms.TextBox();
            this.dataGridView_Estudiantes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox_Estudiantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Estudiantes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_ResgistrarEstudiante
            // 
            this.button_ResgistrarEstudiante.ForeColor = System.Drawing.Color.Black;
            this.button_ResgistrarEstudiante.Location = new System.Drawing.Point(122, 240);
            this.button_ResgistrarEstudiante.Name = "button_ResgistrarEstudiante";
            this.button_ResgistrarEstudiante.Size = new System.Drawing.Size(139, 40);
            this.button_ResgistrarEstudiante.TabIndex = 0;
            this.button_ResgistrarEstudiante.Text = "REGISTRAR";
            this.button_ResgistrarEstudiante.UseVisualStyleBackColor = true;
            this.button_ResgistrarEstudiante.Click += new System.EventHandler(this.button_ResgistrarEstudiante_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "CEDULA";
            // 
            // textBox_CedulaEstudiantes
            // 
            this.textBox_CedulaEstudiantes.Location = new System.Drawing.Point(147, 54);
            this.textBox_CedulaEstudiantes.Name = "textBox_CedulaEstudiantes";
            this.textBox_CedulaEstudiantes.Size = new System.Drawing.Size(206, 29);
            this.textBox_CedulaEstudiantes.TabIndex = 2;
            this.textBox_CedulaEstudiantes.TextChanged += new System.EventHandler(this.textBox_CedulaEstudiantes_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "NOMBRES";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox_Estudiantes
            // 
            this.groupBox_Estudiantes.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox_Estudiantes.Controls.Add(this.pictureBox1);
            this.groupBox_Estudiantes.Controls.Add(this.textBox_Buscar);
            this.groupBox_Estudiantes.Controls.Add(this.label4);
            this.groupBox_Estudiantes.Controls.Add(this.textBox_ApellidosEstudiantes);
            this.groupBox_Estudiantes.Controls.Add(this.label3);
            this.groupBox_Estudiantes.Controls.Add(this.textBox_NombreEstudiantes);
            this.groupBox_Estudiantes.Controls.Add(this.button_ResgistrarEstudiante);
            this.groupBox_Estudiantes.Controls.Add(this.label1);
            this.groupBox_Estudiantes.Controls.Add(this.label2);
            this.groupBox_Estudiantes.Controls.Add(this.textBox_CedulaEstudiantes);
            this.groupBox_Estudiantes.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Estudiantes.ForeColor = System.Drawing.Color.White;
            this.groupBox_Estudiantes.Location = new System.Drawing.Point(27, 30);
            this.groupBox_Estudiantes.Name = "groupBox_Estudiantes";
            this.groupBox_Estudiantes.Size = new System.Drawing.Size(707, 311);
            this.groupBox_Estudiantes.TabIndex = 5;
            this.groupBox_Estudiantes.TabStop = false;
            this.groupBox_Estudiantes.Text = "DATOS DEL ESTUDIANTES";
            this.groupBox_Estudiantes.Enter += new System.EventHandler(this.groupBox_Estudiantes_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Prueba_Git.Properties.Resources.read;
            this.pictureBox1.Location = new System.Drawing.Point(447, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_Buscar
            // 
            this.textBox_Buscar.Location = new System.Drawing.Point(481, 247);
            this.textBox_Buscar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textBox_Buscar.Name = "textBox_Buscar";
            this.textBox_Buscar.Size = new System.Drawing.Size(203, 29);
            this.textBox_Buscar.TabIndex = 11;
            this.textBox_Buscar.TextChanged += new System.EventHandler(this.textBox_Buscar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "FILTRAR :";
            // 
            // textBox_ApellidosEstudiantes
            // 
            this.textBox_ApellidosEstudiantes.Location = new System.Drawing.Point(147, 172);
            this.textBox_ApellidosEstudiantes.Name = "textBox_ApellidosEstudiantes";
            this.textBox_ApellidosEstudiantes.Size = new System.Drawing.Size(206, 29);
            this.textBox_ApellidosEstudiantes.TabIndex = 8;
            this.textBox_ApellidosEstudiantes.TextChanged += new System.EventHandler(this.textBox_ApellidosEstudiantes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "APELLIDOS";
            // 
            // textBox_NombreEstudiantes
            // 
            this.textBox_NombreEstudiantes.Location = new System.Drawing.Point(147, 114);
            this.textBox_NombreEstudiantes.Name = "textBox_NombreEstudiantes";
            this.textBox_NombreEstudiantes.Size = new System.Drawing.Size(206, 29);
            this.textBox_NombreEstudiantes.TabIndex = 6;
            // 
            // dataGridView_Estudiantes
            // 
            this.dataGridView_Estudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Estudiantes.Location = new System.Drawing.Point(32, 45);
            this.dataGridView_Estudiantes.Name = "dataGridView_Estudiantes";
            this.dataGridView_Estudiantes.RowHeadersWidth = 62;
            this.dataGridView_Estudiantes.RowTemplate.Height = 28;
            this.dataGridView_Estudiantes.Size = new System.Drawing.Size(643, 223);
            this.dataGridView_Estudiantes.TabIndex = 5;
            this.dataGridView_Estudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Estudiantes_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Controls.Add(this.dataGridView_Estudiantes);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(27, 376);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(707, 294);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LISTA DE ESTUDIANTES REGISTRADOS";
            // 
            // Form_Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(799, 695);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Estudiantes);
            this.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Estudiante";
            this.Text = "Registro de Estudiantes";
            this.Load += new System.EventHandler(this.Form_Estudiantes_Load);
            this.groupBox_Estudiantes.ResumeLayout(false);
            this.groupBox_Estudiantes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Estudiantes)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBox_Buscar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}