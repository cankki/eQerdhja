using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eQerdhja.BO
{
    class KidBO
    {
        public int KidID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BirthPlace { get; set; }
        public int SexID { get; set; } // KOMPOZICION
        public int EtinicityID { get; set; } // KOMPOZICION
        public bool IsAlergic { get; set; }
        public bool TakesMedication { get; set; }
        public int GenerationID { get; set; } // KOMPOZICION
        public string InsertedBy { get; set; }
        public DateTime InsertDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime UpdateNo { get; set; }
    }
}
