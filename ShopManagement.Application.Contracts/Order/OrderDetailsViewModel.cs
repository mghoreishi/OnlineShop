using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopManagement.Application.Contracts.Order
{
    public class OrderDetailsViewModel: OrderViewModel
    {
        public string Address { get; set; }
        public List<OrderItemViewModel> OrderItems { get; set; }
    }
}
