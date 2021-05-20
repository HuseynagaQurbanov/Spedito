using System;
using System.ComponentModel.DataAnnotations;

namespace SpeditoReposity.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        [MaxLength(50)]
        public string AddedBy { get; set; }

        [MaxLength(50)]
        public string ModifiedBy { get; set; }
    }
}
