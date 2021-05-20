using System.ComponentModel.DataAnnotations;

namespace SpeditoReposity.Models
{
   public class FoodCollection : BaseEntity
    {
        public int OrderBy { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Icon { get; set; }

        [Required]
        [MaxLength(200)]
        public string EndPoint { get; set; }
    }
}
