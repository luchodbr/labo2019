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
    public partial class FrmMenu : Form
    {
        Centralita c;
        public FrmMenu()
        {
            InitializeComponent();
            c = new Centralita("ele center");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
            FrmLlamador frmLlamador = new FrmLlamador(c);
            frmLlamador.Show();
        }
    }
}
