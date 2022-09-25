using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Usuario
    {
        private int id { get; set; }
        private int dni { get; set; }
        private String nombre { get; set; }
        private String apellido { get; set; }
        private String email { get; set; }
        private String password { get; set; }
        private int intentosFallidos { get; set; }
        private bool bloqueado { get; set; }
        private List<CajaDeAhorro> cajas { get; set; }
        private List<PlazoFijo> pf { get; set; }
        private List<TarjetaDeCredito> tarjeta { get; set; }
        private List<Pago> pagos { get; set; }

        public Usuario()
        {

            pagos = new List<Pago>();

            tarjeta = new List<TarjetaDeCredito>();

            pf = new List<PlazoFijo>();

            cajas= new List<CajaDeAhorro>();



        }

    }
}
