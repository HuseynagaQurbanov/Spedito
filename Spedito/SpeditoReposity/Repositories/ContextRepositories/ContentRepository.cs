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

        AboutUsSection GetAboutUsSectionsById(int id);

        Feature GetFeatureById(int id);

        Step GetStepById(int id);

        void UpdateAboutUsSection(AboutUsSection aboutUsToUpdate, AboutUsSection aboutUs);

        void UpdateFeature(Feature featureToUpdate, Feature feature);

        void UpdateStep(Step stepToUpdate, Step step);
        Step CreateStep(Step step);
        void DeleteStep(Step step);
    }

    public class ContentRepository : IContentRepository
    {
        private readonly SpeditoDbContext _context;
        public ContentRepository(SpeditoDbContext context)
        {
            _context = context;
        }

        public Step CreateStep(Step step)
        {
            step.AddedDate = DateTime.Now;

            _context.Steps.Add(step);

            _context.SaveChanges();

            return step;
        }

        public void DeleteStep(Step step)
        {
            _context.Steps.Remove(step);

            _context.SaveChanges();
        }

        public IEnumerable<AboutUsSection> GetAboutUsSections()
        {
            return _context.AboutUsSections.Where(s => s.Status)
                                           .ToList();
        }

        public AboutUsSection GetAboutUsSectionsById(int id)
        {
            return _context.AboutUsSections.Find(id);
        }

        public Feature GetFeatureById(int id)
        {
            return _context.Features.Find(id);
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
                                          .ToList();
        }

        public IEnumerable<SliderItem> GetSliderItems()
        {
            return _context.SliderItems.Where(s => s.Status)
                                       .OrderBy(s => s.OrderBy)
                                       .ToList();
        }

        public Step GetStepById(int id)
        {
            return _context.Steps.Find(id);
        }

        public IEnumerable<Step> GetSteps()
        {
            return _context.Steps.Where(s => s.Status)
                                       .OrderBy(s => s.OrderBy)
                                       .ToList();
        }

        public void UpdateAboutUsSection(AboutUsSection aboutUsToUpdate, AboutUsSection aboutUs)
        {
            aboutUsToUpdate.Status = aboutUs.Status;
            aboutUsToUpdate.Title = aboutUs.Title;
            aboutUsToUpdate.Description = aboutUs.Description;
            aboutUsToUpdate.ModifiedBy = aboutUs.ModifiedBy;
            aboutUsToUpdate.ModifiedDate = DateTime.Now;

            _context.SaveChanges();
        }

        public void UpdateFeature(Feature featureToUpdate, Feature feature)
        {
            featureToUpdate.Status = feature.Status;
            featureToUpdate.Title = feature.Title;
            featureToUpdate.Description = feature.Description;
            featureToUpdate.ModifiedBy = feature.ModifiedBy;
            featureToUpdate.ModifiedDate = DateTime.Now;

            _context.SaveChanges();
        }

        public void UpdateStep(Step stepToUpdate, Step step)
        {
            stepToUpdate.Status = step.Status;
            stepToUpdate.Title = step.Title;
            stepToUpdate.Description = step.Description;
            stepToUpdate.Steps = step.Steps;
            stepToUpdate.ModifiedBy = step.ModifiedBy;
            stepToUpdate.ModifiedDate = DateTime.Now;

            _context.SaveChanges();
        }
    }
}
