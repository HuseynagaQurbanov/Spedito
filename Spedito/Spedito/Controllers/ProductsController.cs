using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Spedito.Libs;
using Spedito.Models;
using SpeditoReposity.Models;
using SpeditoReposity.Repositories.ShoppingReposities;
using System;

namespace Spedito.Controllers
{
    public class ProductsController : Controller
    {
        public readonly IMapper _mapper;
        private readonly IAuth _auth;
        public readonly IProductRepository _productRepository;

        public ProductsController(IMapper mapper,
                                  IProductRepository productRepository,
                                  IAuth auth)
        {
            _mapper = mapper;
            _productRepository = productRepository;
            _auth = auth;
        }

        public IActionResult Index(int id)
        {
            var product = _productRepository.GetProductDetailsById(id);

            if (product == null) return NotFound();

            var model = _mapper.Map<Product, ProductViewModel>(product);

            return View(model);
        }

        public IActionResult LeaveReview(int id)
        {
            var product = _productRepository.GetProductById(id);

            if (product == null) return NotFound();

            ViewBag.ProductId = product.Id;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult LeaveReview(ProductViewModel model)
        {
            if (_auth.User == null) return NotFound();

            if (ModelState.IsValid)
            {
                ProductReview productReview = new ProductReview
                {
                    Status = false,
                    ProductId = model.ProductId,
                    UserId = _auth.User.Id,
                    Name = model.FullName,
                    Email = model.Email,
                    Review = model.Review,
                    AddedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    AddedBy = _auth.User.FullName,
                    ModifiedBy = _auth.User.FullName

                };

                _productRepository.CreateReview(productReview);
            }

            var product = _productRepository.GetProductById(model.ProductId);

            if (product == null) return NotFound();

            ViewBag.ProductId = product.Id;

            return View(model);
        }


    }
}
