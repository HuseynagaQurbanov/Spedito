using System;
using System.Collections.Generic;
using System.Text;

namespace SpeditoReposity.Models
{
    public class ProductOptionItem
    {
        public int ProductOptionId { get; set; }
        public string Name { get; set; }
        public string  Value { get; set; }
        public ProductOption Option { get; set; }
    }
}
