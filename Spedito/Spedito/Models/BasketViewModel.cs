using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spedito.Models
{
    public class BasketViewModel 
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public int Count { get; set; }
        public ProductViewModel Product { get; set; }
    }
}
