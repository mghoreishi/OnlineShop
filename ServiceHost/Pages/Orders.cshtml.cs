using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _0_Framework.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ShopManagement.Application.Contracts.Order;

namespace ServiceHost.Pages
{
    public class OrdersModel : PageModel
    {
        public List<OrderViewModel> Orders { get; set; }

        private readonly IOrderApplication _orderApplication;
        private readonly IAuthHelper _authHelper;

        public OrdersModel(IOrderApplication orderApplication, IAuthHelper authHelper)
        {
            _orderApplication = orderApplication;
            _authHelper = authHelper;
        }
        [BindProperty(SupportsGet = true)]
        public int CurrentPage { get; set; } = 1;
        public int Count { get; set; }
        public int CountPages { get; set; }
        public int PageSize { get; set; } = 10;

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(Count, PageSize));



        public void OnGetAsync()
        {
            long accountId = _authHelper.CurrentAccountInfo().Id;
            Orders = _orderApplication.GetPaginatedOrders(accountId,CurrentPage,PageSize);
            Count = _orderApplication.GetCountOrders(accountId);
            CountPages = Count / PageSize==0?1: Count / PageSize;
        }





        public IActionResult OnGetItems(long id)
        {
            return RedirectToPage("/OrderDetails", new { id = id });
        }
    }
}
