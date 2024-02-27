using System;

namespace practicaFinal

public class Docente
{
	public string Nombre { get; set; }
    public string Apellido { get; set; }

    public Docente(string nombre, string apellido)
    {
        this.Nombre = nombre;
        this.Apellido = apellido;
    }
}
