using DAL;
using DTO;

namespace BLL
{
    public class OrderServices : IOrderServices
    {
        private IOrderRepository _orderRepository { get; set; }
        public OrderServices(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public void PlaceOrder(string userLogin, int productId) => _orderRepository.CreateOrder(userLogin, productId);
        public OrderDTO GetOrder(int id) => _orderRepository.Get(id);
        public List<OrderDTO> GetAllOrders() => _orderRepository.GetAll();
        public List<OrderDTO> GetOrderHistory(string userLogin) => _orderRepository.GetOrderHistory(userLogin);
        public bool UserOrderCheck(string userLogin, int orderId)
        {
            OrderDTO order;
            if ((order = _orderRepository.Get(orderId)) != null)
                if (order.UserLogin == userLogin)
                    return true;
            return false;
        }
    }
}