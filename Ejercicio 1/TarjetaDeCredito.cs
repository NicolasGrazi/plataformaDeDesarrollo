using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class TarjetaDeCredito

    {

        public int id { get; set; }
        public Usuario titular { get; set; }
        public int numero { get; set; }
        public int odigoV { get; set; }
        public float limite { get; set; }
        public float consumos { get; set; }



    }
}
