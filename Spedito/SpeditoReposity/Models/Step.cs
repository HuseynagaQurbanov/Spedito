using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SpeditoReposity.Models
{
    public class Step : BaseEntity
    {
        
        public string Image { get; set; }

        [Required]
        public int Steps { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public int OrderBy { get; set; }
    }
}
