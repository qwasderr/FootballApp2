using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FootballApp2.Models;

public partial class Country
{
    public int Id { get; set; }
    [Display(Name="Ім'я")]
    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public string Name { get; set; } = null!;
    [Display(Name = "Рейтинг")]
    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public float Rating { get; set; }

    public virtual ICollection<Team> Teams { get; set; } = new List<Team>();
}
