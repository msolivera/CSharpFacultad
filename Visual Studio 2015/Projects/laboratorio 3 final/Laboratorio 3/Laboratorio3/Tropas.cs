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
    public partial class Tropas : Form
    {
        public Tropas()
        {
            InitializeComponent();
        }


        private void button13_Click(object sender, EventArgs e)
        {
            
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Cuarteles.Count == 0))
            {
                if (A1.ElixirNegroActual >= 6)
                {
                    if ((A1.ObtenerCapacidadMaximaTropas() - (A1.ObtenerCapacidadActualTropas())) >= 1)
                    {
                        foreach (CuartelOscuro cc in A1.CuartelesO)
                        {
                            cc.CrearTropa("Esbirro");
                            A1.ElixirNegroActual = A1.RestructurarElixirNegro(-6);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = A1.Tropas;
                            

                            break;
                        }
                    }
                }
                else { MessageBox.Show("No tiene suficiente elixir Oscuro para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Compre un Cuartel Oscuro en la tienda para ralizar esta acción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Cuarteles.Count == 0))
            {
                if (A1.ElixirNegroActual >= 40)
                {
                    if ((A1.ObtenerCapacidadMaximaTropas() - (A1.ObtenerCapacidadActualTropas())) >= 1)
                    {
                        foreach (CuartelOscuro cc in A1.CuartelesO)
                        {
                            cc.CrearTropa("Montapuercos");
                            A1.ElixirNegroActual = A1.RestructurarElixirNegro(-40);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = A1.Tropas;
                            break;
                        }
                    }
                }
                else { MessageBox.Show("No tiene suficiente elixir rojo para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Compre un Cuartel en la tienda para ralizar esta acción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            InformacionTropas info2 = new InformacionTropas();
            info2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Cuarteles.Count == 0))
            {
                if (A1.ElixirRojoActual >= 25)
                {
                    if ((A1.ObtenerCapacidadMaximaTropas() -(A1.ObtenerCapacidadActualTropas() )) >= 1)
                    {
                
                        foreach (CuartelComun cc in A1.Cuarteles)
                        {
                            cc.CrearTropa("Barbaro");
                            A1.ElixirRojoActual = A1.RestructurarElixirRojo(-25);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = A1.Tropas;
                            break;
                        }
                    }
                    else
                    {
                         MessageBox.Show("No tiene suficiente espacio para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); 
                    }
                }
                else { MessageBox.Show("No tiene suficiente elixir rojo para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Compre un Cuartel en la tienda para ralizar esta acción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Cuarteles.Count == 0))
            {

                if (A1.ElixirRojoActual >= 50)
                {
                    if ((A1.ObtenerCapacidadMaximaTropas() -A1.ObtenerCapacidadActualTropas() )>= 1)
                    {
                        foreach (CuartelComun cc in A1.Cuarteles)
                        {
                            cc.CrearTropa("Arquera");
                            A1.ElixirRojoActual = A1.RestructurarElixirRojo(-50);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = A1.Tropas;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tiene suficiente espacio para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else { MessageBox.Show("No tiene suficiente elixir rojo para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Compre un Cuartel en la tienda para ralizar esta acción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Cuarteles.Count == 0))
            {
                if (A1.ElixirRojoActual >= 250)
                {
                    if ((A1.ObtenerCapacidadMaximaTropas() -A1.ObtenerCapacidadActualTropas() ) >= 5)
                    {
                        foreach (CuartelComun cc in A1.Cuarteles)
                        {
                            cc.CrearTropa("Gigante");
                            A1.ElixirRojoActual = A1.RestructurarElixirRojo(-250);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = A1.Tropas;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tiene suficiente espacio para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else { MessageBox.Show("No tiene suficiente elixir rojo para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Compre un Cuartel en la tienda para ralizar esta acción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Cuarteles.Count == 0))
            {
                if (A1.ElixirRojoActual >= 1500)
                {
                    if ((A1.ObtenerCapacidadMaximaTropas() -A1.ObtenerCapacidadActualTropas() ) >= 4)
                    {
                        foreach (CuartelComun cc in A1.Cuarteles)
                        {
                            cc.CrearTropa("Mago");
                            A1.ElixirRojoActual = A1.RestructurarElixirRojo(-1500);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = A1.Tropas;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tiene suficiente espacio para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { MessageBox.Show("No tiene suficiente elixir rojo para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Compre un Cuartel en la tienda para ralizar esta acción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Cuarteles.Count == 0))
            {
                if (A1.ElixirRojoActual >= 25)
                {
                    if ((A1.ObtenerCapacidadMaximaTropas() - A1.ObtenerCapacidadActualTropas()) >= 1)
                    {
                        foreach (CuartelComun cc in A1.Cuarteles)
                        {
                            cc.CrearTropa("Duende");
                            A1.ElixirRojoActual = A1.RestructurarElixirRojo(-25);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = A1.Tropas;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tiene suficiente espacio para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { MessageBox.Show("No tiene suficiente elixir rojo para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Compre un Cuartel en la tienda para ralizar esta acción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Cuarteles.Count == 0))
            {
                if (A1.ElixirRojoActual >= 2000)
                {
                    if ((A1.ObtenerCapacidadMaximaTropas() -A1.ObtenerCapacidadActualTropas() ) >= 5)
                    {
                        foreach (CuartelComun cc in A1.Cuarteles)
                        {
                            cc.CrearTropa("Globo Bombastico");
                            A1.ElixirRojoActual = A1.RestructurarElixirRojo(-2000);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = A1.Tropas;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tiene suficiente espacio para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { MessageBox.Show("No tiene suficiente elixir rojo para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Compre un Cuartel en la tienda para ralizar esta acción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Cuarteles.Count == 0))
            {
                if (A1.ElixirRojoActual >= 2800)
                {
                    if((A1.ObtenerCapacidadMaximaTropas() -A1.ObtenerCapacidadActualTropas() ) >= 25)
                    {
                        foreach (CuartelComun cc in A1.Cuarteles)
                        {
                            cc.CrearTropa("P.E.K.K.A.");
                            A1.ElixirRojoActual = A1.RestructurarElixirRojo(-2800);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = A1.Tropas;
                            break;
                        }
                    }
                                        else
                    {
                        MessageBox.Show("No tiene suficiente espacio para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { MessageBox.Show("No tiene suficiente elixir rojo para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Compre un Cuartel en la tienda para ralizar esta acción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Cuarteles.Count == 0))
            {
                if (A1.ElixirRojoActual >= 7500)
                {
                    if ((A1.ObtenerCapacidadMaximaTropas() -A1.ObtenerCapacidadActualTropas() ) >= 10)
                    {
                        foreach (CuartelComun cc in A1.Cuarteles)
                        {
                            cc.CrearTropa("Dragon");
                            A1.ElixirRojoActual = A1.RestructurarElixirRojo(-7500);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = A1.Tropas;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tiene suficiente espacio para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { MessageBox.Show("No tiene suficiente elixir rojo para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Compre un Cuartel en la tienda para ralizar esta acción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Cuarteles.Count == 0))
            {
                if (A1.ElixirRojoActual >= 100)
                {
                    if ((A1.ObtenerCapacidadMaximaTropas() -A1.ObtenerCapacidadActualTropas() ) >= 2)
                    {
                        foreach (CuartelComun cc in A1.Cuarteles)
                        {
                            cc.CrearTropa("Esqueleto");
                            A1.ElixirRojoActual = A1.RestructurarElixirRojo(-100);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = A1.Tropas;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tiene suficiente espacio para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { MessageBox.Show("No tiene suficiente elixir rojo para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Compre un Cuartel en la tienda para ralizar esta acción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Cuarteles.Count == 0))
            {
                if (A1.ElixirRojoActual >= 25)
                {
                    foreach (CuartelComun cc in A1.Cuarteles)
                    {
                        if ((A1.ObtenerCapacidadMaximaTropas() -A1.ObtenerCapacidadActualTropas() ) >= 14)
                        {
                            cc.CrearTropa("Curandera");
                            A1.ElixirRojoActual = A1.RestructurarElixirRojo(-25);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = A1.Tropas;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("No tiene suficiente espacio para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else { MessageBox.Show("No tiene suficiente elixir rojo para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Compre un Cuartel en la tienda para ralizar esta acción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Cuarteles.Count == 0))
            {
                if (A1.ElixirRojoActual >= 1500)
                {
                    if ((A1.ObtenerCapacidadMaximaTropas() -A1.ObtenerCapacidadActualTropas() ) >= 10)
                    {
                        foreach (CuartelComun cc in A1.Cuarteles)
                        {
                            cc.CrearTropa("Dragon Bebe");
                            A1.ElixirRojoActual = A1.RestructurarElixirRojo(-1500);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = A1.Tropas;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tiene suficiente espacio para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { MessageBox.Show("No tiene suficiente elixir rojo para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Compre un Cuartel en la tienda para ralizar esta acción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Cuarteles.Count == 0))
            {
                if (A1.ElixirRojoActual >= 4000)
                {
                    if ((A1.ObtenerCapacidadMaximaTropas() -A1.ObtenerCapacidadActualTropas() ) >= 5)
                    {
                        foreach (CuartelComun cc in A1.Cuarteles)
                        {
                            cc.CrearTropa("Minero");
                            A1.ElixirRojoActual = A1.RestructurarElixirRojo(-4000);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = A1.Tropas;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tiene suficiente espacio para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { MessageBox.Show("No tiene suficiente elixir rojo para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Compre un Cuartel en la tienda para ralizar esta acción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Cuarteles.Count == 0))
            {
                if (A1.ElixirNegroActual >= 70)
                {
                    if ((A1.ObtenerCapacidadMaximaTropas() -A1.ObtenerCapacidadActualTropas() ) >= 8)
                    {
                        foreach (CuartelOscuro cc in A1.CuartelesO)
                        {
                            cc.CrearTropa("Valquiria");
                            A1.ElixirNegroActual = A1.RestructurarElixirNegro(-70);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = A1.Tropas;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tiene suficiente espacio para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { MessageBox.Show("No tiene suficiente elixir negro para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Compre un Cuartel en la tienda para ralizar esta acción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Cuarteles.Count == 0))
            {
                if (A1.ElixirNegroActual >= 450)
                {
                    if ((A1.ObtenerCapacidadMaximaTropas() -A1.ObtenerCapacidadActualTropas() ) >= 30)
                    {
                        foreach (CuartelOscuro cc in A1.CuartelesO)
                        {
                            cc.CrearTropa("Golem");
                            A1.ElixirNegroActual = A1.RestructurarElixirNegro(-450);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = A1.Tropas;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tiene suficiente espacio para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { MessageBox.Show("No tiene suficiente elixir negro para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Compre un Cuartel Oscuro en la tienda para ralizar esta acción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Cuarteles.Count == 0))
            {
                if (A1.ElixirNegroActual >= 250)
                {
                    if ((A1.ObtenerCapacidadMaximaTropas() -A1.ObtenerCapacidadActualTropas() ) >= 12)
                    {
                        foreach (CuartelOscuro cc in A1.CuartelesO)
                        {
                            cc.CrearTropa("Bruja");
                            A1.ElixirNegroActual = A1.RestructurarElixirNegro(-250);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = A1.Tropas;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tiene suficiente espacio para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { MessageBox.Show("No tiene suficiente elixir negro para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Compre un Cuartel Oscuro en la tienda para ralizar esta acción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Cuarteles.Count == 0))
            {
                if (A1.ElixirNegroActual >= 390)
                {
                    if ((A1.ObtenerCapacidadMaximaTropas() -A1.ObtenerCapacidadActualTropas() ) >= 8)
                    {
                        foreach (CuartelOscuro cc in A1.CuartelesO)
                        {
                            cc.CrearTropa("Sabueso de lava");
                            A1.ElixirNegroActual = A1.RestructurarElixirNegro(-390);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = A1.Tropas;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tiene suficiente espacio para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { MessageBox.Show("No tiene suficiente elixir negro para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Compre un Cuartel Oscuro en la tienda para ralizar esta acción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            if (!(A1.Cuarteles.Count == 0))
            {
                if (A1.ElixirNegroActual >= 130)
                {
                    if ((A1.ObtenerCapacidadMaximaTropas() -A1.ObtenerCapacidadActualTropas() ) >= 6)
                    {
                        foreach (CuartelOscuro cc in A1.CuartelesO)
                        {
                            cc.CrearTropa("Lanzarocas");
                            A1.ElixirNegroActual = A1.RestructurarElixirNegro(-130);
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = A1.Tropas;
                            break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tiene suficiente espacio para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else { MessageBox.Show("No tiene suficiente elixir negro para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            else { MessageBox.Show("Compre un Cuartel Oscuro en la tienda para ralizar esta acción", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void button20_Click(object sender, EventArgs e)
        {

            Aldea A1 = Aldea.GetInstancia();
                if (A1.ElixirNegroActual >= 10000)
                {
                        foreach (Tropa t in A1.Tropas)
                        {
                            if (!(t.Nombre == "Rey Bárbaro"))
                            {
                                Heroe h1 = new ReyBarbaro("Rey Bárbaro", 1500, 1, 16, 119, 0, 10000, "Puño de hierro");
                                A1.ElixirNegroActual = A1.RestructurarElixirNegro(-10000);
                                A1.Tropas.Add(t);
                                dataGridView1.DataSource = null;
                                dataGridView1.DataSource = A1.Tropas;

                        }
                            else
                            {
                                MessageBox.Show("Solo puedes tener un Rey Bárbaro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        }
                    }
                     else
                    {
                        MessageBox.Show("No tiene suficiente elixir negro para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

            
        }

        

        private void button21_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
                if (A1.ElixirNegroActual >= 40000)
                {
                        foreach (Tropa t in A1.Tropas)
                        {
                            if (!(t.Nombre == "Reina Arquera"))
                            {
                                Heroe h2 = new ReinaArquera("Reina Arquera", 1500, 1, 16, 119, 0, 40000,"Manto real");
                                A1.ElixirNegroActual = A1.RestructurarElixirNegro(-40000);
                                A1.Tropas.Add(t);
                                dataGridView1.DataSource = null;
                                dataGridView1.DataSource = A1.Tropas;

                        }
                            else
                            {
                                MessageBox.Show("Solo puedes tener una Reina Arquera", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        }
                  }
                   else
                   {
                        MessageBox.Show("No tiene suficiente elixir negro para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }


        }

        private void button22_Click(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();

                if (A1.ElixirRojoActual >= 60000)
                {
                        foreach (Tropa t in A1.Tropas)
                        {
                            if( !(t.Nombre=="Gran Centinela"))
                            {
                                Heroe h3 = new GranCentinela ("Gran Centinela", 1500, 1, 16, 119, 0, 60000,"Libro eterno");
                               A1.ElixirRojoActual = A1.RestructurarElixirRojo(-60000);
                                A1.Tropas.Add(t);
                                dataGridView1.DataSource = null;
                                dataGridView1.DataSource = A1.Tropas;

                        }
                            else
                            {
                                MessageBox.Show("Solo puedes tener un Gran Centinela", "Alerta", MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }
                                
                            break;
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("No tiene suficiente elixir rojo para crear esta tropa", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }

        private void Tropas_Load(object sender, EventArgs e)
        {
            Aldea A1 = Aldea.GetInstancia();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = A1.Tropas;
            dataGridView1.Columns[5].Visible = false;



        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    
    

