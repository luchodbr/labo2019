using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _28Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            string s = richTextBox1.ToString();
            for (int i = 0; i < s.Count<char>(); i++)
            {
                if(s[i].CompareTo('a')==1 && s[i].CompareTo('z')==0)
                {
                }
            }
        }
    }
}
