using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopManagement.Application.Contracts.Order
{
    public interface IOrderApplication
    {
        long PlaceOrder(Cart cart);
        double GetAmountBy(long id);
        void Cancel(long id);
        string PaymentSucceeded(long orderId, long refId);
        List<OrderItemViewModel> GetItems(long orderId);
        List<OrderViewModel> Search(OrderSearchModel searchModel);
        List<OrderViewModel> GetPaginatedOrders(long accountId, int currentPage, int pageSize);
        int GetCountOrders(long accountId);

        OrderDetailsViewModel GetOrderDetails(long orderId, long accountId);
    }
}