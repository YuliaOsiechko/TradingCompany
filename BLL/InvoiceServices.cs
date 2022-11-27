using DAL;
using DTO;

namespace BLL
{
    public class InvoiceServices : IInvoiceServices
    {
        private IInvoiceRepository _invoiceRepository { get; set; }
        public InvoiceServices(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }
        public void AddInvoice(int orderId, int managerId) => _invoiceRepository.AddInvoice(orderId, managerId);
        public List<InvoiceDTO> GetAllInvoices() => _invoiceRepository.GetAllInvoices();
        public List<InvoiceDTO> GetInvoicesOfManager(int id) => _invoiceRepository.GetInvoicesOfManager(id);
        public void SendInvoice(int id) => _invoiceRepository.SendInvoice(id);
    }
}