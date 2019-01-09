using System.ComponentModel.DataAnnotations;

namespace ElLib.Web.Models
{
    public class CreateBookCategoryModel
    {
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Поле название не может быть пустым")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Не верная длина названия")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        [Required(ErrorMessage = "Поле описание не может быть пустым")]
        [StringLength(150, MinimumLength = 15, ErrorMessage = "Не верная длина описания")]
        public string Description { get; set; }
    }
}