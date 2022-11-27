using DTO;

namespace DAL
{
    public interface IOrderRepository
    {
        public void CreateOrder(string userId, int productId);
        public OrderDTO Get(int id); 
        public List<OrderDTO> GetAll();
        public List<OrderDTO> GetOrderHistory(string userLogin);
    }
}