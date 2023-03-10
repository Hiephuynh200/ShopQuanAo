using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopQuanAo.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="vui long nhap email")]
        public string Email { set; get; }
        [Required(ErrorMessage = "vui long nhap mat khau")]
        public string Password { set; get; }
        public bool RememberMe { set; get; }

    }
}