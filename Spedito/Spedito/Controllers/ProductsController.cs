using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Spedito.Models;
using SpeditoReposity.Models;
using SpeditoReposity.Repositories.ShoppingReposities;

namespace Spedito.Controllers
{
    public class ProductsController : Controller
    {
        public readonly IMapper _mapper;
        public readonly IProductRepository _productRepository;

        public ProductsController(IMapper mapper,
                                  IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public IActionResult Index(int id)
        {
            var product = _productRepository.GetProductById(id);

            if (product == null) return NotFound();

            var model = _mapper.Map<Product, ProductViewModel>(product);

            return View(model);
        }

        public IActionResult LeaveReview()
        {
            return View();
        }


    }
}
