using System.ComponentModel.DataAnnotations;

namespace ElLib.Web.Models
{
    public class CreateLanguageModel
    {
        [Display(Name = "Язык (на Английском)")]
        [Required(ErrorMessage = "Поле язык не может быть пустым")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Не верная длина")]
        public string NameEn { get; set; }

        [Display(Name = "Язык (на Русском)")]
        [Required(ErrorMessage = "Поле язык не может быть пустым")]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Не верная длина")]
        public string NameRu { get; set; }
    }
}