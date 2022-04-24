using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ktltserver.Authentication
{
    public class LoginModel
    {
        [Required]
        public string Username {get;set;}
        [Required]
        public string Password {get;set;}
    }
}