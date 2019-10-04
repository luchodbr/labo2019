using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;
namespace Central
{
    public partial class FormLlamador : Form
    {
        Centralita c;
        System.Windows.Forms.TextBox txtBoxFinal;

        public FormLlamador(Centralita c)
        {
            InitializeComponent();
            this.c = c;
            ComboBoxFranjas.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            ComboBoxFranjas.Enabled = false;
            txtBoxFinal = textBoxNroDestino;
        }

        public void TableroNumerico(System.Windows.Forms.TextBox txtBoxFinal, string numero)
        {
            if (textBoxNroDestino.Text == "Nro Destino" || textBoxNroOrigen.Text == "Nro Origen")
            {
                txtBoxFinal.Text = numero;
            }
            else
            {
                txtBoxFinal.Text += numero;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "2");
        }

        private void ButtonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "3");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNroDestino.Text = "Nro Destino";
            textBoxNroOrigen.Text = "Nro Origen";
            ComboBoxFranjas.Enabled = false;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "1");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "6");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "9");
        }

        private void buttonAsterisco_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "*");
        }

        private void button0_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "0");
        }

        private void buttonNumeral_Click(object sender, EventArgs e)
        {
            TableroNumerico(txtBoxFinal, "#");
        }
              

        private void textBoxNroDestino_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNroDestino.Text == "#")
            {
                ComboBoxFranjas.Enabled = true;
            }
        }

        private void buttonLlamar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
