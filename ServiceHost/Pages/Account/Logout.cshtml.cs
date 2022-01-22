using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccountManagement.Application.Contracts.Account;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceHost.Pages.Account
{
    public class LogoutModel : PageModel
    {
        private readonly IAccountApplication _accountApplication;

        public LogoutModel(IAccountApplication accountApplication)
        {
            _accountApplication = accountApplication;
        }
        public IActionResult OnGet()
        {
            _accountApplication.Logout();
            return RedirectToPage("/Index");
        }
    }
}
