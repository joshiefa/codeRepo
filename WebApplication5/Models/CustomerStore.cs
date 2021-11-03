using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Models
{
    public class CustomerStore
    {
        private List<Customer> customers = new List<Customer>();

        public bool AddCustomer(Customer customer)
        {
            if (customers.Any((storedCustomer) => customer.Name == storedCustomer.Name))
            {
                return false;
            }

            customers.Add(customer);

            return true;
        }

        public bool RemoveCustomer(string customerName)
        {
            Customer customer = customers.Find((storedCustomer) => customerName == storedCustomer.Name);

            if (customer == null)
            {
                return false;
            }

            customers.Remove(customer);

            return true;
        }
   
        public Customer GetCustomerByName(string customerName)
        {
            return customers.Find((storedCustomer) => customerName == storedCustomer.Name);
        }
    }
}