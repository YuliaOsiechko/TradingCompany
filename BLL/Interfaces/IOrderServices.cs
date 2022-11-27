using DTO;

namespace BLL
{
    public interface IOrderServices
    {
        void PlaceOrder(string userLogin, int productId);
        OrderDTO GetOrder(int id);
        List<OrderDTO> GetAllOrders();
        List<OrderDTO> GetOrderHistory(string userLogin);
        bool UserOrderCheck(string userLogin, int orderId);
    }
}