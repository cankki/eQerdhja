using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eQerdhja.BO
{
    class SubscriptionBO
    {
        public int ID { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime  ExpirationDate{ get; set; }
        public int ParentID { get; set; } // kompozicion
        public int ScheduleID { get; set; } // kompozicion
        public decimal TotalPrice { get; set; }
    }
}
