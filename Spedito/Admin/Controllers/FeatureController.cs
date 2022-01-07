using Admin.Models.Content;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SpeditoReposity.Models;
using SpeditoReposity.Repositories.ContextRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Controllers
{
    public class FeatureController : Controller
    {
        private SpeditoReposity.Models.Admin _admin => RouteData.Values["Admin"] as SpeditoReposity.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;

        public FeatureController(IMapper mapper,
                                  IContentRepository catalogRepository)
        {
            _mapper = mapper;
            _contentRepository = catalogRepository;
        }

        public IActionResult Index()
        {
            var feature = _contentRepository.GetFeatures();
            var model = _mapper.Map<IEnumerable<Feature>, IEnumerable<FeatureViewModel>>(feature);

            return View(model);
        }

        public IActionResult Edit(int id)
        {
            Feature feature = _contentRepository.GetFeatureById(id);

            if (feature == null) return NotFound();

            var model = _mapper.Map<Feature, FeatureViewModel>(feature);

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(FeatureViewModel model)
        {
            if (ModelState.IsValid)
            {
                Feature feature = _mapper.Map<FeatureViewModel, Feature>(model);

                Feature featureToUpdate = _contentRepository.GetFeatureById(model.Id);

                if (featureToUpdate == null) return NotFound();

                _contentRepository.UpdateFeature(featureToUpdate, feature);

                return RedirectToAction("index");
            }

            return View(model);
        }
    }
}
