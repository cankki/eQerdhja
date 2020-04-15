using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eQerdhja.BO
{
    class AllergiesBO
    {
        public int AllergiesID { get; set; }
        public string Name { get; set; }
        public KidBO Kid { get; set; }
        public string Description { get; set; }

    }
}
