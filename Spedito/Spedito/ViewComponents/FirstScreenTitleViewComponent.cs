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
    public class FirstScreenTitleViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;

        public FirstScreenTitleViewComponent(IMapper mapper,
                                   IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }

        public IViewComponentResult Invoke()
        {
            var firstScreenTitles = _contentRepository.GetFirstScreenTitles();

            var model = _mapper.Map<IEnumerable<FirstScreenTitle>, IEnumerable<FirstScreenTitleViewModel>>(firstScreenTitles);

            return View(model);
        }
    }
}
