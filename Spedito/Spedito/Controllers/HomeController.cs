using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SpeditoReposity.Models;
using SpeditoReposity.Reposities.AuthReposities;
using SpeditoReposity.Repositories.ShoppingReposities;

namespace Spedito.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAuthRepository _authRepository;
        private readonly IBasketRepository _basketRepository;
        public HomeController(IMapper mapper,
                                 IAuthRepository authRepository,
                                 IBasketRepository basketRepository)
        {
            _mapper = mapper;
            _authRepository = authRepository;
            _basketRepository = basketRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logout()
        {
            Request.Cookies.TryGetValue("token", out string token);

            User user = _authRepository.CheckByToken(token);

            _authRepository.UpdateToken(user.Id, null);

            return RedirectToAction("index", "home");
        }
    }
}
