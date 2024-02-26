using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace practicaFinal
{
    public partial class FormConsultaFecha : Form
    {
        //Variable privada para guardar si el formulario esta abierto o no 
        private static FormConsultaFecha Instancia = null;

        //Función para validar si el formulario esta abierto
        //si esta abierto que me devuelva la instancia, de lo contrario, me cree una nueva instancia 
        public static FormConsultaFecha VentanaUnica()
        {
            if (Instancia == null)
            {
                Instancia = new FormConsultaFecha();
                return Instancia;
            }
            return Instancia;
        }
        public FormConsultaFecha()
        {
            InitializeComponent();
        }

        private void Button_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = "Datos.txt";

                DateTime fecha = DateTime_Seleccionar_Fecha.Value.Date;
                string fechaFormateada = fecha.ToString("dd/MM/yyyy"); // Formato día/mes/año

                XDocument doc = XDocument.Load(filePath);

                var agendas = from agenda in doc.Descendants("Agenda")
                              let fechaAgenda = DateTime.ParseExact(agenda.Element("Fecha").Value, "dd/MM/yyyy", null).Date
                              where fechaAgenda == fecha
                              select agenda;

                // Limpiar el DataGridView antes de agregar nuevos datos
                Data_Consulta_Fecha.Rows.Clear();

                foreach (var agenda in agendas)
                {
                    int rowIndex = Data_Consulta_Fecha.Rows.Add(); // Agregar una nueva fila al DataGridView

                    // Asignar los valores de la agenda a las celdas correspondientes en la fila recién agregada
                    Data_Consulta_Fecha.Rows[rowIndex].Cells["Estudiante"].Value = agenda.Element("Estudiante").Value;
                    Data_Consulta_Fecha.Rows[rowIndex].Cells["Fecha"].Value = agenda.Element("Fecha").Value;
                    Data_Consulta_Fecha.Rows[rowIndex].Cells["Hora"].Value = agenda.Element("Hora").Value;
                    Data_Consulta_Fecha.Rows[rowIndex].Cells["Docente"].Value = agenda.Element("Docente").Value;
                    Data_Consulta_Fecha.Rows[rowIndex].Cells["Asunto"].Value = agenda.Element("Asunto").Value;
                    Data_Consulta_Fecha.Rows[rowIndex].Cells["Descripcion"].Value = agenda.Element("Descripcion").Value;
                }

            } catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
