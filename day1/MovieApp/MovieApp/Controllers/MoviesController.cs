using MovieApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieApp.Controllers
{
    public class MoviesController : Controller
    {
        private Repository _repo = new Repository();

        // GET: Movies
        [Route("Movies/Index")]
        public ActionResult Index()
        {
            return View(_repo.ListMovies());
        }
    }
}