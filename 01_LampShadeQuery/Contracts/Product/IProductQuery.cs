using System.Collections.Generic;
using ShopManagement.Application.Contracts.Order;

namespace _01_OnlineShopQuery.Contracts.Product
{
    public interface IProductQuery
    {
        ProductQueryModel GetProductDetails(string slug);
        List<ProductQueryModel> GetLatestArrivals();
        ProductQuerySearchModel Search(string value, int currentPage, int pageSize);
        List<CartItem> CheckInventoryStatus(List<CartItem> cartItems);
    }
}
