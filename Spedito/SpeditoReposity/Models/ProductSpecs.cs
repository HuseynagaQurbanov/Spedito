using System;
using System.Collections.Generic;
using System.Text;

namespace SpeditoReposity.Models
{
    public class ProductSpecs : BaseEntity
    {
        public int OrderBy { get; set; }

        public int ProductId { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }
    }
}
