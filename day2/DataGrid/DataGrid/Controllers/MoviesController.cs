using DataGridMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataGridMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            MovieIndexViewModel vm = new MovieIndexViewModel();

            return View(vm);
        }
    }
}