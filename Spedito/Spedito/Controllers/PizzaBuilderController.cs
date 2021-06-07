using Microsoft.AspNetCore.Mvc;

namespace Spedito.Controllers
{
    public class PizzaBuilderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
