using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Spedito.Models;
using SpeditoReposity.Models;
using SpeditoReposity.Repositories.ContextRepositories;
using System.Collections.Generic;

namespace Spedito.ViewComponents
{
    public class BannerViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;

        public BannerViewComponent(IMapper mapper,
                                   IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }

        public IViewComponentResult Invoke()
        {
            var collections = _contentRepository.GetFoodCollections();

            var model = _mapper.Map<IEnumerable<FoodCategory>, IEnumerable<FoodCatalogViewModel>>(collections);

            return View(model);
        }
    }
}
