using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ktltserver.Authentication
{
    public class Response
    {
        public string Status {get;set;}
        public string Massage {get;set;}
    }
}