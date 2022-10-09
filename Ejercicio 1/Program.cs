using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    


     class Program
    {
        public static void Main(string[] args)
        {
            Banco banck1=new Banco();

            banck1.AltaUsuario("kevin", "sanchez", 12345678, "ks@gmail.com", "as123212");
        }
    }
}
