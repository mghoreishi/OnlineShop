using _0_Framework.Application;
using AccountManagement.Application.Contracts.Role;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccountManagement.Application.Contracts.Account
{
    public class RegisterAccount
    {

        [DisplayName("Fullname")]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]    
        public string Fullname { get; set; }

        [DisplayName("Username")]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Username { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(255, ErrorMessage = "Must be between 5 and 10 characters", MinimumLength = 5)]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(255, ErrorMessage = "Must be between 5 and 10 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [DisplayName("Mobile")]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Mobile { get; set; }

        [DisplayName("Address")]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Address { get; set; }

        public long RoleId { get; set; }

        public IFormFile ProfilePhoto { get; set; }
        public List<RoleViewModel> Roles { get; set; }
    }
}
