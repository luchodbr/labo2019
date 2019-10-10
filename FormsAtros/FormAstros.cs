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
namespace Forms
{
    public partial class FormAstros : Form
    {
        static List<Astros> planetas;
        public FormAstros()
        {
            InitializeComponent();
            FormAstros.planetas = new List<Astros>();
        }

        private void FormAstros_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Tipo));
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int aux;
            if (textBox1.Text != "" && int.TryParse(textBox2.Text, out aux) && numericUpDown1.Value > 0)
            {
                Planeta auxPlaneta = new Planeta(aux, (int)numericUpDown1.Value, textBox1.Text, (Tipo)comboBox1.SelectedItem, (int)numericUpDown2.Value);
                FormAstros.planetas.Add(auxPlaneta);
                comboBox2.Items.Add(auxPlaneta);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0 && textBox3.Text != "" && numericUpDown3.Value > 0 && numericUpDown4.Value > 0)
            {
                Satelite sat = new Satelite((int)numericUpDown3.Value, (int)numericUpDown4.Value, textBox3.Text);
                foreach (Planeta p in FormAstros.planetas)
                {
                    if(p == comboBox2.SelectedItem)
                    {
                        p.Satelites.Add(sat);
                    }
                }


            }
        }
    }
}
