using System.ComponentModel.DataAnnotations;

namespace ElLib.Web.Models
{
    public class CreateBookCategoryModel
    {
        [Display(Name = "Категория")]
        [Required(ErrorMessage = "Поле катигория не может быть пустым")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Не верная длина")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        [Required(ErrorMessage = "Поле описание не может быть пустым")]
        [StringLength(50, MinimumLength = 15, ErrorMessage = "Не верная длина")]
        public string Description { get; set; }
    }
}