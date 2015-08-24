using ComplexObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComplexObject.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            return View("List", new List<Customer>
            {
                new Customer
                {
                    FirstName = "Greg",
                    LastName = "Bohanon",
                    BillingAddress = new Address
                    {
                        Street = "17 Hornbill",
                        City = "The Woodlands"
                    },
                    ShippingAddress = new Address
                    {
                        Street = "17 Hornbill",
                        City = "The Woodlands"
                    }
                },

                new Customer
                {
                    FirstName = "Phil",
                    LastName = "Johnson",
                    BillingAddress = new Address
                    {
                        Street = "17 Johnson",
                        City = "Spring"
                    },
                    ShippingAddress = new Address
                    {
                        Street = "256 Memory Lane",
                        City = "Byteland"
                    }
                },

                new Customer
                {
                    FirstName = "Cave",
                    LastName = "Johnson",
                    BillingAddress = new Address
                    {
                        Street = "Aperture",
                        City = "Science"
                    },
                    ShippingAddress = new Address
                    {
                        Street = "Aperture",
                        City = "Science"
                    }
                }
            });
        }

        // GET: Customers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        [HttpPost]
        public ActionResult Create(Customer collection)
        {
            try
            {
                // TODO: Add insert logic here


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Customers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
