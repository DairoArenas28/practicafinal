using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;

using Docente;
public class Estudiante : Docente
{
	public string Grado { get; set; }
	public Estudiante(string nombre, string apellido, string grado) : base(nombre, apellido)
	{
		this.Grado = nombre;	
	}

    public saludar() => MessageBox.Show(nombre, "Contenido del elemento Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);
}
