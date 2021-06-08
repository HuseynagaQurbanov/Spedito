using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Spedito.Models;
using Spedito.Models.Catalog;
using SpeditoReposity.Models;
using SpeditoReposity.Repositories.ShoppingReposities;
using System.Collections;
using System.Collections.Generic;

namespace Spedito.Controllers
{
    public class CatalogController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ICatalogRepository _catalogRepository;
        private readonly IProductRepository _productRepository;

        public CatalogController(IMapper mapper,
                                 ICatalogRepository catalogRepository,
                                 IProductRepository productRepository)
        {
            _mapper = mapper;
            _catalogRepository = catalogRepository;
            _productRepository = productRepository;
        }
        public IActionResult Index(int id)
        {
            var catalog = _catalogRepository.GetFoodCategoryById(id);

            if (catalog == null) return NotFound();

            var products = _productRepository.GetProductsByCatalogId(catalog.Id, 16, 0, SpeditoReposity.Enum.ProductListing.Newness);

            var model = new FoodCatalogListViewModel
            {
                FoodCatalog = _mapper.Map<FoodCategory, FoodCatalogViewModel>(catalog),
                Products = _mapper.Map<IEnumerable<Product>,IEnumerable<ProductViewModel>>(products)
            };

            return View(model);
        }
    }
}
