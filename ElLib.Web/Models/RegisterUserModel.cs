using System.ComponentModel.DataAnnotations;

namespace ElLib.Web.Models
{
    public class RegisterUserModel
    {
        [Display(Name = "Логин")]
        [Required(ErrorMessage = "Поле логин не может быть пустым")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Не верная длина")]
        public string UserName { get; set; }

        [Display(Name = "Пароль")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле пароль не может быть пустым")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Пароль не может быть менее 6 символов")]
        public string Password { get; set; }

        [Display(Name = "Повторите пароль")]
        [Required(ErrorMessage = "Повторите пароль")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Поле Email не может быть пустым")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Неверно введен Email")]
        public string Email { get; set; }
    }
}