using System.ComponentModel.DataAnnotations;

namespace SpeditoReposity.Models
{
    public class ProductSliderItem : BaseEntity
    {
        public int OrderBy { get; set; }

        public int ProductId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Image { get; set; }

        [Required]
        [MaxLength(50)]
        public string ActionText { get; set; }

        [Required]
        [MaxLength(200)]
        public string EndPoint { get; set; }

        public Product Product { get; set; }
    }
}
