using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OnlineShopQuery.Contracts.Product
{
    public class ProductQuerySearchModel
    {
        public List<ProductQueryModel> Products { get; set; }
        public int TotalCount { get; set; }
    }
}
