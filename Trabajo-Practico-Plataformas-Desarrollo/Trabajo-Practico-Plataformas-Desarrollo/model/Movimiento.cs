using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_Plataformas_Desarrollo.model
{
    public class Movimiento
    {
        private int id { get; set; }
        private CajaDeAhorro caja { get; set; }
        private String detalle { get; set; }
        private float monto { get; set; }
        private DateTime fecha { get; set; }
    }
}
