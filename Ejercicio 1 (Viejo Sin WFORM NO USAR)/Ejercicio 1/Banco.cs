using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Banco
    {
        public List<Usuario> usuario { get; set; }
        public List<CajaDeAhorro> caja { get; set; }
        public List<PlazoFijo> pfs { get; set; }
        public List<TarjetaDeCredito> tarjetas { get; set; }
        public List<Pago> pagos { get; set; }
        public List<Movimiento> movimientos { get; set; }
        public Usuario usuarioActual; 

        public Banco()
        {
            pagos = new List<Pago>();
            tarjetas = new List<TarjetaDeCredito>();
            movimientos = new List<Movimiento>();
            pfs = new List<PlazoFijo>();
            caja = new List<CajaDeAhorro>();
            usuario = new List<Usuario>();

        }

        public void IniciarSesion(string usuario, string contrasenia)
        {
            bool encontrado=false

			foreach (Usuario usuarioInd in this.usuario)
			{
                if (usuarioInd.nombre == usuario )

				{
                    if (usuarioInd.bloqueado == false) { 

                        while( usuarioInd.intentosFallidos< 4 && encontrado == false) { 
                    

                            if(usuarioInd.password == contrasenia  ) {
                                usuarioActual = usuarioInd;
                                usuarioInd.intentosFallidos=0;
                                encontrado = true;
                            }
                            else
                            {
                                usuarioInd.intentosFallidos++;
                                if (usuarioInd.intentosFallidos == 4)
                                {
                                    usuarioInd.bloqueado=true
                                }
                        
                            }
                        }
                    }
                    
				}
			}

        }


      /*
         public List<CajaDeAhorro> MostrarCajasDeAhorro()
        {
             return this.usuarioActual.cajas;

        }
       */



          public void CerrarSesion()
		{
            usuarioActual = null;
        }

        public void CrearCajaAhorro()
		{
            if (usuarioActual != null)
			{
                // Creás la caja de ahorro.
			}
		}

        public void Depositar()
        {
            if (usuarioActual != null)
            {
                // Depositás.
            }
        }
        public void Retirar()
        {
            if (usuarioActual != null)
            {
                // Retirás.
            }
        }

        public List<Pago> MostrarPagos()
        {
            return usuarioActual.pagos;


        }

        public List<PlazoFijo> MostrarPlazoFijos()
        {
            return usuarioActual.pf;
        }




       public List<Movimiento> MostrarMovimientos (CajaDeAhorro numero)
        {
            if(usuarioActual != null) { 
                foreach (Usuario usuarioInd in this.usuarioActual.cajas)
			    {   
                    if(numero.id ==  ((CajaDeAhorro)usuarioInd).id)
                    {
                        return numero.movimientos;

                    }            
            
                }
            }
        }
        
        



    }
}
