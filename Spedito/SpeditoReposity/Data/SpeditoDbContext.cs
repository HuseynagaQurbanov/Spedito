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

        public DbSet<FoodCategory> FoodCategories { get; set; }
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
        public DbSet<SliderItem> SliderItems { get; set; }
        public DbSet<FirstScreenTitle> FirstScreenTitles { get; set; }
        public DbSet<AboutUsSection> AboutUsSections { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}
