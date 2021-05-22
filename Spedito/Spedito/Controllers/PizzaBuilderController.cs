using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
