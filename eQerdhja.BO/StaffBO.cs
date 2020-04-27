using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eQerdhja.BO
{
    class StaffBO
    {
        public int StaffID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public AddressBO AddressID { get; set; } 
        public SexBO SexID { get; set; } 
        public StaffRoleBO TypeID { get; set; } 
        public StaffShiftBO ShiftID { get; set; } 
        public string InsertedBy { get; set; }
        public DateTime InsertDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime UpdateNo { get; set; }
    }
}
