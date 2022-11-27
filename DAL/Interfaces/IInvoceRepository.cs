using DTO;

namespace DAL
{
    public interface IInvoiceRepository
    {
        public void AddInvoice(int orderId, int managerId);
        List<InvoiceDTO> GetAllInvoices();
        public List<InvoiceDTO> GetInvoicesOfManager(int id);
        public void SendInvoice(int id);
    }
}