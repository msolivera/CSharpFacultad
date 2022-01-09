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
    public partial class Edificios : Form
    {
        public Edificios()
        {
            InitializeComponent();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            InformacionEdificios info1 = new InformacionEdificios();
            info1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();

            if (A1.CastilloClan== null)
            {
                if (A1.ObtenerOroActual() > 1000)
                {
                    CastilloDeClan castillo = new CastilloDeClan("Castillo del Clan", 4000, 1, 1000);
                    A1.CastilloClan = castillo;
                    A1.ListEdificios.Add(castillo);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = A1.ListEdificios;
                    A1.OroActual = A1.RestructurarOro(-1000);


                }
                else
                {
                    MessageBox.Show("No tienes Suficiente Oro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Solo puedes tener un Castillo del Clan", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Campamento.Count >= 4))
            {
                if (A1.ObtenerElixirRojoActual() > 250)
                {
                    Campamento c = new Campamento("Campamento", 400, 1, 250);
                    A1.Campamento.Add(c);
                    A1.ListEdificios.Add(c);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = A1.ListEdificios;
                    A1.OroActual = A1.RestructurarOro(-250);
                }
                else
                {
                    MessageBox.Show("No tienen suficiente Elixir", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("No puedes comprar mas de cuatro Campamentos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
                if (!(A1.Cuarteles.Count >= 4))
                {
                    if (A1.ObtenerElixirRojoActual() > 200)
                    {
                        CuartelComun cuartel1 = new CuartelComun("Cuartel Comun", 580, 1, 200);
                        A1.Cuarteles.Add(cuartel1);
                        A1.ListEdificios.Add(cuartel1);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = A1.ListEdificios;
                        A1.OroActual = A1.RestructurarOro(-200);
                }
                    else
                    {
                    MessageBox.Show("No tienes suficiente Elixir", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
            }
                else
                {
                    MessageBox.Show("No puedes comprar mas de cuatro Cuarteles", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
         }

        private void button5_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if(!(A1.CuartelesO.Count >= 2))
            {
                if (A1.ObtenerElixirRojoActual() > 7500)
                {
                    CuartelOscuro cuartel2 = new CuartelOscuro("Cuartel Oscuro", 700, 1, 7500);
                    A1.CuartelesO.Add(cuartel2);
                    A1.ListEdificios.Add(cuartel2);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = A1.ListEdificios;
                    A1.OroActual = A1.RestructurarOro(-7500);
                }
                else
                {
                    MessageBox.Show("No tienes suficiente Elixir", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("No puedes comprar mas de dos Cuarteles", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Aldea A1 = Aldea.GetInstancia();
            Int32 contador = 0;
            foreach (Almacen al in A1.Almacenes)
            {
                if (al is AlmacenOro)
                {
                    contador += 1;
                }
            }
            if (contador < 4)
            {
                if (A1.ObtenerElixirRojoActual() > 300)
                {
                    AlmacenOro AlmacenOro = new AlmacenOro();
                    A1.Almacenes.Add(AlmacenOro);
                    A1.ListEdificios.Add(AlmacenOro);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = A1.ListEdificios;
                    A1.ElixirRojoActual = A1.RestructurarElixirRojo(-300);
                }
                else
                {
                    MessageBox.Show("No tienes suficiente Elixir", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("No puedes tener mas de 4 almacenes de oro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            Int32 contador = 0;
            foreach (Almacen al in A1.Almacenes)
            {
                if (al is AlmacenElixirRojo)
                {
                    contador += 1;
                }
            }
            if (contador < 4)
            {
                if (A1.ObtenerOroActual() >= 300)
                {
                    AlmacenElixirRojo AlmacenRojo = new AlmacenElixirRojo();
                    A1.Almacenes.Add(AlmacenRojo);
                    A1.ListEdificios.Add(AlmacenRojo);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = A1.ListEdificios;
                    A1.OroActual = A1.RestructurarOro(-300);

                }
                else
                {
                    MessageBox.Show("No tienes suficiente Oro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("No puedes tener mas de 4 almacenes de elixir rojo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

            Aldea A1 = Aldea.GetInstancia();
            Int32 contador = 0;
            foreach (Almacen al in A1.Almacenes)
            {
                if (al is AlmacenElixirOscuro)
                {
                    contador += 1;
                }
            }
            if (contador < 1)
            {
                if (A1.ObtenerElixirRojoActual() > 600)
                {
                    AlmacenElixirOscuro AlmacenNegro = new AlmacenElixirOscuro();
                    A1.Almacenes.Add(AlmacenNegro);
                    A1.ListEdificios.Add(AlmacenNegro);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = A1.ListEdificios;
                    A1.ElixirRojoActual = A1.RestructurarElixirRojo(-600);
                }
                else
                {
                    MessageBox.Show("No tienes suficiente Elixir", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("No pudes comprar mas de un Almacen de Elixir Oscuro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            Int32 contadorRecO = A1.ObtenerRecolectoresOro();
            if (!(contadorRecO >= 6))
            {
                if (A1.ObtenerElixirRojoActual() > 150)
                {
                    RecolectorOro RecOro = new RecolectorOro();
                    A1.Recolectores.Add(RecOro);
                    A1.ListEdificios.Add(RecOro);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = A1.ListEdificios;
                    A1.ElixirRojoActual = A1.RestructurarElixirRojo(-150);
                }
                else
                {
                    MessageBox.Show("No tienes suficiente Elixir", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("No puedes comprar mas de seis Recolectores de Oro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            Int32 contadorRecEN = A1.ObtenerRecolectoresElixirNegro();
            if (!(contadorRecEN >= 3))
            {
                if (A1.ObtenerElixirRojoActual() > 1500)
                {
                    RecolectorElixirOscuro RecOscuro = new RecolectorElixirOscuro();
                    A1.Recolectores.Add(RecOscuro);
                    A1.ListEdificios.Add(RecOscuro);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = A1.ListEdificios;
                    A1.ElixirRojoActual = A1.RestructurarElixirRojo(-1500);

                }
                else
                {
                    MessageBox.Show("No tienes suficiente Elixir", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("No puedes comprar mas de tres Recolectores de Elixir Oscuro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            Int32 contadorRecER = A1.ObtenerRecolectoresElixirRojo();
            if (!(contadorRecER >= 6))
            {
                if (A1.ObtenerOroActual() > 150)
                {
                    RecolectorElixirRojo RecRojo = new RecolectorElixirRojo();
                    A1.Recolectores.Add(RecRojo);
                    A1.ListEdificios.Add(RecRojo);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = A1.ListEdificios;
                    A1.OroActual = A1.RestructurarOro(-150);

                }
                else
                {
                    MessageBox.Show("No tienes suficiente Oro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("No puedes comprar mas de seis Recolectores de Elixir Rojo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.ObtenerOroActual()<1000))
            {

                    Defensa torreArquera = new TorreArqueras("Torre de Aqueras", 800, 1, 1000, "Tierra y Aire", 75, 500, 0);
                    A1.Defensas.Add(torreArquera);
                    A1.ListEdificios.Add(torreArquera);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = A1.ListEdificios;
                    A1.OroActual = A1.RestructurarOro(-1000);

            }
            else
            {
                MessageBox.Show("No tienes suficiente Oro para comprar este articulo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.ObtenerOroActual() < 250))
            {
               
                    Defensa cañon = new Cañon("Cañon", 1000, 1, 250, "Tierra", 95, 500, 0);
                    A1.Defensas.Add(cañon);
                    A1.ListEdificios.Add(cañon);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = A1.ListEdificios;
                    A1.OroActual = A1.RestructurarOro(-250);


            }
            else
            {
                MessageBox.Show("No tienes suficiente Oro para comprar este articulo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.ObtenerOroActual() < 1800))
            {
      
                    Defensa torreMagos = new TorreMagos("Torre de Magos", 1400, 1, 1800, "Tierra y Aire", 48, 500, 0);
                    A1.Defensas.Add(torreMagos);
                    A1.ListEdificios.Add(torreMagos);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = A1.ListEdificios;
                    A1.OroActual = A1.RestructurarOro(-1800);


            }
            else
            {
                MessageBox.Show("No tienes suficiente Oro para comprar este articulo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.ObtenerOroActual() < 2500))
            {

                    Defensa coheteAntiaereo = new Cohete("Cohete Antiaereo", 1100, 1, 2500, "Aire", 280, 0, 1000);
                    A1.Defensas.Add(coheteAntiaereo);
                    A1.ListEdificios.Add(coheteAntiaereo);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = A1.ListEdificios;
                    A1.OroActual = A1.RestructurarOro(-2500);


            }
            else
            {
                MessageBox.Show("No tienes suficiente Oro para comprar este articulo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.ObtenerOroActual() < 1000))
            {

                    Defensa tesla = new Tesla("Torre Tesla", 800, 1, 1000, "Tierra y Aire", 87, 0, 10);
                    A1.Defensas.Add(tesla);
                    A1.ListEdificios.Add(tesla);
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = A1.ListEdificios;
                    A1.OroActual = A1.RestructurarOro(-1000);


            }
            else
            {
                MessageBox.Show("No tienes suficiente Oro para comprar este articulo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.ObtenerOroActual() < 30000))
            {
                Defensa ballesta = new Ballesta("Ballesta", 3000, 1, 30000, "Tierra y Aire", 110, 500, 0);
                A1.Defensas.Add(ballesta);
                A1.ListEdificios.Add(ballesta);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = A1.ListEdificios;
                A1.OroActual = A1.RestructurarOro(-30000);

            }
            else
            {
                MessageBox.Show("No tienes suficiente Oro para comprar este articulo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.ObtenerOroActual() < 50000))
            {
                Defensa torreInfernal = new TorreInfernal("Torre Infernal", 2400, 1, 50000, "Tierra Aire", 41, 0, 1000);
                A1.Defensas.Add(torreInfernal);
                A1.ListEdificios.Add(torreInfernal);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = A1.ListEdificios;
                A1.OroActual = A1.RestructurarOro(-50000);

            }
            else
            {
                MessageBox.Show("No tienes suficiente Oro para comprar este articulo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.ObtenerOroActual() < 50))
            {
                Defensa muro = new Muro("Muro", 8500, 1, 50, "Tierra", 0, 10, 0);
                A1.Defensas.Add(muro);
                A1.ListEdificios.Add(muro);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = A1.ListEdificios;
                A1.OroActual = A1.RestructurarOro(-50);

            }
            else
            {
                MessageBox.Show("No tienes suficiente Oro para comprar este articulo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.ObtenerOroActual() < 80000))
            {
                Defensa aguila = new AguilaArtilleria("Águila de Artilleria", 4400, 1, 80000, "Tierra y Aire", 90, 0, 1000);
                A1.Defensas.Add(aguila);
                A1.ListEdificios.Add(aguila);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = A1.ListEdificios;
                A1.OroActual = A1.RestructurarOro(-80000);

            }
            else
            {
                MessageBox.Show("No tienes suficiente Oro para comprar este articulo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Edificios_Load(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = A1.ListEdificios;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
