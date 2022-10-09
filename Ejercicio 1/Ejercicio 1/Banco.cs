using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
   internal class Banco
	{
        // Nunca vas a necesitar hacerle un "set" a la lista, ya que no vas a pisar una lista con otra.
        // Con el "get" ya vas a poder agregar usuarios.
        // Podrías borrarle el "set" a todas las listas, como hice con "usuarios".
        public List<Usuario> usuarios { get; set }
        public List<CajaDeAhorro> cajas { get; set; }
        public List<PlazoFijo> pfs { get; set; }
        public List<TarjetaDeCredito> tarjetas { get; set; }
        public List<Pago> pagos { get; set; }
        public List<Movimiento> movimientos { get; set; }

        Usuario usuarioActual;


        public Banco()
        {
            pagos = new List<Pago>();
            tarjetas = new List<TarjetaDeCredito>();
            movimientos = new List<Movimiento>();
            pfs = new List<PlazoFijo>();
            cajas = new List<CajaDeAhorro>();
            usuarios = new List<Usuario>();
            usuarioActual = null;
        }


        
        public void IniciarSesion(string usuario, string contrasenia)
        {
            try{ 
                bool encontrado=false

			     foreach (Usuario usuarioInd in this.usuario){

                        if (usuarioInd.nombre == usuario ){

                            if (usuarioInd.bloqueado == false) { 

                                while( usuarioInd.intentosFallidos< 4 && encontrado == false) { 
                    

                                    if(usuarioInd.password == contrasenia  ) {
                                        usuarioActual = usuarioInd;
                                        usuarioInd.intentosFallidos=0;
                                        encontrado = true;
                                    }
                                    else{
                                        usuarioInd.intentosFallidos++;

                                        if (usuarioInd.intentosFallidos == 4){

                                            usuarioInd.bloqueado=true
                                        }
                        
                                    }
                                }
                            }
                    
				        }

                 }


            }
            catch(Exception i){

                Console.WriteLine("error de "+i);
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

         public bool Depositar(int cajaDeAhorro, float monto){


            if (usuarioActual != null)
            {
		        foreach(CajasAhorro cajas in usuarioActual.cajas){
		    
		            if(cajas.id == cajaAhorro){
		       
			    
			    	cajas.Saldo = monto + cajas.Saldo;

                        return true;

                    }else{ 
                    
                            return false;
                    }
		        }
                
            } 


         }
        
        
        public bool Retirar(int cajaDeAhorro, float monto)
        {
            if (usuarioActual != null)
            {
             
		       foreach(CajasAhorro cajas in usuarioActual.cajas){    
		    
                    
                    if (cajas.saldo >= monto && cajas.id == cajaDeAhorro){
                
                    
                        cajas.saldo = cajas.saldo - monto;

                        return true;
                       

		            }else{ 
                
                    
                        Console.WriteLine("Fondos insuficientes");
                        
                        return false;
                    
                    }
        
                }
		    
	        }		    

        
            
        public bool Transferir(int cajaDeAhorro, int cajaDeAhorroDestino, float monto){ 
        
		
            if (usuarioActual != null){
		
			
                bool montoTransferir = Retirar(cajaDeAhorro, monto);
			
                if(true == montoTransferir) {
                    
                          
                   bool transferenciaCompletada = Depositar(cajaDeAhorroDestino, monto);

                        Console.WriteLine(transferenciaCompletada);
                        return true;

                    }
                    else{ 
                    
                     return false;

                    }
		
		
		}


    }
}
