namespace practicaFinal
{
    partial class FormAgendamiento
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Label_Agendar_Cita = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Button_Guardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RichTextBox_Descrip = new System.Windows.Forms.RichTextBox();
            this.Label_Descrip = new System.Windows.Forms.Label();
            this.TextBox_Asunto = new System.Windows.Forms.TextBox();
            this.Label_Asunto = new System.Windows.Forms.Label();
            this.ComboBox_Profesor = new System.Windows.Forms.ComboBox();
            this.Label_Docente = new System.Windows.Forms.Label();
            this.ComboBox_Hora = new System.Windows.Forms.ComboBox();
            this.Label_Hora = new System.Windows.Forms.Label();
            this.DateTime_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Label_Fecha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Label_Nombre_Estudiante = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Label_Agendar_Cita);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 88);
            this.panel2.TabIndex = 0;
            // 
            // Label_Agendar_Cita
            // 
            this.Label_Agendar_Cita.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Agendar_Cita.AutoSize = true;
            this.Label_Agendar_Cita.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Label_Agendar_Cita.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Agendar_Cita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.Label_Agendar_Cita.Location = new System.Drawing.Point(260, 19);
            this.Label_Agendar_Cita.Name = "Label_Agendar_Cita";
            this.Label_Agendar_Cita.Size = new System.Drawing.Size(305, 55);
            this.Label_Agendar_Cita.TabIndex = 2;
            this.Label_Agendar_Cita.Text = "Agendar Cita";
            this.Label_Agendar_Cita.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 523);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Button_Guardar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 463);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 60);
            this.panel3.TabIndex = 4;
            // 
            // Button_Guardar
            // 
            this.Button_Guardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Button_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Guardar.ForeColor = System.Drawing.Color.Transparent;
            this.Button_Guardar.Image = global::practicaFinal.Properties.Resources.guardar;
            this.Button_Guardar.Location = new System.Drawing.Point(725, 0);
            this.Button_Guardar.Name = "Button_Guardar";
            this.Button_Guardar.Size = new System.Drawing.Size(75, 60);
            this.Button_Guardar.TabIndex = 0;
            this.Button_Guardar.UseVisualStyleBackColor = true;
            this.Button_Guardar.Click += new System.EventHandler(this.Button_Guardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.RichTextBox_Descrip);
            this.groupBox1.Controls.Add(this.Label_Descrip);
            this.groupBox1.Controls.Add(this.TextBox_Asunto);
            this.groupBox1.Controls.Add(this.Label_Asunto);
            this.groupBox1.Controls.Add(this.ComboBox_Profesor);
            this.groupBox1.Controls.Add(this.Label_Docente);
            this.groupBox1.Controls.Add(this.ComboBox_Hora);
            this.groupBox1.Controls.Add(this.Label_Hora);
            this.groupBox1.Controls.Add(this.DateTime_Fecha);
            this.groupBox1.Controls.Add(this.Label_Fecha);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Label_Nombre_Estudiante);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 435);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // RichTextBox_Descrip
            // 
            this.RichTextBox_Descrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RichTextBox_Descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RichTextBox_Descrip.Location = new System.Drawing.Point(240, 278);
            this.RichTextBox_Descrip.Name = "RichTextBox_Descrip";
            this.RichTextBox_Descrip.Size = new System.Drawing.Size(346, 80);
            this.RichTextBox_Descrip.TabIndex = 12;
            this.RichTextBox_Descrip.Text = "";
            // 
            // Label_Descrip
            // 
            this.Label_Descrip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Descrip.AutoSize = true;
            this.Label_Descrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Descrip.Location = new System.Drawing.Point(237, 258);
            this.Label_Descrip.Name = "Label_Descrip";
            this.Label_Descrip.Size = new System.Drawing.Size(75, 16);
            this.Label_Descrip.TabIndex = 11;
            this.Label_Descrip.Text = "Descipción";
            // 
            // TextBox_Asunto
            // 
            this.TextBox_Asunto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox_Asunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Asunto.Location = new System.Drawing.Point(240, 222);
            this.TextBox_Asunto.Name = "TextBox_Asunto";
            this.TextBox_Asunto.Size = new System.Drawing.Size(346, 26);
            this.TextBox_Asunto.TabIndex = 10;
            this.TextBox_Asunto.Tag = "";
            // 
            // Label_Asunto
            // 
            this.Label_Asunto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Asunto.AutoSize = true;
            this.Label_Asunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Asunto.Location = new System.Drawing.Point(237, 203);
            this.Label_Asunto.Name = "Label_Asunto";
            this.Label_Asunto.Size = new System.Drawing.Size(48, 16);
            this.Label_Asunto.TabIndex = 9;
            this.Label_Asunto.Text = "Asunto";
            // 
            // ComboBox_Profesor
            // 
            this.ComboBox_Profesor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBox_Profesor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Profesor.FormattingEnabled = true;
            this.ComboBox_Profesor.Items.AddRange(new object[] {
            "Yaned Larrea Cardona"});
            this.ComboBox_Profesor.Location = new System.Drawing.Point(240, 165);
            this.ComboBox_Profesor.Name = "ComboBox_Profesor";
            this.ComboBox_Profesor.Size = new System.Drawing.Size(346, 28);
            this.ComboBox_Profesor.TabIndex = 8;
            // 
            // Label_Docente
            // 
            this.Label_Docente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Docente.AutoSize = true;
            this.Label_Docente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Docente.Location = new System.Drawing.Point(237, 145);
            this.Label_Docente.Name = "Label_Docente";
            this.Label_Docente.Size = new System.Drawing.Size(58, 16);
            this.Label_Docente.TabIndex = 7;
            this.Label_Docente.Text = "Docente";
            // 
            // ComboBox_Hora
            // 
            this.ComboBox_Hora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBox_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox_Hora.FormattingEnabled = true;
            this.ComboBox_Hora.Location = new System.Drawing.Point(440, 107);
            this.ComboBox_Hora.Name = "ComboBox_Hora";
            this.ComboBox_Hora.Size = new System.Drawing.Size(146, 28);
            this.ComboBox_Hora.TabIndex = 6;
            // 
            // Label_Hora
            // 
            this.Label_Hora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Hora.AutoSize = true;
            this.Label_Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Hora.Location = new System.Drawing.Point(437, 87);
            this.Label_Hora.Name = "Label_Hora";
            this.Label_Hora.Size = new System.Drawing.Size(37, 16);
            this.Label_Hora.TabIndex = 5;
            this.Label_Hora.Text = "Hora";
            // 
            // DateTime_Fecha
            // 
            this.DateTime_Fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTime_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime_Fecha.Location = new System.Drawing.Point(240, 107);
            this.DateTime_Fecha.Name = "DateTime_Fecha";
            this.DateTime_Fecha.Size = new System.Drawing.Size(187, 22);
            this.DateTime_Fecha.TabIndex = 4;
            // 
            // Label_Fecha
            // 
            this.Label_Fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Fecha.AutoSize = true;
            this.Label_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Fecha.Location = new System.Drawing.Point(237, 87);
            this.Label_Fecha.Name = "Label_Fecha";
            this.Label_Fecha.Size = new System.Drawing.Size(45, 16);
            this.Label_Fecha.TabIndex = 3;
            this.Label_Fecha.Text = "Fecha";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(240, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(346, 26);
            this.textBox1.TabIndex = 1;
            this.textBox1.Tag = "";
            // 
            // Label_Nombre_Estudiante
            // 
            this.Label_Nombre_Estudiante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Nombre_Estudiante.AutoSize = true;
            this.Label_Nombre_Estudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nombre_Estudiante.Location = new System.Drawing.Point(237, 31);
            this.Label_Nombre_Estudiante.Name = "Label_Nombre_Estudiante";
            this.Label_Nombre_Estudiante.Size = new System.Drawing.Size(122, 16);
            this.Label_Nombre_Estudiante.TabIndex = 2;
            this.Label_Nombre_Estudiante.Text = "Nombre Estudiante";
            // 
            // FormAgendamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAgendamiento";
            this.Text = "Agendamiento";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Label_Nombre_Estudiante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Label_Fecha;
        private System.Windows.Forms.Label Label_Hora;
        private System.Windows.Forms.DateTimePicker DateTime_Fecha;
        private System.Windows.Forms.ComboBox ComboBox_Profesor;
        private System.Windows.Forms.Label Label_Docente;
        private System.Windows.Forms.ComboBox ComboBox_Hora;
        private System.Windows.Forms.Label Label_Asunto;
        private System.Windows.Forms.Label Label_Descrip;
        private System.Windows.Forms.TextBox TextBox_Asunto;
        private System.Windows.Forms.RichTextBox RichTextBox_Descrip;
        private System.Windows.Forms.Label Label_Agendar_Cita;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Button_Guardar;
    }
}