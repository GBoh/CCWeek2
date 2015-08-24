using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComplexObject.Models
{
    public class Customer : Address
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address ShippingAddress { get; set; }
        public Address BillingAddress { get; set; }
    }
}