﻿using System;
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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearAldea Aldea = new CrearAldea();
            if (Aldea.ShowDialog()== DialogResult.OK)
            {
                MessageBox.Show("Funciona");
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
