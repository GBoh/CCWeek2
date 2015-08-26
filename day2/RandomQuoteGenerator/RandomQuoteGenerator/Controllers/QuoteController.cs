using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RandomQuoteGenerator.Controllers
{
    public class QuoteController : Controller
    {
        [ChildActionOnly]
        public ActionResult GetQuote()
        {
            var quoteText = "test";
            List<string> Quotes = new List<string>();
            Quotes.Add("A person who never made a mistake never tried anything new. \n -Albert Einstein");
            Quotes.Add("I like nonsense, it wakes up the brain cells. Fantasy is a necessary ingredient in living, it's a way of looking at life through the wrong end of a telescope. Which is what I do, and that enables you to laugh at life's realities. \n -Dr. Seuss");
            Quotes.Add("JUST DO IT!!! \n -shia labeouf");
            Quotes.Add("There is no great genius without a mixture of madness. \n- Aristotle");
            Quotes.Add("However difficult life may seem, there is always something you can do and succeed at. \n -Stephen Hawking");
            Random rnd = new Random();

            switch (rnd.Next(0, 5))
            {
                case 0:
                    quoteText = Quotes[0];
                    break;
                case 1:
                    quoteText = Quotes[1];
                    break;
                case 2:
                    quoteText = Quotes[2];
                    break;
                case 3:
                    quoteText = Quotes[3];
                    break;
                case 4:
                    quoteText = Quotes[4];
                    break;
            }

            return PartialView("_QuotePartial", quoteText);
        }
    }
}