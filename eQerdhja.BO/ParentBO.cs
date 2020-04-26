using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eQerdhja.BO
{
    class ParentBO
    {
        public int ParentID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int SexID { get; set; } //kompozicion
        public string PhoneNum { get; set; }
        public string Email { get; set; }
        public int AdressID { get; set; } //KOMPOZICION
        public int KidID { get; set; }//KOMPOZICION
        public bool LiveTogether { get; set; }
        public string Profession { get; set; }
        public   string InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
        public string  UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime UpdateNo { get; set; }
    }
}
