using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RandomQuoteGenerator.Controllers
{
    public class BeInspiredController : Controller
    {
        // GET: BeInspired
        public ActionResult Index()
        {
            return View();
        }
    }
}