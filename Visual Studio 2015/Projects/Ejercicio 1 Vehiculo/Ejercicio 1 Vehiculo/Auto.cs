using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1_Vehiculo
{
    class Auto
    {
        private readonly string marca;
        private readonly string modelo;
        public string Color { get; set; }
        public string Matricula { get; set; }
        public int VelMaxima { get; set; }
        public int VelActual { get; set; }
        public string Estado { get; set; }

        public Auto (string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.Color = "";
            this.Matricula = "";
            this.VelActual = 0;
            this.VelMaxima = 0;
            this.Estado = "Apagado";
        }

        public void Arrancar()
        {
            if (Estado == "Apagado")
            {
                Estado = "Encendido";
            }
            Console.WriteLine("Se encendio el auto!");
        }
        public void Apagar()
        {
            if (Estado == "Encendido")
            {
                Estado = "Apagado";
            }
            Console.WriteLine("Se apago ewl auto!");
        }

        public void MostrarEstado()
        {
            Console.WriteLine(this.Estado);
        }

        public void Acelerar(int velocidad)
        {
            if ( Estado=="Encendido" && ((VelActual+velocidad)<  VelMaxima))
            {
                VelActual += velocidad;
                Console.WriteLine(this.VelActual);
            }
            else
            {
                Console.WriteLine("No puedes acelerar mas el auto");
            }

        }
        public void Desacelerar (int velocidad)
        {
            if (Estado == "Encendido" && ((VelActual + velocidad) >= 0))
            {
                VelActual -= velocidad;
            }
            else
            {
                Console.WriteLine("No puedes desacelerar mas el auto");
            }
        }
        public void Frenar()
        {
            if (Estado == "Encendido")
            {
                this.VelActual = 0;
            }
        }
        public void MuestraVelActual()
        {
            Console.WriteLine("Velocidad actual "+this.VelActual);
        }
        public void Ficha()
        {
            Console.WriteLine("Ficha de automovil: \n Marca: "+this.marca+"\n Modelo: "+this.modelo+"\n Color: "+this.Color+"\n Matricula: "+this.Matricula+"\n Estado: "+this.Estado+"\n" );
        }

    }
    
}
