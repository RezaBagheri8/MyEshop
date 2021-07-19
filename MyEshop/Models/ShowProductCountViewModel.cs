using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyEshop.Models
{
    public class ShowProductCountViewModel
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public int ProductCount { get; set; }
    }
}
