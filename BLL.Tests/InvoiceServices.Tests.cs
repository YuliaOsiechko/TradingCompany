using Autofac.Extras.Moq;
using DAL;
using DTO;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace BLL.Tests
{
    public class InvoiceServicesTests
    {
        [Fact]
        public void AddInvoice_Valid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                int orderId = 1;
                int managerId = 1;
                mock.Mock<IInvoiceRepository>()
                    .Setup(x => x.AddInvoice(orderId, managerId));

                var service = mock.Create<InvoiceServices>();
                service.AddInvoice(orderId, managerId);

                mock.Mock<IInvoiceRepository>()
                    .Verify(x => x.AddInvoice(orderId, managerId), Times.Exactly(1));
            }
        }

        [Fact]
        public void GetInvoicesOfManager_Valid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                int userId = 1;

                mock.Mock<IInvoiceRepository>()
                    .Setup(x => x.GetInvoicesOfManager(userId))
                    .Returns(UserCommentsSample());

                var service = mock.Create<InvoiceServices>();
                var expected = UserCommentsSample();
                var actual = service.GetInvoicesOfManager(userId);
                
                Assert.True(actual != null);
                Assert.Equal(expected.Count, actual.Count);
                for (int i = 0; i < actual.Count; i++)
                {
                    Assert.Equal(expected[i].Id, actual[i].Id);
                    Assert.Equal(expected[i].OrderId, actual[i].OrderId);
                    Assert.Equal(expected[i].ManagerId, actual[i].ManagerId);
                }
            }
        }

        private List<InvoiceDTO> UserCommentsSample()
        {
            return new List<InvoiceDTO>()
            {
                new InvoiceDTO()
                {
                    Id = 1,
                    OrderId = 1,
                    ManagerId = 1
                },
                new InvoiceDTO()
                {
                    Id = 2,
                    OrderId = 2,
                    ManagerId = 2
                }
            };
        }
    }
}