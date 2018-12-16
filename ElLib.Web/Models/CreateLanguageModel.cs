using System.ComponentModel.DataAnnotations;

namespace ElLib.Web.Models
{
    public class CreateLanguageModel
    {
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Поле названия языка не может быть пустым")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Не верная длина")]
        public string Name { get; set; }
    }
}