using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace practicaFinal
{
    public partial class FormAgendamiento : Form
    {
        //Variable privada para guardar si el formulario esta abierto o no 
        private static FormAgendamiento Instancia = null;

        //Función para validar si el formulario esta abierto
        //si esta abierto que me devuelva la instancia, de lo contrario, me cree una nueva instancia 
        public static FormAgendamiento VentanaUnica() {
            if (Instancia == null)
            {
                Instancia = new FormAgendamiento();
                return Instancia;
            }
            return Instancia;
        }
        public FormAgendamiento()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void Button_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string estudiante = (TextBox_Estudiante.Text).Trim();
                DateTime fecha = DateTime_Fecha.Value;
                string fechaFormateada = fecha.ToString("dd/MM/yyyy"); // Formato día/mes/año
                string hora = ComboBox_Hora.SelectedItem.ToString();
                string docente = ComboBox_Docente.SelectedItem.ToString();
                string asunto = (TextBox_Asunto.Text).Trim();
                string descripcion = (RichTextBox_Descrip.Text).Trim();
                string filePath = "Datos.txt";

                // Verificar si el archivo ya contiene la etiqueta "Agendas"
                bool agendasExists = File.Exists(filePath) && File.ReadAllText(filePath).Contains("<Agendas>");

                if (!agendasExists)
                {
                    // Si la etiqueta "Agendas" no existe, crearla junto con su contenido
                    XElement agendar =
                        new XElement("Agendas",
                            new XElement("Agenda",
                            new XAttribute("id", 1), //Se iniciado con un 1
                                new XElement("Estudiante", estudiante),
                                new XElement("Fecha", fechaFormateada),
                                new XElement("Hora", hora),
                                new XElement("Docente", docente),
                                new XElement("Asunto", asunto),
                                new XElement("Descripcion", descripcion)
                            )
                        );

                    // Escribir la etiqueta "Agendas" y su contenido en el archivo
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.WriteLine(agendar);
                    }
                    LimpiarControles();
                    MessageBox.Show("XML Guardado", "Contenido del elemento Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Si la etiqueta "Agendas" ya existe, leer el archivo para obtener el último ID
                    XDocument doc = XDocument.Load(filePath);
                    int lastId = doc.Descendants("Agenda")
                                    .Select(x => (int)x.Attribute("id"))
                                    .LastOrDefault();
                    int newId = lastId + 1; // Obtener el siguiente ID

                    // Crear la nueva etiqueta "Agenda" con el nuevo ID y agregarla al documento
                    XElement newAgenda =
                        new XElement("Agenda",
                        new XAttribute("id", newId),
                            new XElement("Estudiante", estudiante),
                            new XElement("Fecha", fechaFormateada),
                            new XElement("Hora", hora),
                            new XElement("Docente", docente),
                            new XElement("Asunto", asunto),
                            new XElement("Descripcion", descripcion)
                        );

                    doc.Root.Add(newAgenda); // Agregar la nueva agenda al documento

                    // Guardar el documento de nuevo en el archivo
                    doc.Save(filePath);
                    LimpiarControles();
                    MessageBox.Show("Contenido agregado a la etiqueta Agendas", "Contenido del elemento Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            } catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error en el archivo XML:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarControles()
        {
            // Establecer el texto de los controles en una cadena vacía
            TextBox_Estudiante.Text = "";
            ComboBox_Hora.SelectedItem = null;
            ComboBox_Docente.SelectedItem = null;
            TextBox_Asunto.Text = "";
            RichTextBox_Descrip.Text = "";
        }
    }
}
