using SpeditoReposity.Data;
using SpeditoReposity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpeditoReposity.Repositories.ShoppingReposities
{
    public interface ICatalogRepository
    {
        FoodCategory GetFoodCategoryById(int id);
    }
    public class CatalogRepository : ICatalogRepository
    {
        private readonly SpeditoDbContext _context;
        public CatalogRepository(SpeditoDbContext context)
        {
            _context = context;
        }

        public FoodCategory GetFoodCategoryById(int id)
        {
            return _context.FoodCategories.Find(id);
        }
    }
}
