using _0_Framework.Application;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagement.Application.Contracts.Account
{
    public class ChangeAddress
    {
        public long Id { get; set; }
        [DisplayName("Address")]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Address { get; set; }
    }
}
