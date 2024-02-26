using System;

public class XDocumento
{
	public XDocumento()
	{
		
    }
    public XAgregar()
    {
        string filePath = "Datos.txt";

        // Crear el elemento XML con un atributo
        XElement customerElement = new XElement("Customer",
                                    new XAttribute("id", 126), // Atributo "id" con valor 123
                                    "Buenas");

        //Escribir el elemento XML en el archivo
            using (StreamWriter writer = new StreamWriter(filePath, true)) // true para agregar al archivo existente
        {
            MessageBox.Show("XML Guardado", "Contenido del elemento Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
