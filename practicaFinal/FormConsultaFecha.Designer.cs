namespace practicaFinal
{
    partial class FormConsultaFecha
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label_Consultar_Fecha = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Data_Consulta_Fecha = new System.Windows.Forms.DataGridView();
            this.GroupBox_Buscar = new System.Windows.Forms.GroupBox();
            this.Button_Buscar = new System.Windows.Forms.Button();
            this.DateTime_Seleccionar_Fecha = new System.Windows.Forms.DateTimePicker();
            this.Label_Seleccionar = new System.Windows.Forms.Label();
            this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Consulta_Fecha)).BeginInit();
            this.GroupBox_Buscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_Consultar_Fecha
            // 
            this.Label_Consultar_Fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Consultar_Fecha.AutoSize = true;
            this.Label_Consultar_Fecha.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Label_Consultar_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Consultar_Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.Label_Consultar_Fecha.Location = new System.Drawing.Point(178, 20);
            this.Label_Consultar_Fecha.Name = "Label_Consultar_Fecha";
            this.Label_Consultar_Fecha.Size = new System.Drawing.Size(444, 55);
            this.Label_Consultar_Fecha.TabIndex = 2;
            this.Label_Consultar_Fecha.Text = "Consultar por fecha";
            this.Label_Consultar_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Label_Consultar_Fecha);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 88);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 463);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.Data_Consulta_Fecha);
            this.panel3.Controls.Add(this.GroupBox_Buscar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 375);
            this.panel3.TabIndex = 3;
            // 
            // Data_Consulta_Fecha
            // 
            this.Data_Consulta_Fecha.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_Consulta_Fecha.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Data_Consulta_Fecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Data_Consulta_Fecha.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_Consulta_Fecha.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Data_Consulta_Fecha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Consulta_Fecha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Estudiante,
            this.Fecha,
            this.Hora,
            this.Docente,
            this.Asunto,
            this.Descripcion});
            this.Data_Consulta_Fecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data_Consulta_Fecha.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Data_Consulta_Fecha.Location = new System.Drawing.Point(0, 80);
            this.Data_Consulta_Fecha.Name = "Data_Consulta_Fecha";
            this.Data_Consulta_Fecha.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.Data_Consulta_Fecha.Size = new System.Drawing.Size(800, 295);
            this.Data_Consulta_Fecha.TabIndex = 2;
            // 
            // GroupBox_Buscar
            // 
            this.GroupBox_Buscar.Controls.Add(this.Button_Buscar);
            this.GroupBox_Buscar.Controls.Add(this.DateTime_Seleccionar_Fecha);
            this.GroupBox_Buscar.Controls.Add(this.Label_Seleccionar);
            this.GroupBox_Buscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.GroupBox_Buscar.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_Buscar.Name = "GroupBox_Buscar";
            this.GroupBox_Buscar.Size = new System.Drawing.Size(800, 80);
            this.GroupBox_Buscar.TabIndex = 1;
            this.GroupBox_Buscar.TabStop = false;
            this.GroupBox_Buscar.Text = "Buscar";
            // 
            // Button_Buscar
            // 
            this.Button_Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.Button_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Buscar.ForeColor = System.Drawing.Color.White;
            this.Button_Buscar.Image = global::practicaFinal.Properties.Resources.buscar_32;
            this.Button_Buscar.Location = new System.Drawing.Point(700, 28);
            this.Button_Buscar.Name = "Button_Buscar";
            this.Button_Buscar.Size = new System.Drawing.Size(39, 37);
            this.Button_Buscar.TabIndex = 2;
            this.Button_Buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Buscar.UseVisualStyleBackColor = false;
            this.Button_Buscar.Click += new System.EventHandler(this.Button_Buscar_Click);
            // 
            // DateTime_Seleccionar_Fecha
            // 
            this.DateTime_Seleccionar_Fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateTime_Seleccionar_Fecha.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DateTime_Seleccionar_Fecha.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.DateTime_Seleccionar_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime_Seleccionar_Fecha.Location = new System.Drawing.Point(233, 34);
            this.DateTime_Seleccionar_Fecha.Name = "DateTime_Seleccionar_Fecha";
            this.DateTime_Seleccionar_Fecha.Size = new System.Drawing.Size(429, 26);
            this.DateTime_Seleccionar_Fecha.TabIndex = 1;
            // 
            // Label_Seleccionar
            // 
            this.Label_Seleccionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Seleccionar.AutoSize = true;
            this.Label_Seleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Seleccionar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.Label_Seleccionar.Location = new System.Drawing.Point(89, 36);
            this.Label_Seleccionar.Name = "Label_Seleccionar";
            this.Label_Seleccionar.Size = new System.Drawing.Size(141, 20);
            this.Label_Seleccionar.TabIndex = 0;
            this.Label_Seleccionar.Text = "Seleccionar Fecha";
            // 
            // Estudiante
            // 
            this.Estudiante.HeaderText = "Estudiante";
            this.Estudiante.Name = "Estudiante";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            // 
            // Docente
            // 
            this.Docente.HeaderText = "Docente";
            this.Docente.Name = "Docente";
            // 
            // Asunto
            // 
            this.Asunto.HeaderText = "Asunto";
            this.Asunto.Name = "Asunto";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            // 
            // FormConsultaFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultaFecha";
            this.Text = "ConsultaFecha";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data_Consulta_Fecha)).EndInit();
            this.GroupBox_Buscar.ResumeLayout(false);
            this.GroupBox_Buscar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_Consultar_Fecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox GroupBox_Buscar;
        private System.Windows.Forms.Button Button_Buscar;
        private System.Windows.Forms.DateTimePicker DateTime_Seleccionar_Fecha;
        private System.Windows.Forms.Label Label_Seleccionar;
        private System.Windows.Forms.DataGridView Data_Consulta_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Asunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}