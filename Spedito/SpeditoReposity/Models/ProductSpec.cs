using System.ComponentModel.DataAnnotations;

namespace SpeditoReposity.Models
{
    public class ProductSpec : BaseEntity
    {
        public int OrderBy { get; set; }

        public int ProductId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Key { get; set; }

        [Required]
        [MaxLength(500)]
        public string Value { get; set; }
    }
}
