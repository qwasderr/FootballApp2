using System;
using System.Collections.Generic;

namespace FootballApp2.Models;

public partial class Country
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public float Rating { get; set; }

    public virtual ICollection<Team> Teams { get; set; } = new List<Team>();
}
