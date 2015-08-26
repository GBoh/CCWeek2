using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneBook.Models
{
    public class Repository
    {
        public IList<Customer> ListCustomers()
        {
            return new List<Customer>{
                new Customer
                {
                    //ID = 0,
                    FirstName = "Greg",
                    LastName = "Bohanon",
                    PhoneNumber = "1234567890"
                }
            };
        }
    }
}