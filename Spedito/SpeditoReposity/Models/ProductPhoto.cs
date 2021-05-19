using System;
using System.Collections.Generic;
using System.Text;

namespace SpeditoReposity.Models
{
    public class ProductPhoto : BaseEntity
    {
        public int OrderBy { get; set; }

        public int ProductId { get; set; }

        public string Image { get; set; }

        public Product Product { get; set; }
    }
}
