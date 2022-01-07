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
    public class AboutUsController : Controller
    {
        private SpeditoReposity.Models.Admin _admin => RouteData.Values["Admin"] as SpeditoReposity.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;

        public AboutUsController(IMapper mapper,
                                  IContentRepository catalogRepository)
        {
            _mapper = mapper;
            _contentRepository = catalogRepository;
        }

        public IActionResult Index()
        {
            var aboutSection = _contentRepository.GetAboutUsSections();
            var model = _mapper.Map<IEnumerable<AboutUsSection>, IEnumerable<AboutUsViewModel>>(aboutSection);

            return View(model);
        }


        public IActionResult Edit(int id)
        {
            AboutUsSection section = _contentRepository.GetAboutUsSectionsById(id);

            if (section == null) return NotFound();

            var model = _mapper.Map<AboutUsSection, AboutUsViewModel>(section);

            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(AboutUsViewModel model)
        {
            if (ModelState.IsValid)
            {
                AboutUsSection section = _mapper.Map<AboutUsViewModel, AboutUsSection>(model);

                AboutUsSection aboutUsToUpdate = _contentRepository.GetAboutUsSectionsById(model.Id);

                if (aboutUsToUpdate == null) return NotFound();

                _contentRepository.UpdateAboutUsSection(aboutUsToUpdate, section);

                return RedirectToAction("index");
            }

            return View(model);
        }
    }
}
