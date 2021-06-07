using Microsoft.AspNetCore.Mvc;

namespace Spedito.Controllers
{
    public class CatalogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
