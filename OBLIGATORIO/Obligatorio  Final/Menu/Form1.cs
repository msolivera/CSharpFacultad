using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Obligatorio;
using TaTeTi;
using BatallaNaval;
using BuscaMinas;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Boton que crea una instancia de Buscaminas para poder jugar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            BuscaMinasGame b1 = BuscaMinasGame.GetInstancia();
            b1.GenerarJuego();            
            GUI g = new GUI(b1.tablero, b1.r1);
            g.ShowDialog();
            b1.SetInstancia();

        }
        /// <summary>
        /// Boton que crea una instancia de Batalla Naval para poder jugar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            BatallaNavalGame b2 = BatallaNavalGame.GetInstancia();
            b2.GenerarJuego();
            GUI g1 = new GUI(b2.tablero, b2.r1);
            g1.ShowDialog();
            b2.SetInstancia();
        }
        /// <summary>
        /// Boton que crea una instancia de Tateti para poder jugar.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            TaTeTiGame t1 = TaTeTiGame.GetInstancia();            
            t1.GenerarJuego();
            GUI g2 = new GUI(t1.tablero, t1.r1);
            g2.ShowDialog();
            t1.SetInstancia();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
