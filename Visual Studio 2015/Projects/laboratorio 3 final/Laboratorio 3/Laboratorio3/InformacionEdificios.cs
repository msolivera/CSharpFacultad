using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio3
{
    public partial class InformacionEdificios : Form
    {
        public InformacionEdificios()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            MessageBox.Show(" Vida: 1600 \n Niveles: 12 \n Capacidad de almacenamiento: 1000 ", "Almacen de Oro", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Vida: 1400 \n Niveles: 12 \n Capacidad de almacenamiento: 4500 ", "Almacen de Elixir Rojo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Vida: 1000 \n Niveles: 15 \n Daño por Segundo: 95 \n Tipo de Defensa: Tierra ", "Cañon", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Vida: 2600 \n Niveles: 6 \n Capacidad de almacenamiento: 7500 ", "Almacen de Elixir Oscuro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Vida: 3200 \n Niveles: 11 \n Capacidad de almacenamiento Oro: 5000 \n Capacidad de almacenamiento Elixir Rojo: 7500 \n Capacidad maxima de Tropas: 20 ", "Ayuntamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Vida: 400 \n Niveles: 8 \n Capacidad maxima de Tropas: 50 ", "Campamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Vida:4000 \n Niveles: 7 \n Capacidad de almacenamiento Oro: 500 \n Capacidad de almacenamiento Elixir Rojo: 750 \n Capacidad de almacenamiento Elixir Oscuro: 300 \n Capacidad maxima de Tropas: 25 ", "Castillo del Clan", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Vida: 580 \n Niveles: 12", "Cuartel", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Vida: 700 \n Niveles: 7", "Cuartel Oscuro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Vida: 300 \n Niveles: 12 \n Recoleccion por segundo: 1 \n Recolección Maxima: 1000", "Recolector de Elixir Rojo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Vida: 500 \n Niveles: 12 \n Recoleccion por segundo: 1 \n Recolección Maxima: 500", "Recolector de Elixir Oscuro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Vida: 300 \n Niveles: 12 \n Recoleccion por segundo: 1 \n Recolección Maxima: 1000", "Recolector de Oro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Vida: 800 \n Niveles: 15 \n Daño por Segundo: 75 \n Tipo de Defensa: Tierra y aire ", "Torre de Arqueras", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Vida: 1400 \n Niveles: 10 \n Daño por Segundo: 48 \n Tipo de Defensa: Tierra y aire ", "Torre de Magos", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button19_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Vida: 1100 \n Niveles: 10 \n Daño por Segundo: 280 \n Tipo de Defensa: Aire ", "Cohete Antiaéreo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button18_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Vida: 800 \n Niveles: 9 \n Daño por Segundo: 87 \n Tipo de Defensa: Tierra y aire ", "Torre Tesla", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Vida: 3000 \n Niveles: 5 \n Daño por Segundo: 110 \n Tipo de Defensa: Tierra y aire ", "Ballesta", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Vida: 2400 \n Niveles: 4 \n Daño por Segundo: 41 \n Tipo de Defensa: Tierra y aire ", "Torre Infernal", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Vida: 8500 \n Niveles: 12 \n Tipo de Defensa: Tierra ", "Muro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Vida: 4400 \n Niveles: 2 \n Daño por Segundo: 90 \n Tipo de Defensa: Tierra y aire ", "Águila de Artillería", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
