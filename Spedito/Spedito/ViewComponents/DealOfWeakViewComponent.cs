using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Spedito.Models;
using SpeditoReposity.Models;
using SpeditoReposity.Repositories.ShoppingReposities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spedito.ViewComponents
{
    public class DealOfWeakViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public DealOfWeakViewComponent(IMapper mapper,
                                    IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public IViewComponentResult Invoke()
        {
            var dealOfWeak = _productRepository.GetDealOfWeakProducts(1);

            var model = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(dealOfWeak);

            return View(model);
        }
    }
}
