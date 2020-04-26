using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eQerdhja.BO
{
    class StaffShiftBO
    {
        public int StaffShiftID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StartHour { get; set; }
        public int EndHour { get; set; }
    }
}
