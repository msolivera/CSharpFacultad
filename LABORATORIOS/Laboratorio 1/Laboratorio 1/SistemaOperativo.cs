using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1
{
    class SistemaOperativo
    {
        public readonly Int32 id;
        public readonly String nombre;
        public readonly String version;
        public Computadora pcVinculada;
        public int peso; //Peso en GB del sistema operativo

        public SistemaOperativo (String nombre, String version, int peso)
        {
            this.id = Local.DarId();
            this.nombre = nombre;
            this.version = version;
            this.peso = peso;
            Local.AñadirComponente(this);
             

        }
        /// <summary>
        /// Impresión de valores asociados al objeto.
        /// <returns>Devuelve una cadena estructurada con los valores pertenecientes al objeto</returns>
        public String Imprimir()
        {
            return "Nombre: " + this.nombre +" Version: "+ this.version;
        }
        /// <summary>
        /// Instala un programa dado como parámetro (agrega) al objeto Computadora vinculado.
        /// </summary>
        /// <param name="program">Corresponde a un objeto programa</param>
        public void InstalarPrograma (Programa program)
        {
            if (!(pcVinculada == null))
            {
                if (pcVinculada.Estado == "Encendida")
                {

                    if (pcVinculada.capacidad >= program.peso)
                    {

                        pcVinculada.capacidad -= program.peso;
                        pcVinculada.programas.Add(program);
                        Local.EliminarComponente(program);


                    }
                    else
                    {
                        Console.WriteLine("No dispone de espacio disponible en el disco para la instalación de este programa");
                    }
                }
                else { Console.WriteLine("Debe tener la computadora encendida para realizar esta acción"); }
            }
        }
        /// <summary>
        /// Desinstala un programa dado como parámetro (elimina) al objeto Computadora vinculado.
        /// </summary>
        /// <param name="program">Corresponde a un objeto programa</param>
        public void DesintalarPrograma(Programa programa)
        {
            if (pcVinculada.Estado == "Encendida")
            {
                pcVinculada.programas.Remove(programa);
                Console.WriteLine("Se ha Desinstalado: " + programa.Imprimir());
                pcVinculada.capacidad += programa.peso;
                Local.AñadirComponente(programa);
            }
            else
            { Console.WriteLine("Debe tener la computadora encendida para realizar esta acción"); }
        }
    }
}
