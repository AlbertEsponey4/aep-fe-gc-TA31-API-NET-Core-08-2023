using System;
using System.Collections.Generic;

namespace Clients.Models;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Direccion { get; set; }

    public int? Dni { get; set; }

    public DateOnly? Fecha { get; set; }

    public virtual ICollection<Video> Videos { get; set; } = new List<Video>();
}
