using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SpeditoReposity.Models
{
    public class SliderItem : BaseEntity
    {
        public int OrderBy { get; set; }

        [Required]
        [MaxLength(100)]
        public string Image { get; set; }
    }
}
