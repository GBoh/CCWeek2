using ShoppingList.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingList.Controllers
{
    public class ShoppingListController : Controller
    {
        // GET: ShoppingList
        public ActionResult Index()
        {

            //create shopping cart
            var customerCart = new List<Customer>
            {
               new Customer
               {
                   FirstName = "Cave",
                   LastName ="Johnson",
                   Cart = new List<Product>
                   {
                       new Product {Name="Lemon", Price = 5.00m },
                   }
               },

               new Customer
               {
                   FirstName = "Chell",
                   LastName = "Unknown",
                   Cart = new List<Product>
                   {
                       new Product {Name="Portal Gun", Price = 9999.00m },
                       new Product {Name="Companion Cube", Price = 50.00m }
                   }
               }
            };

            var vm = new CustomerIndexViewModel
            {
                Customers = customerCart
            };



            return View(vm);
        }
    }
}