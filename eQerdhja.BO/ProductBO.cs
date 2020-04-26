using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eQerdhja.BO
{
    class ProductBO
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public DateTime ExpirationDate{ get; set; }
        public string ProductionCountry { get; set; }
        public string Description { get; set; }
        public int CategoryID { get; set; } //kompozicion
    }
}
