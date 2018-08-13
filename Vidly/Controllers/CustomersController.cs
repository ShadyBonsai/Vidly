using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    /// <summary>
    /// A controller for the customers
    /// </summary>
    public class CustomersController : Controller
    {
        /// <summary>
        /// The default view
        /// </summary>
        /// <returns>Returns the customers</returns>
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }
        
        /// <summary>
        /// A function to get the details of the customers
        /// </summary>
        /// <param name="id">The unique id for the customers</param>
        /// <returns>Retruns the customers, else returns not found if false</returns>
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(customer);
            }
        }

        /// <summary>
        /// A function to return a collection of the customers
        /// </summary>
        /// <returns>Returns the customers listed</returns>
        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };
        }
    }
}