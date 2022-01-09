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
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Stock_Load(object sender, EventArgs e)
        {
            //muestra los elementos de la lista inventario.
            Producto p = Producto.GetInstancia();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = p.Inventario;

        }
    }
}
