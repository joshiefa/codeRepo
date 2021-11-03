using System;
using Moq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication5.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class CustomerControllerUnitTests
    {
        [TestMethod]
        public void postCustomer_ShouldRunAddCustomerWithGivenCustomer()
        {
            Customer customer = new Customer("Dave");
            Mock < CustomerStore > = new Mock<CustomerStore>();
        }
    }
}
