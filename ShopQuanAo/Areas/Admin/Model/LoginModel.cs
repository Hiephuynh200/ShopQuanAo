using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopQuanAo.Areas.Admin.Model
{
    public class LoginModel
    {
        [Required (ErrorMessage ="vui long nhap email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "vui long nhap mat khau")]

        public string Pass { get; set; }
        public bool RememberMe { get; set; }
    }
}