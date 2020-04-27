using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eQerdhja.BO
{
    class SupplierBO
    {
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public AddressBO AddressID { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public ProductBO ProductID { get; set; }
    }
}
