using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Restaurant
    {
        public static Int32 codigo = 0;
        public readonly String nombreRestaurant;
        public static List<Producto> stock { get; set; }
        public static List<Cliente> clientes { get; set; }

        public Restaurant (String nombre)
        {
            this.nombreRestaurant = nombre;
            clientes = new List<Cliente>();
            stock = new List<Producto>();
        }
        /// <summary>
        /// Metodo que asigna un codigo autonumerado a los Objetos Productos.
        /// </summary>
        /// <returns> retorna el codigo generado</returns>
        public static Int32 DarCodigo()
        {
            codigo++;
            return codigo;
        }

        /// <summary>
        /// Añade a los clientes que "ingresen" al restaurant
        /// </summary>
        /// <param name="cliente"> representa un objeto Cliente</param>
        public void AñadirCliente(Cliente cliente)
        {
            clientes.Add(cliente);
        }
        /// <summary>
        /// Añade Productos al stock del restaurant. Antes verifica que la lista de stock este creada.
        /// </summary>
        /// <param name="p">representa un Objeto Producto</param>
        public static void AñadirStock (Producto p)
        {
            if (!(stock == null))
            {
                stock.Add(p);
            }
        }
        /// <summary>
        ///  Elimina Productos al stock del restaurant. Antes verifica que la lista de stock este creada.        /// </summary>
        /// <param name="p">representa un Objeto Producto</param>
        public static void EliminarStock(Producto p)
        {
            if (!(stock == null))
            {

                stock.Remove(p);
            }
        }
        /// <summary>
        /// Se muestra la compra que va a realizar el cliente y se eliminan dichos productos del Stock.
        /// Invoca el metodo ClienteCompra del cliente dado por parametro.
        /// </summary>
        /// <param name="c">Objeto Cliente</param>

        public void ClienteCompra(Cliente c )
        { 
            c.ComprarProductos();
        }
        /// <summary>
        /// Muestra el precio total que debe abonar el cliente.
        /// </summary>
        /// <param name="c">objeto Cliente</param>
        public void PrecioTotal(Cliente c)
        {
            c.CompraTotal();
        }

        /// <summary>
        /// Muestra el stock actual del local. Antes verifica que exista un stock.
        /// El stock se muestra mediante el metodo de los Obejtos Productos que permite ver su Ficha.
        /// </summary>
        public void MostrarStock()
        {
            if (!(stock == null))
            {
                Console.WriteLine("Stock actual de Restaurant "+this.nombreRestaurant+":");
                foreach (Producto pro in stock)
                {
                    pro.Ficha();
                }
            }
        }
        /// <summary>
        /// Muestra todos los clientes que actualmente se encuentran en el Local.
        /// </summary>
        public void MostrarClientesDelRestaurant()
        {
            Console.WriteLine("Clientes que se encuentran actualmente en el Restaurant: ");
            foreach (Cliente c in clientes)
            {
                c.Nombre();
            }
        }
    }
}
