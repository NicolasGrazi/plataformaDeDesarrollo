﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Movimiento
    {
        public int id { get; set; }
        public CajaDeAhorro caja { get; set; }
        public String detalle { get; set; }
        public float monto { get; set; }
        public DateTime fecha { get; set; }

        public Movimiento()
        {

        }
    }
}