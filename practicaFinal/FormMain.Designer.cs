namespace practicaFinal
{
    partial class FormMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.header = new System.Windows.Forms.Panel();
            this.Label_Asesorias = new System.Windows.Forms.Label();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bodypanel = new System.Windows.Forms.Panel();
            this.Btn_Agendar_Cita = new System.Windows.Forms.Button();
            this.Btn_Consultar_Fecha = new System.Windows.Forms.Button();
            this.Btn_Consultar_Docente = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.menu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(52)))), ((int)(((byte)(89)))));
            this.header.Controls.Add(this.Label_Asesorias);
            this.header.Controls.Add(this.Btn_Salir);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(0);
            this.header.Name = "header";
            this.header.Padding = new System.Windows.Forms.Padding(5);
            this.header.Size = new System.Drawing.Size(1003, 70);
            this.header.TabIndex = 0;
            // 
            // Label_Asesorias
            // 
            this.Label_Asesorias.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_Asesorias.AutoSize = true;
            this.Label_Asesorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Asesorias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label_Asesorias.Location = new System.Drawing.Point(368, 9);
            this.Label_Asesorias.Name = "Label_Asesorias";
            this.Label_Asesorias.Size = new System.Drawing.Size(235, 55);
            this.Label_Asesorias.TabIndex = 1;
            this.Label_Asesorias.Text = "Asesorías";
            this.Label_Asesorias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Salir.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_Salir.Location = new System.Drawing.Point(881, 5);
            this.Btn_Salir.Margin = new System.Windows.Forms.Padding(10);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(117, 60);
            this.Btn_Salir.TabIndex = 0;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = false;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            this.Btn_Salir.MouseEnter += new System.EventHandler(this.Salir_MouseEnter);
            this.Btn_Salir.MouseLeave += new System.EventHandler(this.Salir_MouseLeave);
            this.Btn_Salir.MouseHover += new System.EventHandler(this.Salir_MouseHover);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(167)))));
            this.menu.Controls.Add(this.tableLayoutPanel1);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 70);
            this.menu.Margin = new System.Windows.Forms.Padding(0);
            this.menu.Name = "menu";
            this.menu.Padding = new System.Windows.Forms.Padding(10);
            this.menu.Size = new System.Drawing.Size(238, 551);
            this.menu.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.Btn_Agendar_Cita, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Consultar_Fecha, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Btn_Consultar_Docente, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(218, 174);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bodypanel
            // 
            this.bodypanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bodypanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodypanel.Location = new System.Drawing.Point(238, 70);
            this.bodypanel.Name = "bodypanel";
            this.bodypanel.Size = new System.Drawing.Size(765, 551);
            this.bodypanel.TabIndex = 2;
            this.bodypanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bodypanel_Paint);
            // 
            // Btn_Agendar_Cita
            // 
            this.Btn_Agendar_Cita.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Agendar_Cita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Agendar_Cita.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Agendar_Cita.Image = global::practicaFinal.Properties.Resources.teacher_;
            this.Btn_Agendar_Cita.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Agendar_Cita.Location = new System.Drawing.Point(0, 3);
            this.Btn_Agendar_Cita.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Btn_Agendar_Cita.Name = "Btn_Agendar_Cita";
            this.Btn_Agendar_Cita.Size = new System.Drawing.Size(218, 52);
            this.Btn_Agendar_Cita.TabIndex = 0;
            this.Btn_Agendar_Cita.Text = "Agendar cita con docente        ";
            this.Btn_Agendar_Cita.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Agendar_Cita.UseVisualStyleBackColor = true;
            this.Btn_Agendar_Cita.Click += new System.EventHandler(this.Btn_Agendar_Cita_Click);
            this.Btn_Agendar_Cita.MouseEnter += new System.EventHandler(this.Btn_Agendar_Cita_MouseEnter);
            this.Btn_Agendar_Cita.MouseLeave += new System.EventHandler(this.Agendar_Cita_MouseLeave);
            // 
            // Btn_Consultar_Fecha
            // 
            this.Btn_Consultar_Fecha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Consultar_Fecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Consultar_Fecha.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Consultar_Fecha.Image = global::practicaFinal.Properties.Resources.calendar;
            this.Btn_Consultar_Fecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Consultar_Fecha.Location = new System.Drawing.Point(0, 61);
            this.Btn_Consultar_Fecha.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Btn_Consultar_Fecha.Name = "Btn_Consultar_Fecha";
            this.Btn_Consultar_Fecha.Size = new System.Drawing.Size(218, 52);
            this.Btn_Consultar_Fecha.TabIndex = 1;
            this.Btn_Consultar_Fecha.Text = "Consultar agenda por fecha     ";
            this.Btn_Consultar_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Consultar_Fecha.UseVisualStyleBackColor = true;
            this.Btn_Consultar_Fecha.Click += new System.EventHandler(this.Btn_Consultar_Fecha_Click);
            this.Btn_Consultar_Fecha.MouseEnter += new System.EventHandler(this.Btn_Consultar_Fecha_MouseEnter);
            this.Btn_Consultar_Fecha.MouseLeave += new System.EventHandler(this.Btn_Consultar_Fecha_MouseLeave);
            // 
            // Btn_Consultar_Docente
            // 
            this.Btn_Consultar_Docente.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Consultar_Docente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Consultar_Docente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Consultar_Docente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Btn_Consultar_Docente.Image = global::practicaFinal.Properties.Resources.job_search;
            this.Btn_Consultar_Docente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Consultar_Docente.Location = new System.Drawing.Point(0, 119);
            this.Btn_Consultar_Docente.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Btn_Consultar_Docente.Name = "Btn_Consultar_Docente";
            this.Btn_Consultar_Docente.Size = new System.Drawing.Size(218, 52);
            this.Btn_Consultar_Docente.TabIndex = 2;
            this.Btn_Consultar_Docente.Text = "Consultar agenda por docente ";
            this.Btn_Consultar_Docente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Consultar_Docente.UseVisualStyleBackColor = false;
            this.Btn_Consultar_Docente.Click += new System.EventHandler(this.Btn_Consultar_Docente_Click);
            this.Btn_Consultar_Docente.MouseEnter += new System.EventHandler(this.Btn_Consultar_Docente_MouseEnter);
            this.Btn_Consultar_Docente.MouseLeave += new System.EventHandler(this.Btn_Consultar_Docente_MouseLeave);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1003, 621);
            this.Controls.Add(this.bodypanel);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Text = "Principal";
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            this.menu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Btn_Salir;
        private System.Windows.Forms.Button Btn_Agendar_Cita;
        private System.Windows.Forms.Button Btn_Consultar_Fecha;
        private System.Windows.Forms.Button Btn_Consultar_Docente;
        private System.Windows.Forms.Panel bodypanel;
        private System.Windows.Forms.Label Label_Asesorias;
    }
}

