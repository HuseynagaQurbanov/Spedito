using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Spedito.Models.Account;
using SpeditoReposity.Models;
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
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login(LoginViewModel login)
        {
            return Ok();
        }
    }
}
