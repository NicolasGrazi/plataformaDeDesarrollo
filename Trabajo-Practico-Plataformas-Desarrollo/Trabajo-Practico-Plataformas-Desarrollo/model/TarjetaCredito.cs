using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_Plataformas_Desarrollo.model
{
    public class TarjetaCredito
    {
        private int id { get; set; }
        private Usuario titular { get; set; }
        private int numero { get; set; }
        private int odigoV { get; set; }
        private float limite { get; set; }
        private float consumos { get; set; }
    }
}
