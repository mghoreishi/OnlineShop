using _0_Framework.Application;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccountManagement.Application.Contracts.Account
{
    public class ChangePassword
    {
        public long Id { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(255, ErrorMessage = "Must be between 5 and 10 characters", MinimumLength = 5)]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [StringLength(255, ErrorMessage = "Must be between 5 and 10 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string RePassword { get; set; }
    }
}
