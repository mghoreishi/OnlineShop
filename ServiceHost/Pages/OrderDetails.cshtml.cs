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
    public class OrderDetailsModel : PageModel
    {
        public OrderDetailsViewModel OrderDetails { get; set; }
        private readonly IOrderApplication _orderApplication;
        private readonly IAuthHelper _authHelper;

        public OrderDetailsModel(IOrderApplication orderApplication, IAuthHelper authHelper)
        {
            _orderApplication = orderApplication;
            _authHelper = authHelper;
        }

        public void OnGet(long id)
        {
            long accountId = _authHelper.CurrentAccountInfo().Id;
            OrderDetails = _orderApplication.GetOrderDetails(orderId: id, accountId: accountId);
        }
    }
}
