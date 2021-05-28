using SpeditoReposity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpeditoReposity.Repositories.ShoppingReposities
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetRecommendedProduct(int limit);
    }
}
