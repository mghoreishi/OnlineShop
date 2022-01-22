using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages
{
    public class RegisterModel : PageModel
    {

        [TempData]
        public string ErrorMessage { get; set; }

        [TempData]
        public string SuccessMessage { get; set; }


        public RegisterAccount Command { get; set; }


        private readonly IAccountApplication _accountApplication;

        public RegisterModel(IAccountApplication accountApplication)
        {
            _accountApplication = accountApplication;
        }

        public void OnGet()
        {
        }



        public IActionResult OnPostRegister(RegisterAccount command)
        {
            if (ModelState.IsValid)
            {
                var result = _accountApplication.Register(command);
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
