using System.ComponentModel.DataAnnotations;

namespace SpeditoReposity.Models
{
   public class FoodCategory : BaseEntity
    {

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Icon { get; set; }
    }
}
