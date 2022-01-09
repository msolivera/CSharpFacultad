using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    public class Cerveza
    {
        public String Marca { get; private set; }
        public Cerveza(String marca)
        {
            Marca = marca;
        }
        public virtual void Madurar()
        {
            Console.WriteLine("Madurando una cerveza.");
        }
    }

    public class BarleyWine: Cerveza
    {
        public BarleyWine(String marca) : base(marca) { }
        public override void Madurar()
        {
            Console.WriteLine("Madurando una cerveza en unos meses.");
        }
        public void Madurar (Int32 años)//Ejemplo de sobrecarga de metodos
        {
            Console.WriteLine("Madurando una cerveza en "+años +" años!");
        }
    }


    class Program
    {
        
        static void Main(string[] args)
        {
            List<Cerveza> cervezas = new List<Cerveza>();

            // Parte 1:
            // -----------------------------
            //
            // Modifique las clases Cerveza y BarleyWine para que la 
            // siguiente líneas de código muestren consola "Madurando una cerveza en unos meses".
            // NO se pueden modificar las líneas 1 y 2.

            /*1*/
            Cerveza cerveza = new BarleyWine("Fullers");
            /*2*/ cerveza.Madurar();


            /* *
             * Parte 2: 
             * ---------------------------------------
             * 
             * Corrija el siguiente código para que muestre en pantalla las marcas de 
             * 10 cervezas BarleyWine de diferentes marcas (las que estan listadas en el vector).-
             * No puede mostrar el vector, sino los elementos de la variable "cervezas".
             * */
             String[] marcas = new String[10];
            marcas[0] = "Fullers";
            marcas[1] = "Guaraní";
            marcas[2] = "Patricia";
            marcas[3] = "Two Roads";
            marcas[4] = "Davok";
            marcas[5] = "Antares";
            marcas[6] = "Blest";
            marcas[7] = "Berlina";
            marcas[8] = "Barbarian";
            marcas[9] = "Big Foot";

            int i = 0;
            while (i > 0)
            {
                BarleyWine barley = new BarleyWine(marcas[i]);
                cervezas.Add(barley);
                i++;
            }

            while (i <= 10)
            {
                Console.WriteLine(cervezas[i].Marca);
            }


            // Parte 3:
            // -------------------------------
            //
            // En base a las clases anteriores, ejemplifique un método sobrecargado.
            //
            BarleyWine b = new BarleyWine("Patricia");
            b.Madurar(100);
            Console.ReadKey();

        }
    }
}
