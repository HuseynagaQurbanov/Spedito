using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Spedito.Models;
using SpeditoReposity.Models;
using SpeditoReposity.Repositories.ShoppingReposities;
using System.Collections.Generic;

namespace Spedito.Controllers
{
    public class BasketController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IBasketRepository _basketRepository;

        public BasketController(IMapper mapper,
                                IBasketRepository basketRepository)
        {
            _mapper = mapper;
            _basketRepository = basketRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(int id)
        {
            Request.Cookies.TryGetValue("token", out string token);

            var basketItem = _basketRepository.GetBasketByProductAndToken(id, token);

            if (basketItem == null)
            {
                Basket basket = new Basket
                {
                    ProductId = id,
                    Token = token,
                    Count = 1,
                    AddedBy = "System",
                    ModifiedBy = "System"
                };

                _basketRepository.CreateBasket(basket);
            }
            else
            {
                _basketRepository.ChangeCount(basketItem, basketItem.Count + 1);
            }

            var basketItems = _basketRepository.GetBasketByToken(token);

            var basketModel = _mapper.Map<IEnumerable<Basket>, IEnumerable<BasketViewModel>>(basketItems);

            return View("Basket", basketModel);
        }
    }
}
