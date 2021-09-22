using Admin.Filters;
using Microsoft.AspNetCore.Mvc;
using System;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpeditoReposity.Repositories.ShoppingReposities;
using Admin.Models.Shopping;
using SpeditoReposity.Models;

namespace Admin.Controllers
{
    [TypeFilter(typeof(Auth))]
    public class CategoryController : Controller
    {
        private SpeditoReposity.Models.Admin _admin => RouteData.Values["Admin"] as SpeditoReposity.Models.Admin;
        private readonly IMapper _mapper;
        private readonly ICatalogRepository _catalogRepository;

        public CategoryController(IMapper mapper,
                                  ICatalogRepository catalogRepository)
        {
            _mapper = mapper;
            _catalogRepository = catalogRepository;
        }


        public IActionResult Index()
        {
            var categories = _catalogRepository.GetCategories();
            var model = _mapper.Map<IEnumerable<FoodCategory>, IEnumerable<CategoryViewModel>>(categories);

            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                FoodCategory foodCategory = _mapper.Map<CategoryViewModel, FoodCategory>(model);
                foodCategory.AddedBy = _admin.Fullname;

                _catalogRepository.CreateCategory(foodCategory);

                return RedirectToAction("index");
            }

            return View(model);
        }

        public IActionResult Edit(int id)
        {
            FoodCategory foodCategory = _catalogRepository.GetFoodCategoryById(id);

            if (foodCategory == null) return NotFound();

            var model = _mapper.Map<FoodCategory, CategoryViewModel>(foodCategory);

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                FoodCategory foodCategory = _mapper.Map<CategoryViewModel, FoodCategory>(model);
                foodCategory.ModifiedBy = _admin.Fullname;

                FoodCategory foodCategoryToUpdate = _catalogRepository.GetFoodCategoryById(model.Id);

                if (foodCategoryToUpdate == null) return NotFound();

                _catalogRepository.UpdateCategory(foodCategoryToUpdate, foodCategory);

                return RedirectToAction("index");
            }

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            FoodCategory foodCategory = _catalogRepository.GetFoodCategoryById(id);

            if (foodCategory == null) return NotFound();

            _catalogRepository.DeleteCategory(foodCategory);

            return RedirectToAction("index");
        }
    }
}
