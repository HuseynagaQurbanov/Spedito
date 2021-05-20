using System.ComponentModel.DataAnnotations;

namespace SpeditoReposity.Models
{
    public class ProductReview : BaseEntity
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(500)]
        public string Review { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }

    }
}
