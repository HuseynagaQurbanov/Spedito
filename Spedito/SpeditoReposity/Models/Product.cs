using System;
using System.Collections.Generic;
using System.Text;

namespace SpeditoReposity.Models
{
    public class Product : BaseEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductPhoto> Photos { get; set; }
        public ICollection<ProductReview> Reviews { get; set; }
        public ICollection<ProductOption> Options { get; set; }
    }
}
