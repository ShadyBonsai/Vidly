using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        public ViewResult Index()
        {
            var customer = GetCustomer();

            return View(Index);
        }
    }
}
//https://github.com/mosh-hamedani/vidly-mvc-5/commit/b727a26e1b4b88abe84a8b48208fec537db2ed43?diff=unified