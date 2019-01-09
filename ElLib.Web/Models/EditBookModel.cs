using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using ElLib.Web.CustomValidationAttributes;

namespace ElLib.Web.Models
{
    public class EditBookModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Поле название не может быть пустым")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Не верная длина названия")]
        public string Name { get; set; }

        [Display(Name = "Категории")]
        [ArrayCount(MinCount = 1, ErrorMessage = "Поле категорий не может быть пустым")]
        public int[] Categories { get; set; }

        [Display(Name = "Авторы")]
        [ArrayCount(MinCount = 1, ErrorMessage = "Поле авторов не может быть пустым")]
        public int[] Authors { get; set; }

        [Display(Name = "Язык")]
        [Required(ErrorMessage = "Поле язык публикации не может быть пустым")]
        public int Language { get; set; }

        [Display(Name = "Издательсва")]
        [ArrayCount(MinCount = 1, ErrorMessage = "Поле издательств не может быть пустым")]
        public int[] Publishings { get; set; }

        public string File { get; set; }

        public string Picture { get; set; }
    }
}