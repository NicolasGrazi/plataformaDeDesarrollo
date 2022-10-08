using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_Plataformas_Desarrollo.model
{
    public class CajaDeAhorro
    {
        private int id { get; set; }
        private int cbu { get; set; }
        private List<Usuario> titular { get; set; }
        private float saldo { get; set; }
        private List<Movimiento> movimientos { get; set; }

        public CajaDeAhorro()
        {

            titular = new List<Usuario>();

            movimientos = new List<Movimiento>();


        }
    }
}
