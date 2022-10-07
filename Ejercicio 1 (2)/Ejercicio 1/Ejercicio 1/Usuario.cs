using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Usuario
    {
       // public int id { get; set; }
        public int dni { get; set; }
        public String nombre { get; set; }
        public String apellido { get; set; }
        public String email { get; set; }
        public String password { get; set; }
        public int intentosFallidos { get; set; }
        public bool bloqueado { get; set; }
        public List<CajaDeAhorro> cajas { get; set; }
        public List<PlazoFijo> pf { get; set; }
        public List<TarjetaDeCredito> tarjeta { get; set; }
        public List<Pago> pagos { get; set; }

        public Usuario()
        {

            pagos = new List<Pago>();

            tarjeta = new List<TarjetaDeCredito>();

            pf = new List<PlazoFijo>();

            cajas= new List<CajaDeAhorro>();

            intentosFallidos=0;
            bloqueado=false;



        }


    }
}
