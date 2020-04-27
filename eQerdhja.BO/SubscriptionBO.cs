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
        public ParentBO ParentID { get; set; } 
        public KindergartenScheduleBO ScheduleID { get; set; } 
        public decimal TotalPrice { get; set; }
    }
}
