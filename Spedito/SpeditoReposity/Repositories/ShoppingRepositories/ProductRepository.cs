using Microsoft.EntityFrameworkCore;
using SpeditoReposity.Data;
using SpeditoReposity.Enum;
using SpeditoReposity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeditoReposity.Repositories.ShoppingReposities
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetSpecialDealProducts();
        IEnumerable<Product> GetRecommendedProduct(int limit);

        IEnumerable<Product> GetDealOfWeakProducts(int limit);

        IEnumerable<Product> GetProductsByCatalogId(int catalogId, int take, int skip, ProductListing orderBy);
    }

    public class ProductRepository : IProductRepository
    {
        private readonly SpeditoDbContext _context;
        public ProductRepository(SpeditoDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetDealOfWeakProducts(int limit)
        {
            return _context.Products.Include("Photos")
                                    .Where(p => p.Status)
                                    .Take(limit)
                                    .ToList();
        }

        public IEnumerable<Product> GetProductsByCatalogId(int catalogId, int take, int skip, ProductListing orderBy)
        {
            var products = _context.Products.Include("Photos")
                                    .Where(p => p.Status)
                                    .Where(p => p.FoodCategoryId == catalogId)
                                    .Where(p => p.Status);
            switch (orderBy)
            {
                case ProductListing.Newness:
                    products.OrderByDescending(p => p.AddedDate);
                    break;
                case ProductListing.PriceAsc:
                    products.OrderBy(p => p.Price);
                    break;
                case ProductListing.PriceDesc:
                    products.OrderByDescending(p => p.Price);
                    break;
            };

            return products.ToList().Take(take).Skip(skip);
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

        public IEnumerable<Product> GetSpecialDealProducts()
        {
            return _context.Products.Include("Photos")
                                    .Where(p => p.Status)
                                    .Where(p => p.IsSpecialDeal)
                                    .OrderByDescending(p => p.AddedDate)
                                    .ToList();
        }
    }
}
