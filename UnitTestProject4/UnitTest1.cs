using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;
using WebApplication3.Controllers;
using WebApplication3.Models;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task postCustomer_ShouldReturnFailureWhenCustomerAlreadyExists()
        {
            Customer customer = new Customer("josh").setEmail("joshiecorn@gmail.com").setAddress("somewhere").setDateOfBirth(new DateTime(12345678));
            CustomerController customerController = new CustomerController();

            var t = await customerController.postCustomer(customer);

            Assert.IsTrue(t == BadRequest());
        }
    }
}
