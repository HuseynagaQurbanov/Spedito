using System;
using System.Collections.Generic;
using System.Text;

namespace SpeditoReposity.Models
{
    public class ProductOption : BaseEntity
    {
        public OptionsType Type { get; set; }
        public int ProductId { get; set; }
        public string Title { get; set; }
        public Product Product { get; set; }
        public ICollection<ProductOptionItem> OptionItems { get; set; }
    }
}
