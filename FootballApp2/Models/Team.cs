using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FootballApp2.Models;

public partial class Team
{
    public int Id { get; set; }
    [Display(Name = "Ім'я дивізіону")]
    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public string DivName { get; set; } = null!;
    [Display(Name = "Ранг дивізіону")]
    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public int Division { get; set; }
    [Display(Name = "Ім'я футбольного клубу")]
    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public string Name { get; set; } = null!;
    [Display(Name = "Країна")]
    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public int CountryId { get; set; }
    [Display(Name = "Опис")]
    public string? Description { get; set; }
    [ValidateNever]
    [Display(Name = "Країна")]
    public virtual Country Country { get; set; } = null!;

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();
}
