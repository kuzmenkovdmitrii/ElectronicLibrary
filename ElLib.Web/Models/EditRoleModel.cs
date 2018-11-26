using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace ElLib.Web.Models
{
    public class EditRoleModel
    {
        [HiddenInput(DisplayValue = false)]
        public string Id { get; set; }

        [Display(Name = "Роль")]
        [Required(ErrorMessage = "Поле роль не может быть пустым")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Не верная длина")]
        public string Name { get; set; }

        [Display(Name = "Описание")]
        [Required(ErrorMessage = "Поле описание не может быть пустым")]
        [StringLength(50, MinimumLength = 15, ErrorMessage = "Не верная длина")]
        public string Description { get; set; }
    }
}