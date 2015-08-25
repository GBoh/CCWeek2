using MVCHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCHelpers.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index(AddViewModel incoming)
        {
            incoming.Sum = incoming.Num2 + incoming.Num1;
            return View(incoming);
        }
    }
}