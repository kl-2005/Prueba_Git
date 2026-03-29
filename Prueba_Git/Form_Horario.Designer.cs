namespace Prueba_Git
{
    partial class Form_Horario
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Aula = new System.Windows.Forms.TextBox();
            this.comboBox_Hora = new System.Windows.Forms.ComboBox();
            this.comboBox_Dia = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_RegistrarHorario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox_Aula);
            this.groupBox1.Controls.Add(this.comboBox_Hora);
            this.groupBox1.Controls.Add(this.comboBox_Dia);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.button_RegistrarHorario);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(517, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "horarios registrados";
            // 
            // textBox_Aula
            // 
            this.textBox_Aula.Location = new System.Drawing.Point(113, 101);
            this.textBox_Aula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_Aula.Name = "textBox_Aula";
            this.textBox_Aula.Size = new System.Drawing.Size(82, 20);
            this.textBox_Aula.TabIndex = 10;
            // 
            // comboBox_Hora
            // 
            this.comboBox_Hora.FormattingEnabled = true;
            this.comboBox_Hora.Location = new System.Drawing.Point(113, 70);
            this.comboBox_Hora.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Hora.Name = "comboBox_Hora";
            this.comboBox_Hora.Size = new System.Drawing.Size(82, 21);
            this.comboBox_Hora.TabIndex = 9;
            // 
            // comboBox_Dia
            // 
            this.comboBox_Dia.FormattingEnabled = true;
            this.comboBox_Dia.Location = new System.Drawing.Point(113, 40);
            this.comboBox_Dia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Dia.Name = "comboBox_Dia";
            this.comboBox_Dia.Size = new System.Drawing.Size(82, 21);
            this.comboBox_Dia.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(211, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(285, 215);
            this.dataGridView1.TabIndex = 7;
            // 
            // button_RegistrarHorario
            // 
            this.button_RegistrarHorario.Location = new System.Drawing.Point(53, 149);
            this.button_RegistrarHorario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_RegistrarHorario.Name = "button_RegistrarHorario";
            this.button_RegistrarHorario.Size = new System.Drawing.Size(63, 25);
            this.button_RegistrarHorario.TabIndex = 6;
            this.button_RegistrarHorario.Text = "Registrar";
            this.button_RegistrarHorario.UseVisualStyleBackColor = true;
            this.button_RegistrarHorario.Click += new System.EventHandler(this.button_RegistrarHorario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aula\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hora\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dia";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form_Horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_Horario";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_RegistrarHorario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Hora;
        private System.Windows.Forms.ComboBox comboBox_Dia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Aula;
    }
}