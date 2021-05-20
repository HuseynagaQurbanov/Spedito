using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SpeditoReposity.Models
{
    public class User : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }

        [MaxLength(50)]
        public string Token { get; set; }

        public ICollection<ProductReview> Reviews { get; set; }
        public ICollection<WishList> WishList { get; set; }
    }
}
