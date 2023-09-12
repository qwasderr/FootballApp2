using System;
using System.Collections.Generic;

namespace FootballApp2.Models;

public partial class Player
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Position { get; set; } = null!;

    public float Price { get; set; }

    public DateTime BirthDate { get; set; }

    public int TeamId { get; set; }

    public string? PlayerUrl { get; set; }

    public virtual Team Team { get; set; } = null!;
}
