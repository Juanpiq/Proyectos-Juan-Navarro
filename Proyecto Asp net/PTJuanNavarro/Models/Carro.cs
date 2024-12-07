using System;
using System.Collections.Generic;

namespace PTJuanNavarro.Models;

public partial class Carro
{
    public int Id { get; set; }

    public int? ClienteId { get; set; }

    public string Marca { get; set; } = null!;

    public string Modelo { get; set; } = null!;

    public int Año { get; set; }

    public string? TipoSeguro { get; set; }

    public string? Cobertura { get; set; }

    public decimal Costo { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual ICollection<Cotizacione> Cotizaciones { get; set; } = new List<Cotizacione>();
}
