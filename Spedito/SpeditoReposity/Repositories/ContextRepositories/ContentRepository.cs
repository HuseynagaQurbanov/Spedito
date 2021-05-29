using SpeditoReposity.Data;
using SpeditoReposity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeditoReposity.Repositories.ContextRepositories
{
    public class ContentRepository : IContentRepository
    {
        private readonly SpeditoDbContext _context;
        public ContentRepository(SpeditoDbContext context)
        {
            _context = context;
        }

        public IEnumerable<AboutUsSection> GetAboutUsSections()
        {
            return _context.AboutUsSections.Where(s => s.Status)
                                           .ToList();
        }

        public IEnumerable<Feature> GetFeatures()
        {
            return _context.Features.Where(s => s.Status)
                                    .OrderBy(s => s.OrderBy)
                                    .ToList();
        }

        public IEnumerable<FirstScreenTitle> GetFirstScreenTitles()
        {
            return _context.FirstScreenTitles.Where(s => s.Status)
                                             .ToList();
        }

        public IEnumerable<FoodCollection> GetFoodCollections()
        {
            return _context.FoodCollections.Where(s => s.Status)
                                       .OrderBy(s => s.OrderBy)
                                       .ToList();
        }

        public IEnumerable<SliderItem> GetSliderItems()
        {
            return _context.SliderItems.Where(s => s.Status)
                                       .OrderBy(s => s.OrderBy)
                                       .ToList();
        }

        public IEnumerable<Step> GetSteps()
        {
            return _context.Steps.Where(s => s.Status)
                                       .OrderBy(s => s.OrderBy)
                                       .ToList();
        }
    }
}
