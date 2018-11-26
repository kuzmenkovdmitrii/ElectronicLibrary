using System.ComponentModel.DataAnnotations;

namespace ElLib.Web.Models
{
    public class CreatePublishingModel
    {
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Поле название не может быть пустым")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Не верная длина")]
        public string Name { get; set; }

        [Display(Name = "Адрес")]
        [Required(ErrorMessage = "Поле адрес не может быть пустым")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Не верная длина")]
        public string Address { get; set; }
    }
}