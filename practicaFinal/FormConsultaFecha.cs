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

                //Obtener el valor de la fecha seleccionada
                DateTime fecha = DateTime_Seleccionar_Fecha.Value.Date;
                //Formatear la fecha obtenida anteriormente "dd/MM/yyyy" 
                string fechaFormateada = fecha.ToString("dd/MM/yyyy"); // Formato día/mes/año

                //Cargar el contenido del archivo xml
                XDocument doc = XDocument.Load(filePath);

                //Buscar en el archivo de texto la fecha seleccionada
                var agendas = from agenda in doc.Descendants("Agenda")
                              //Obtner el valor de la fecha en el archivo text
                              let fechaAgenda = DateTime.ParseExact(agenda.Element("Fecha").Value, "dd/MM/yyyy", null).Date
                              //Hacemos una comparacion, si la fecha obtenida en el archivo text es igual a la fecha seleccionada
                              where fechaAgenda == fecha
                              //Si encuentra algo traemos todos los datos de esa busqueda
                              select agenda;

                //Verificar si en agendas tiene datos o no 
                if (!agendas.Any())
                {
                    MessageBox.Show("No se encontraron datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
                {
                    // Limpiar el DataGridView antes de agregar nuevos datos
                    Data_Consulta_Fecha.Rows.Clear();

                    foreach (var agenda in agendas)
                    {
                        //Obtener el index de cada columna de la tabla
                        int rowIndex = Data_Consulta_Fecha.Rows.Add(); // Agregar una nueva fila al DataGridView

                        // Asignar los valores de la agenda a las celdas correspondientes en la fila recién agregada
                        Data_Consulta_Fecha.Rows[rowIndex].Cells["Estudiante"].Value = agenda.Element("Estudiante").Value;
                        Data_Consulta_Fecha.Rows[rowIndex].Cells["Fecha"].Value = agenda.Element("Fecha").Value;
                        Data_Consulta_Fecha.Rows[rowIndex].Cells["Hora"].Value = agenda.Element("Hora").Value;
                        Data_Consulta_Fecha.Rows[rowIndex].Cells["Docente"].Value = agenda.Element("Docente").Value;
                        Data_Consulta_Fecha.Rows[rowIndex].Cells["Asunto"].Value = agenda.Element("Asunto").Value;
                        Data_Consulta_Fecha.Rows[rowIndex].Cells["Descripcion"].Value = agenda.Element("Descripcion").Value;
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
