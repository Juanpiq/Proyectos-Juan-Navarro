using System;
using System.Collections.Generic;

namespace PTJuanNavarro.Models;

public partial class Cotizacione
{
    public int Id { get; set; }

    public int? ClienteId { get; set; }

    public int? CarroId { get; set; }

    public DateOnly FechaCotizacion { get; set; }

    public decimal Precio { get; set; }

    public virtual Carro? Carro { get; set; }

    public virtual Cliente? Cliente { get; set; }
}
