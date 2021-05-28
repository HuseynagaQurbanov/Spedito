using Microsoft.EntityFrameworkCore;
using SpeditoReposity.Data;
using SpeditoReposity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeditoReposity.Repositories.ShoppingReposities
{
    public class ProductRepository : IProductRepository
    {
        private readonly SpeditoDbContext _context;
        public ProductRepository(SpeditoDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetRecommendedProduct(int limit)
        {
            return _context.Products.Include("Photos")
                                    .Where(p => p.Status)
                                    .Where(p => p.IsRecommended)
                                    .OrderByDescending(p => p.AddedDate)
                                    .Take(limit)
                                    .ToList();
        }
    }
}
