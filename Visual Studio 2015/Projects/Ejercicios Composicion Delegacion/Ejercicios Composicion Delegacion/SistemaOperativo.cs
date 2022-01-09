using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Composicion_Delegacion
{
    class SistemaOperativo
    {
        private readonly String nombre;
        private readonly String version;
        public Celular CelVinculado { get; set; }

        internal Celular Celular
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public SistemaOperativo(String nombre, String version)
        {
            this.nombre = nombre;
            this.version = version;
        }
        public void Inicializarse()
        {
            Console.WriteLine("Iniciando Sesion...");
            Console.WriteLine("Sesion Iniciada con Exito!");
            
        }
        public void Apagarse()
        {
            Console.WriteLine("Cerrando Sesion...");
        }

        public void EjecutarProgramas (String nombrePrograma)
        {
            Console.WriteLine("Se Esta Ejecutando "+nombrePrograma);
        }
    }
}
