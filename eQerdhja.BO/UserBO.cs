using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eQerdhja.BO
{
    class UserBO
    {
        public int userID { get; set; }
        public int StaffID { get; set; } //KOMPOZICION
        public string UserName { get; set; }
        public string Password { get; set; }
        public string InsertedBy { get; set; }
        public DateTime InsertDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime UpdateNo { get; set; }
    }
}
