using DTO;
using Xunit;
using System.Collections.Generic;

namespace DAL.Tests
{
   public class OrderRepositoryTests : RepositoryTestsBase
   {
       [Fact]
       public void Get_Test()
       {
           //Arrange
           OrderRepository orderRepository = new OrderRepository(_connectionString);
           OrderDTO expected = new OrderDTO
           {
               UserLogin = "User1",
               ProductId = 1,
               ProductName = "Burger"
           };

           //Act
           OrderDTO actual = orderRepository.Get(1);
           //Assert
           Assert.Equal(actual.ProductId,    expected.ProductId);
           Assert.Equal(actual.ProductName, expected.ProductName);
           Assert.Equal(actual.UserLogin, expected.UserLogin);
       }
       [Fact]
       public void CreateOrder_Test()
       {
           //Arrange
           OrderRepository orderRepository = new OrderRepository(_connectionString);
           OrderDTO expected = new OrderDTO
           {
               UserLogin = "User1",
               ProductId = 1,
               ProductName = "Burger"
           };
           orderRepository.CreateOrder(expected.UserLogin, expected.ProductId);
           //Act
           OrderDTO actual = orderRepository.Get(1);
           //Assert
           Assert.Equal(actual.ProductId,    expected.ProductId);
           Assert.Equal(actual.ProductName, expected.ProductName);
           Assert.Equal(actual.UserLogin, expected.UserLogin);
       }
        
   }
}
