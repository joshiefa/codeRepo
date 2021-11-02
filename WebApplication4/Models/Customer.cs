using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Customer
    {
        public string name;
        public string email;
        public string address;
        public DateTime dateOfBirth;

        public Customer(string name)
        {
            this.name = name;
        }

        public Customer setEmail(string email)
        {
            this.email = email;
            return this;
        }

        public Customer setAddress(string address)
        {
            this.address = address;
            return this;
        }

        public Customer setDateOfBirth(DateTime dateOfBirth)
        {
            this.dateOfBirth = dateOfBirth;
            return this;
        }
    }
}
