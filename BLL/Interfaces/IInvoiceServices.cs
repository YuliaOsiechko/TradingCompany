using DTO;

namespace BLL
{
    public interface IInvoiceServices
    {
        void AddInvoice(int orderId, int managerId);
        List<InvoiceDTO> GetInvoicesOfManager(int id);
        void SendInvoice(int id);
    }
}