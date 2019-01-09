using System.ComponentModel.DataAnnotations;

namespace ElLib.Web.Models
{
    public class CreateAuthorModel
    {
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Поле имя не может быть пустым")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Не верная длина имени")]
        public string Name { get; set; }

        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Поле фамилия не может быть пустым")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Не верная длина фамилии")]
        public string LastName { get; set; }

        [Display(Name = "Отчество")]
        [Required(ErrorMessage = "Поле отчество не может быть пустым")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Не верная длина отчества")]
        public string MiddleName { get; set; }

        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Неверно введен Email")]
        public string Email { get; set; }
    }
}