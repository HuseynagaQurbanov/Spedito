﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SpeditoReposity.Models
{
    public class Department : BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
