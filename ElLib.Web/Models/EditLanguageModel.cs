using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ElLib.Web.Models
{
    public class EditLanguageModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

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