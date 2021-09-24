using Admin.Filters;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SpeditoReposity.Repositories.ShoppingReposities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class DashboardController : Controller
    {
        private SpeditoReposity.Models.Admin _admin => RouteData.Values["Admin"] as SpeditoReposity.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public DashboardController(IMapper mapper,
                                 IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            ViewBag.Products = _productRepository.GetProducts();

            return View();
        }
    }
}
