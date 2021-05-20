using System.ComponentModel.DataAnnotations;

namespace SpeditoReposity.Models
{
    public class Setting : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Logo { get; set; }

        [Required]
        [MaxLength(50)]
        public string CallUs { get; set; }

        [Required]
        [MaxLength(50)]
        public string Address { get; set; }

        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }

        [Required]
        [MaxLength(50)]
        public string OpeningHours { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }
    }
}
