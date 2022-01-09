using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tercera_clase_Clase_alumno
{ 
       class Alumno
        {
            private string nombre;
            private string apellido;

            public Alumno(string n, string a)
            {
                nombre = n;
                apellido = a;
            }

            public string GetNombre()
            {
                return nombre;
            }
            public string GetApellido()
            {
                return apellido;
            }
            public void SetNombre(string valor)
            {
                nombre = valor;

            }
            public void SetApellido(string valor1)
            {
                apellido = valor1;

            }
        }
    }


