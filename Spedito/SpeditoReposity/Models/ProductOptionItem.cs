using System.ComponentModel.DataAnnotations;

namespace SpeditoReposity.Models
{
    public class ProductOptionItem : BaseEntity
    {
        public int ProductOptionId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string  Value { get; set; }

        public ProductOption Option { get; set; }
    }
}
