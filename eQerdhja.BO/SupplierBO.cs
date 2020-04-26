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
        public int AddressID { get; set; }//kompozicion
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public int ProductID { get; set; } // KOMPOZICION
    }
}
