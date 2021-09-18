using SpeditoReposity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spedito.Models
{
    public class ReviewViewModel
    {
        public string Name { get; set; }
        public string Review { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
