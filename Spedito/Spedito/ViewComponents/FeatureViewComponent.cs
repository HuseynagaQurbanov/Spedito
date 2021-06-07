using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Spedito.Models;
using SpeditoReposity.Models;
using SpeditoReposity.Repositories.ContextRepositories;
using System.Collections.Generic;

namespace Spedito.ViewComponents
{
    public class FeatureViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;

        public FeatureViewComponent(IMapper mapper,
                                   IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }

        public IViewComponentResult Invoke()
        {
            var features = _contentRepository.GetFeatures();

            var model = _mapper.Map<IEnumerable<Feature>, IEnumerable<FeatureViewModel>>(features);

            return View(model);
        }
    }
}
