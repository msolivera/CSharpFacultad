using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Cliente
    {
        public readonly String nombre;
        public List<Producto> pedido { get; set; }

        public Cliente (String nombre)
        {
            this.nombre = nombre;
            pedido = new List<Producto>();
        }
        /// <summary>
        /// Añade objetos Producto al "pedido" del cliente, el cual posteriormente podra confirmar con la compra o no.
        /// </summary>
        /// <param name="producto">Representa un objeto del tipo Producto</param>
        public void AñadirProductoPedido(Producto producto)
        {
            pedido.Add(producto);
            
           
        }
        /// <summary>
        /// Verifica que el cliente tenga objetos Producto en su pedido, de no ser asi indica imprime un mensaje 
        /// informando dicha situacion. 
        /// De tener Productos en el pedido, se invoca a la ficha de cada producto y se muestra listado.
        /// </summary>

        public void ComprarProductos()
        {
            Console.WriteLine("Pedido del cliente " + this.nombre + ":");
            foreach (Producto pro in pedido)
            {
                if (pedido.Count == 0)
                {
                    Console.WriteLine("El cliente "+this.nombre+" no ha realizado ningun pedido");
                }
                else
                {
                    pro.Ficha();
                    
                }
                Restaurant.EliminarStock(pro);
            }
        }
        /// <summary>
        /// Se establece una variable compraTotal que suma los precios de todos los Productos del Pedido
        /// Imprime un mensaje con el total de la compra.
        /// </summary>
        public void CompraTotal()
        {
            Int32 compraTotal = 0;
            foreach (Producto pro in pedido)
            {
                compraTotal = pro.precio + compraTotal;
            }
            Console.WriteLine("La compra de "+this.nombre+" sera de "+compraTotal+"$");
        }

        /// <summary>
        /// Muestra el nombre del cliente.
        /// </summary>
        public void Nombre()
        {
            Console.WriteLine(this.nombre);
        }
    }
}
