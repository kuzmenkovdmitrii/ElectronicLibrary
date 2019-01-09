using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ElLib.Web.Models
{
    public class CreateLanguageModel
    {
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Поле названия языка не может быть пустым")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Не верная длина названия")]
        [Remote("CheckName", "Language", ErrorMessage = "Язык с таким названием уже существует")]
        public string Name { get; set; }
    }
}