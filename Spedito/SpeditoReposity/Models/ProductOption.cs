﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SpeditoReposity.Models
{
    public class ProductOption : BaseEntity
    {
        [Required]
        public OptionsType Type { get; set; }

        [Required]
        public int ProductId { get; set; }

        public Product Product { get; set; }
        public ICollection<ProductOptionItem> OptionItems { get; set; }
    }
}
