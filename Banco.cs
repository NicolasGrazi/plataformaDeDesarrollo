using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InterfazTP
{
    public class Banco
    {
        public List<Usuario> usuario { get; set; }
        private List<CajaDeAhorro> caja { get; set; }
        private List<PlazoFijo> pfs { get; set; }
        private List<TarjetaDeCredito> tarjetas { get; set; }
        private List<Pago> pagos { get; set; }
        private List<Movimiento> movimientos { get; set; }
        public Usuario usuarioActual { get; set; }
        public int cbu = 1000;

        public Banco()
        {
            pagos = new List<Pago>();
            tarjetas = new List<TarjetaDeCredito>();
            movimientos = new List<Movimiento>();
            pfs = new List<PlazoFijo>();
            caja = new List<CajaDeAhorro>();
            usuario = new List<Usuario>();
        }

        public bool AltaUsuario(string user, string password, string nombre, string apellido, string dni, string email)
        {
            if (password.Length < 8 || user.Length < 8)
            {
                MessageBox.Show("Usuario y Contraseña deben tener minimo 8 caracteres.");
                return false;
            }
            else
            {
                Usuario nuevoUsuario = new Usuario();
                nuevoUsuario.usuarioLogin = user;
                nuevoUsuario.password = password;
                nuevoUsuario.nombre = nombre;
                nuevoUsuario.apellido = apellido;
                nuevoUsuario.dni = dni;
                nuevoUsuario.email = email;

                usuario.Add(nuevoUsuario);
                return true;
            }
        }

        public void ModificarUsuario(Usuario usuarioActual)
        {
            foreach (var usuario in usuario)
            {
                if (usuario.id == usuarioActual.id)
                {
                    usuario.nombre = usuarioActual.nombre;
                    usuario.apellido = usuarioActual.apellido;
                    usuario.email = usuarioActual.email;

                    if (usuarioActual.dni.ToString().Length == 8)
                    {
                        usuario.dni = usuarioActual.dni;
                    }
                    else
                    {
                        Console.WriteLine("Dni debe tener 8 caracteres.");
                    }

                    // aca poner la referencia de string para cambiar la contraseña
                    if (usuarioActual.password.Length >= 8)
                    {
                        usuario.password = usuarioActual.password;
                    }
                    else
                    {
                        Console.WriteLine("La contraseña debe tener minimo 8 caracteres.");
                    }
                }
                else
                {
                    Console.WriteLine("No registrado");
                }
            }
        }
        /*
        public void EliminarUsuario()
        {
            BajaCajaAhorro(usuarioActual.id);
            usuario.Remove(usuarioActual);
        }*/

        public void AltaCajaAhorro(Usuario usuarioActual)
        {

            if (usuarioActual != null)
            {
                // Usuario
                CajaDeAhorro nuevaCajaAhorro = new CajaDeAhorro();
                nuevaCajaAhorro.saldo = 0;
                //nuevaCajaAhorro.id = usuarioActual.id;
                nuevaCajaAhorro.cbu = cbu;
                nuevaCajaAhorro.titular.Add(usuarioActual);
                usuarioActual.cajas.Add(nuevaCajaAhorro);


                // Banco
                caja.Add(nuevaCajaAhorro);
                cbu++;

            }

        }

        public void BajaCajaAhorro(int id)
        {
            if (usuarioActual != null)
            {
                foreach (var c in usuarioActual.cajas)
                {
                    if (c.id == id)
                    {
                        if (c.saldo == 0)
                        {
                            usuarioActual.cajas.Remove(c);
                            caja.Remove(c);
                        }
                        else
                        {
                            Console.WriteLine("La caja no se puede eliminar si cuenta con saldo.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No tiene cajas de ahorro asociadas.");
                    }
                }
            }
            else
            {
                Console.WriteLine("No tiene cajas de ahorro.");
            }

        }

        public void ModificarCajaAhorro(int id)
        {
            foreach (var c in usuarioActual.cajas)
            {
                if (c.id == id)
                {
                    c.id = 0;
                    c.cbu = 0;
                }
                else
                {
                    Console.WriteLine("No tiene caja ahorro!");
                }
            }
        }

        public bool IniciarSesion(string usuario, string contraseña)
        {
            bool encontre = false;
            
            foreach (Usuario usuarioInd in this.usuario)
            {
                

                if (usuarioInd.usuarioLogin == usuario && usuarioInd.password == contraseña)
                {
                    encontre = true;

                }
                
            }
            return encontre;
        }


        /*AltaMovimiento (in Movimiento, in Caja): Vincula el movimiento con la caja de ahorro
        indicada, agrega el movimiento a la lista de la caja y del banco.*/

        public void AltaMovimiento(Movimiento mov, CajaDeAhorro entrada)
        {
            movimientos.Add(mov);
            entrada.movimientos.Add(mov);
        }
        /* AltaPago(in Pago, in Usuario): Agrega un Pago a la lista y lo vincula con el Usuario.*/

        public void AltaPago(Pago pg, Usuario usuarioA)
        {
            usuarioA.pagos.Add(pg);
            // pg.user = usuarioA;  
        }

        /* BajaPago (in ID): Da de baja el pago, no es lo mismo que pagar el pago,
         * en dicho caso el pago sigue existiendo en estado “pagado”,
         * esta acción elimina el registro del pago.
         * Elimina el pago de la lista del usuario y del banco*/

        public void BajaPago(int id)
        {
            foreach (var p in pagos)
            {
                if (p.id == id)
                {
                    pagos.Remove(p);
                    usuarioActual.pagos.Remove(p);
                }
                else
                {
                    Console.WriteLine("salida en 215");
                }
            }
        }

        /*ModificarPago (in ID): Modifica Datos del pago. Permite pasar a estado pagado.*/

        public void ModificarPago(int id)
        {
            foreach (var p in pagos)
            {
                if (p.id == (int)id)
                {
                    p.pagado = true;
                }
            }

        }

        /*AltaPlazoFijo(in Plazo Fijo, in Usuario): Agrega un Plazo Fijo a la lista y
         * lo vincula con el Usuario.*/

        public void AltaPlazoFijo(PlazoFijo pfj, Usuario usu)
        {
            usu.plazoFijo.Add(pfj);
        }

        /*BajaPlazoFijo (in ID): Sólo si el estado es pagado y la fecha actual es 1 mes posterior a
la fecha de vencimiento permite operar, esta acción elimina el registro del Plazo Fijo,
no es lo mismo que pagar. Elimina el Plazo Fijo de la lista del usuario y del banco.*/


        public void BajaPlazoFijo(int id)
        {
            foreach (var p in plazoFijo)
            {
                if (p.id == (int)id)
                {
                    if (p.pagado == true && p.fechaFin > 30 )
                    {
                        usuarioActual.plazoFijo.Remove(p);
                        plazoFijo.Remove(p);
                    }
                    else
                    {
                        Console.WriteLine("salida en 260");
                    }
                }
            }

        }



    }
}