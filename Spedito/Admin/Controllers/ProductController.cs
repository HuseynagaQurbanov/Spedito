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

        public IActionResult Edit(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null) return NotFound();

            var model = _mapper.Map<Product, ProductViewModel>(product);

            ViewBag.Categories = _catalogRepository.GetCategories();


            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ProductViewModel model)
        {
            if (ModelState.IsValid)
            {
                var product = _mapper.Map<ProductViewModel, Product>(model);

                var productToUpdate = _productRepository.GetProductById(model.Id);

                if (productToUpdate == null) return NotFound();

                product.ModifiedBy = _admin.Fullname;

                _productRepository.UpdateProduct(productToUpdate, product);
                
                return RedirectToAction("index");
            }

            ViewBag.Categories = _catalogRepository.GetCategories();

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            Product product = _productRepository.GetProductById(id);

            if (product == null) return NotFound();

            _productRepository.DeleteProduct(product);

            return RedirectToAction("index");
        }

        [HttpPost]
        public IActionResult Upload(IFormFile file,int? productId,int? orderBy)
        {
            var filename = _fileManager.Upload(file);
            var publicId = _cloudinaryService.Store(filename);
            _fileManager.Delete(filename);

            if (productId != null)
            {
                ProductPhoto productPhoto = new ProductPhoto
                {
                    AddedBy = _admin.Fullname,
                    AddedDate = DateTime.Now,
                    Image = publicId,
                    ProductId = (int)productId,
                    OrderBy = (int)orderBy
                };
                _productRepository.AddPhoto(productPhoto);
            }

            return Ok(new { 
                filename = publicId,
                src = _cloudinaryService.BuildUrl(publicId)
            });
        }

        [HttpPost]
        public IActionResult Remove(string name, int? id)
        {
            if (id != null)
            {
                _productRepository.RemovePhotoById((int)id);
            }
            _cloudinaryService.Delete(name);

            return Ok(new { status = 200 });
        }
        
    }
}
