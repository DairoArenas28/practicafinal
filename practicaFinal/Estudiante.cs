using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace practicaFinal
{
    public class Estudiante : Docente
    {
        //Estudiante() es un construtor, este nos permite crear un objeto con propiedades
        //obligatorias, es decir, que cuando creamos un objeto debemos
        //ingresar tanto el nombre como el apellido
        public Estudiante(string nombre, string apellido) : base(nombre, apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public void AgregarAgenda()
        {
            MessageBox.Show("Datos guardado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
