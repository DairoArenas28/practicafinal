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
                //Capturar los datos del formulario y guardarlo en las variables
                string nombreEstudiante = (TextBox_Nombre_Estudiante.Text).Trim();
                string apellidoEstudiante = (TextBox_Nombre_Estudiante.Text).Trim();
                //Crear un objeto estudiante para agregarlo despues en el xml
                Estudiante estudobj = new Estudiante(nombreEstudiante, apellidoEstudiante);
                DateTime fecha = DateTime_Fecha.Value;
                string fechaFormateada = fecha.ToString("dd/MM/yyyy"); // Formato día/mes/año
                string hora = ComboBox_Hora.SelectedItem.ToString();
                string docente = ComboBox_Docente.SelectedItem.ToString();
                string asunto = (TextBox_Asunto.Text).Trim();
                string descripcion = (RichTextBox_Descrip.Text).Trim();

                //Ruta del archivo txt
                string filePath = "Datos.txt";

                // Verificar si el archivo ya contiene la etiqueta "Agendas"
                bool agendasExists = File.Exists(filePath) && File.ReadAllText(filePath).Contains("<Agendas>");
                
                //verificar si la etiqueta <Agendas> existe en el archivo txt
                if (!agendasExists)
                {
                    // Si la etiqueta "Agendas" no existe, crearla junto con su contenido
                    //crear un objeto XElement
                    XElement agendar =
                        //Agregar etiqueta agendas en el xml
                        new XElement("Agendas",
                            //Agregar etiqueta agenda en el xml
                            new XElement("Agenda",
                            //Agregar un atributo como identificador unico a cada etiqueta agenda creada en el xml
                            new XAttribute("id", 1), //Se iniciado con un 1
                                //Agregar las etiquedas solicitadas en el formulario con su respectivo valor 
                                new XElement("Estudiante", estudobj.Nombre),
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
                        //Escribir los datos de agendar en el archivo txt
                        writer.WriteLine(agendar);
                    }
                    LimpiarControles();
                    MessageBox.Show("Datos guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Si la etiqueta "Agendas" ya existe, leer el archivo para obtener el último ID
                    //Leer o cargar el archivo txt o hacer una instancia a el 
                    XDocument doc = XDocument.Load(filePath);
                    //buscar y guardar el ultimo ID de la agenda
                    int lastId = doc.Descendants("Agenda")
                                    //Seleccionar todos los ID de la etiqueta agenda
                                    //Convertimos de texto a entero (int)
                                    .Select(x => (int)x.Attribute("id"))
                                    //buscar y traer el ultimo ID
                                    .LastOrDefault();
                    int newId = lastId + 1; // Obtener el siguiente ID y sumar 1

                    // Crear la nueva etiqueta "Agenda" con el nuevo ID y agregarla al documento
                    XElement newAgenda =
                        new XElement("Agenda",
                        //Agregar el ID siguiente al atributo
                        new XAttribute("id", newId),
                            new XElement("Estudiante", estudobj.Nombre),
                            new XElement("Fecha", fechaFormateada),
                            new XElement("Hora", hora),
                            new XElement("Docente", docente),
                            new XElement("Asunto", asunto),
                            new XElement("Descripcion", descripcion)
                        );
                    //Root se utiliza para ingresar todos los datos en la etiqueta global, en este caso agendas
                    doc.Root.Add(newAgenda); // Agregar la nueva agenda al documento

                    // Guardar el documento de nuevo en el archivo
                    doc.Save(filePath);
                    //Cuando se guarde los datos, limpiar los campos en el formulario para ingresar otro datos
                    LimpiarControles();
                    //Mensaje de exito 
                    estudobj.AgregarAgenda();
                }

            }
            catch (Exception ex)
            {
                //Si hay algun problema cuando se guarda la información aparecerá un mensaje de error
                MessageBox.Show($"Se produjo un error en el archivo XML:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarControles()
        {
            // Establecer el texto de los controles en una cadena vacía
            TextBox_Nombre_Estudiante.Text = "";
            ComboBox_Hora.SelectedItem = null;
            ComboBox_Docente.SelectedItem = null;
            TextBox_Asunto.Text = "";
            RichTextBox_Descrip.Text = "";
        }
    }
}
