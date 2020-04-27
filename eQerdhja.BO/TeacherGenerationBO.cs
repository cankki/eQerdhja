using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eQerdhja.BO
{
    class TeacherGenerationBO
    {
        public int TeacherGenerationID { get; set; }
        public StaffRoleBO TeacherID { get; set; } 
        public GenerationBO GenerationID { get; set; }
    }
}
