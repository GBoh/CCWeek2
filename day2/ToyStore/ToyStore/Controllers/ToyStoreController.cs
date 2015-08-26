using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToyStore.Models;

namespace ToyStore.Controllers
{
    public class ToyStoreController : Controller
    {
        // GET: ToyStore
        public ActionResult Index()
        {
            List<Image> FeaturedImage = new List<Image>();
            FeaturedImage.Add(new Image { ImageURL = "http://fun.familyeducation.com/images/Mr_Potato_Head_toy_H.jpg", ToyName = "Mr. Potato Head" });
            FeaturedImage.Add(new Image { ImageURL = "https://www.bellalunatoys.com/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/h/a/haba-duck-wooden-pull-toys.jpg", ToyName = "Wooden Duck" });
            FeaturedImage.Add(new Image { ImageURL = "http://fortrendymoms.files.wordpress.com/2012/11/fisher-price-laugh-and-learn.jpg", ToyName = "Puppy Dog" });

            return View(FeaturedImage);
        }
    }
}