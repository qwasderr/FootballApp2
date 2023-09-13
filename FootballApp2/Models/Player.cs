using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FootballApp2.Models;

public partial class Player
{
    public int Id { get; set; }
    [Display(Name = "Ім'я")]
    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public string Name { get; set; } = null!;
    [Display(Name = "Позиція")]
    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public string Position { get; set; } = null!;
    [Display(Name = "Ціна")]
    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    public float Price { get; set; }
    [Display(Name = "Дата народження")]
    [Required(ErrorMessage = "Поле не повинно бути порожнім")]
    [DataType(DataType.Date)]
    [Column(TypeName = "Date")]
    public DateTime BirthDate { get; set; }
    [Display(Name = "Команда")]
    public int? TeamId { get; set; }
    [Display(Name = "Посилання на профіль")]
    public string? PlayerUrl { get; set; }
    [ForeignKey("TeamId")]
    [Display(Name = "Команда")]
    [ValidateNever]
    public virtual Team? Team { get; set; }
}
