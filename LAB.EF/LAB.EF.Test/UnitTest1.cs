using System;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using LAB.EF.Logic;
using LAB.EF.Entities;
using LAB.EF.Data;

namespace LAB.EF.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertCustomerTest()
        {
            var mockSet = new Mock<DbSet<Customers>>(); //Creo la tabla virtual de mock
            var mockContext = new Mock<NorthwindContext>(); //Tomo el contexto de Nortwhind

            mockContext.Setup(m=>m.Customers).Returns(mockSet.Object);

            ClientesLogic clientesLogic = new ClientesLogic(mockContext.Object);

            clientesLogic.Add(new Customers
            {
                CustomerID = "TEST",
                CompanyName = "TestCompany",
                ContactName = "Test subject",
                ContactTitle = "Tester",
                Address = "Adress T",
                City = "T CITY",
                Region = "TestRegion",
                PostalCode = "000",
                Country = "Argentina",
                Phone = "00000",
                Fax = ""
            });

            mockSet.Verify(m => m.Add(It.IsAny<Customers>()), Times.Once());
            mockContext.Verify(m => m.SaveChanges(), Times.Once());
            
        }
    }
}
