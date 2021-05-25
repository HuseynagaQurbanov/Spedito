using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SpeditoReposity.Models;

namespace SpeditoReposity.Data
{
    public class SpeditoDbContext : DbContext
    {
        public SpeditoDbContext(DbContextOptions<SpeditoDbContext> options) :base(options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<FoodCollection> FoodCollections { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOption> ProductOptions { get; set; }
        public DbSet<ProductOptionItem> ProductOptionItems { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<ProductReview> ProductReviews { get; set; }
        public DbSet<ProductSliderItem> ProductSliderItems { get; set; }
        public DbSet<ProductSpec> ProductSpecs { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WishList> WishLists { get; set; }
    }
}
