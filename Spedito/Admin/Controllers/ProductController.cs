using Admin.Filters;
using Admin.Models.Shopping;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpeditoReposity.Models;
using SpeditoReposity.Services;
using SpeditoReposity.Repositories.ShoppingReposities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin.Libs;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Admin.Filters.Auth))]
    public class ProductController : Controller
    {
        private SpeditoReposity.Models.Admin _admin => RouteData.Values["Admin"] as SpeditoReposity.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;
        private readonly ICloudinaryService _cloudinaryService;
        private readonly IFileManager _fileManager;
        private readonly ICatalogRepository _catalogRepository;

        public ProductController(IMapper mapper,
                                  IProductRepository productRepository,
                                  ICloudinaryService cloudinaryService,
                                  IFileManager fileManager,
                                  ICatalogRepository catalogRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
            _cloudinaryService = cloudinaryService;
            _fileManager = fileManager;
            _catalogRepository = catalogRepository;
        }
        public IActionResult Index()
        {
            var products = _productRepository.GetProducts();

            var model = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(products);

            return View(model);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = _catalogRepository.GetCategories();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product = _mapper.Map<ProductViewModel, Product>(model);

                product.AddedBy = _admin.Fullname;
                _productRepository.CreateProduct(product);


                return RedirectToAction("index");
            }


            return NotFound(model);
        }

        [HttpPost]
        public IActionResult Upload(IFormFile file)
        {
            var filename = _fileManager.Upload(file);
            var publicId = _cloudinaryService.Store(filename);
            _fileManager.Delete(filename);

            return Ok(new { 
                filename = publicId,
                src = _cloudinaryService.BuildUrl(publicId)
            });
        }

        [HttpPost]
        public IActionResult Remove(string name)
        {
            _cloudinaryService.Delete(name);

            return Ok(new { status = 200 });
        }
    }
}
