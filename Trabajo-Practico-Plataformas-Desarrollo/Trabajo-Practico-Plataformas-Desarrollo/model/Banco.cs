using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo_Practico_Plataformas_Desarrollo.model
{
    public class Banco
    {
        public List<Usuario> usuario { get; set; }
        public List<CajaDeAhorro> caja { get; set; }
        public List<PlazoFijo> plazoFijo { get; set; }
        public List<TarjetaCredito> tarjetas { get; set; }
        public List<Pago> pagos { get; set; }
        public List<Movimiento> movimientos { get; set; }
        private Usuario usuarioActual;

        public Banco()
        {
            pagos = new List<Pago>();
            tarjetas = new List<TarjetaCredito>();
            movimientos = new List<Movimiento>();
            plazoFijo = new List<PlazoFijo>();
            caja = new List<CajaDeAhorro>();
            usuario = new List<Usuario>();

        }
    }
}
