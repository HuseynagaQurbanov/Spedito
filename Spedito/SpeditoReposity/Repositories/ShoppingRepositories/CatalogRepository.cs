using SpeditoReposity.Data;
using SpeditoReposity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeditoReposity.Repositories.ShoppingReposities
{
    public interface ICatalogRepository
    {
        FoodCategory GetFoodCategoryById(int id);
        IEnumerable<FoodCategory> GetCategories();
        FoodCategory CreateCategory(FoodCategory foodCategory);
        void UpdateCategory(FoodCategory foodCategoryToUpdate, FoodCategory foodCategory);
        void DeleteCategory(FoodCategory foodCategory);
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

        public IEnumerable<FoodCategory> GetCategories()
        {
            return _context.FoodCategories.ToList();
        }

        public FoodCategory CreateCategory(FoodCategory foodCategory)
        {
            foodCategory.AddedDate = DateTime.Now;

            _context.FoodCategories.Add(foodCategory);

            _context.SaveChanges();

            return foodCategory;
        }

        public void UpdateCategory(FoodCategory foodCategoryToUpdate, FoodCategory foodCategory)
        {
            foodCategoryToUpdate.Status = foodCategory.Status;
            foodCategoryToUpdate.Name = foodCategory.Name;
            foodCategoryToUpdate.ModifiedBy = foodCategory.ModifiedBy;
            foodCategoryToUpdate.ModifiedDate = DateTime.Now;

            _context.SaveChanges();
        }

        public void DeleteCategory(FoodCategory foodCategory)
        {
            _context.FoodCategories.Remove(foodCategory);

            _context.SaveChanges();
        }
    }
}
