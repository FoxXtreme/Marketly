﻿using System.ComponentModel.DataAnnotations;

namespace Project.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress]
        public string Email {get; set;}

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(40, MinimumLength = 8, ErrorMessage = "Your password must contain at least 8 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set;}

        [Required(ErrorMessage = "Confirm Password is required.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password",  ErrorMessage = "Password does not match.")]
        public string ConfirmPassword { get; set;}
    }
}
