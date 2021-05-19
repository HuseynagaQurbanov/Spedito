using System;
using System.Collections.Generic;
using System.Text;

namespace SpeditoReposity.Models
{
    public class Category : BaseEntity
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
    }
}
