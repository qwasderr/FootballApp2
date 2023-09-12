using System;
using System.Collections.Generic;

namespace FootballApp2.Models;

public partial class Team
{
    public int Id { get; set; }

    public string DivName { get; set; } = null!;

    public int Division { get; set; }

    public string Name { get; set; } = null!;

    public int CountryId { get; set; }

    public string? Description { get; set; }

    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();
}
