using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpeditoReposity.Models
{
    public class Product : BaseEntity
    {
        [Required]
        public int CategoryId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [Column(TypeName="ntext")]
        public string Text { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public bool IsRecommended { get; set; }

        [Required]
        public bool IsDealOfWeek { get; set; }

        public Department Department { get; set; }
        public ICollection<ProductPhoto> Photos { get; set; }
        public ICollection<ProductReview> Reviews { get; set; }
        public ICollection<ProductOption> Options { get; set; }
        public ICollection<WishList> WishList { get; set; }
    
    }
}
