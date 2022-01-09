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
    public partial class InfoAlmacenes : Form
    {
        public InfoAlmacenes()
        {
            InitializeComponent();
        }

        private void InfoAlmacenes_Load(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            A1.OroActual = A1.RestructurarOro(0);
            A1.ElixirRojoActual = A1.RestructurarElixirRojo(0);
            A1.ElixirNegroActual = A1.RestructurarElixirNegro(0);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = A1.Almacenes;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }
    }
}
