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
        private List<CajaDeAhorro> caja { get; set; }
        private List<PlazoFijo> pfs { get; set; }
        private List<TarjetaDeCredito> tarjetas { get; set; }
        private List<Pago> pagos { get; set; }
        private List<Movimiento> movimientos { get; set; }

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
			foreach (Usuario usuarioInd in usuarios)
			{
                if (usuarioInd.nombre == usuario && usuarioInd.password == contrasenia)
				{
                    usuarioActual = usuarioInd;
                    break;
				}
			}

			for (int i = 0; i < usuarios.Count; i++)
			{
                //if (usuarios[i].nombre == )
                // Lo mismo que en el foreach.
			}
        }
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

        public void Depositar(int cajaDeAhorro, float monto)
        {
            if (usuarioActual != null)
            {
                cajaDeAhorro = monto + cajaDeAhorro
            }


        }
        
        
        public void Retirar(int cajaDeAhorro, float monto)
        {
            if (usuarioActual != null)
            {
             
                if (saldo > 0)
                {
                
                    if (cajaDeAhorro < monto)
                    
                       return "Fondos insuficientes";

                }
                else{ 
                
                    cajaDeAhorro = cajaDeAhorro - monto;
                    
                }
        }

        public void Transferir(int cajaDeAhorro, int cajaDeAhorroDestino, float monto){ 
        
            
        
        }

        public void abmclases()
        {

        }
        public void mostrarDatos()
        {

        }
        public void operacionesUsuarios()
        {

        }



    }
}
