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

        public void AltaUsuario(string nombre, string apellido, int dni, string email, string password)
        {
            Usuario usuarioActual = new Usuario();
            usuarioActual.nombre = nombre;
            usuarioActual.apellido = apellido;
            usuarioActual.email = email;
            usuarioActual.id = dni;

            if(dni.ToString().Length == 8)
            {
                usuarioActual.dni = dni;
            }
            else
            {
                Console.WriteLine("Dni debe tener 8 caracteres.");
            }

            if(password.Length >= 8)
            {
                usuarioActual.password = password;
            } 
            else
            {
                Console.WriteLine("La contraseña debe tener minimo 8 caracteres.");
            }

            usuario.Add(usuarioActual);
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

                    if(usuarioActual.dni.ToString().Length == 8)
                    {
                        usuario.dni = usuarioActual.dni;
                    }
                    else
                    {
                        Console.WriteLine("Dni debe tener 8 caracteres.");
                    }

                    // aca poner la referencia de string para cambiar la contraseña
                    if(usuarioActual.password.Length >= 8)
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

        public void EliminarUsuario()
        {
            BajaCajaAhorro(usuarioActual.id);
            
            
        }

        public void AltaCajaAhorro(Usuario usuarioActual)
        {

            if(usuarioActual != null)
            {
                // Usuario
                CajaDeAhorro nuevaCajaAhorro = new CajaDeAhorro();
                nuevaCajaAhorro.saldo = 0;
                nuevaCajaAhorro.id = usuarioActual.id;
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
            foreach(var u in usuario)
            {
                foreach (var c in u.cajas)
                {
                    if (c.id == id)
                    {
                        Console.WriteLine(c.id);
                        string agregarTitulares = "";
                        if (agregarTitulares == "Agregar")
                        {
                            c.titular.Add(u);
                        }
                        else if (agregarTitulares == "Quitar")
                        {

                        }
                    }
                    else
                    {
                        Console.WriteLine("No tiene caja ahorro!");
                    }
                }
            }
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
