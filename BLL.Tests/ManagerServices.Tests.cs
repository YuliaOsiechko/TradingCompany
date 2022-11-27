using Autofac.Extras.Moq;
using DAL;
using DTO;
using Moq;
using Xunit;

namespace BLL.Tests
{
    public class ManagerServicesTests
    {
        [Fact]
        public void GetInt_Valid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IManagerRepository>()
                    .Setup(x => x.Get(1))
                    .Returns(GetSampleManager());
                var service = mock.Create<ManagerServices>();

                var expected = GetSampleManager();
                var actual = service.Get(1);

                Assert.True(actual != null);
                Assert.Equal(expected.Id, actual.Id);
                Assert.Equal(expected.Login, actual.Login);
                Assert.Equal(expected.Password, actual.Password);
                Assert.Equal(expected.DispName, actual.DispName);
            }
        }

        [Fact]
        public void GetString_Valid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IManagerRepository>()
                    .Setup(x => x.Get("nadia07"))
                    .Returns(GetSampleManager());
                var service = mock.Create<ManagerServices>();

                var expected = GetSampleManager();
                var actual = service.Get("nadia07");

                Assert.True(actual != null);
                Assert.Equal(expected.Id, actual.Id);
                Assert.Equal(expected.Login, actual.Login);
                Assert.Equal(expected.Password, actual.Password);
                Assert.Equal(expected.DispName, actual.DispName);
            }
        }

        [Fact]
        public void UpdateDisplayName_Valid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                mock.Mock<IManagerRepository>()
                    .Setup(x => x.UpdateDispName("nadia07", "nadia"));

                var service = mock.Create<ManagerServices>();
                service.UpdateDispName("nadia07", "nadia");

                mock.Mock<IManagerRepository>()
                    .Verify(x => x.UpdateDispName("nadia07", "nadia"), Times.Exactly(1));
            }
        }

        [Fact]
        public void UpdatePassword_Valid()
        {
            using (var mock = AutoMock.GetLoose())
            {
                string login = "nadia07";
                string newPassword = "1234";
                var passwordHash = newPassword;

                mock.Mock<IManagerRepository>()
                    .Setup(x => x.UpdatePassword(login, newPassword));

                var service = mock.Create<ManagerServices>();
                service.UpdatePassword(login, newPassword);
                //mock.Mock<IManagerRepository>()
                //    .Verify(x => x.UpdatePassword(login, newPassword), Times.Never());
                //mock.Mock<IManagerRepository>()
                //    .Verify(x => x.UpdatePassword(login, newPassword), Times.Never());
            }
        }

        private ManagerDTO GetSampleManager() =>
            new ManagerDTO
            {
                Id = 1,
                Login = "nadia07",
                Password = "1111",
                DispName = "nadia"
            };
    }
}