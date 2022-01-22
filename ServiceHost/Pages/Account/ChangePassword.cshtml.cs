using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _0_Framework.Application;
using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class ChangePasswordModel : PageModel
    {
        [TempData]
        public string ChangePasswordMessage { get; set; }
        [TempData]
        public string ErrorMessage { get; set; }

        public ChangePassword Command { get; set; }

        private readonly IAccountApplication _accountApplication;
        private readonly IAuthHelper _authHelper;

        public ChangePasswordModel(IAccountApplication accountApplication, IAuthHelper authHelper)
        {
            _accountApplication = accountApplication;
            _authHelper = authHelper;
        }

        public void OnGet()
        {
           
        }

        public IActionResult OnPost(ChangePassword command)
        {
            command.Id = _authHelper.CurrentAccountInfo().Id;
            var result = _accountApplication.ChangePassword(command);

            if (result.IsSuccedded)
                ChangePasswordMessage = result.Message;
            else
                ErrorMessage = result.Message;

            return Page();
        }

      


    }
}
