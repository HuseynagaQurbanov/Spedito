using System.ComponentModel.DataAnnotations;

namespace SpeditoReposity.Models
{
    public class ProductPhoto : BaseEntity
    {
        public int OrderBy { get; set; }

        public int ProductId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Image { get; set; }

        public Product Product { get; set; }
    }
}
