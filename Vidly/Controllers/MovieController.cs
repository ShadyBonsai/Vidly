using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    /// <summary>
    /// A Controller for the movies
    /// </summary>
    public class MovieController : Controller
    {
        /// <summary>
        /// The defualt view
        /// </summary>
        public ActionResult Index()
        {
            var movies = GetMovie();

            return View(movies);
        }

        /// <summary>
        /// A function to create a collection of movies
        /// </summary>
        /// <returns>Returns the movies</returns>
        public IEnumerable<Movie> GetMovie()
        {
            return new List<Movie>
            {
                new Movie { ID = 1, Name = "Shrek" },
                new Movie { ID = 2, Name = "Wall-e" }
            };
        }

        /// <summary>
        /// A function to create a random movie and random customers
        /// </summary>
        /// <returns>Returns the index view</returns>
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer { Name = "John Smith" },
                new Customer { Name = "Mary Williams" }
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View("Index");
        }


    }
}