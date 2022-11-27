using DTO;
using DAL;
using Xunit;

namespace DAL.Tests
{
   public class InvoiceRepositoryTests : RepositoryTestsBase
   {
       [Fact]
       public void AdInvoice_Test()
       {
           //Arrange
           InvoiceRepository invoiceRepository = new InvoiceRepository(_connectionString);
           InvoiceDTO expected = new InvoiceDTO
           {
               Id = 5,
               OrderId = 1,
               ManagerId = 1
           };
           invoiceRepository.AddInvoice(expected.OrderId, expected.ManagerId);
           //Act
           var actual = invoiceRepository.GetInvoicesOfManager(1)[0];
           //Assert
           Assert.Equal(actual.ManagerId, expected.ManagerId);
       }
   }
}
