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
    public partial class FormAldea : Form
    {
        public Aldea miAldea { get; private set; }
        public FormAldea(String nombreAldea)
        {
             
            InitializeComponent();

            this.Text = "Bienvenido " + nombreAldea;

            Aldea A1 = Aldea.GetInstancia();
            A1.Nombre = nombreAldea;

        }
        public String nombre = "";

        private void FormAldea_Load(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            label1.Text = A1.ObtenerOroActual() + "/" + A1.ObtenerOroMaximo();
            label2.Text = A1.ObtenerElixirRojoActual() + "/" + A1.ObtenerElixirRojoMaximo();
            label3.Text = A1.ObtenerElixirOscuroActual() + "/" + A1.ObtenerElixirOscuroMaximo();
            label4.Text = A1.ObtenerCapacidadActualTropas() + "/" + A1.ObtenerCapacidadMaximaTropas();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Edificios edificio = new Edificios();
            edificio.ShowDialog();
            Aldea A1 = Aldea.GetInstancia();
            label1.Text = A1.ObtenerOroActual() + "/" + A1.ObtenerOroMaximo();
            label2.Text = A1.ObtenerElixirRojoActual() + "/" + A1.ObtenerElixirRojoMaximo();
            label3.Text = A1.ObtenerElixirOscuroActual() + "/" + A1.ObtenerElixirOscuroMaximo();
            label4.Text = A1.ObtenerCapacidadActualTropas() + "/" + A1.ObtenerCapacidadMaximaTropas();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tropas tropas = new Tropas();
            tropas.ShowDialog();
            Aldea A1 = Aldea.GetInstancia();
            label1.Text = A1.ObtenerOroActual() + "/" + A1.ObtenerOroMaximo();
            label2.Text = A1.ObtenerElixirRojoActual() + "/" + A1.ObtenerElixirRojoMaximo();
            label3.Text = A1.ObtenerElixirOscuroActual() + "/" + A1.ObtenerElixirOscuroMaximo();
            label4.Text = A1.ObtenerCapacidadActualTropas() + "/" + A1.ObtenerCapacidadMaximaTropas();
        }

        private void button22_Click(object sender, EventArgs e)

        {
            Aldea A1 = Aldea.GetInstancia();
            Int32 OroRecolectado = 0;
            Int32 ElixirRecolectado = 0;
            Int32 ElixirNegroRecolectado = 0;

            if (A1.Recolectores.Count >= 1)
            {

                foreach (IRecolector rec in A1.Recolectores)
                {
                    Int32 Valor = rec.Recolectar();
                    if (rec is RecolectorElixirOscuro)
                    {
                        ElixirNegroRecolectado += Valor;
                    }
                    if (rec is RecolectorElixirRojo)
                    {
                        ElixirRecolectado += Valor;
                    }
                    if (rec is RecolectorOro)
                    {
                        OroRecolectado += Valor;
                    }

                }
                A1.OroActual = A1.RestructurarOro(OroRecolectado);
                A1.ElixirRojoActual = A1.RestructurarElixirRojo(ElixirRecolectado);
                A1.ElixirNegroActual = A1.RestructurarElixirNegro(ElixirNegroRecolectado);
                
                
            }
            else
            {
                MessageBox.Show("No dispones de Recolectores de ningún tipo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label1.Text = A1.ObtenerOroActual() + "/" + A1.ObtenerOroMaximo();
            label2.Text = A1.ObtenerElixirRojoActual() + "/" + A1.ObtenerElixirRojoMaximo();
            label3.Text = A1.ObtenerElixirOscuroActual() + "/" + A1.ObtenerElixirOscuroMaximo();

        }

                
                
        public void Refrescar()
        {
            this.Refresh();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            InfoAlmacenes info = new InfoAlmacenes();
            info.ShowDialog();
        }
    }
}
