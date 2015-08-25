using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductViewModel.Models
{
    public class Repository
    {
        public IList<Product> ListProducts()
        {
            return new List<Product>
            {
                new Product {Name="Milk", Price=5.00m },
                new Product {Name="Eggs", Price=10.00m },
                new Product {Name="Cheese", Price=0.99m }
            };
        }
    }
}