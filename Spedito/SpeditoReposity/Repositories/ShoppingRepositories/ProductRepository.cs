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
        Product GetProductById(int id);
        Product GetProductDetailsById(int id);
        void CreateReview(ProductReview productReview);
        IEnumerable<Product> GetProducts();
        Product CreateProduct(Product product);
        void RemovePhotoById(int id);
        void AddPhoto(ProductPhoto productPhoto);
        void UpdateProduct(Product productToUpdate, Product product);
        void DeleteProduct(Product product);
    }

    public class ProductRepository : IProductRepository
    {
        private readonly SpeditoDbContext _context;
        public ProductRepository(SpeditoDbContext context)
        {
            _context = context;
        }

        public void AddPhoto(ProductPhoto productPhoto)
        {
            _context.ProductPhotos.Add(productPhoto);
            _context.SaveChanges();
        }

        public Product CreateProduct(Product product)
        {
            product.AddedDate = DateTime.Now;

            _context.Products.Add(product);
            _context.SaveChanges();

            return product;
        }

        public void CreateReview(ProductReview productReview)
        {
            _context.ProductReviews.Add(productReview);
            _context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            _context.Products.Remove(product);

            _context.SaveChanges();
        }

        public IEnumerable<Product> GetDealOfWeakProducts(int limit)
        {
            return _context.Products.Include("Photos")
                                    .Where(p => p.Status)
                                    .Take(limit)
                                    .ToList();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.Include("Photos")
                                    .Include("FoodCategory")
                                    .FirstOrDefault(p => p.Status && p.Id == id);
        }

        public Product GetProductDetailsById(int id)
        {
            return _context.Products
                           .Include("Photos")
                           .Include("Reviews")
                           .FirstOrDefault(p => p.Status && p.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.Include("Photos")
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

        public void RemovePhotoById(int id)
        {
            ProductPhoto productPhoto = _context.ProductPhotos.Find(id);

            _context.ProductPhotos.Remove(productPhoto);

            _context.SaveChanges();
        }

        public void UpdateProduct(Product productToUpdate, Product product)
        {
            productToUpdate.Status = product.Status;
            productToUpdate.Name = product.Name;
            productToUpdate.Price = product.Price;
            productToUpdate.Text = product.Text;
            productToUpdate.Description = product.Description;
            productToUpdate.FoodCategoryId = product.FoodCategoryId;
            productToUpdate.ModifiedBy = product.ModifiedBy;
            productToUpdate.ModifiedDate = DateTime.Now;

            _context.SaveChanges();
        }
    }
}
