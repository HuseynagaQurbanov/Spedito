using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models.Shopping
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [Range(0.1,double.MaxValue)]
        public decimal Price { get; set; }

        [Required]
        [MaxLength(500)]
        public string Text { get; set; }

        [Required]
        public string Description { get; set; }

        public int FoodCategoryId { get; set; }

        public IList<ProductPhotoViewModel> Photos { get; set; }
    }
}
