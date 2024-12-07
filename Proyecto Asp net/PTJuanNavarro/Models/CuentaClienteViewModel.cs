namespace PTJuanNavarro.Models
{
    public class CuentaClienteViewModel
    {
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public List<CotizacionViewModel> Cotizaciones { get; set; }
    }

    public class CotizacionViewModel
    {
        public int Id { get; set; }
        public string FechaCotizacion { get; set; }
        public string ModeloCarro { get; set; }
        public string Precio { get; set; }
    }
}
