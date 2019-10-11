using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCantina;
using Entidades;
namespace FrmCantina
{
    public partial class FrmCantina : Form
    {
        public FrmCantina()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            comboBox1.DataSource = Enum.GetValues(typeof(Botella.Tipo));

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Botella.Tipo t;
                Enum.TryParse<Botella.Tipo>(comboBox1.SelectedValue.ToString(), out t);
                Botella b = new Cerveza(textBox1.Text, (int)numericUpDown1.Value, (int)numericUpDown2.Value, t);
                barra1.AgregarBotella(b);
            }
            else if(radioButton2.Checked)
            {
                Botella b = new Agua((int)numericUpDown1.Value, (int)numericUpDown2.Value, textBox1.Text);
                barra1.AgregarBotella(b);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                comboBox1.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                comboBox1.Enabled = true;
        }
    }
}
