namespace Trabajo_Practico_Plataformas_Desarrollo.model
{
    public class Usuario
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
        public static List<PlazoFijo> plazoFijo { get; set; }
        private List<TarjetaCredito> tarjeta { get; set; }
        private List<Pago> pagos { get; set; }

        public Usuario()
        {
            pagos = new List<Pago>();
            tarjeta = new List<TarjetaCredito>();
            plazoFijo = new List<PlazoFijo>();
            cajas = new List<CajaDeAhorro>();

            intentosFallidos = 0;
            bloqueado = false;
        }

    }
}
