﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AuthSystemMVC.ViewModels.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
		[Display(Name = "First Name")]
		[StringLength(15, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
		public string FirstName { get; set; }

		[Required]
		[Display(Name = "First Name")]
		[StringLength(15, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 2)]
		public string LastName { get; set; }

        [Required]
        [Display(Name = "Date Of Birth")]
        public DateTime DOB { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

		[Display(Name = "Remember me?")]
		public bool RememberMe { get; set; }
	}
}
