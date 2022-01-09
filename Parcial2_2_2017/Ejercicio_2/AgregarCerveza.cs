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
    public partial class AgregarCerveza : Form
    {
        public AgregarCerveza()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Crea un elemento del tipo indicado en el boton y lo añade en la lista de inventarios
            IPA ipa = new IPA(1, "Pilsen", 100);
            Producto p = Producto.GetInstancia();
            p.Inventario.Add(ipa);
        }

        private void button2_Click(object sender, EventArgs e)
        {            // Crea un elemento del tipo indicado en el boton y lo añade en la lista de inventarios

            Porter porter = new Porter(2, "Pilsen", 200);
            Producto p = Producto.GetInstancia();
            p.Inventario.Add(porter);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Crea un elemento del tipo indicado en el boton y lo añade en la lista de inventarios

            Blonde blonde = new Blonde(3, "Pilsen", 120);
            Producto p = Producto.GetInstancia();
            p.Inventario.Add(blonde);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Crea un elemento del tipo indicado en el boton y lo añade en la lista de inventarios

            Ale ale = new Ale(4, "pilsen", 150);
            Producto p = Producto.GetInstancia();
            p.Inventario.Add(ale);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Crea un elemento del tipo indicado en el boton y lo añade en la lista de inventarios

            RedAle redAle = new RedAle(5, "pilsen", 200);
            Producto p = Producto.GetInstancia();
            p.Inventario.Add(redAle);
        }

        private void AgregarCerveza_Load(object sender, EventArgs e)
        {

        }
    }
}
