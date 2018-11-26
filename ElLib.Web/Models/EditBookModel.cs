using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;
using System.Web.Mvc;
using ElLib.Common.Entity;

namespace ElLib.Web.Models
{
    public class EditBookModel
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }

        [Display(Name = "Название")]
        [Required(ErrorMessage = "Поле название не может быть пустым")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Не верная длина")]
        public string Name { get; set; }

        [Display(Name = "Категории")]
        [Required(ErrorMessage = "Поле категории не может быть пустым")]
        public ICollection<BookCategory> Categories { get; set; }

        [Display(Name = "Авторы")]
        [Required(ErrorMessage = "Поле авторы не может быть пустым")]
        public ICollection<Author> Authors { get; set; }

        [Display(Name = "Дата публикации")]
        [Required(ErrorMessage = "Поле дата публикации не может быть пустым")]
        public DateTime PublishingDate { get; set; }

        [Display(Name = "Язык")]
        [Required(ErrorMessage = "Поле язык не может быть пустым")]
        public Language Language { get; set; }

        [Display(Name = "Издательсво")]
        [Required(ErrorMessage = "Поле издательство не может быть пустым")]
        public Publishing Publishing { get; set; }
    }
}