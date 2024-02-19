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

    }
}
