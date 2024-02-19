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
    public partial class FormConsultaDocente : Form
    {
        //Variable privada para guardar si el formulario esta abierto o no
        private static FormConsultaDocente Instancia = null;

        //Función para validar si el formulario esta abierto
        //si esta abierto que me devuelva la instancia, de lo contrario, me cree una nueva instancia 
        public static FormConsultaDocente VentanaUnica()
        {
            if (Instancia == null)
            {
                Instancia = new FormConsultaDocente();
                return Instancia;
            }
            return Instancia;
        }
        public FormConsultaDocente()
        {
            InitializeComponent();
        }
    }
}
