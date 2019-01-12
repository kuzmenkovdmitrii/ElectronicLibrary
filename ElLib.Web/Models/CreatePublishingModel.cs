﻿using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using ElLib.Common.Entities;

namespace ElLib.Web.Models
{
    public class CreatePublishingModel
    {
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Поле название не может быть пустым")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Не верная длина названия")]
        [Remote("CheckName", "Publishing", ErrorMessage = "Издательство с таким названием уже существует")]
        public string Name { get; set; }

        [Display(Name = "Адрес")]
        public Address Address { get; set; }
    }
}