﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eQerdhja.BO
{
    class ClassBO
    {
        public int ClassID { get; set; }
        public  StaffBO TeacherID { get; set; }
        public GenerationBO GenerationID { get; set; }

    }
}
