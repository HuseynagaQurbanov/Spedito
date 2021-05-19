using System;
using System.Collections.Generic;
using System.Text;

namespace SpeditoReposity.Models
{
    public class User : BaseEntity
    {
        public ICollection<ProductReview> Reviews { get; set; }
    }
}
