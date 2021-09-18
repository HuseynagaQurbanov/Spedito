using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Spedito.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Text { get; set; }
        public IList<string> Photos { get; set; }
        public string Description { get; set; }
        public IList<ReviewViewModel> Reviews { get; set; }
        public IList<OptionsViewModel> Options { get; set; }


        public int ProductId { get; set; }
        [Required]
        [MaxLength(30)]
        public string FullName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(500)]
        public string Review { get; set; }
    }
}
