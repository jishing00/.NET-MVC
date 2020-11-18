using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class LoginViewModel
    {
        [Display(Name ="信箱")]
        [EmailAddress(ErrorMessage ="信箱格式有誤")]
        [Required(ErrorMessage ="請填寫信箱"), StringLength(maximumLength:10,MinimumLength =2, ErrorMessage ="2~10個字元")]
        public string Email { get; set; }
        [Display(Name = "密碼")]
        [DataType(DataType.Password)]
        [Required,MinLength(6)]
        public string Password { get; set; }
    }
}