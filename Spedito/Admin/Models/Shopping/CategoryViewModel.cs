using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Admin.Models.Shopping
{
    public class CategoryViewModel
    {
        public int Id { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required(ErrorMessage = "Category name is required")]
        [MaxLength(50,ErrorMessage = "The category name can be a maximum of 50 characters")]
        public string Name { get; set; }
    }
}
