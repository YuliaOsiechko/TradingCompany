namespace DTO
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Order_status { get; set; }
        public DateTime InsertTime { get; set; }
        public DateTime UpdateTime { get; set; }

    }
}