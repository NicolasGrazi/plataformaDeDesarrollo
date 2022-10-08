using Trabajo_Practico_Plataformas_Desarrollo.controller;
using Trabajo_Practico_Plataformas_Desarrollo.model;

namespace Trabajo_Practico_Plataformas_Desarrollo
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(FormController.VistaBanco);
        }
    }
}