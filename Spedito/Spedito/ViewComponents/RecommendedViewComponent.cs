using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Spedito.Models;
using SpeditoReposity.Models;
using SpeditoReposity.Repositories.ShoppingReposities;
using System.Collections.Generic;

namespace Spedito.ViewComponents
{
    public class RecommendedViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public RecommendedViewComponent(IMapper mapper,
                                    IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public IViewComponentResult Invoke()
        {
            var products = _productRepository.GetRecommendedProduct(8);

            var model = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);

            return View(model);
        }
    }
}
