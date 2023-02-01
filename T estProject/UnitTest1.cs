using Bussiness_Services_;
using Domain;
using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using Persistance;
using System;
using System.Threading.Tasks;

namespace T_estProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task AddSuccess()
        {
            //arrange
            var mocktest = new Mock<DbSet<Customer>>();

            var mockContext = new Mock<AppDbContext>();
            mockContext.Setup(m => m.Customers).Returns(mocktest.Object);
            var service = new CustomerService(mockContext.Object);
            //act
            await service.Add(new Customer()
            {
                DateOfBirth = DateTime.Now,
                FirstName = "Mahdi",
                LastName = "kabiri",
                Email = "kabirmahdi@gmail.com"
            });

            //assert
            mocktest.Verify(m => m.Add(It.IsAny<Customer>()), Times.Once);
            mockContext.Verify(m => m.SaveChanges(), Times.Once);
            Assert.Pass();
        }
    }
}