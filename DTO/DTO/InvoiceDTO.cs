namespace DTO
{
    public class InvoiceDTO
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ManagerId { get; set; }
        public string OrderItem { get; set; }
        public string ManagerName{ get; set; }
        public string CustomerName { get; set; }
        public string InvoiceStatus { get; set; }
        public DateTime InsertTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}