namespace Prueba_Git
{
    partial class Form_Tutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Tutor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_Buscar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.numericUpDown_CapacidadMaxima = new System.Windows.Forms.NumericUpDown();
            this.button_RegistrarTutor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_NombreTutor = new System.Windows.Forms.TextBox();
            this.textBox_CedulaTutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Tutor = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CapacidadMaxima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tutor)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.IndianRed;
            this.groupBox1.Controls.Add(this.textBox_Apellido);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox_Buscar);
            this.groupBox1.Controls.Add(this.button_Buscar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDown_CapacidadMaxima);
            this.groupBox1.Controls.Add(this.button_RegistrarTutor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_NombreTutor);
            this.groupBox1.Controls.Add(this.textBox_CedulaTutor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 300);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS DEL TUTOR";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Prueba_Git.Properties.Resources.teacher;
            this.pictureBox1.Location = new System.Drawing.Point(534, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_Buscar
            // 
            this.textBox_Buscar.Location = new System.Drawing.Point(562, 219);
            this.textBox_Buscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox_Buscar.Name = "textBox_Buscar";
            this.textBox_Buscar.Size = new System.Drawing.Size(213, 29);
            this.textBox_Buscar.TabIndex = 16;
            this.textBox_Buscar.TextChanged += new System.EventHandler(this.textBox_Buscar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(464, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "FILTRAR :";
            // 
            // button_Buscar
            // 
            this.button_Buscar.ForeColor = System.Drawing.Color.Black;
            this.button_Buscar.Location = new System.Drawing.Point(314, 237);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(103, 36);
            this.button_Buscar.TabIndex = 14;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // numericUpDown_CapacidadMaxima
            // 
            this.numericUpDown_CapacidadMaxima.Location = new System.Drawing.Point(239, 183);
            this.numericUpDown_CapacidadMaxima.Name = "numericUpDown_CapacidadMaxima";
            this.numericUpDown_CapacidadMaxima.Size = new System.Drawing.Size(133, 29);
            this.numericUpDown_CapacidadMaxima.TabIndex = 13;
            // 
            // button_RegistrarTutor
            // 
            this.button_RegistrarTutor.ForeColor = System.Drawing.Color.Black;
            this.button_RegistrarTutor.Location = new System.Drawing.Point(147, 237);
            this.button_RegistrarTutor.Name = "button_RegistrarTutor";
            this.button_RegistrarTutor.Size = new System.Drawing.Size(133, 36);
            this.button_RegistrarTutor.TabIndex = 7;
            this.button_RegistrarTutor.Text = "REGISTRAR";
            this.button_RegistrarTutor.UseVisualStyleBackColor = true;
            this.button_RegistrarTutor.Click += new System.EventHandler(this.button_RegistrarTutor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(30, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "CUPO MAXIMO";
            // 
            // textBox_NombreTutor
            // 
            this.textBox_NombreTutor.Location = new System.Drawing.Point(239, 88);
            this.textBox_NombreTutor.Name = "textBox_NombreTutor";
            this.textBox_NombreTutor.Size = new System.Drawing.Size(213, 29);
            this.textBox_NombreTutor.TabIndex = 4;
            this.textBox_NombreTutor.TextChanged += new System.EventHandler(this.textBox_NombreTutor_TextChanged);
            // 
            // textBox_CedulaTutor
            // 
            this.textBox_CedulaTutor.Location = new System.Drawing.Point(239, 42);
            this.textBox_CedulaTutor.Name = "textBox_CedulaTutor";
            this.textBox_CedulaTutor.Size = new System.Drawing.Size(213, 29);
            this.textBox_CedulaTutor.TabIndex = 3;
            this.textBox_CedulaTutor.TextChanged += new System.EventHandler(this.textBox_CedulaTutor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(30, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "NOMBRE \r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "CEDULA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 0;
            // 
            // dataGridView_Tutor
            // 
            this.dataGridView_Tutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tutor.Location = new System.Drawing.Point(18, 44);
            this.dataGridView_Tutor.Name = "dataGridView_Tutor";
            this.dataGridView_Tutor.RowHeadersWidth = 62;
            this.dataGridView_Tutor.RowTemplate.Height = 28;
            this.dataGridView_Tutor.Size = new System.Drawing.Size(764, 309);
            this.dataGridView_Tutor.TabIndex = 8;
            this.dataGridView_Tutor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Tutor_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dataGridView_Tutor);
            this.groupBox2.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(13, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(821, 383);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LISTA DE TUTORES REGISTRADOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "APELLIDO";
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(239, 135);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(213, 29);
            this.textBox_Apellido.TabIndex = 19;
            this.textBox_Apellido.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form_Tutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(863, 742);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Maiandra GD", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Tutor";
            this.Text = "Registro de Tutores";
            this.Load += new System.EventHandler(this.Form_Tutor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CapacidadMaxima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tutor)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_NombreTutor;
        private System.Windows.Forms.TextBox textBox_CedulaTutor;
        private System.Windows.Forms.DataGridView dataGridView_Tutor;
        private System.Windows.Forms.Button button_RegistrarTutor;
        private System.Windows.Forms.NumericUpDown numericUpDown_CapacidadMaxima;
        private System.Windows.Forms.Button button_Buscar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Buscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.Label label6;
    }
}