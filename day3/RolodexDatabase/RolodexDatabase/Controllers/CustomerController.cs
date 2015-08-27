using RolodexDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RolodexDatabase.Controllers
{
    public class CustomerController : Controller
    {

        private DataContext _db = new DataContext();
        // GET: Customer
        public ActionResult Index()
        {
            var contacts = (from c in _db.Contacts.Include(c => c.Address)
                            select c).ToList();

            return View(contacts);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(Contact collection)
        {
            if (ModelState.IsValid)
            {
                _db.Contacts.Add(collection);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
            
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            var customer = _db.Contacts.Find(id);
            return View(customer);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Contact collection)
        {
            if (ModelState.IsValid)
            {
                var original = _db.Contacts.Find(collection.Id);
                original.Name = collection.Name;
                original.Birthday = collection.Birthday;
                original.Phone = collection.Phone;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            var customer = _db.Contacts.Find(id);
            return View(customer);
        }

        // POST: Customer/Delete/5
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteReally(int id)
        {
            var original = _db.Contacts.Find(id);
            _db.Contacts.Remove(original);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
