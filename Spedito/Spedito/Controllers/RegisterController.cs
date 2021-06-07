using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Spedito.Models.Account;
using SpeditoReposity.Models;
using SpeditoReposity.Reposities.AuthReposities;
using SpeditoReposity.Repositories.ShoppingReposities;
using System;

namespace Spedito.Controllers
{
    public class RegisterController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IAuthRepository _authRepository;
        private readonly IBasketRepository _basketRepository;
        public RegisterController(IMapper mapper,
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(RegisterViewModel register)
        {
            bool checkUser = _authRepository.CheckEmail(register.Email);

            if (checkUser)
            {
                ModelState.AddModelError("Email", "Email has already been taken");
            }
            if (ModelState.IsValid)
            {
                var user = _mapper.Map<RegisterViewModel, User>(register);
                user.Token = Guid.NewGuid().ToString();
                user.Status = true;
                _authRepository.Register(user);

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

            return View("~/Views/Register/Index.cshtml", new AccountViewModel 
            { 
                Register = register
            });
        }
    }
}
