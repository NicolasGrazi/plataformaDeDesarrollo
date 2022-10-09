using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Pago
    {
        public int id { get; set; }
        public Usuario user { get; set; }
        public String nombre { get; set; }
        public float monto { get; set; }
        public bool pagado { get; set; }
        public String metodo { get; set; }

    }
}
