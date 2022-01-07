using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Spedito.Models
{
    public class ContactViewModel
    {
        public int Id { get; set; }

        [Required]
        public bool Status { get; set; }

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
