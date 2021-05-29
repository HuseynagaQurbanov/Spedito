using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SpeditoReposity.Models
{
    public class Feature : BaseEntity
    {
        public int OrderBy { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [MaxLength(200)]
        public string Image { get; set; }
        

    }
}
