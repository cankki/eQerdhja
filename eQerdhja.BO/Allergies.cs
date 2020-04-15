using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eQerdhja.BO
{
    class Allergies
    {
        public int AllergiesID { get; set; }
        public string Name { get; set; }
        public Kid Kid { get; set; }
        public string Description { get; set; }

    }
}
