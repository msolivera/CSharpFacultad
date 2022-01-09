using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString(), "Resultado");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString(), "Resulta");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "0")
            {
                MessageBox.Show((Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text)).ToString(), "resultado");
            }
            else
            {
                MessageBox.Show("No se puede dividir entre 0");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show((Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString(), "Resultado");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Cambio");
        }
    }
}
