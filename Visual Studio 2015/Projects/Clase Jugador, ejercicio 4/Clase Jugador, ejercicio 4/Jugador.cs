using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Jugador__ejercicio_4
{
    class Jugador
    {
        private String nombre;
        private String apellido;
        public int edad { get; set; }
        public String posicion { get; set; }

        public String GetNombre()
        {
            return this.nombre;
        }
        public String GetApellido()
        {
            return this.apellido;
        }
        public Jugador(String nombre, String apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = 0;
            this.posicion = "";
        }




    }
}
