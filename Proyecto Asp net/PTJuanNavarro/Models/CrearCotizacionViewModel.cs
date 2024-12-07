namespace PTJuanNavarro.Models
{
    public class CrearCotizacionViewModel
    {
        public int ClienteId { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnioFabricacion { get; set; }
        public decimal CostoAuto { get; set; }
        public string TipoSeguro { get; set; }
        public string Cobertura { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int UltimaCotizacionId { get; set; }
    }
}
