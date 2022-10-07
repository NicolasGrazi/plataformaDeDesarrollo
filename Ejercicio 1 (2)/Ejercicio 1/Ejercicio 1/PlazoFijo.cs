using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class PlazoFijo
    {
        private int id { get; set; }
        private Usuario titular { get; set; }
        private float monto { get; set; }
        private DateTime fechaIni { get; set; }
        private DateTime fechaFin { get; set; }
        private float tasa { get; set; }
        private bool pagado { get; set; }

    }
}
