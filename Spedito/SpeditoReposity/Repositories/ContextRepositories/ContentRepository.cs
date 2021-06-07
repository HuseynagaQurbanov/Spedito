using SpeditoReposity.Data;
using SpeditoReposity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeditoReposity.Repositories.ContextRepositories
{
    public interface IContentRepository
    {
        IEnumerable<SliderItem> GetSliderItems();

        IEnumerable<FoodCategory> GetFoodCollections();

        IEnumerable<FirstScreenTitle> GetFirstScreenTitles();

        IEnumerable<AboutUsSection> GetAboutUsSections();

        IEnumerable<Feature> GetFeatures();

        IEnumerable<Step> GetSteps();
    }

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

        public IEnumerable<FoodCategory> GetFoodCollections()
        {
            return _context.FoodCategories.Where(s => s.Status)
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
