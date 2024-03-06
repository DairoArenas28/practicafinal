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
