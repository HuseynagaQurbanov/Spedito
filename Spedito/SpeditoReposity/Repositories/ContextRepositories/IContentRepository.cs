using SpeditoReposity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpeditoReposity.Repositories.ContextRepositories
{
    public interface IContentRepository
    {
        IEnumerable<SliderItem> GetSliderItems();

        IEnumerable<FoodCollection> GetFoodCollections();

        IEnumerable<FirstScreenTitle> GetFirstScreenTitles();
    }
}
