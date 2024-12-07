using System;
using System.Collections.Generic;

namespace PTJuanNavarro.Models;

public partial class ContraseñasCliente
{
    public string NombreUsuario { get; set; } = null!;

    public string Salting { get; set; } = null!;

    public string Hash { get; set; } = null!;

    public virtual Usuario NombreUsuarioNavigation { get; set; } = null!;
}
