using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingList.Models
{
    public class ProductIndexViewModel
    {
        public IList<Product> Products { get; set; }
    }
}