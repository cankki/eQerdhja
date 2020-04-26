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
        public int TeacherID { get; set; } //KOMPOZICION
        public int GenerationID { get; set; }//KOMPOZICION
    }
}
