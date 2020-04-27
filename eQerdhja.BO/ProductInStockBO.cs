using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eQerdhja.BO
{
    class ProductInStockBO
    {
        public ProductBO ProductID { get; set; } 
        public bool IsGramMeassured { get; set; }
        public decimal Quantity { get; set; }

    }
}
