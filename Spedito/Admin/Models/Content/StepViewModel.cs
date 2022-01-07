using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Content
{
    public class StepViewModel
    {
        public int Id { get; set; }

        [Required]
        public bool Status { get; set; }

        [Required(ErrorMessage = "Step is required")]
        [MaxLength(50, ErrorMessage = "The Step number can be a maximum of 50 characters")]
        public string Steps { get; set; }

        [Required(ErrorMessage = "Title name is required")]
        [MaxLength(50, ErrorMessage = "The title name can be a maximum of 50 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [MaxLength(500, ErrorMessage = "The description can be a maximum of 500 characters")]
        public string Description { get; set; }
    }
}
