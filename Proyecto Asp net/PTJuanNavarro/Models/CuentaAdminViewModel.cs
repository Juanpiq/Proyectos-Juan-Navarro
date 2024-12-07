namespace PTJuanNavarro.Models
{
    public class CuentaAdminViewModel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<ClienteCotizacionViewModel> ClientesCotizaciones { get; set; }
    }

    public class ClienteCotizacionViewModel
    {
        public int ClienteId { get; set; }
        public string NombreUsuario { get; set; }
        public List<CotizacionCarroViewModel> Cotizaciones { get; set; }
    }

    public class CotizacionCarroViewModel
    {
        public int CotizacionId { get; set; }
        public DateOnly FechaCotizacion { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
    }
}
