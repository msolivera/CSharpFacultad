﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_1
{
    class DiscoDuro
    {
        public readonly Int32 id;
        public readonly String marca;
        public readonly int capacidad; //   Capacidad en GB

        public DiscoDuro (String marca, int capacidad)
        {
            this.id = Local.DarId();
            this.marca = marca;
            this.capacidad = capacidad;
            Local.AñadirComponente(this);
        }
        /// <summary>
        /// Impresión de valores asociados al objeto.
        /// <returns>Devuelve una cadena estructurada con los valores pertenecientes al objeto</returns>
        public String Imprimir()
        {
            return "Marca: " + this.marca + " Capacidad: " + this.capacidad;
        }
    }
}
