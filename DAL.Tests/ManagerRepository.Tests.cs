using DTO;
using DAL;
using Xunit;

namespace DAL.Tests
{
   public class ManagerRepositoryTests : RepositoryTestsBase
   {
       [Fact]
       public void GetId_Test()
       {
           //Arrange
           ManagerRepository userRepository = new ManagerRepository(_connectionString);
           ManagerDTO expected = new ManagerDTO()
           {
               Id = 1,
               Login = "Manager1",
               Password = "1111",
               DispName = "MarKson"
           };
           //Act
           ManagerDTO actual = userRepository.Get(expected.Id);
           //Assert
           Assert.Equal(actual.Login, expected.Login);
           Assert.Equal(actual.Password, expected.Password);
           Assert.Equal(actual.DispName, expected.DispName);
       }
       [Fact]
       public void GetLogin_Test()
       {
           //Arrange
           ManagerRepository userRepository = new ManagerRepository(_connectionString);
           ManagerDTO expected = new ManagerDTO()
           {
               Login = "Manager1",
               Password = "1111",
               DispName = "MarKson"
           };
           //Act
           ManagerDTO actual = userRepository.Get(expected.Login);
           //Assert
           Assert.Equal(actual.Login, expected.Login);
           Assert.Equal(actual.Password, expected.Password);
           Assert.Equal(actual.DispName, expected.DispName);
       }
       [Fact]
       public void UpdateDispName_Test()
       {
           //Arrange
           ManagerRepository managerRepository = new ManagerRepository(_connectionString);
           ManagerDTO expected = new ManagerDTO
           {
               Login = "Manager1",
               Password = "1111",
               DispName = "markson"
           };
           //Act
           managerRepository.UpdateDispName(expected.Login, expected.DispName);
           ManagerDTO actual = managerRepository.Get(1);
           //Assert
           //Assert.True(isTrue);
           Assert.Equal(actual.Login,expected.Login);
           Assert.Equal(actual.Password, expected.Password);
           Assert.Equal(actual.DispName, expected.DispName);
       }
       [Fact]
       public void UpdatePassword_Test()
       {
           //Arrange
           ManagerRepository managerRepository = new ManagerRepository(_connectionString);
           ManagerDTO expected = new ManagerDTO
           {
               Login = "Manager1",
               Password = "1234",
               DispName = "MarKson"
           };
           //Act
           managerRepository.UpdatePassword(expected.Login, expected.Password);
           ManagerDTO actual = managerRepository.Get(1);
           //Assert
           //Assert.True(isTrue);
           Assert.Equal(actual.Login,expected.Login);
           Assert.Equal(actual.Password, expected.Password);
           Assert.Equal(actual.DispName, expected.DispName);
       }
   }
}