using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Spedito.Models.Account;
using SpeditoReposity.Reposities.AuthReposities;
using SpeditoReposity.Repositories.ShoppingReposities;
using System;

namespace Spedito.Controllers
{
    public class LoginController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAuthRepository _authRepository;
        private readonly IBasketRepository _basketRepository;
        public LoginController(IMapper mapper,
                                 IAuthRepository authRepository,
                                 IBasketRepository basketRepository)
        {
            _mapper = mapper;
            _authRepository = authRepository;
            _basketRepository = basketRepository;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _authRepository.Login(model.Email, model.Password);

                if(user != null)
                {
                    user.Token = Guid.NewGuid().ToString();

                    _authRepository.UpdateToken(user.Id, user.Token);

                    Response.Cookies.Delete("token");

                    Response.Cookies.Append("token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions
                    {
                        HttpOnly = true,
                        Expires = DateTime.Now.AddYears(1)
                    });

                    Request.Cookies.TryGetValue("token", out string token);

                    _basketRepository.UpdateBasketsToken(token, user.Token);

                    return RedirectToAction("index", "home");
                }

                ModelState.AddModelError("Password", "Email or password is incorrect");
            }

            return View(model);
        }

        
    }
}
