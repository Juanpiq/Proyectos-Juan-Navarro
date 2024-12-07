using System;
using System.Collections.Generic;

namespace PTJuanNavarro.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string TipoUsuario { get; set; } = null!;

    public virtual Administradore? Administradore { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual ContraseñasAdministradore? ContraseñasAdministradore { get; set; }

    public virtual ContraseñasCliente? ContraseñasCliente { get; set; }
}
