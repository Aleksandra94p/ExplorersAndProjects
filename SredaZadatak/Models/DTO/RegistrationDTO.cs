﻿using System.ComponentModel.DataAnnotations;

namespace SredaZadatak.Models.DTO
{
    public class RegistrationDTO
    {
         [Required(ErrorMessage = "User Name is required")]
        public string Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
