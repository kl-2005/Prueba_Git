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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown_CapacidadMaxima = new System.Windows.Forms.NumericUpDown();
            this.dataGridView_Tutor = new System.Windows.Forms.DataGridView();
            this.button_RegistrarTutor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_NombreTutor = new System.Windows.Forms.TextBox();
            this.textBox_CedulaTutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Buscar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CapacidadMaxima)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tutor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_Buscar);
            this.groupBox1.Controls.Add(this.numericUpDown_CapacidadMaxima);
            this.groupBox1.Controls.Add(this.dataGridView_Tutor);
            this.groupBox1.Controls.Add(this.button_RegistrarTutor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_NombreTutor);
            this.groupBox1.Controls.Add(this.textBox_CedulaTutor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(768, 652);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tutor";
            // 
            // numericUpDown_CapacidadMaxima
            // 
            this.numericUpDown_CapacidadMaxima.Location = new System.Drawing.Point(190, 175);
            this.numericUpDown_CapacidadMaxima.Name = "numericUpDown_CapacidadMaxima";
            this.numericUpDown_CapacidadMaxima.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown_CapacidadMaxima.TabIndex = 13;
            // 
            // dataGridView_Tutor
            // 
            this.dataGridView_Tutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Tutor.Location = new System.Drawing.Point(26, 272);
            this.dataGridView_Tutor.Name = "dataGridView_Tutor";
            this.dataGridView_Tutor.RowHeadersWidth = 62;
            this.dataGridView_Tutor.RowTemplate.Height = 28;
            this.dataGridView_Tutor.Size = new System.Drawing.Size(507, 349);
            this.dataGridView_Tutor.TabIndex = 8;
            // 
            // button_RegistrarTutor
            // 
            this.button_RegistrarTutor.Location = new System.Drawing.Point(347, 169);
            this.button_RegistrarTutor.Name = "button_RegistrarTutor";
            this.button_RegistrarTutor.Size = new System.Drawing.Size(101, 34);
            this.button_RegistrarTutor.TabIndex = 7;
            this.button_RegistrarTutor.Text = "Registrar";
            this.button_RegistrarTutor.UseVisualStyleBackColor = true;
            this.button_RegistrarTutor.Click += new System.EventHandler(this.button_RegistrarTutor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "Capacidad maxima\r\n\r\n";
            // 
            // textBox_NombreTutor
            // 
            this.textBox_NombreTutor.Location = new System.Drawing.Point(304, 106);
            this.textBox_NombreTutor.Name = "textBox_NombreTutor";
            this.textBox_NombreTutor.Size = new System.Drawing.Size(206, 26);
            this.textBox_NombreTutor.TabIndex = 4;
            this.textBox_NombreTutor.TextChanged += new System.EventHandler(this.textBox_NombreTutor_TextChanged);
            // 
            // textBox_CedulaTutor
            // 
            this.textBox_CedulaTutor.Location = new System.Drawing.Point(44, 106);
            this.textBox_CedulaTutor.Name = "textBox_CedulaTutor";
            this.textBox_CedulaTutor.Size = new System.Drawing.Size(200, 26);
            this.textBox_CedulaTutor.TabIndex = 3;
            this.textBox_CedulaTutor.TextChanged += new System.EventHandler(this.textBox_CedulaTutor_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombres\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cedula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // button_Buscar
            // 
            this.button_Buscar.Location = new System.Drawing.Point(458, 169);
            this.button_Buscar.Name = "button_Buscar";
            this.button_Buscar.Size = new System.Drawing.Size(93, 34);
            this.button_Buscar.TabIndex = 14;
            this.button_Buscar.Text = "Buscar";
            this.button_Buscar.UseVisualStyleBackColor = true;
            this.button_Buscar.Click += new System.EventHandler(this.button_Buscar_Click);
            // 
            // Form_Tutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 694);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Tutor";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_CapacidadMaxima)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Tutor)).EndInit();
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
    }
}