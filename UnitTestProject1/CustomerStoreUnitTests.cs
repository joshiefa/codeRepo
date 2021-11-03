using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication5.Models;

namespace UnitTestProject1
{
    [TestClass]
    public class CustomerStoreUnitTests
    {
        [TestMethod]
        public void addCustomer_ShouldNotAddCustomerWhenNameAlreadyExists()
        {
            CustomerStore store = new CustomerStore();
            store.AddCustomer(new Customer("Dave"));

            Customer customer = new Customer("Dave");
            bool success = store.AddCustomer(customer);

            Assert.IsFalse(success);
        }

        [TestMethod]
        public void addCustomer_ShouldAddCustomerWhenNameDoesNotExistAlready()
        {
            CustomerStore store = new CustomerStore();

            Customer customer = new Customer("Dave");
            bool success = store.AddCustomer(customer);

            Assert.IsTrue(success);
            Assert.IsNotNull(store.GetCustomerByName("Dave"));
        }

        [TestMethod]
        public void removeCustomer_ShouldNotRemoveCustomerWhenNameDoesNotExist()
        {
            CustomerStore store = new CustomerStore();

            bool success = store.RemoveCustomer("Dave");

            Assert.IsFalse(success);
        }

        [TestMethod]
        public void removeCustomer_ShouldRemoveCustomerWhenNameExists()
        {
            CustomerStore store = new CustomerStore();
            Customer customer = new Customer("Dave");
            store.AddCustomer(customer);

            bool success = store.RemoveCustomer("Dave");

            Assert.IsTrue(success);
            Assert.IsNull(store.GetCustomerByName("Dave"));
        }

        [TestMethod]
        public void getCustomer_ShouldReturnNullIfNoCustomerExists()
        {
            CustomerStore store = new CustomerStore();

            Customer customer = store.GetCustomerByName("Dave");

            Assert.IsNull(customer);
        }

        [TestMethod]
        public void getCustomer_ShouldReturnNullIfNoCustomerWithNameExists()
        {
            CustomerStore store = new CustomerStore();
            store.AddCustomer(new Customer("Fred"));

            Customer customer = store.GetCustomerByName("Dave");

            Assert.IsNull(customer);
        }

        [TestMethod]
        public void getCustomer_ShouldReturnCustomerIfCustomerWithNameExists()
        {
            CustomerStore store = new CustomerStore();
            Customer expectedCustomer = new Customer("Dave");
            store.AddCustomer(expectedCustomer);

            Customer customer = store.GetCustomerByName("Dave");

            Assert.IsTrue(expectedCustomer == customer);
        }
    }
}
