using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Admin.Models.Shopping
{
    public class ProductPhotoViewModel
    {
        public int Id { get; set; }

        public int OrderBy { get; set; }

        public int ProductId { get; set; }

        public string Image { get; set; }
    }
}
