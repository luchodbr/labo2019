using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
namespace Ej68
{
    public partial class Form1 : Form
    {
        public Persona p;
        public Form1()
        {
            InitializeComponent();
        }

        static void NotificarCambio(string msj)
        {
            MessageBox.Show(msj);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (this.p == null)
            {
                this.p = new Persona();
                this.p.EventoString += NotificarCambio;
                this.btnCrear.Text = "Actualizar";
            }
                this.p.Nombre = this.txtNombre.Text;
                this.p.Apellido = this.txtApellido.Text;
        }
    }
}
