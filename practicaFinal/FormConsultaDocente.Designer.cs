namespace practicaFinal
{
    partial class FormConsultaDocente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Label_Consultar_Fecha = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.GroupBox_Buscar = new System.Windows.Forms.GroupBox();
            this.Button_Buscar = new System.Windows.Forms.Button();
            this.Label_Seleccionar_Docente = new System.Windows.Forms.Label();
            this.Data_Consulta_Docente = new System.Windows.Forms.DataGridView();
            this.Column_NombreEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Docente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Asunto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.GroupBox_Buscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Consulta_Docente)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Consultar_Fecha
            // 
            this.Label_Consultar_Fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Consultar_Fecha.AutoSize = true;
            this.Label_Consultar_Fecha.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Label_Consultar_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Consultar_Fecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.Label_Consultar_Fecha.Location = new System.Drawing.Point(135, 19);
            this.Label_Consultar_Fecha.Name = "Label_Consultar_Fecha";
            this.Label_Consultar_Fecha.Size = new System.Drawing.Size(498, 55);
            this.Label_Consultar_Fecha.TabIndex = 2;
            this.Label_Consultar_Fecha.Text = "Consultar por docente";
            this.Label_Consultar_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Label_Consultar_Fecha);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 88);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 390);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 60);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.Data_Consulta_Docente);
            this.panel3.Controls.Add(this.GroupBox_Buscar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 302);
            this.panel3.TabIndex = 4;
            // 
            // GroupBox_Buscar
            // 
            this.GroupBox_Buscar.Controls.Add(this.comboBox1);
            this.GroupBox_Buscar.Controls.Add(this.Button_Buscar);
            this.GroupBox_Buscar.Controls.Add(this.Label_Seleccionar_Docente);
            this.GroupBox_Buscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Buscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.GroupBox_Buscar.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_Buscar.Name = "GroupBox_Buscar";
            this.GroupBox_Buscar.Size = new System.Drawing.Size(800, 80);
            this.GroupBox_Buscar.TabIndex = 2;
            this.GroupBox_Buscar.TabStop = false;
            this.GroupBox_Buscar.Text = "Buscar";
            // 
            // Button_Buscar
            // 
            this.Button_Buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Buscar.BackColor = System.Drawing.Color.Transparent;
            this.Button_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Buscar.ForeColor = System.Drawing.Color.White;
            this.Button_Buscar.Image = global::practicaFinal.Properties.Resources.buscar_docente_32;
            this.Button_Buscar.Location = new System.Drawing.Point(700, 29);
            this.Button_Buscar.Name = "Button_Buscar";
            this.Button_Buscar.Size = new System.Drawing.Size(39, 37);
            this.Button_Buscar.TabIndex = 2;
            this.Button_Buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Buscar.UseVisualStyleBackColor = false;
            // 
            // Label_Seleccionar_Docente
            // 
            this.Label_Seleccionar_Docente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Seleccionar_Docente.AutoSize = true;
            this.Label_Seleccionar_Docente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Seleccionar_Docente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.Label_Seleccionar_Docente.Location = new System.Drawing.Point(79, 36);
            this.Label_Seleccionar_Docente.Name = "Label_Seleccionar_Docente";
            this.Label_Seleccionar_Docente.Size = new System.Drawing.Size(157, 20);
            this.Label_Seleccionar_Docente.TabIndex = 0;
            this.Label_Seleccionar_Docente.Text = "Seleccionar Docente";
            // 
            // Data_Consulta_Docente
            // 
            this.Data_Consulta_Docente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data_Consulta_Docente.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Data_Consulta_Docente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Data_Consulta_Docente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Data_Consulta_Docente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data_Consulta_Docente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_NombreEstudiante,
            this.Column_Fecha,
            this.Column_Docente,
            this.Column_Asunto,
            this.Column_Descrip});
            this.Data_Consulta_Docente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Data_Consulta_Docente.Location = new System.Drawing.Point(0, 80);
            this.Data_Consulta_Docente.Name = "Data_Consulta_Docente";
            this.Data_Consulta_Docente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.Data_Consulta_Docente.Size = new System.Drawing.Size(800, 222);
            this.Data_Consulta_Docente.TabIndex = 3;
            // 
            // Column_NombreEstudiante
            // 
            this.Column_NombreEstudiante.HeaderText = "Nombre Estudiante";
            this.Column_NombreEstudiante.Name = "Column_NombreEstudiante";
            // 
            // Column_Fecha
            // 
            this.Column_Fecha.HeaderText = "Fecha";
            this.Column_Fecha.Name = "Column_Fecha";
            // 
            // Column_Docente
            // 
            this.Column_Docente.HeaderText = "Docente";
            this.Column_Docente.Name = "Column_Docente";
            // 
            // Column_Asunto
            // 
            this.Column_Asunto.HeaderText = "Asunto";
            this.Column_Asunto.Name = "Column_Asunto";
            // 
            // Column_Descrip
            // 
            this.Column_Descrip.HeaderText = "Descripción";
            this.Column_Descrip.Name = "Column_Descrip";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(249, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(429, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // FormConsultaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConsultaDocente";
            this.Text = "ConsultaDocente";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.GroupBox_Buscar.ResumeLayout(false);
            this.GroupBox_Buscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data_Consulta_Docente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_Consultar_Fecha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox GroupBox_Buscar;
        private System.Windows.Forms.Button Button_Buscar;
        private System.Windows.Forms.Label Label_Seleccionar_Docente;
        private System.Windows.Forms.DataGridView Data_Consulta_Docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NombreEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Docente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Asunto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Descrip;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}