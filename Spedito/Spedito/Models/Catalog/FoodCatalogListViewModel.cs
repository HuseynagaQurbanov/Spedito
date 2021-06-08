using SpeditoReposity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spedito.Models.Catalog
{
    public class FoodCatalogListViewModel
    {
        public FoodCatalogViewModel FoodCatalog { get; set; }
        public IEnumerable<ProductViewModel> Products { get; set; }
        public ProductListing OrderBy { get; set; }
    }
}
