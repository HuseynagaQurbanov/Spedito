using System;
using System.Collections.Generic;
using System.Text;

namespace SpeditoReposity.Models
{
    public class ProductReview : BaseEntity
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Review { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }

    }
}
