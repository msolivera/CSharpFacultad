using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuarta_clase
{
    class Alumno
    {
        string nombre;

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;

            }
        }





        public string Apellido { get; set; }
        public string GetNombre()
        {
            return this.nombre;
        }
    }
    public void SetNombre(string nombre);

}
