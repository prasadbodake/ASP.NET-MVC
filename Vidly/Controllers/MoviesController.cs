using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Index()
        {
            return View(GetMovies());
        }


        public ActionResult Details(int id)
        {
            var movie = GetMovies().FirstOrDefault(m => Equals(m.Id, id));

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }


        private static IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie
                {
                    Id = 111,
                    Name = "Harry Potter"
                },
                new Movie
                {
                    Id = 222,
                    Name = "Lord of the ring"
                }
            };
        }
    }
}