using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practicaFinal
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Salir_Click(object sender, EventArgs e)
        {

        }

        private void Salir_MouseHover(object sender, EventArgs e)
        {
            
        }
        //Eventos del boton salir

        private void Salir_MouseEnter(object sender, EventArgs e)
        {
            Btn_Salir.BackColor = Color.CornflowerBlue;
        }

        private void Salir_MouseLeave(object sender, EventArgs e)
        {
            Btn_Salir.BackColor = Color.Transparent;
        }

        //Eventos del boton Agendar Cita
        private void Btn_Agendar_Cita_MouseEnter(object sender, EventArgs e)
        {
            Btn_Agendar_Cita.BackColor = Color.CornflowerBlue;
        }

        private void Agendar_Cita_MouseLeave(object sender, EventArgs e)
        {
            Btn_Agendar_Cita.BackColor = Color.Transparent;
        }
        private void Btn_Agendar_Cita_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario secundario
            FormAgendamiento frm = FormAgendamiento.VentanaUnica();

            // Establecer el formulario principal como el contenedor MDI
            frm.MdiParent = this;

            // Establecer el panel como el contenedor del formulario secundario
            frm.Dock = DockStyle.Fill;
            bodypanel.Controls.Add(frm);

            // Mostrar el formulario secundario
            frm.Show();

            // Mostrar el formulario si esta oculto detras de un formulario
            frm.BringToFront();

        }
        private void bodypanel_Paint(object sender, PaintEventArgs e)
        {

        }

        //Eventos del boton Consulta por fecha
        private void Btn_Consultar_Fecha_MouseEnter(object sender, EventArgs e)
        {
            Btn_Consultar_Fecha.BackColor = Color.CornflowerBlue;
        }
        private void Btn_Consultar_Fecha_MouseLeave(object sender, EventArgs e)
        {
            Btn_Consultar_Fecha.BackColor = Color.Transparent;
        }

        private void Btn_Consultar_Fecha_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario secundario
            FormConsultaFecha frm = FormConsultaFecha.VentanaUnica();

            // Establecer el formulario principal como el contenedor MDI
            frm.MdiParent = this;

            // Establecer el panel como el contenedor del formulario secundario
            frm.Dock = DockStyle.Fill;
            bodypanel.Controls.Add(frm);

            // Mostrar el formulario secundario
            frm.Show();

            // Mostrar el formulario si esta oculto detras de un formulario 
            frm.BringToFront();
        }
        //Eventos del boton Consulta por docente

        private void Btn_Consultar_Docente_MouseEnter(object sender, EventArgs e)
        {
            Btn_Consultar_Docente.BackColor = Color.CornflowerBlue;
        }

        private void Btn_Consultar_Docente_MouseLeave(object sender, EventArgs e)
        {
            Btn_Consultar_Docente.BackColor = Color.Transparent;
        }
        private void Btn_Consultar_Docente_Click(object sender, EventArgs e)
        {

            // Crear una instancia del formulario secundario
            FormConsultaDocente frm = FormConsultaDocente.VentanaUnica();

            // Establecer el formulario principal como el contenedor MDI
            frm.MdiParent = this;

            // Establecer el panel como el contenedor del formulario secundario
            frm.Dock = DockStyle.Fill;
            bodypanel.Controls.Add(frm);

            // Mostrar el formulario secundario
            frm.Show();

            // Mostrar el formulario si esta oculto detras de un formulario 
            frm.BringToFront();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación completamente
            Application.Exit();
        }

        
    }
}
