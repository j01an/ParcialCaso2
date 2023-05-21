using System;
using System.Collections.Generic;

namespace ParcialCaso2.API.Models;

public partial class Team
{
    public int Id { get; set; }

    public string? Descripcion { get; set; }

    public string? Country { get; set; }
}
