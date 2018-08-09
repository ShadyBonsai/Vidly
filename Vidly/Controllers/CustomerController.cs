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