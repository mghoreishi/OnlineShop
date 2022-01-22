using _0_Framework.Application;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AccountManagement.Application.Contracts.Account
{
    public class Login
    {
        [DisplayName("Username")]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Username { get; set; }


        [DisplayName("Password")]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Password { get; set; }
    }
}
