using System.ComponentModel.DataAnnotations;

namespace ElLib.Web.Models
{
    public class LoginUserModel
    {
        [Display(Name = "Логин")]
        [Required(ErrorMessage = "Поле логин не может быть пустым")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Не верная длина")]
        public string UserName { get; set; }

        [Display(Name = "Пароль")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Поле пароль не может быть пустым")]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Пароль не может быть длиной менее 6 символов")]
        public string Password { get; set; }

        [Display(Name = "Запомнить")]
        public bool Remember { get; set; }
    }
}