using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpeditoReposity.Models
{
    public class Product : BaseEntity
    {
        [Required]
        public int FoodCategoryId { get; set; }

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

        [Required]
        public bool IsSpecialDeal { get; set; }

        public FoodCategory FoodCategory { get; set; }
        public ICollection<ProductPhoto> Photos { get; set; }
        public ICollection<ProductReview> Reviews { get; set; }
        public ICollection<Basket> Baskets { get; set; }

    }
}
