using Microsoft.AspNetCore.Mvc;

namespace Spedito.Controllers
{
    public class WishlistController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
