using System;
using System.Collections.Generic;

namespace PTJuanNavarro.Models;

public partial class Administradore
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual Usuario IdNavigation { get; set; } = null!;
}
