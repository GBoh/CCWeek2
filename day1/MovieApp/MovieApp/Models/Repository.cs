using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieApp.Models
{
    public class Repository
    {
        public IList<Movie> ListMovies()
        {
            return new List<Movie>
            {
                new Movie {Title="Star Wars", Director="George Lucas" },
                new Movie {Title="Transformers", Director="Michael Baysplosions" },
                new Movie {Title="Up", Director="Pete Docter" }
            };
        }
    }
}