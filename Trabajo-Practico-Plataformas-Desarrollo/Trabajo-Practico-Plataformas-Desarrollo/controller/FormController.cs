using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabajo_Practico_Plataformas_Desarrollo.model;

namespace Trabajo_Practico_Plataformas_Desarrollo.controller
{
    internal class FormController
    {
        public static VistaBanco VistaBanco
        {
            get
            {
                if (_vista == null)
                {
                    _vista = new VistaBanco();
                }
                return _vista;
            }
        }
        private static VistaBanco _vista;
    }
}
