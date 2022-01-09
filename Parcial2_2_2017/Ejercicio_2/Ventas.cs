using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Funcion que verifica que exista una cerveza del tipo indicado en el boton,
            // de ser asi lo elimina del inventario y lo añade a una lista de vendidos (a fin de controlar ventas)
            Producto p = Producto.GetInstancia();
            foreach (Cerveza c in p.Inventario)
            {
                if (c is IPA)
                {
                    p.Inventario.Remove(c);
                    p.Vendidas.Add(c);
                    break;
                }
                
                else
                {
                    MessageBox.Show("No tiene ese tipo de cerveza en strock", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Funcion que verifica que exista una cerveza del tipo indicado en el boton,
            // de ser asi lo elimina del inventario y lo añade a una lista de vendidos (a fin de controlar ventas)
            Producto p = Producto.GetInstancia();
            foreach (Cerveza c in p.Inventario)
            {
                if (c is Porter)
                {
                    p.Inventario.Remove(c);
                    p.Vendidas.Add(c);
                    break;
                }
                else
                {
                    MessageBox.Show("No tiene ese tipo de cerveza en strock", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Funcion que verifica que exista una cerveza del tipo indicado en el boton,
            // de ser asi lo elimina del inventario y lo añade a una lista de vendidos (a fin de controlar ventas)
            Producto p = Producto.GetInstancia();
            foreach (Cerveza c in p.Inventario)
            {
                if (c is Blonde)
                {
                    p.Inventario.Remove(c);
                    p.Vendidas.Add(c);
                    break;
                }
                else
                {
                    MessageBox.Show("No tiene ese tipo de cerveza en strock", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Funcion que verifica que exista una cerveza del tipo indicado en el boton,
            // de ser asi lo elimina del inventario y lo añade a una lista de vendidos (a fin de controlar ventas)
            Producto p = Producto.GetInstancia();
            foreach (Cerveza c in p.Inventario)
            {
                if (c is Ale)
                {
                    p.Inventario.Remove(c);
                    p.Vendidas.Add(c);
                    break;
                }
                else
                {
                    MessageBox.Show("No tiene ese tipo de cerveza en strock", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Funcion que verifica que exista una cerveza del tipo indicado en el boton,
            // de ser asi lo elimina del inventario y lo añade a una lista de vendidos (a fin de controlar ventas)
            Producto p = Producto.GetInstancia();
            foreach (Cerveza c in p.Inventario)
            {
                if (c is RedAle)
                {
                    p.Inventario.Remove(c);
                    p.Vendidas.Add(c);
                    break;
                }
                else
                {
                    MessageBox.Show("No tiene ese tipo de cerveza en strock", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void Ventas_Load(object sender, EventArgs e)
        {

        }
    }
}
