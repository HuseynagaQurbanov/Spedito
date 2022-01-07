using Admin.Libs;
using Admin.Models.Content;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SpeditoReposity.Models;
using SpeditoReposity.Repositories.ContextRepositories;
using SpeditoReposity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Controllers
{
    public class StepController : Controller
    {
        private SpeditoReposity.Models.Admin _admin => RouteData.Values["Admin"] as SpeditoReposity.Models.Admin;
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;
        private readonly ICloudinaryService _cloudinaryService;
        private readonly IFileManager _fileManager;

        public StepController(IMapper mapper,
                                  IContentRepository catalogRepository)
        {
            _mapper = mapper;
            _contentRepository = catalogRepository;
        }

        public IActionResult Index()
        {
            var step = _contentRepository.GetSteps();
            var model = _mapper.Map<IEnumerable<Step>, IEnumerable<StepViewModel>>(step);

            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(StepViewModel model)
        {
            if (ModelState.IsValid)
            {
                Step step = _mapper.Map<StepViewModel, Step>(model);

                _contentRepository.CreateStep(step);

                return RedirectToAction("index");
            }

            return View(model);
        }

        public IActionResult Edit(int id)
        {
            Step step = _contentRepository.GetStepById(id);

            if (step == null) return NotFound();

            var model = _mapper.Map<Step, StepViewModel>(step);

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(StepViewModel model)
        {
            if (ModelState.IsValid)
            {
                Step step = _mapper.Map<StepViewModel, Step>(model);

                Step stepToUpdate = _contentRepository.GetStepById(model.Id);

                if (stepToUpdate == null) return NotFound();

                _contentRepository.UpdateStep(stepToUpdate, step);

                return RedirectToAction("index");
            }

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            Step step = _contentRepository.GetStepById(id);

            if (step == null) return NotFound();

            _contentRepository.DeleteStep(step);

            return RedirectToAction("index");
        }
    }
}
