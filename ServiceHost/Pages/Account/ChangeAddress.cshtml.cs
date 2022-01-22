using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _0_Framework.Application;
using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages.Account
{
    public class ChangeAddressModel : PageModel
    {
        [TempData]
        public string ErrorMessage { get; set; }

        [TempData]
        public string SuccessMessage { get; set; }


        public ChangeAddress Command { get; set; }


        private readonly IAccountApplication _accountApplication;
        private readonly IAuthHelper _authHelper;

        public ChangeAddressModel(IAccountApplication accountApplication, IAuthHelper authHelper)
        {
            _accountApplication = accountApplication;
            _authHelper = authHelper;
        }

        public void OnGet()
        {
            Command = new ChangeAddress() { Id = _authHelper.CurrentAccountInfo().Id, Address = _authHelper.CurrentAccountAddress() };
        }



        public IActionResult OnPostRegister(ChangeAddress command)
        {
            if (ModelState.IsValid)
            {
               
                var result = _accountApplication.ChangeAddress(command);
                if (result.IsSuccedded)
                    SuccessMessage = result.Message;
                else
                    ErrorMessage = result.Message;

                return Page();
            }
            else
            {
                ErrorMessage = "Please fill in the required fields";
                return Page();
            }
        }
    }
}

