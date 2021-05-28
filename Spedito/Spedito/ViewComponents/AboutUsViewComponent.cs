using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Spedito.Models;
using SpeditoReposity.Models;
using SpeditoReposity.Repositories.ContextRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spedito.ViewComponents
{
    public class AboutUsViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;

        public AboutUsViewComponent(IMapper mapper,
                                   IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }

        public IViewComponentResult Invoke()
        {
            var aboutUs = _contentRepository.GetAboutUsSections();

            var model = _mapper.Map<IEnumerable<AboutUsSection>, IEnumerable<AboutUsViewModel>>(aboutUs);

            return View(model);
        }
    }
}
