using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpIntro
{
    class Product
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string SKU { get; set; }
        public int Qty { get; set; }
        public string Image { get; set; }
        public decimal SalePrice { get; set; }

        //add a method
        public bool InStock() {
            return this.Qty > 0;
        }

    }
}
