using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Composicion_Delegacion
{
    class Celular
    {
        private readonly String marca;
        private readonly String modelo;
        private readonly String color;
        private String Estado { get; set; }
        public Display display { get; set; }
        public SistemaOperativo sistemaOperativo { get; set; }
        public SIM sim { get; set; }

        internal SistemaOperativo SistemaOperativo
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal SIM SIM
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal Display Display
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Celular(String marca, String modelo, String color)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.display = display;
            this.sim = sim;
            this.Estado = "Apagado";
        }

        public void InstalarSistemaOperativo(SistemaOperativo so)
        {
            if (this.Estado == "Encendido")
            {
                this.sistemaOperativo = so;
                so.CelVinculado = this;
            }
        }
        public void Prender()
        {
            if (!(this.sistemaOperativo == null))
            {
                this.Estado = "Encendido";
                sistemaOperativo.Inicializarse();
            }
        }

        public void Apagar()
        {

            this.Estado = "Apagado";
            sistemaOperativo.Apagarse();

        }

        public void MandarMensaje(String mensaje, Int32 numero)
        {
            if (!(this.sistemaOperativo == null))
            {
                if (!(this.sim == null))
                {
                    sim.EnviarSMS(mensaje, numero);

                }
                else
                {
                    Console.WriteLine("No se encuentra tarjera SIM");
                }
            }
        }

        public void Llamar(Int32 numero)
        {
            if (!(this.sistemaOperativo == null))
            {
                if (!(this.sim == null))
                {
                    sim.Llamar(numero);
                }

                else
                {
                    Console.WriteLine("No se encuentra tarjera SIM");

                }
            }
        }
        public void AcercaDelDispositivo()
        {
            if (!(this.sistemaOperativo == null))
            {
                if (this.Estado == "Encendido")
                {
                    Console.WriteLine(this.marca + " " + this.modelo);
                }
            }

        }
        public void MostrarEnPantalla(String mensaje)
        {
            if (!(this.sistemaOperativo == null))
            {
                if (!(this.display == null))
                {
                    display.MostrarMensaje(mensaje);
                }
            }
        }
    }
}
