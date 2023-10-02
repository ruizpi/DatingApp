using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace API.DTOs
{
    public class RegisterDTO
    {
        [Required]
        public string Username {get; set;}

        [Required]        
        public string Password {get; set;}
    }
}