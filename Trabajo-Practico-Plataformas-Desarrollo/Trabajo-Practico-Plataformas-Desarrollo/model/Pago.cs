using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_Plataformas_Desarrollo.model
{
    public class Pago
    {
        private int id { get; set; }
        private Usuario user { get; set; }
        private String nombre { get; set; }
        private float monto { get; set; }
        private bool pagado { get; set; }
        private String metodo { get; set; }
    }
}
