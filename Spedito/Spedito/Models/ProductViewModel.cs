using System.Collections.Generic;

namespace Spedito.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public IList<string> Photos { get; set; }
        public string Description { get; set; }
    }
}
