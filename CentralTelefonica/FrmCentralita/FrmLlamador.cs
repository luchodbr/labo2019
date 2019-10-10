using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
namespace FrmCentralita
{
    public partial class FrmLlamador : Form
    {
        Centralita c;
        public Centralita Centralita { get { return c; } }
        public FrmLlamador()
        {
            InitializeComponent();
        }

        public FrmLlamador(Centralita cen) : this()
        {
            c = cen;
        }
        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            cmbFranja.DataSource = Enum.GetValues(typeof(Franjas));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Nro Destino")
            {
                this.textBox1.Text = "1";
            }
            else
                this.textBox1.Text += "1"; 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Nro Destino")
            {
                this.textBox1.Text = "2";
            }
            else
                this.textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Nro Destino")
            {
                this.textBox1.Text = "3";
            }
            else
                this.textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Nro Destino")
            {
                this.textBox1.Text = "4";
            }
            else
                this.textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Nro Destino")
            {
                this.textBox1.Text = "5";
            }
            else
                this.textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Nro Destino")
            {
                this.textBox1.Text = "6";
            }
            else
                this.textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Nro Duracion")
            {
                this.textBox1.Text = "7";
            }
            else
                this.textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Nro Destino")
            {
                this.textBox1.Text = "8";
            }
            else
                this.textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Nro Duracion")
            {
                this.textBox1.Text = "9";
            }
            else
                this.textBox1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Nro Destino")
            {
                this.textBox1.Text = "*";
            }
            else
                this.textBox1.Text += "*";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Nro Destino")
            {
                this.textBox1.Text = "0";
            }
            else
                this.textBox1.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "Nro Destino")
            {
                this.textBox1.Text = "#";
            }
            else
                this.textBox1.Text += "#";
        }
    }
}
