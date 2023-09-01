using System;
using System.Collections.Generic;

namespace Clients.Models;

public partial class Video
{
    public int Id { get; set; }

    public string? Titulo { get; set; }

    public string? Director { get; set; }

    public int? CliId { get; set; }

    public virtual Cliente? Cli { get; set; }
}
