using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Realizar un programa capaz de gestionar los pedidos de productos por parte de clientes en un restaurant. 
             * Todos los productos tienen un codigo, nombre y un precio.
             * De los clientes, solo nos interesa su nombre, además del pedido realizado.
             * Realizar las siguientes operaciones:
             * - Agregar clientes al restaurant. 
             * - Agregar productos al restaurant.
             * - Realizar la compra de productos por parte de un cliente.
             * - Mostrar el total de la compra de un cliente.
             * - Ejemplo de uso en el método Main de la clase Program.
             */

            Restaurant r1 = new Restaurant("La Pasiva");
            Cliente c1 = new Cliente("Mcaela");
            Cliente c2 = new Cliente("Jorge");
            Cliente c3 = new Cliente("Ana");
            Producto p1 = new Producto("Chivito", 750);
            Producto p2 = new Producto("Milanesa", 450);
            Producto p3 = new Producto("Pizza", 300);
            Producto p4 = new Producto("Panchos", 150);
            r1.MostrarStock();

            r1.AñadirCliente(c1);
            r1.AñadirCliente(c2);
            r1.AñadirCliente(c3);
            r1.MostrarClientesDelRestaurant();

            c1.AñadirProductoPedido(p3);
            c1.AñadirProductoPedido(p4);

            r1.ClienteCompra(c1);
            r1.PrecioTotal(c1);

            r1.MostrarStock();


            Console.ReadKey();
            
        }
    }
}
