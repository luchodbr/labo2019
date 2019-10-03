using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;
namespace ComiqueriaApp
{
    public partial class VentasForm : Form
    {
        Producto producto;
        Comiqueria comiqueria;
        public VentasForm(Producto p,Comiqueria comiqueria)
        {
            InitializeComponent();
            this.producto = p;
            this.comiqueria = comiqueria;

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            lblPrecioFinal.Text = ("Precio Final $" + this.producto.Precio);
            lblDescripcion.Text = this.producto.Descripcion;
        }

        private void NumericUpDownCantidad_ValueChanged(object sender, EventArgs e)
        { 
            
            lblPrecioFinal.Text =("Precio Final $"+((double)numericUpDownCantidad.Value * this.producto.Precio).ToString());
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            if (numericUpDownCantidad.Value <= this.producto.Stock)
            {
                this.comiqueria.Vender(this.producto, (int)numericUpDownCantidad.Value);
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error en cantidad de productos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
