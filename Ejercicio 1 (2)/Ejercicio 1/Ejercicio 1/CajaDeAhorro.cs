using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class CajaDeAhorro
    {
        public int id { get; set; }
        public int cbu { get; set; }
        public List<Usuario> titular { get; set; }
        public float saldo { get; set; }
        public List<Movimiento> movimientos { get; set; }


        public CajaDeAhorro(){

            titular = new List<Usuario>();

            movimientos = new List<Movimiento>();


        }


    }
}
