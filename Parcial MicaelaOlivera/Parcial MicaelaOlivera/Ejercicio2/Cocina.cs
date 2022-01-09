using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Cocina
    {

        /*El nombre de los Atributos deben comenzar en minuscula,
        si esta compuesto por varias palablas el resto empezaran en mayuscula*/        
        //El nombre del cocinero no es responsabilidad de la cocina, se agrega clase Cocinero.
        //Los atributos de la heladera no son responsabilidad de la cocina. Se agrega clase Heladera
        //Los atributos del horno no son responsabilidad de la cocina, se agrega clase horno

        public Cocinero cocinero { get; set; }
        public Horno horno { get; set; }
        public Heladera heladera { get; set; }
        public Cocina()
        {
        }

        /// <summary>
        ///Permite (siempre y cuando la cocina este dotada de los elementos necesarios) realizar una receta de cocina
        /// </summary>
        /// <param name="comida">Nombre de la receta a realizar</param>
        public void Cocinar(string comida)//En base a las clases nuevas se modifican las asignaciones
        {
            if (!(this.cocinero == null && this.heladera == null && this.horno == null))
            {
                //busca las cosas en la heladera
                Console.WriteLine("El cocinero " + cocinero.nombre + " abre la heladera marca " + heladera.marcaHeladera);
                heladera.puertaDeLaHeladeraAbierta = true;
                Console.WriteLine("El cocinero " + cocinero.nombre + " esta buscando los ingredientes");
                //cierra la heladera
                heladera.puertaDeLaHeladeraAbierta = false;
                Console.WriteLine("El cocinero " + cocinero.nombre + " cierra la heladera marca " + heladera.marcaHeladera);
                Console.WriteLine("El cocinero " + cocinero.nombre + " prende el horno marca " + horno.marcaHorno);
                horno.temperaturaHorno = 200;
                prepararComida();
                Console.WriteLine("El cocinero " + cocinero.nombre + " apaga el horno marca " + horno.marcaHorno);
                horno.temperaturaHorno = 0;
                Console.WriteLine("El cocinero " + cocinero.nombre + " ha finalizado la preparación de " + comida);

            }
            else
            {
                Console.WriteLine("No tiene los elementos necesarios para realizar esta accion");
            }
           }

        /// <summary>
        /// Verifica que la cocina tenga cocinero, heladera y horno; de ser asi invoca a la funcion Cocinar del cocinero.
        /// </summary>
        public void prepararComida()  
            //la cocina como habitacion no es la que realiza la coccion de comida, sino el cocinero.
            //se añade a la clase cocinero el metodo para cocinar una receta.
        {
            if (!(this.cocinero==null && this.horno == null))//se verifica que la cocina tenga horno, heladera y cocinero.
            {
                cocinero.Cocinar();
            }
            else
            {
                Console.WriteLine("No tiene los elementos sufucientes para realizar esta accion");
            }
        }
    }
}
