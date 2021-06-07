using Microsoft.AspNetCore.Mvc;

namespace Spedito.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
