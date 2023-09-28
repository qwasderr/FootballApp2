using System.ComponentModel.DataAnnotations;

namespace FootballApp2.Models
{
    public class BlobModel
    {
        [Display(Name = "Посилання")]
        public string? Uri { get; set; }
        [Display(Name = "Ім'я")]
        public string? Name { get; set; }
        [Display(Name = "Тип")]
        public string? ContentType { get; set; }
        public Stream? Content { get; set; }
    }
}
